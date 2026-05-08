$targetFile = "WebGPU/WebGPU_native.cs"

if (-not (Test-Path $targetFile)) {
    Write-Host "Fehler: $targetFile nicht gefunden!" -ForegroundColor Red
    exit
}

# Datei einlesen
$text = Get-Content $targetFile -Raw

# --- Hier wird gelöscht ---
# Wir ersetzen die Begriffe einfach durch "nichts"
$text = $text.Replace("WGPU", "")
$text = $text.Replace("Impl", "")

# --- Fix für die Zahlen-Problematik ---
# Da C# keine Variablennamen erlaubt, die mit Zahlen starten (z.B. 1D)
# machen wir hier aus " 1D" einfach " D1D" usw.
$text = $text.Replace(" 1D", " D1D")
$text = $text.Replace(" 2D", " D2D")
$text = $text.Replace(" 3D", " D3D")
$text = $text.Replace("_1D", "_D1D")
$text = $text.Replace("_2D", "_D2D")
$text = $text.Replace("_3D", "_D3D")

# Speichern
Set-Content $targetFile $text
Write-Host