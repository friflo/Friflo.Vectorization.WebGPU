using System;
// ReSharper disable InconsistentNaming

namespace Friflo.WGPU;

using static Friflo.WGPU.Runtime.WebGPU_native;

[Flags]
public enum BufferUsage : ulong
{
    None            = BufferUsage_None,
    MapRead         = BufferUsage_MapRead,
    MapWrite        = BufferUsage_MapWrite,
    CopySrc         = BufferUsage_CopySrc,
    CopyDst         = BufferUsage_CopyDst,
    Index           = BufferUsage_Index,
    Vertex          = BufferUsage_Vertex,
    Uniform         = BufferUsage_Uniform,
    Storage         = BufferUsage_Storage,
    Indirect        = BufferUsage_Indirect,
    QueryResolve    = BufferUsage_QueryResolve
}

[Flags]
public enum ShaderStage : ulong
{
    None        = ShaderStage_None,
    Vertex      = ShaderStage_Vertex,
    Fragment    = ShaderStage_Fragment,
    Compute     = ShaderStage_Compute,
}

[Flags]
public enum MapMode : ulong
{
    None    = MapMode_None,
    Read    = MapMode_Read,
    Write   = MapMode_Write,
}

[Flags]
public enum TextureUsage : ulong
{
    None                = TextureUsage_None,
    CopySrc             = TextureUsage_CopySrc,
    CopyDst             = TextureUsage_CopyDst,
    TextureBinding      = TextureUsage_TextureBinding,
    StorageBinding      = TextureUsage_StorageBinding,
    RenderAttachment    = TextureUsage_RenderAttachment,
    TransientAttachment = TextureUsage_TransientAttachment
}

[Flags]
public enum InstanceFlag : ulong
{
    Empty                               = InstanceFlag_Empty,
    Debug                               = InstanceFlag_Debug,
    Validation                          = InstanceFlag_Validation,
    DiscardHalLabels                    = InstanceFlag_DiscardHalLabels,
    AllowUnderlyingNoncompliantAdapter  = InstanceFlag_AllowUnderlyingNoncompliantAdapter,
    GPUBasedValidation                  = InstanceFlag_GPUBasedValidation,
    ValidationIndirectCall              = InstanceFlag_ValidationIndirectCall,
    AutomaticTimestampNormalization     = InstanceFlag_AutomaticTimestampNormalization,
    Default                             = InstanceFlag_Default,
    Debugging                           = InstanceFlag_Debugging,
    AdvancedDebugging                   = InstanceFlag_AdvancedDebugging,
    WithEnv                             = InstanceFlag_WithEnv,
}

