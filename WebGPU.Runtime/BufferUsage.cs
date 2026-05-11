namespace Friflo.Vectorization.WebGPU.Runtime;

using static WebGPU_native;

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