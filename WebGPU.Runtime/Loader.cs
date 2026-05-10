using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace Friflo.Vectorization.WebGPU.Runtime;

public static partial class WebGPU_native
{
    private const string LibName = "wgpu_native";

    static WebGPU_native()
    {
        NativeLibrary.SetDllImportResolver(typeof(WebGPU_native).Assembly, ResolveWebGpuNative);
    }

    private static IntPtr ResolveWebGpuNative(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (libraryName != LibName) return IntPtr.Zero;

        // 1. Bestimme das OS-spezifische Dateiformat
        string fileName = libraryName;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            fileName = $"{libraryName}.dll";
        } else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
            fileName = $"lib{libraryName}.dylib";
        } else {
            fileName = $"lib{libraryName}.so"; // Linux & andere
        }

        // 2. Versuche die Datei in der Standard-NuGet/Runtime-Struktur zu finden
        // RID (Runtime Identifier) ist z.B. "win-x64", "linux-x64", "osx-arm64"
        string rid = RuntimeInformation.RuntimeIdentifier;
        
        // Wir prüfen zwei Pfade:
        // a) runtimes/[rid]/native/ (Standard NuGet)
        // b) direkt im BaseDirectory (falls flach kopiert)
        
        string[] probePaths = {
            Path.Combine(AppContext.BaseDirectory, "runtimes", rid, "native", fileName),
            Path.Combine(AppContext.BaseDirectory, fileName)
        };

        foreach (var path in probePaths)
        {
            if (File.Exists(path))
            {
                if (NativeLibrary.TryLoad(path, out var handle))
                {
                    return handle;
                }
            }
        }

        // 3. Fallback: Wenn wir nichts finden, lassen wir das OS suchen 
        // (Vielleicht liegt sie ja im System32 oder PATH)
        return IntPtr.Zero; 
    }
    
    // Hier folgen deine [DllImport] Aufrufe...
}