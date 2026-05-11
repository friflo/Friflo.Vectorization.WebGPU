# Friflo.Vectorization.WebGPU

Designed to provide a high-performance WebGPU backend for https://github.com/friflo/Friflo.Vectorization  
enabling hardware-accelerated compute using `wgpu-native` with zero-overhead C# bindings."

## Setup

Install dotnet tool [ClangSharpPInvokeGenerator](https://github.com/dotnet/ClangSharp)

```powershell
dotnet tool install -g ClangSharpPInvokeGenerator
```


### Download libraries 

Download libraries and include from: https://github.com/gfx-rs/wgpu-native/releases  
with Power Shell
```powershell
./download-wgpu-native.ps1
```

### Generate C# Binding

Generate initial `WebGPU_native.cs` with **ClangSharp**

```powershell
ClangSharpPInvokeGenerator "@generate.rsp"
```

*generated `WebGPU_native.cs` requires adjustments*

Make Rider happy by adding the comments at the top
```cs
// ReSharper disable UnusedType.Global
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
```

Strip long enum names.
```powershell
./strip_enums.ps1
```

Strip long type names
```powershell
./strip_types.ps1
```

### Create .nupkg

````
dotnet pack -c Release "/p:Version=0.1.0"
```



