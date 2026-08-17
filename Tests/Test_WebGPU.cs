using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Friflo.WGPU;
using Friflo.WGPU.Runtime;
using NUnit.Framework;
using static Friflo.WGPU.Runtime.WebGPU_native;

namespace Tests;

public class Test_WebGPU
{
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe void OnAdapterReceived(RequestAdapterStatus status, Adapter* adapter, StringView message, void* handle, void* userdata)
    {
        if (status == RequestAdapterStatus.Success)
        {
            Console.WriteLine("Adapter erhalten!");
            // Hier geht's weiter (z.B. Device anfragen)
        }
        else
        {

        }
    }
    

    [Test]
    public static unsafe  void CreateInstance()
    {
        var desc = new InstanceDescriptor { };
        
        Instance* instance = wgpuCreateInstance(&desc);
        
        var options1 = new InstanceEnumerateAdapterOptions();
        var adapterCount = wgpuInstanceEnumerateAdapters(instance, &options1, null);
        
        Adapter** adapters = stackalloc Adapter*[ (int)adapterCount ];
        wgpuInstanceEnumerateAdapters(instance, &options1, adapters);
        for (int i = 0; i < (int)adapterCount; i++)
        {
            Adapter* adapter = adapters[i];
            var info = new AdapterInfo();
            wgpuAdapterGetInfo(adapter, &info);
        }
        
        
        var options = new RequestAdapterOptions {
            powerPreference = PowerPreference.HighPerformance
        };
        
        RequestAdapterCallbackInfo callbackInfo = new() {
            callback = &OnAdapterReceived,
        };
        wgpuInstanceRequestAdapter(instance, &options, callbackInfo);
    }
    
    public static void UseEnums()
    {
        _ = BufferUsage.CopyDst;
        _ = ShaderStage.Fragment;
        _ = MapMode.Read;
    }
}