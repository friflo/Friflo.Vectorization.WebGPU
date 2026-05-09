# --- Global Settings ---
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$ErrorActionPreference = "Stop"

# --- Configuration ---
$version = "v29.0.0.0" 
$baseOutDir = "./runtimes"
$includeDir = "./include" 
$tempDir = "./temp_native"

# Comprehensive list of artifacts for all major .NET platforms
$artifacts = @(
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-windows-x86_64-msvc-release.zip";   RID = "win-x64";        LibName = "wgpu_native.dll" },
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-linux-x86_64-release.zip";          RID = "linux-x64";      LibName = "libwgpu_native.so" },
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-android-aarch64-release.zip";       RID = "android-arm64";  LibName = "libwgpu_native.so" },
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-ios-aarch64-release.zip";           RID = "ios-arm64";      LibName = "libwgpu_native.a" },
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-macos-aarch64-release.zip";         RID = "osx-arm64";      LibName = "libwgpu_native.dylib" },
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-macos-x86_64-release.zip";          RID = "osx-x64";        LibName = "libwgpu_native.dylib" }
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-linux-aarch64-release.zip";         RID = "linux-arm64";    LibName = "libwgpu_native.so" },
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-android-x86_64-release.zip";        RID = "android-x64";    LibName = "libwgpu_native.so" },
    @{ Url = "https://github.com/gfx-rs/wgpu-native/releases/download/$version/wgpu-windows-aarch64-msvc-release.zip";  RID = "win-arm64";      LibName = "wgpu_native.dll" }
)

# --- Directory Setup ---
if (!(Test-Path $tempDir)) { New-Item -ItemType Directory $tempDir | Out-Null }
if (!(Test-Path $includeDir)) { New-Item -ItemType Directory $includeDir | Out-Null }

Write-Host "Syncing wgpu-native assets with ZIP-named tracking files - Version: $version" -ForegroundColor Cyan

foreach ($art in $artifacts) {
    $zipFileName = Split-Path $art.Url -Leaf
    $folderName = $zipFileName -replace "\.zip$", ""
    $downloadPath = Join-Path $tempDir $zipFileName
    $extractPath = Join-Path $tempDir $folderName
    $targetDir = "$baseOutDir/$($art.RID)/native"

    Write-Host "`n[Processing RID: $($art.RID)]" -ForegroundColor Magenta

    # 1. Download ZIP if not present
    if (!(Test-Path $downloadPath)) {
        try {
            Write-Host "  -> Downloading: $zipFileName"
            Invoke-WebRequest -Uri $art.Url -OutFile $downloadPath -MaximumRedirection 5
        } catch {
            Write-Host "  [!] Asset not found on GitHub. Skipping $($art.RID)..." -ForegroundColor Red
            continue
        }
    }

    # 2. Extract ZIP
    if (Test-Path $extractPath) { Remove-Item $extractPath -Recurse -Force }
    New-Item -ItemType Directory $extractPath | Out-Null
    Expand-Archive -Path $downloadPath -DestinationPath $extractPath -Force

    # 3. Copy Native Library and Create Zip-Named Info File
    if (!(Test-Path $targetDir)) { New-Item -ItemType Directory -Force $targetDir | Out-Null }
    $sourceFile = Get-ChildItem -Path $extractPath -Filter $art.LibName -Recurse | Select-Object -First 1

    if ($sourceFile) {
        # Copy binary
        Copy-Item $sourceFile.FullName -Destination (Join-Path $targetDir $art.LibName) -Force
        
        # Create metadata file named after the zip (e.g., wgpu-windows-...zip.txt)
        $infoFileName = "$zipFileName.md"
        $infoFilePath = Join-Path $targetDir $infoFileName
        
        $content = @"
Source ZIP:   $zipFileName  
Release Tag:  $version  
Download Url: $($art.Url)
"@
        Set-Content -Path $infoFilePath -Value $content
        
        Write-Host "  -> Success: $($art.LibName) and $infoFileName created." -ForegroundColor Green
    }

    # 4. Header Sync (Win-x64 as master source)
    if ($art.RID -eq "win-x64") {
        Write-Host "  -> Syncing headers to $includeDir..." -ForegroundColor Yellow
        Get-ChildItem -Path $extractPath -Filter "*.h" -Recurse | Copy-Item -Destination $includeDir -Force
    }
}

Write-Host "`n" + ("=" * 60) -ForegroundColor Cyan
Write-Host "COMPLETED: Runtimes and headers are ready for your NuGet package." -ForegroundColor Cyan
Write-Host ("=" * 60) -ForegroundColor Cyan