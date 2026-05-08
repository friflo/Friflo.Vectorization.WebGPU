# Friflo.Vectorization.WebGPU


## Setup

Generate initial dotnet tool [ClangSharpPInvokeGenerator](https://github.com/dotnet/ClangSharp)

```powershell
dotnet tool install -g ClangSharpPInvokeGenerator
```


## 🛠 Download libraries from [wgpu-native](https://github.com/gfx-rs/wgpu-native)

To keep the repository light, native binaries are not checked in. 
To fetch the runtimes for all platforms, simply run the included PowerShell script:

```powershell
./download-wgpu-native.ps1
```

### Generate C# Binding

Generate initial C# with [ClangSharp](https://github.com/dotnet/ClangSharp)

```powershell
ClangSharpPInvokeGenerator "@generate.rsp"
```

Generate file `WebGPU.cs` requires adjustments

Make Rider happy by adding the comments at the top
```cs
// ReSharper disable UnusedType.Global
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
```

Make enum short symbol names short. E.g.  
```powershell
./strip_enums.ps1
```

Make type names short. E.g.  
```powershell
./strip_types.ps1
```




