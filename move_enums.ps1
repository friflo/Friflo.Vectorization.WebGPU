$file = "WebGPU.Runtime/WebGPU_native.cs"
$enumFile = "WebGPU.Runtime/WebGPU_enums.cs"
$namespaceName = "Friflo.WGPU"

$content = Get-Content $file -Raw
$extractedEnums = New-Object System.Collections.Generic.List[string]

# Find all enum blocks in their exact physical order
$matches = [regex]::Matches($content, '(?s)public enum (?<name>\w+)\s*\{(.*?[^\}])\}')

foreach ($m in $matches) {
    $block = $m.Value
    
    # Indent the block for the new file (4 spaces)
    $indentedBlock = $block -replace '(?m)^', '    '
    $extractedEnums.Add($indentedBlock)
    
    # Comment out the exact block in the original file content
    $commentedBlock = $block -replace '(?m)^', '// '
    $content = $content.Replace($block, $commentedBlock)
}

# 1. Save original file with commented out enums
Set-Content $file $content

# 2. Write the clean enums into the new file
if ($extractedEnums.Count -gt 0) {
    $enumFileContent = New-Object System.Text.StringBuilder
    $null = $enumFileContent.AppendLine("// Automatically extracted WebGPU Enums`r`n")
    $null = $enumFileContent.AppendLine("namespace $namespaceName`r`n{")
    
    foreach ($enum in $extractedEnums) {
        $null = $enumFileContent.AppendLine($enum)
        $null = $enumFileContent.AppendLine()
    }
    
    $null = $enumFileContent.AppendLine("}")
    
    Set-Content -Path $enumFile -Value $enumFileContent.ToString() -Encoding utf8
    Write-Host "Successfully moved $($extractedEnums.Count) enums to '$enumFile'." -ForegroundColor Green
}