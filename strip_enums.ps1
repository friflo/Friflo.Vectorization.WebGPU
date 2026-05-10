$file = "WebGPU.Runtime/WebGPU_native.cs"
$content = Get-Content $file -Raw

# RegEx-Logik für Enums
$content = [regex]::Replace($content, '(?s)public enum (?<name>\w+)\s*\{(.*?[^\}])\}', {
    param($m)
    $name = $m.Groups['name'].Value
    $block = $m.Value
    
    # 1. Entferne das Standard-Präfix (z.B. TextureViewDimension_)
    $newBlock = $block.Replace($name + "_", "")
    $newBlock = $newBlock.Replace("WGPU" + $name + "_", "")

    # 2. Fix für Bezeichner, die mit einer Zahl beginnen (z.B. 1D -> D1D oder _1D)
    # Wir suchen nach Zeilen, die mit einer Zahl beginnen und setzen ein 'D' davor
    $newBlock = [regex]::Replace($newBlock, '(?m)^\s*(\d\w+)\s*=', {
        param($m2)
        return "    D" + $m2.Groups[1].Value + " ="
    })

    return $newBlock
})

Set-Content $file $content