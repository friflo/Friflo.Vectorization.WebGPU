using System.Runtime.InteropServices;

// ReSharper disable UnusedType.Global
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
namespace Friflo.Vectorization.WebGPU
{
    public enum NativeSType
    {
        SType_DeviceExtras = 0x00030001,
        SType_NativeLimits = 0x00030002,
        SType_PipelineLayoutExtras = 0x00030003,
        SType_ShaderSourceGLSL = 0x00030004,
        SType_InstanceExtras = 0x00030006,
        SType_BindGroupEntryExtras = 0x00030007,
        SType_BindGroupLayoutEntryExtras = 0x00030008,
        SType_QuerySetDescriptorExtras = 0x00030009,
        SType_SurfaceConfigurationExtras = 0x0003000A,
        SType_SurfaceSourceSwapChainPanel = 0x0003000B,
        SType_PrimitiveStateExtras = 0x0003000C,
        Force32 = 0x7FFFFFFF,
    }

    public enum NativeSurfaceGetCurrentTextureStatus
    {
        SurfaceGetCurrentTextureStatus_Occluded = 0x00030001,
        Force32 = 0x7FFFFFFF,
    }

    public enum NativeFeature
    {
        Immediates = 0x00030001,
        TextureAdapterSpecificFormatFeatures = 0x00030002,
        MultiDrawIndirectCount = 0x00030004,
        VertexWritableStorage = 0x00030005,
        TextureBindingArray = 0x00030006,
        SampledTextureAndStorageBufferArrayNonUniformIndexing = 0x00030007,
        PipelineStatisticsQuery = 0x00030008,
        StorageResourceBindingArray = 0x00030009,
        PartiallyBoundBindingArray = 0x0003000A,
        TextureFormat16bitNorm = 0x0003000B,
        TextureCompressionAstcHdr = 0x0003000C,
        MappablePrimaryBuffers = 0x0003000E,
        BufferBindingArray = 0x0003000F,
        UniformBufferAndStorageTextureArrayNonUniformIndexing = 0x00030010,
        PolygonModeLine = 0x00030013,
        PolygonModePoint = 0x00030014,
        ConservativeRasterization = 0x00030015,
        SpirvShaderPassthrough = 0x00030017,
        VertexAttribute64bit = 0x00030019,
        TextureFormatNv12 = 0x0003001A,
        RayQuery = 0x0003001C,
        ShaderF64 = 0x0003001D,
        ShaderI16 = 0x0003001E,
        ShaderEarlyDepthTest = 0x00030020,
        Subgroup = 0x00030021,
        SubgroupVertex = 0x00030022,
        SubgroupBarrier = 0x00030023,
        TimestampQueryInsideEncoders = 0x00030024,
        TimestampQueryInsidePasses = 0x00030025,
        ShaderInt64 = 0x00030026,
        Force32 = 0x7FFFFFFF,
    }

    public enum LogLevel
    {
        Off = 0x00000000,
        Error = 0x00000001,
        Warn = 0x00000002,
        Info = 0x00000003,
        Debug = 0x00000004,
        Trace = 0x00000005,
        Force32 = 0x7FFFFFFF,
    }

    public enum Dx12Compiler
    {
        Undefined = 0x00000000,
        Fxc = 0x00000001,
        Dxc = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum Gles3MinorVersion
    {
        Automatic = 0x00000000,
        Version0 = 0x00000001,
        Version1 = 0x00000002,
        Version2 = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum PipelineStatisticName
    {
        VertexShaderInvocations = 0x00000000,
        ClipperInvocations = 0x00000001,
        ClipperPrimitivesOut = 0x00000002,
        FragmentShaderInvocations = 0x00000003,
        ComputeShaderInvocations = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum NativeQueryType
    {
        PipelineStatistics = 0x00030000,
        Force32 = 0x7FFFFFFF,
    }

    public enum DxcMaxShaderModel
    {
        V6_0 = 0x00000000,
        V6_1 = 0x00000001,
        V6_2 = 0x00000002,
        V6_3 = 0x00000003,
        V6_4 = 0x00000004,
        V6_5 = 0x00000005,
        V6_6 = 0x00000006,
        V6_7 = 0x00000007,
        Force32 = 0x7FFFFFFF,
    }

    public enum GLFenceBehaviour
    {
        Normal = 0x00000000,
        AutoFinish = 0x00000001,
        Force32 = 0x7FFFFFFF,
    }

    public enum Dx12SwapchainKind
    {
        Undefined = 0x00000000,
        DxgiFromHwnd = 0x00000001,
        DxgiFromVisual = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum NativeDisplayHandleType
    {
        None = 0x00000000,
        Xlib = 0x00000001,
        Xcb = 0x00000002,
        Wayland = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public unsafe partial struct XlibDisplayHandle
    {
        public void* display;

        public int screen;
    }

    public unsafe partial struct XcbDisplayHandle
    {
        public void* connection;

        public int screen;
    }

    public unsafe partial struct WaylandDisplayHandle
    {
        public void* display;
    }

    public partial struct NativeDisplayHandle
    {
        public NativeDisplayHandleType type;

        [NativeTypeName("__AnonymousRecord_wgpu_L917_C5")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _data_e__Union
        {
            [FieldOffset(0)]
            public XlibDisplayHandle xlib;

            [FieldOffset(0)]
            public XcbDisplayHandle xcb;

            [FieldOffset(0)]
            public WaylandDisplayHandle wayland;
        }
    }

    public unsafe partial struct InstanceExtras
    {
        public ChainedStruct chain;

        [NativeTypeName("InstanceBackend")]
        public ulong backends;

        [NativeTypeName("InstanceFlag")]
        public ulong flags;

        public Dx12Compiler dx12ShaderCompiler;

        public Gles3MinorVersion gles3MinorVersion;

        public GLFenceBehaviour glFenceBehaviour;

        public StringView dxcPath;

        public DxcMaxShaderModel dxcMaxShaderModel;

        public Dx12SwapchainKind dx12PresentationSystem;

        [NativeTypeName("const uint8_t *")]
        public byte* budgetForDeviceCreation;

        [NativeTypeName("const uint8_t *")]
        public byte* budgetForDeviceLoss;

        public NativeDisplayHandle displayHandle;
    }

    public partial struct DeviceExtras
    {
        public ChainedStruct chain;

        public StringView tracePath;
    }

    public partial struct NativeLimits
    {
        public ChainedStruct chain;

        [NativeTypeName("uint32_t")]
        public uint maxImmediateSize;

        [NativeTypeName("uint32_t")]
        public uint maxNonSamplerBindings;

        [NativeTypeName("uint32_t")]
        public uint maxBindingArrayElementsPerShaderStage;
    }

    public partial struct PipelineLayoutExtras
    {
        public ChainedStruct chain;

        [NativeTypeName("uint32_t")]
        public uint immediateDataSize;
    }

    public partial struct ShaderDefine
    {
        public StringView name;

        public StringView value;
    }

    public unsafe partial struct ShaderSourceGLSL
    {
        public ChainedStruct chain;

        [NativeTypeName("ShaderStage")]
        public ulong stage;

        public StringView code;

        [NativeTypeName("uint32_t")]
        public uint defineCount;

        [NativeTypeName("const ShaderDefine *")]
        public ShaderDefine* defines;
    }

    public unsafe partial struct ShaderModuleDescriptorSpirV
    {
        public StringView label;

        [NativeTypeName("uint32_t")]
        public uint sourceSize;

        [NativeTypeName("const uint32_t *")]
        public uint* source;
    }

    public partial struct RegistryReport
    {
        [NativeTypeName("size_t")]
        public nuint numAllocated;

        [NativeTypeName("size_t")]
        public nuint numKeptFromUser;

        [NativeTypeName("size_t")]
        public nuint numReleasedFromUser;

        [NativeTypeName("size_t")]
        public nuint elementSize;
    }

    public partial struct HubReport
    {
        public RegistryReport adapters;

        public RegistryReport devices;

        public RegistryReport queues;

        public RegistryReport pipelineLayouts;

        public RegistryReport shaderModules;

        public RegistryReport bindGroupLayouts;

        public RegistryReport bindGroups;

        public RegistryReport commandBuffers;

        public RegistryReport renderBundles;

        public RegistryReport renderPipelines;

        public RegistryReport computePipelines;

        public RegistryReport pipelineCaches;

        public RegistryReport querySets;

        public RegistryReport buffers;

        public RegistryReport textures;

        public RegistryReport textureViews;

        public RegistryReport samplers;
    }

    public partial struct GlobalReport
    {
        public RegistryReport surfaces;

        public HubReport hub;
    }

    public unsafe partial struct InstanceEnumerateAdapterOptions
    {
        [NativeTypeName("const ChainedStruct *")]
        public ChainedStruct* nextInChain;

        [NativeTypeName("InstanceBackend")]
        public ulong backends;
    }

    public unsafe partial struct BindGroupEntryExtras
    {
        public ChainedStruct chain;

        [NativeTypeName("const Buffer *")]
        public Buffer** buffers;

        [NativeTypeName("size_t")]
        public nuint bufferCount;

        [NativeTypeName("const Sampler *")]
        public Sampler** samplers;

        [NativeTypeName("size_t")]
        public nuint samplerCount;

        [NativeTypeName("const TextureView *")]
        public TextureView** textureViews;

        [NativeTypeName("size_t")]
        public nuint textureViewCount;
    }

    public partial struct BindGroupLayoutEntryExtras
    {
        public ChainedStruct chain;

        [NativeTypeName("uint32_t")]
        public uint count;
    }

    public unsafe partial struct QuerySetDescriptorExtras
    {
        public ChainedStruct chain;

        [NativeTypeName("const PipelineStatisticName *")]
        public PipelineStatisticName* pipelineStatistics;

        [NativeTypeName("size_t")]
        public nuint pipelineStatisticCount;
    }

    public partial struct SurfaceConfigurationExtras
    {
        public ChainedStruct chain;

        [NativeTypeName("uint32_t")]
        public uint desiredMaximumFrameLatency;
    }

    public unsafe partial struct SurfaceSourceSwapChainPanel
    {
        public ChainedStruct chain;

        public void* panelNative;
    }

    public enum PolygonMode
    {
        Fill = 0,
        Line = 1,
        Point = 2,
    }

    public partial struct PrimitiveStateExtras
    {
        public ChainedStruct chain;

        public PolygonMode polygonMode;

        [NativeTypeName("Bool")]
        public uint conservative;
    }

    public enum NativeTextureFormat
    {
        R16Unorm = 0x00030001,
        R16Snorm = 0x00030002,
        Rg16Unorm = 0x00030003,
        Rg16Snorm = 0x00030004,
        Rgba16Unorm = 0x00030005,
        Rgba16Snorm = 0x00030006,
        NV12 = 0x00030007,
        P010 = 0x00030008,
    }

    public unsafe partial struct StringView
    {
        [NativeTypeName("const char *")]
        public sbyte* data;

        [NativeTypeName("size_t")]
        public nuint length;
    }

    public partial struct Adapter
    {
    }

    public partial struct BindGroup
    {
    }

    public partial struct BindGroupLayout
    {
    }

    public partial struct Buffer
    {
    }

    public partial struct CommandBuffer
    {
    }

    public partial struct CommandEncoder
    {
    }

    public partial struct ComputePassEncoder
    {
    }

    public partial struct ComputePipeline
    {
    }

    public partial struct Device
    {
    }

    public partial struct ExternalTexture
    {
    }

    public partial struct Instance
    {
    }

    public partial struct PipelineLayout
    {
    }

    public partial struct QuerySet
    {
    }

    public partial struct Queue
    {
    }

    public partial struct RenderBundle
    {
    }

    public partial struct RenderBundleEncoder
    {
    }

    public partial struct RenderPassEncoder
    {
    }

    public partial struct RenderPipeline
    {
    }

    public partial struct Sampler
    {
    }

    public partial struct ShaderModule
    {
    }

    public partial struct Surface
    {
    }

    public partial struct Texture
    {
    }

    public partial struct TextureView
    {
    }

    public enum AdapterType
    {
        DiscreteGPU = 0x00000001,
        IntegratedGPU = 0x00000002,
        CPU = 0x00000003,
        Unknown = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum AddressMode
    {
        Undefined = 0x00000000,
        ClampToEdge = 0x00000001,
        Repeat = 0x00000002,
        MirrorRepeat = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum BackendType
    {
        Undefined = 0x00000000,
        Null = 0x00000001,
        WebGPU = 0x00000002,
        D3D11 = 0x00000003,
        D3D12 = 0x00000004,
        Metal = 0x00000005,
        Vulkan = 0x00000006,
        OpenGL = 0x00000007,
        OpenGLES = 0x00000008,
        Force32 = 0x7FFFFFFF,
    }

    public enum BlendFactor
    {
        Undefined = 0x00000000,
        Zero = 0x00000001,
        One = 0x00000002,
        Src = 0x00000003,
        OneMinusSrc = 0x00000004,
        SrcAlpha = 0x00000005,
        OneMinusSrcAlpha = 0x00000006,
        Dst = 0x00000007,
        OneMinusDst = 0x00000008,
        DstAlpha = 0x00000009,
        OneMinusDstAlpha = 0x0000000A,
        SrcAlphaSaturated = 0x0000000B,
        Constant = 0x0000000C,
        OneMinusConstant = 0x0000000D,
        Src1 = 0x0000000E,
        OneMinusSrc1 = 0x0000000F,
        Src1Alpha = 0x00000010,
        OneMinusSrc1Alpha = 0x00000011,
        Force32 = 0x7FFFFFFF,
    }

    public enum BlendOperation
    {
        Undefined = 0x00000000,
        Add = 0x00000001,
        Subtract = 0x00000002,
        ReverseSubtract = 0x00000003,
        Min = 0x00000004,
        Max = 0x00000005,
        Force32 = 0x7FFFFFFF,
    }

    public enum BufferBindingType
    {
        BindingNotUsed = 0x00000000,
        Undefined = 0x00000001,
        Uniform = 0x00000002,
        Storage = 0x00000003,
        ReadOnlyStorage = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum BufferMapState
    {
        Unmapped = 0x00000001,
        Pending = 0x00000002,
        Mapped = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum CallbackMode
    {
        WaitAnyOnly = 0x00000001,
        AllowProcessEvents = 0x00000002,
        AllowSpontaneous = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum CompareFunction
    {
        Undefined = 0x00000000,
        Never = 0x00000001,
        Less = 0x00000002,
        Equal = 0x00000003,
        LessEqual = 0x00000004,
        Greater = 0x00000005,
        NotEqual = 0x00000006,
        GreaterEqual = 0x00000007,
        Always = 0x00000008,
        Force32 = 0x7FFFFFFF,
    }

    public enum CompilationInfoRequestStatus
    {
        Success = 0x00000001,
        CallbackCancelled = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum CompilationMessageType
    {
        Error = 0x00000001,
        Warning = 0x00000002,
        Info = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum ComponentSwizzle
    {
        Undefined = 0x00000000,
        Zero = 0x00000001,
        One = 0x00000002,
        R = 0x00000003,
        G = 0x00000004,
        B = 0x00000005,
        A = 0x00000006,
        Force32 = 0x7FFFFFFF,
    }

    public enum CompositeAlphaMode
    {
        Auto = 0x00000000,
        Opaque = 0x00000001,
        Premultiplied = 0x00000002,
        Unpremultiplied = 0x00000003,
        Inherit = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum CreatePipelineAsyncStatus
    {
        Success = 0x00000001,
        CallbackCancelled = 0x00000002,
        ValidationError = 0x00000003,
        InternalError = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum CullMode
    {
        Undefined = 0x00000000,
        None = 0x00000001,
        Front = 0x00000002,
        Back = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum DeviceLostReason
    {
        Unknown = 0x00000001,
        Destroyed = 0x00000002,
        CallbackCancelled = 0x00000003,
        FailedCreation = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum ErrorFilter
    {
        Validation = 0x00000001,
        OutOfMemory = 0x00000002,
        Internal = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum ErrorType
    {
        NoError = 0x00000001,
        Validation = 0x00000002,
        OutOfMemory = 0x00000003,
        Internal = 0x00000004,
        Unknown = 0x00000005,
        Force32 = 0x7FFFFFFF,
    }

    public enum FeatureLevel
    {
        Undefined = 0x00000000,
        Compatibility = 0x00000001,
        Core = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum FeatureName
    {
        CoreFeaturesAndLimits = 0x00000001,
        DepthClipControl = 0x00000002,
        Depth32FloatStencil8 = 0x00000003,
        TextureCompressionBC = 0x00000004,
        TextureCompressionBCSliced3D = 0x00000005,
        TextureCompressionETC2 = 0x00000006,
        TextureCompressionASTC = 0x00000007,
        TextureCompressionASTCSliced3D = 0x00000008,
        TimestampQuery = 0x00000009,
        IndirectFirstInstance = 0x0000000A,
        ShaderF16 = 0x0000000B,
        RG11B10UfloatRenderable = 0x0000000C,
        BGRA8UnormStorage = 0x0000000D,
        Float32Filterable = 0x0000000E,
        Float32Blendable = 0x0000000F,
        ClipDistances = 0x00000010,
        DualSourceBlending = 0x00000011,
        Subgroups = 0x00000012,
        TextureFormatsTier1 = 0x00000013,
        TextureFormatsTier2 = 0x00000014,
        PrimitiveIndex = 0x00000015,
        TextureComponentSwizzle = 0x00000016,
        Force32 = 0x7FFFFFFF,
    }

    public enum FilterMode
    {
        Undefined = 0x00000000,
        Nearest = 0x00000001,
        Linear = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum FrontFace
    {
        Undefined = 0x00000000,
        CCW = 0x00000001,
        CW = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum IndexFormat
    {
        Undefined = 0x00000000,
        Uint16 = 0x00000001,
        Uint32 = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum InstanceFeatureName
    {
        TimedWaitAny = 0x00000001,
        ShaderSourceSPIRV = 0x00000002,
        MultipleDevicesPerAdapter = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum LoadOp
    {
        Undefined = 0x00000000,
        Load = 0x00000001,
        Clear = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum MapAsyncStatus
    {
        Success = 0x00000001,
        CallbackCancelled = 0x00000002,
        Error = 0x00000003,
        Aborted = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum MipmapFilterMode
    {
        Undefined = 0x00000000,
        Nearest = 0x00000001,
        Linear = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum OptionalBool
    {
        False = 0x00000000,
        True = 0x00000001,
        Undefined = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum PopErrorScopeStatus
    {
        Success = 0x00000001,
        CallbackCancelled = 0x00000002,
        Error = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum PowerPreference
    {
        Undefined = 0x00000000,
        LowPower = 0x00000001,
        HighPerformance = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum PredefinedColorSpace
    {
        SRGB = 0x00000001,
        DisplayP3 = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum PresentMode
    {
        Undefined = 0x00000000,
        Fifo = 0x00000001,
        FifoRelaxed = 0x00000002,
        Immediate = 0x00000003,
        Mailbox = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum PrimitiveTopology
    {
        Undefined = 0x00000000,
        PointList = 0x00000001,
        LineList = 0x00000002,
        LineStrip = 0x00000003,
        TriangleList = 0x00000004,
        TriangleStrip = 0x00000005,
        Force32 = 0x7FFFFFFF,
    }

    public enum QueryType
    {
        Occlusion = 0x00000001,
        Timestamp = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum QueueWorkDoneStatus
    {
        Success = 0x00000001,
        CallbackCancelled = 0x00000002,
        Error = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum RequestAdapterStatus
    {
        Success = 0x00000001,
        CallbackCancelled = 0x00000002,
        Unavailable = 0x00000003,
        Error = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum RequestDeviceStatus
    {
        Success = 0x00000001,
        CallbackCancelled = 0x00000002,
        Error = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum SamplerBindingType
    {
        BindingNotUsed = 0x00000000,
        Undefined = 0x00000001,
        Filtering = 0x00000002,
        NonFiltering = 0x00000003,
        Comparison = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum Status
    {
        Success = 0x00000001,
        Error = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum StencilOperation
    {
        Undefined = 0x00000000,
        Keep = 0x00000001,
        Zero = 0x00000002,
        Replace = 0x00000003,
        Invert = 0x00000004,
        IncrementClamp = 0x00000005,
        DecrementClamp = 0x00000006,
        IncrementWrap = 0x00000007,
        DecrementWrap = 0x00000008,
        Force32 = 0x7FFFFFFF,
    }

    public enum StorageTextureAccess
    {
        BindingNotUsed = 0x00000000,
        Undefined = 0x00000001,
        WriteOnly = 0x00000002,
        ReadOnly = 0x00000003,
        ReadWrite = 0x00000004,
        Force32 = 0x7FFFFFFF,
    }

    public enum StoreOp
    {
        Undefined = 0x00000000,
        Store = 0x00000001,
        Discard = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum SType
    {
        ShaderSourceSPIRV = 0x00000001,
        ShaderSourceWGSL = 0x00000002,
        RenderPassMaxDrawCount = 0x00000003,
        SurfaceSourceMetalLayer = 0x00000004,
        SurfaceSourceWindowsHWND = 0x00000005,
        SurfaceSourceXlibWindow = 0x00000006,
        SurfaceSourceWaylandSurface = 0x00000007,
        SurfaceSourceAndroidNativeWindow = 0x00000008,
        SurfaceSourceXCBWindow = 0x00000009,
        SurfaceColorManagement = 0x0000000A,
        RequestAdapterWebXROptions = 0x0000000B,
        TextureComponentSwizzleDescriptor = 0x0000000C,
        ExternalTextureBindingLayout = 0x0000000D,
        ExternalTextureBindingEntry = 0x0000000E,
        CompatibilityModeLimits = 0x0000000F,
        TextureBindingViewDimension = 0x00000010,
        Force32 = 0x7FFFFFFF,
    }

    public enum SurfaceGetCurrentTextureStatus
    {
        SuccessOptimal = 0x00000001,
        SuccessSuboptimal = 0x00000002,
        Timeout = 0x00000003,
        Outdated = 0x00000004,
        Lost = 0x00000005,
        Error = 0x00000006,
        Force32 = 0x7FFFFFFF,
    }

    public enum TextureAspect
    {
        Undefined = 0x00000000,
        All = 0x00000001,
        StencilOnly = 0x00000002,
        DepthOnly = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum TextureDimension
    {
        Undefined = 0x00000000,
    D1D = 0x00000001,
    D2D = 0x00000002,
    D3D = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum TextureFormat
    {
        Undefined = 0x00000000,
        R8Unorm = 0x00000001,
        R8Snorm = 0x00000002,
        R8Uint = 0x00000003,
        R8Sint = 0x00000004,
        R16Unorm = 0x00000005,
        R16Snorm = 0x00000006,
        R16Uint = 0x00000007,
        R16Sint = 0x00000008,
        R16Float = 0x00000009,
        RG8Unorm = 0x0000000A,
        RG8Snorm = 0x0000000B,
        RG8Uint = 0x0000000C,
        RG8Sint = 0x0000000D,
        R32Float = 0x0000000E,
        R32Uint = 0x0000000F,
        R32Sint = 0x00000010,
        RG16Unorm = 0x00000011,
        RG16Snorm = 0x00000012,
        RG16Uint = 0x00000013,
        RG16Sint = 0x00000014,
        RG16Float = 0x00000015,
        RGBA8Unorm = 0x00000016,
        RGBA8UnormSrgb = 0x00000017,
        RGBA8Snorm = 0x00000018,
        RGBA8Uint = 0x00000019,
        RGBA8Sint = 0x0000001A,
        BGRA8Unorm = 0x0000001B,
        BGRA8UnormSrgb = 0x0000001C,
        RGB10A2Uint = 0x0000001D,
        RGB10A2Unorm = 0x0000001E,
        RG11B10Ufloat = 0x0000001F,
        RGB9E5Ufloat = 0x00000020,
        RG32Float = 0x00000021,
        RG32Uint = 0x00000022,
        RG32Sint = 0x00000023,
        RGBA16Unorm = 0x00000024,
        RGBA16Snorm = 0x00000025,
        RGBA16Uint = 0x00000026,
        RGBA16Sint = 0x00000027,
        RGBA16Float = 0x00000028,
        RGBA32Float = 0x00000029,
        RGBA32Uint = 0x0000002A,
        RGBA32Sint = 0x0000002B,
        Stencil8 = 0x0000002C,
        Depth16Unorm = 0x0000002D,
        Depth24Plus = 0x0000002E,
        Depth24PlusStencil8 = 0x0000002F,
        Depth32Float = 0x00000030,
        Depth32FloatStencil8 = 0x00000031,
        BC1RGBAUnorm = 0x00000032,
        BC1RGBAUnormSrgb = 0x00000033,
        BC2RGBAUnorm = 0x00000034,
        BC2RGBAUnormSrgb = 0x00000035,
        BC3RGBAUnorm = 0x00000036,
        BC3RGBAUnormSrgb = 0x00000037,
        BC4RUnorm = 0x00000038,
        BC4RSnorm = 0x00000039,
        BC5RGUnorm = 0x0000003A,
        BC5RGSnorm = 0x0000003B,
        BC6HRGBUfloat = 0x0000003C,
        BC6HRGBFloat = 0x0000003D,
        BC7RGBAUnorm = 0x0000003E,
        BC7RGBAUnormSrgb = 0x0000003F,
        ETC2RGB8Unorm = 0x00000040,
        ETC2RGB8UnormSrgb = 0x00000041,
        ETC2RGB8A1Unorm = 0x00000042,
        ETC2RGB8A1UnormSrgb = 0x00000043,
        ETC2RGBA8Unorm = 0x00000044,
        ETC2RGBA8UnormSrgb = 0x00000045,
        EACR11Unorm = 0x00000046,
        EACR11Snorm = 0x00000047,
        EACRG11Unorm = 0x00000048,
        EACRG11Snorm = 0x00000049,
        ASTC4x4Unorm = 0x0000004A,
        ASTC4x4UnormSrgb = 0x0000004B,
        ASTC5x4Unorm = 0x0000004C,
        ASTC5x4UnormSrgb = 0x0000004D,
        ASTC5x5Unorm = 0x0000004E,
        ASTC5x5UnormSrgb = 0x0000004F,
        ASTC6x5Unorm = 0x00000050,
        ASTC6x5UnormSrgb = 0x00000051,
        ASTC6x6Unorm = 0x00000052,
        ASTC6x6UnormSrgb = 0x00000053,
        ASTC8x5Unorm = 0x00000054,
        ASTC8x5UnormSrgb = 0x00000055,
        ASTC8x6Unorm = 0x00000056,
        ASTC8x6UnormSrgb = 0x00000057,
        ASTC8x8Unorm = 0x00000058,
        ASTC8x8UnormSrgb = 0x00000059,
        ASTC10x5Unorm = 0x0000005A,
        ASTC10x5UnormSrgb = 0x0000005B,
        ASTC10x6Unorm = 0x0000005C,
        ASTC10x6UnormSrgb = 0x0000005D,
        ASTC10x8Unorm = 0x0000005E,
        ASTC10x8UnormSrgb = 0x0000005F,
        ASTC10x10Unorm = 0x00000060,
        ASTC10x10UnormSrgb = 0x00000061,
        ASTC12x10Unorm = 0x00000062,
        ASTC12x10UnormSrgb = 0x00000063,
        ASTC12x12Unorm = 0x00000064,
        ASTC12x12UnormSrgb = 0x00000065,
        Force32 = 0x7FFFFFFF,
    }

    public enum TextureSampleType
    {
        BindingNotUsed = 0x00000000,
        Undefined = 0x00000001,
        Float = 0x00000002,
        UnfilterableFloat = 0x00000003,
        Depth = 0x00000004,
        Sint = 0x00000005,
        Uint = 0x00000006,
        Force32 = 0x7FFFFFFF,
    }

    public enum TextureViewDimension
    {
        Undefined = 0x00000000,
    D1D = 0x00000001,
    D2D = 0x00000002,
    D2DArray = 0x00000003,
        Cube = 0x00000004,
        CubeArray = 0x00000005,
    D3D = 0x00000006,
        Force32 = 0x7FFFFFFF,
    }

    public enum ToneMappingMode
    {
        Standard = 0x00000001,
        Extended = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum VertexFormat
    {
        Uint8 = 0x00000001,
        Uint8x2 = 0x00000002,
        Uint8x4 = 0x00000003,
        Sint8 = 0x00000004,
        Sint8x2 = 0x00000005,
        Sint8x4 = 0x00000006,
        Unorm8 = 0x00000007,
        Unorm8x2 = 0x00000008,
        Unorm8x4 = 0x00000009,
        Snorm8 = 0x0000000A,
        Snorm8x2 = 0x0000000B,
        Snorm8x4 = 0x0000000C,
        Uint16 = 0x0000000D,
        Uint16x2 = 0x0000000E,
        Uint16x4 = 0x0000000F,
        Sint16 = 0x00000010,
        Sint16x2 = 0x00000011,
        Sint16x4 = 0x00000012,
        Unorm16 = 0x00000013,
        Unorm16x2 = 0x00000014,
        Unorm16x4 = 0x00000015,
        Snorm16 = 0x00000016,
        Snorm16x2 = 0x00000017,
        Snorm16x4 = 0x00000018,
        Float16 = 0x00000019,
        Float16x2 = 0x0000001A,
        Float16x4 = 0x0000001B,
        Float32 = 0x0000001C,
        Float32x2 = 0x0000001D,
        Float32x3 = 0x0000001E,
        Float32x4 = 0x0000001F,
        Uint32 = 0x00000020,
        Uint32x2 = 0x00000021,
        Uint32x3 = 0x00000022,
        Uint32x4 = 0x00000023,
        Sint32 = 0x00000024,
        Sint32x2 = 0x00000025,
        Sint32x3 = 0x00000026,
        Sint32x4 = 0x00000027,
        Unorm10_10_10_2 = 0x00000028,
        Unorm8x4BGRA = 0x00000029,
        Force32 = 0x7FFFFFFF,
    }

    public enum VertexStepMode
    {
        Undefined = 0x00000000,
        Vertex = 0x00000001,
        Instance = 0x00000002,
        Force32 = 0x7FFFFFFF,
    }

    public enum WaitStatus
    {
        Success = 0x00000001,
        TimedOut = 0x00000002,
        Error = 0x00000003,
        Force32 = 0x7FFFFFFF,
    }

    public enum WGSLLanguageFeatureName
    {
        ReadonlyAndReadwriteStorageTextures = 0x00000001,
        Packed4x8IntegerDotProduct = 0x00000002,
        UnrestrictedPointerParameters = 0x00000003,
        PointerCompositeAccess = 0x00000004,
        UniformBufferStandardLayout = 0x00000005,
        SubgroupId = 0x00000006,
        TextureAndSamplerLet = 0x00000007,
        SubgroupUniformity = 0x00000008,
        TextureFormatsTier1 = 0x00000009,
        Force32 = 0x7FFFFFFF,
    }

    public unsafe partial struct ChainedStruct
    {
        [NativeTypeName("struct ChainedStruct *")]
        public ChainedStruct* next;

        public SType sType;
    }

    public unsafe partial struct BufferMapCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("BufferMapCallback")]
        public delegate* unmanaged[Cdecl]<MapAsyncStatus, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct CompilationInfoCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("CompilationInfoCallback")]
        public delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct CreateComputePipelineAsyncCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("CreateComputePipelineAsyncCallback")]
        public delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, ComputePipeline*, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct CreateRenderPipelineAsyncCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("CreateRenderPipelineAsyncCallback")]
        public delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct DeviceLostCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("DeviceLostCallback")]
        public delegate* unmanaged[Cdecl]<Device**, DeviceLostReason, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct PopErrorScopeCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("PopErrorScopeCallback")]
        public delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct QueueWorkDoneCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("QueueWorkDoneCallback")]
        public delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct RequestAdapterCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("RequestAdapterCallback")]
        public delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct RequestDeviceCallbackInfo
    {
        public ChainedStruct* nextInChain;

        public CallbackMode mode;

        [NativeTypeName("RequestDeviceCallback")]
        public delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct UncapturedErrorCallbackInfo
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("UncapturedErrorCallback")]
        public delegate* unmanaged[Cdecl]<Device**, ErrorType, StringView, void*, void*, void> callback;

        public void* userdata1;

        public void* userdata2;
    }

    public unsafe partial struct AdapterInfo
    {
        public ChainedStruct* nextInChain;

        public StringView vendor;

        public StringView architecture;

        public StringView device;

        public StringView description;

        public BackendType backendType;

        public AdapterType adapterType;

        [NativeTypeName("uint32_t")]
        public uint vendorID;

        [NativeTypeName("uint32_t")]
        public uint deviceID;

        [NativeTypeName("uint32_t")]
        public uint subgroupMinSize;

        [NativeTypeName("uint32_t")]
        public uint subgroupMaxSize;
    }

    public partial struct BlendComponent
    {
        public BlendOperation operation;

        public BlendFactor srcFactor;

        public BlendFactor dstFactor;
    }

    public unsafe partial struct BufferBindingLayout
    {
        public ChainedStruct* nextInChain;

        public BufferBindingType type;

        [NativeTypeName("Bool")]
        public uint hasDynamicOffset;

        [NativeTypeName("uint64_t")]
        public ulong minBindingSize;
    }

    public unsafe partial struct BufferDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("BufferUsage")]
        public ulong usage;

        [NativeTypeName("uint64_t")]
        public ulong size;

        [NativeTypeName("Bool")]
        public uint mappedAtCreation;
    }

    public partial struct Color
    {
        public double r;

        public double g;

        public double b;

        public double a;
    }

    public unsafe partial struct CommandBufferDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;
    }

    public unsafe partial struct CommandEncoderDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;
    }

    public partial struct CompatibilityModeLimits
    {
        public ChainedStruct chain;

        [NativeTypeName("uint32_t")]
        public uint maxStorageBuffersInVertexStage;

        [NativeTypeName("uint32_t")]
        public uint maxStorageTexturesInVertexStage;

        [NativeTypeName("uint32_t")]
        public uint maxStorageBuffersInFragmentStage;

        [NativeTypeName("uint32_t")]
        public uint maxStorageTexturesInFragmentStage;
    }

    public unsafe partial struct CompilationMessage
    {
        public ChainedStruct* nextInChain;

        public StringView message;

        public CompilationMessageType type;

        [NativeTypeName("uint64_t")]
        public ulong lineNum;

        [NativeTypeName("uint64_t")]
        public ulong linePos;

        [NativeTypeName("uint64_t")]
        public ulong offset;

        [NativeTypeName("uint64_t")]
        public ulong length;
    }

    public unsafe partial struct ConstantEntry
    {
        public ChainedStruct* nextInChain;

        public StringView key;

        public double value;
    }

    public partial struct Extent3D
    {
        [NativeTypeName("uint32_t")]
        public uint width;

        [NativeTypeName("uint32_t")]
        public uint height;

        [NativeTypeName("uint32_t")]
        public uint depthOrArrayLayers;
    }

    public unsafe partial struct ExternalTextureBindingEntry
    {
        public ChainedStruct chain;

        [NativeTypeName("ExternalTexture")]
        public ExternalTexture* externalTexture;
    }

    public partial struct ExternalTextureBindingLayout
    {
        public ChainedStruct chain;
    }

    public partial struct Future
    {
        [NativeTypeName("uint64_t")]
        public ulong id;
    }

    public unsafe partial struct InstanceLimits
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("size_t")]
        public nuint timedWaitAnyMaxCount;
    }

    public unsafe partial struct MultisampleState
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("uint32_t")]
        public uint count;

        [NativeTypeName("uint32_t")]
        public uint mask;

        [NativeTypeName("Bool")]
        public uint alphaToCoverageEnabled;
    }

    public partial struct Origin3D
    {
        [NativeTypeName("uint32_t")]
        public uint x;

        [NativeTypeName("uint32_t")]
        public uint y;

        [NativeTypeName("uint32_t")]
        public uint z;
    }

    public unsafe partial struct PassTimestampWrites
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("QuerySet")]
        public QuerySet* querySet;

        [NativeTypeName("uint32_t")]
        public uint beginningOfPassWriteIndex;

        [NativeTypeName("uint32_t")]
        public uint endOfPassWriteIndex;
    }

    public unsafe partial struct PipelineLayoutDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("size_t")]
        public nuint bindGroupLayoutCount;

        [NativeTypeName("const BindGroupLayout *")]
        public BindGroupLayout** bindGroupLayouts;

        [NativeTypeName("uint32_t")]
        public uint immediateSize;
    }

    public unsafe partial struct PrimitiveState
    {
        public ChainedStruct* nextInChain;

        public PrimitiveTopology topology;

        public IndexFormat stripIndexFormat;

        public FrontFace frontFace;

        public CullMode cullMode;

        [NativeTypeName("Bool")]
        public uint unclippedDepth;
    }

    public unsafe partial struct QuerySetDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        public QueryType type;

        [NativeTypeName("uint32_t")]
        public uint count;
    }

    public unsafe partial struct QueueDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;
    }

    public unsafe partial struct RenderBundleDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;
    }

    public unsafe partial struct RenderBundleEncoderDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("size_t")]
        public nuint colorFormatCount;

        [NativeTypeName("const TextureFormat *")]
        public TextureFormat* colorFormats;

        public TextureFormat depthStencilFormat;

        [NativeTypeName("uint32_t")]
        public uint sampleCount;

        [NativeTypeName("Bool")]
        public uint depthReadOnly;

        [NativeTypeName("Bool")]
        public uint stencilReadOnly;
    }

    public unsafe partial struct RenderPassDepthStencilAttachment
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("TextureView")]
        public TextureView* view;

        public LoadOp depthLoadOp;

        public StoreOp depthStoreOp;

        public float depthClearValue;

        [NativeTypeName("Bool")]
        public uint depthReadOnly;

        public LoadOp stencilLoadOp;

        public StoreOp stencilStoreOp;

        [NativeTypeName("uint32_t")]
        public uint stencilClearValue;

        [NativeTypeName("Bool")]
        public uint stencilReadOnly;
    }

    public partial struct RenderPassMaxDrawCount
    {
        public ChainedStruct chain;

        [NativeTypeName("uint64_t")]
        public ulong maxDrawCount;
    }

    public partial struct RequestAdapterWebXROptions
    {
        public ChainedStruct chain;

        [NativeTypeName("Bool")]
        public uint xrCompatible;
    }

    public unsafe partial struct SamplerBindingLayout
    {
        public ChainedStruct* nextInChain;

        public SamplerBindingType type;
    }

    public unsafe partial struct SamplerDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        public AddressMode addressModeU;

        public AddressMode addressModeV;

        public AddressMode addressModeW;

        public FilterMode magFilter;

        public FilterMode minFilter;

        public MipmapFilterMode mipmapFilter;

        public float lodMinClamp;

        public float lodMaxClamp;

        public CompareFunction compare;

        [NativeTypeName("uint16_t")]
        public ushort maxAnisotropy;
    }

    public unsafe partial struct ShaderSourceSPIRV
    {
        public ChainedStruct chain;

        [NativeTypeName("uint32_t")]
        public uint codeSize;

        [NativeTypeName("const uint32_t *")]
        public uint* code;
    }

    public partial struct ShaderSourceWGSL
    {
        public ChainedStruct chain;

        public StringView code;
    }

    public partial struct StencilFaceState
    {
        public CompareFunction compare;

        public StencilOperation failOp;

        public StencilOperation depthFailOp;

        public StencilOperation passOp;
    }

    public unsafe partial struct StorageTextureBindingLayout
    {
        public ChainedStruct* nextInChain;

        public StorageTextureAccess access;

        public TextureFormat format;

        public TextureViewDimension viewDimension;
    }

    public unsafe partial struct SupportedFeatures
    {
        [NativeTypeName("size_t")]
        public nuint featureCount;

        [NativeTypeName("const FeatureName *")]
        public FeatureName* features;
    }

    public unsafe partial struct SupportedInstanceFeatures
    {
        [NativeTypeName("size_t")]
        public nuint featureCount;

        [NativeTypeName("const InstanceFeatureName *")]
        public InstanceFeatureName* features;
    }

    public unsafe partial struct SupportedWGSLLanguageFeatures
    {
        [NativeTypeName("size_t")]
        public nuint featureCount;

        [NativeTypeName("const WGSLLanguageFeatureName *")]
        public WGSLLanguageFeatureName* features;
    }

    public unsafe partial struct SurfaceCapabilities
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("TextureUsage")]
        public ulong usages;

        [NativeTypeName("size_t")]
        public nuint formatCount;

        [NativeTypeName("const TextureFormat *")]
        public TextureFormat* formats;

        [NativeTypeName("size_t")]
        public nuint presentModeCount;

        [NativeTypeName("const PresentMode *")]
        public PresentMode* presentModes;

        [NativeTypeName("size_t")]
        public nuint alphaModeCount;

        [NativeTypeName("const CompositeAlphaMode *")]
        public CompositeAlphaMode* alphaModes;
    }

    public partial struct SurfaceColorManagement
    {
        public ChainedStruct chain;

        public PredefinedColorSpace colorSpace;

        public ToneMappingMode toneMappingMode;
    }

    public unsafe partial struct SurfaceConfiguration
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("Device")]
        public Device* device;

        public TextureFormat format;

        [NativeTypeName("TextureUsage")]
        public ulong usage;

        [NativeTypeName("uint32_t")]
        public uint width;

        [NativeTypeName("uint32_t")]
        public uint height;

        [NativeTypeName("size_t")]
        public nuint viewFormatCount;

        [NativeTypeName("const TextureFormat *")]
        public TextureFormat* viewFormats;

        public CompositeAlphaMode alphaMode;

        public PresentMode presentMode;
    }

    public unsafe partial struct SurfaceSourceAndroidNativeWindow
    {
        public ChainedStruct chain;

        public void* window;
    }

    public unsafe partial struct SurfaceSourceMetalLayer
    {
        public ChainedStruct chain;

        public void* layer;
    }

    public unsafe partial struct SurfaceSourceWaylandSurface
    {
        public ChainedStruct chain;

        public void* display;

        public void* surface;
    }

    public unsafe partial struct SurfaceSourceWindowsHWND
    {
        public ChainedStruct chain;

        public void* hinstance;

        public void* hwnd;
    }

    public unsafe partial struct SurfaceSourceXCBWindow
    {
        public ChainedStruct chain;

        public void* connection;

        [NativeTypeName("uint32_t")]
        public uint window;
    }

    public unsafe partial struct SurfaceSourceXlibWindow
    {
        public ChainedStruct chain;

        public void* display;

        [NativeTypeName("uint64_t")]
        public ulong window;
    }

    public unsafe partial struct SurfaceTexture
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("Texture")]
        public Texture* texture;

        public SurfaceGetCurrentTextureStatus status;
    }

    public partial struct TexelCopyBufferLayout
    {
        [NativeTypeName("uint64_t")]
        public ulong offset;

        [NativeTypeName("uint32_t")]
        public uint bytesPerRow;

        [NativeTypeName("uint32_t")]
        public uint rowsPerImage;
    }

    public unsafe partial struct TextureBindingLayout
    {
        public ChainedStruct* nextInChain;

        public TextureSampleType sampleType;

        public TextureViewDimension viewDimension;

        [NativeTypeName("Bool")]
        public uint multisampled;
    }

    public partial struct TextureBindingViewDimension
    {
        public ChainedStruct chain;

        public TextureViewDimension textureBindingViewDimension;
    }

    public partial struct TextureComponentSwizzle
    {
        public ComponentSwizzle r;

        public ComponentSwizzle g;

        public ComponentSwizzle b;

        public ComponentSwizzle a;
    }

    public unsafe partial struct VertexAttribute
    {
        public ChainedStruct* nextInChain;

        public VertexFormat format;

        [NativeTypeName("uint64_t")]
        public ulong offset;

        [NativeTypeName("uint32_t")]
        public uint shaderLocation;
    }

    public unsafe partial struct BindGroupEntry
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("uint32_t")]
        public uint binding;

        [NativeTypeName("Buffer")]
        public Buffer* buffer;

        [NativeTypeName("uint64_t")]
        public ulong offset;

        [NativeTypeName("uint64_t")]
        public ulong size;

        [NativeTypeName("Sampler")]
        public Sampler* sampler;

        [NativeTypeName("TextureView")]
        public TextureView* textureView;
    }

    public unsafe partial struct BindGroupLayoutEntry
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("uint32_t")]
        public uint binding;

        [NativeTypeName("ShaderStage")]
        public ulong visibility;

        [NativeTypeName("uint32_t")]
        public uint bindingArraySize;

        public BufferBindingLayout buffer;

        public SamplerBindingLayout sampler;

        public TextureBindingLayout texture;

        public StorageTextureBindingLayout storageTexture;
    }

    public partial struct BlendState
    {
        public BlendComponent color;

        public BlendComponent alpha;
    }

    public unsafe partial struct CompilationInfo
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("size_t")]
        public nuint messageCount;

        [NativeTypeName("const CompilationMessage *")]
        public CompilationMessage* messages;
    }

    public unsafe partial struct ComputePassDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("const PassTimestampWrites *")]
        public PassTimestampWrites* timestampWrites;
    }

    public unsafe partial struct ComputeState
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("ShaderModule")]
        public ShaderModule* module;

        public StringView entryPoint;

        [NativeTypeName("size_t")]
        public nuint constantCount;

        [NativeTypeName("const ConstantEntry *")]
        public ConstantEntry* constants;
    }

    public unsafe partial struct DepthStencilState
    {
        public ChainedStruct* nextInChain;

        public TextureFormat format;

        public OptionalBool depthWriteEnabled;

        public CompareFunction depthCompare;

        public StencilFaceState stencilFront;

        public StencilFaceState stencilBack;

        [NativeTypeName("uint32_t")]
        public uint stencilReadMask;

        [NativeTypeName("uint32_t")]
        public uint stencilWriteMask;

        [NativeTypeName("int32_t")]
        public int depthBias;

        public float depthBiasSlopeScale;

        public float depthBiasClamp;
    }

    public partial struct FutureWaitInfo
    {
        public Future future;

        [NativeTypeName("Bool")]
        public uint completed;
    }

    public unsafe partial struct InstanceDescriptor
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("size_t")]
        public nuint requiredFeatureCount;

        [NativeTypeName("const InstanceFeatureName *")]
        public InstanceFeatureName* requiredFeatures;

        [NativeTypeName("const InstanceLimits *")]
        public InstanceLimits* requiredLimits;
    }

    public unsafe partial struct Limits
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("uint32_t")]
        public uint maxTextureDimension1D;

        [NativeTypeName("uint32_t")]
        public uint maxTextureDimension2D;

        [NativeTypeName("uint32_t")]
        public uint maxTextureDimension3D;

        [NativeTypeName("uint32_t")]
        public uint maxTextureArrayLayers;

        [NativeTypeName("uint32_t")]
        public uint maxBindGroups;

        [NativeTypeName("uint32_t")]
        public uint maxBindGroupsPlusVertexBuffers;

        [NativeTypeName("uint32_t")]
        public uint maxBindingsPerBindGroup;

        [NativeTypeName("uint32_t")]
        public uint maxDynamicUniformBuffersPerPipelineLayout;

        [NativeTypeName("uint32_t")]
        public uint maxDynamicStorageBuffersPerPipelineLayout;

        [NativeTypeName("uint32_t")]
        public uint maxSampledTexturesPerShaderStage;

        [NativeTypeName("uint32_t")]
        public uint maxSamplersPerShaderStage;

        [NativeTypeName("uint32_t")]
        public uint maxStorageBuffersPerShaderStage;

        [NativeTypeName("uint32_t")]
        public uint maxStorageTexturesPerShaderStage;

        [NativeTypeName("uint32_t")]
        public uint maxUniformBuffersPerShaderStage;

        [NativeTypeName("uint64_t")]
        public ulong maxUniformBufferBindingSize;

        [NativeTypeName("uint64_t")]
        public ulong maxStorageBufferBindingSize;

        [NativeTypeName("uint32_t")]
        public uint minUniformBufferOffsetAlignment;

        [NativeTypeName("uint32_t")]
        public uint minStorageBufferOffsetAlignment;

        [NativeTypeName("uint32_t")]
        public uint maxVertexBuffers;

        [NativeTypeName("uint64_t")]
        public ulong maxBufferSize;

        [NativeTypeName("uint32_t")]
        public uint maxVertexAttributes;

        [NativeTypeName("uint32_t")]
        public uint maxVertexBufferArrayStride;

        [NativeTypeName("uint32_t")]
        public uint maxInterStageShaderVariables;

        [NativeTypeName("uint32_t")]
        public uint maxColorAttachments;

        [NativeTypeName("uint32_t")]
        public uint maxColorAttachmentBytesPerSample;

        [NativeTypeName("uint32_t")]
        public uint maxComputeWorkgroupStorageSize;

        [NativeTypeName("uint32_t")]
        public uint maxComputeInvocationsPerWorkgroup;

        [NativeTypeName("uint32_t")]
        public uint maxComputeWorkgroupSizeX;

        [NativeTypeName("uint32_t")]
        public uint maxComputeWorkgroupSizeY;

        [NativeTypeName("uint32_t")]
        public uint maxComputeWorkgroupSizeZ;

        [NativeTypeName("uint32_t")]
        public uint maxComputeWorkgroupsPerDimension;

        [NativeTypeName("uint32_t")]
        public uint maxImmediateSize;
    }

    public unsafe partial struct RenderPassColorAttachment
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("TextureView")]
        public TextureView* view;

        [NativeTypeName("uint32_t")]
        public uint depthSlice;

        [NativeTypeName("TextureView")]
        public TextureView* resolveTarget;

        public LoadOp loadOp;

        public StoreOp storeOp;

        public Color clearValue;
    }

    public unsafe partial struct RequestAdapterOptions
    {
        public ChainedStruct* nextInChain;

        public FeatureLevel featureLevel;

        public PowerPreference powerPreference;

        [NativeTypeName("Bool")]
        public uint forceFallbackAdapter;

        public BackendType backendType;

        [NativeTypeName("Surface")]
        public Surface* compatibleSurface;
    }

    public unsafe partial struct ShaderModuleDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;
    }

    public unsafe partial struct SurfaceDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;
    }

    public unsafe partial struct TexelCopyBufferInfo
    {
        public TexelCopyBufferLayout layout;

        [NativeTypeName("Buffer")]
        public Buffer* buffer;
    }

    public unsafe partial struct TexelCopyTextureInfo
    {
        [NativeTypeName("Texture")]
        public Texture* texture;

        [NativeTypeName("uint32_t")]
        public uint mipLevel;

        public Origin3D origin;

        public TextureAspect aspect;
    }

    public partial struct TextureComponentSwizzleDescriptor
    {
        public ChainedStruct chain;

        public TextureComponentSwizzle swizzle;
    }

    public unsafe partial struct TextureDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("TextureUsage")]
        public ulong usage;

        public TextureDimension dimension;

        public Extent3D size;

        public TextureFormat format;

        [NativeTypeName("uint32_t")]
        public uint mipLevelCount;

        [NativeTypeName("uint32_t")]
        public uint sampleCount;

        [NativeTypeName("size_t")]
        public nuint viewFormatCount;

        [NativeTypeName("const TextureFormat *")]
        public TextureFormat* viewFormats;
    }

    public unsafe partial struct VertexBufferLayout
    {
        public ChainedStruct* nextInChain;

        public VertexStepMode stepMode;

        [NativeTypeName("uint64_t")]
        public ulong arrayStride;

        [NativeTypeName("size_t")]
        public nuint attributeCount;

        [NativeTypeName("const VertexAttribute *")]
        public VertexAttribute* attributes;
    }

    public unsafe partial struct BindGroupDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("BindGroupLayout")]
        public BindGroupLayout* layout;

        [NativeTypeName("size_t")]
        public nuint entryCount;

        [NativeTypeName("const BindGroupEntry *")]
        public BindGroupEntry* entries;
    }

    public unsafe partial struct BindGroupLayoutDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("size_t")]
        public nuint entryCount;

        [NativeTypeName("const BindGroupLayoutEntry *")]
        public BindGroupLayoutEntry* entries;
    }

    public unsafe partial struct ColorTargetState
    {
        public ChainedStruct* nextInChain;

        public TextureFormat format;

        [NativeTypeName("const BlendState *")]
        public BlendState* blend;

        [NativeTypeName("ColorWriteMask")]
        public ulong writeMask;
    }

    public unsafe partial struct ComputePipelineDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("PipelineLayout")]
        public PipelineLayout* layout;

        public ComputeState compute;
    }

    public unsafe partial struct DeviceDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("size_t")]
        public nuint requiredFeatureCount;

        [NativeTypeName("const FeatureName *")]
        public FeatureName* requiredFeatures;

        [NativeTypeName("const Limits *")]
        public Limits* requiredLimits;

        public QueueDescriptor defaultQueue;

        public DeviceLostCallbackInfo deviceLostCallbackInfo;

        public UncapturedErrorCallbackInfo uncapturedErrorCallbackInfo;
    }

    public unsafe partial struct RenderPassDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("size_t")]
        public nuint colorAttachmentCount;

        [NativeTypeName("const RenderPassColorAttachment *")]
        public RenderPassColorAttachment* colorAttachments;

        [NativeTypeName("const RenderPassDepthStencilAttachment *")]
        public RenderPassDepthStencilAttachment* depthStencilAttachment;

        [NativeTypeName("QuerySet")]
        public QuerySet* occlusionQuerySet;

        [NativeTypeName("const PassTimestampWrites *")]
        public PassTimestampWrites* timestampWrites;
    }

    public unsafe partial struct TextureViewDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        public TextureFormat format;

        public TextureViewDimension dimension;

        [NativeTypeName("uint32_t")]
        public uint baseMipLevel;

        [NativeTypeName("uint32_t")]
        public uint mipLevelCount;

        [NativeTypeName("uint32_t")]
        public uint baseArrayLayer;

        [NativeTypeName("uint32_t")]
        public uint arrayLayerCount;

        public TextureAspect aspect;

        [NativeTypeName("TextureUsage")]
        public ulong usage;
    }

    public unsafe partial struct VertexState
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("ShaderModule")]
        public ShaderModule* module;

        public StringView entryPoint;

        [NativeTypeName("size_t")]
        public nuint constantCount;

        [NativeTypeName("const ConstantEntry *")]
        public ConstantEntry* constants;

        [NativeTypeName("size_t")]
        public nuint bufferCount;

        [NativeTypeName("const VertexBufferLayout *")]
        public VertexBufferLayout* buffers;
    }

    public unsafe partial struct FragmentState
    {
        public ChainedStruct* nextInChain;

        [NativeTypeName("ShaderModule")]
        public ShaderModule* module;

        public StringView entryPoint;

        [NativeTypeName("size_t")]
        public nuint constantCount;

        [NativeTypeName("const ConstantEntry *")]
        public ConstantEntry* constants;

        [NativeTypeName("size_t")]
        public nuint targetCount;

        [NativeTypeName("const ColorTargetState *")]
        public ColorTargetState* targets;
    }

    public unsafe partial struct RenderPipelineDescriptor
    {
        public ChainedStruct* nextInChain;

        public StringView label;

        [NativeTypeName("PipelineLayout")]
        public PipelineLayout* layout;

        public VertexState vertex;

        public PrimitiveState primitive;

        [NativeTypeName("const DepthStencilState *")]
        public DepthStencilState* depthStencil;

        public MultisampleState multisample;

        [NativeTypeName("const FragmentState *")]
        public FragmentState* fragment;
    }

    public static unsafe partial class WebGPU_native
    {
        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_All = 0x00000000;

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_Vulkan = 1 << 0;

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_GL = 1 << 1;

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_Metal = 1 << 2;

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_DX12 = 1 << 3;

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_BrowserWebGPU = 1 << 5;

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_Primary = (1 << 0) | (1 << 2) | (1 << 3) | (1 << 5);

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_Secondary = (1 << 1);

        [NativeTypeName("const InstanceBackend")]
        public const ulong InstanceBackend_Force32 = 0x7FFFFFFF;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_Empty = 0x00000000;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_Debug = 1 << 0;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_Validation = 1 << 1;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_DiscardHalLabels = 1 << 2;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_AllowUnderlyingNoncompliantAdapter = 1 << 3;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_GPUBasedValidation = 1 << 4;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_ValidationIndirectCall = 1 << 5;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_AutomaticTimestampNormalization = 1 << 6;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_Default = 1 << 24;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_Debugging = 1 << 25;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_AdvancedDebugging = 1 << 26;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_WithEnv = 1 << 27;

        [NativeTypeName("const InstanceFlag")]
        public const ulong InstanceFlag_Force32 = 0x7FFFFFFF;

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuGenerateReport([NativeTypeName("Instance")] Instance* instance, GlobalReport* report);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wgpuInstanceEnumerateAdapters([NativeTypeName("Instance")] Instance* instance, [NativeTypeName("const InstanceEnumerateAdapterOptions *")] InstanceEnumerateAdapterOptions* options, [NativeTypeName("Adapter *")] Adapter** adapters);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SubmissionIndex")]
        public static extern ulong wgpuQueueSubmitForIndex([NativeTypeName("Queue")] Queue* queue, [NativeTypeName("size_t")] nuint commandCount, [NativeTypeName("const CommandBuffer *")] CommandBuffer** commands);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float wgpuQueueGetTimestampPeriod([NativeTypeName("Queue")] Queue* queue);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Bool")]
        public static extern uint wgpuDevicePoll([NativeTypeName("Device")] Device* device, [NativeTypeName("Bool")] uint wait, [NativeTypeName("const SubmissionIndex *")] ulong* submissionIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ShaderModule")]
        public static extern ShaderModule* wgpuDeviceCreateShaderModuleSpirV([NativeTypeName("Device")] Device* device, [NativeTypeName("const ShaderModuleDescriptorSpirV *")] ShaderModuleDescriptorSpirV* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSetLogCallback([NativeTypeName("LogCallback")] delegate* unmanaged[Cdecl]<LogLevel, StringView, void*, void> callback, void* userdata);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSetLogLevel(LogLevel level);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint wgpuGetVersion();

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* wgpuDeviceGetNativeMetalDevice([NativeTypeName("Device")] Device* device);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* wgpuQueueGetNativeMetalCommandQueue([NativeTypeName("Queue")] Queue* queue);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* wgpuTextureGetNativeMetalTexture([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetImmediates([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* encoder, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint sizeBytes, [NativeTypeName("const void *")] void* data);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderSetImmediates([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* encoder, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint sizeBytes, [NativeTypeName("const void *")] void* data);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderSetImmediates([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* encoder, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint sizeBytes, [NativeTypeName("const void *")] void* data);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderMultiDrawIndirect([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* encoder, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("uint32_t")] uint count);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderMultiDrawIndexedIndirect([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* encoder, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("uint32_t")] uint count);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderMultiDrawIndirectCount([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* encoder, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("Buffer")] Buffer* count_buffer, [NativeTypeName("uint64_t")] ulong count_buffer_offset, [NativeTypeName("uint32_t")] uint max_count);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderMultiDrawIndexedIndirectCount([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* encoder, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("Buffer")] Buffer* count_buffer, [NativeTypeName("uint64_t")] ulong count_buffer_offset, [NativeTypeName("uint32_t")] uint max_count);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderBeginPipelineStatisticsQuery([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, [NativeTypeName("QuerySet")] QuerySet* querySet, [NativeTypeName("uint32_t")] uint queryIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderEndPipelineStatisticsQuery([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderBeginPipelineStatisticsQuery([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("QuerySet")] QuerySet* querySet, [NativeTypeName("uint32_t")] uint queryIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderEndPipelineStatisticsQuery([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderWriteTimestamp([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, [NativeTypeName("QuerySet")] QuerySet* querySet, [NativeTypeName("uint32_t")] uint queryIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderWriteTimestamp([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("QuerySet")] QuerySet* querySet, [NativeTypeName("uint32_t")] uint queryIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Bool")]
        public static extern uint wgpuDeviceStartGraphicsDebuggerCapture([NativeTypeName("Device")] Device* device);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuDeviceStopGraphicsDebuggerCapture([NativeTypeName("Device")] Device* device);

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_None = 0x0000000000000000;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_MapRead = 0x0000000000000001;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_MapWrite = 0x0000000000000002;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_CopySrc = 0x0000000000000004;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_CopyDst = 0x0000000000000008;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_Index = 0x0000000000000010;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_Vertex = 0x0000000000000020;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_Uniform = 0x0000000000000040;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_Storage = 0x0000000000000080;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_Indirect = 0x0000000000000100;

        [NativeTypeName("const BufferUsage")]
        public const ulong BufferUsage_QueryResolve = 0x0000000000000200;

        [NativeTypeName("const ColorWriteMask")]
        public const ulong ColorWriteMask_None = 0x0000000000000000;

        [NativeTypeName("const ColorWriteMask")]
        public const ulong ColorWriteMask_Red = 0x0000000000000001;

        [NativeTypeName("const ColorWriteMask")]
        public const ulong ColorWriteMask_Green = 0x0000000000000002;

        [NativeTypeName("const ColorWriteMask")]
        public const ulong ColorWriteMask_Blue = 0x0000000000000004;

        [NativeTypeName("const ColorWriteMask")]
        public const ulong ColorWriteMask_Alpha = 0x0000000000000008;

        [NativeTypeName("const ColorWriteMask")]
        public const ulong ColorWriteMask_All = 0x000000000000000F;

        [NativeTypeName("const MapMode")]
        public const ulong MapMode_None = 0x0000000000000000;

        [NativeTypeName("const MapMode")]
        public const ulong MapMode_Read = 0x0000000000000001;

        [NativeTypeName("const MapMode")]
        public const ulong MapMode_Write = 0x0000000000000002;

        [NativeTypeName("const ShaderStage")]
        public const ulong ShaderStage_None = 0x0000000000000000;

        [NativeTypeName("const ShaderStage")]
        public const ulong ShaderStage_Vertex = 0x0000000000000001;

        [NativeTypeName("const ShaderStage")]
        public const ulong ShaderStage_Fragment = 0x0000000000000002;

        [NativeTypeName("const ShaderStage")]
        public const ulong ShaderStage_Compute = 0x0000000000000004;

        [NativeTypeName("const TextureUsage")]
        public const ulong TextureUsage_None = 0x0000000000000000;

        [NativeTypeName("const TextureUsage")]
        public const ulong TextureUsage_CopySrc = 0x0000000000000001;

        [NativeTypeName("const TextureUsage")]
        public const ulong TextureUsage_CopyDst = 0x0000000000000002;

        [NativeTypeName("const TextureUsage")]
        public const ulong TextureUsage_TextureBinding = 0x0000000000000004;

        [NativeTypeName("const TextureUsage")]
        public const ulong TextureUsage_StorageBinding = 0x0000000000000008;

        [NativeTypeName("const TextureUsage")]
        public const ulong TextureUsage_RenderAttachment = 0x0000000000000010;

        [NativeTypeName("const TextureUsage")]
        public const ulong TextureUsage_TransientAttachment = 0x0000000000000020;

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Instance")]
        public static extern Instance* wgpuCreateInstance([NativeTypeName("const InstanceDescriptor *")] InstanceDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuGetInstanceFeatures(SupportedInstanceFeatures* features);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuGetInstanceLimits(InstanceLimits* limits);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Bool")]
        public static extern uint wgpuHasInstanceFeature(InstanceFeatureName feature);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Proc")]
        public static extern delegate* unmanaged[Cdecl]<void> wgpuGetProcAddress(StringView procName);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuAdapterGetFeatures([NativeTypeName("Adapter")] Adapter* adapter, SupportedFeatures* features);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuAdapterGetInfo([NativeTypeName("Adapter")] Adapter* adapter, AdapterInfo* info);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuAdapterGetLimits([NativeTypeName("Adapter")] Adapter* adapter, Limits* limits);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Bool")]
        public static extern uint wgpuAdapterHasFeature([NativeTypeName("Adapter")] Adapter* adapter, FeatureName feature);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuAdapterRequestDevice([NativeTypeName("Adapter")] Adapter* adapter, [NativeTypeName("const DeviceDescriptor *")] DeviceDescriptor* descriptor, RequestDeviceCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuAdapterAddRef([NativeTypeName("Adapter")] Adapter* adapter);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuAdapterRelease([NativeTypeName("Adapter")] Adapter* adapter);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuAdapterInfoFreeMembers(AdapterInfo adapterInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBindGroupSetLabel([NativeTypeName("BindGroup")] BindGroup* bindGroup, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBindGroupAddRef([NativeTypeName("BindGroup")] BindGroup* bindGroup);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBindGroupRelease([NativeTypeName("BindGroup")] BindGroup* bindGroup);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBindGroupLayoutSetLabel([NativeTypeName("BindGroupLayout")] BindGroupLayout* bindGroupLayout, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBindGroupLayoutAddRef([NativeTypeName("BindGroupLayout")] BindGroupLayout* bindGroupLayout);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBindGroupLayoutRelease([NativeTypeName("BindGroupLayout")] BindGroupLayout* bindGroupLayout);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBufferDestroy([NativeTypeName("Buffer")] Buffer* buffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* wgpuBufferGetConstMappedRange([NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("size_t")] nuint offset, [NativeTypeName("size_t")] nuint size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* wgpuBufferGetMappedRange([NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("size_t")] nuint offset, [NativeTypeName("size_t")] nuint size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern BufferMapState wgpuBufferGetMapState([NativeTypeName("Buffer")] Buffer* buffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong wgpuBufferGetSize([NativeTypeName("Buffer")] Buffer* buffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BufferUsage")]
        public static extern ulong wgpuBufferGetUsage([NativeTypeName("Buffer")] Buffer* buffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuBufferMapAsync([NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("MapMode")] ulong mode, [NativeTypeName("size_t")] nuint offset, [NativeTypeName("size_t")] nuint size, BufferMapCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuBufferReadMappedRange([NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("size_t")] nuint offset, void* data, [NativeTypeName("size_t")] nuint size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBufferSetLabel([NativeTypeName("Buffer")] Buffer* buffer, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBufferUnmap([NativeTypeName("Buffer")] Buffer* buffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuBufferWriteMappedRange([NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("size_t")] nuint offset, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBufferAddRef([NativeTypeName("Buffer")] Buffer* buffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuBufferRelease([NativeTypeName("Buffer")] Buffer* buffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandBufferSetLabel([NativeTypeName("CommandBuffer")] CommandBuffer* commandBuffer, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandBufferAddRef([NativeTypeName("CommandBuffer")] CommandBuffer* commandBuffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandBufferRelease([NativeTypeName("CommandBuffer")] CommandBuffer* commandBuffer);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ComputePassEncoder")]
        public static extern ComputePassEncoder* wgpuCommandEncoderBeginComputePass([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("const ComputePassDescriptor *")] ComputePassDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("RenderPassEncoder")]
        public static extern RenderPassEncoder* wgpuCommandEncoderBeginRenderPass([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("const RenderPassDescriptor *")] RenderPassDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderClearBuffer([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("uint64_t")] ulong size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderCopyBufferToBuffer([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("Buffer")] Buffer* source, [NativeTypeName("uint64_t")] ulong sourceOffset, [NativeTypeName("Buffer")] Buffer* destination, [NativeTypeName("uint64_t")] ulong destinationOffset, [NativeTypeName("uint64_t")] ulong size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderCopyBufferToTexture([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("const TexelCopyBufferInfo *")] TexelCopyBufferInfo* source, [NativeTypeName("const TexelCopyTextureInfo *")] TexelCopyTextureInfo* destination, [NativeTypeName("const Extent3D *")] Extent3D* copySize);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderCopyTextureToBuffer([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("const TexelCopyTextureInfo *")] TexelCopyTextureInfo* source, [NativeTypeName("const TexelCopyBufferInfo *")] TexelCopyBufferInfo* destination, [NativeTypeName("const Extent3D *")] Extent3D* copySize);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderCopyTextureToTexture([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("const TexelCopyTextureInfo *")] TexelCopyTextureInfo* source, [NativeTypeName("const TexelCopyTextureInfo *")] TexelCopyTextureInfo* destination, [NativeTypeName("const Extent3D *")] Extent3D* copySize);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("CommandBuffer")]
        public static extern CommandBuffer* wgpuCommandEncoderFinish([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("const CommandBufferDescriptor *")] CommandBufferDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderInsertDebugMarker([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, StringView markerLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderPopDebugGroup([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderPushDebugGroup([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, StringView groupLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderResolveQuerySet([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("QuerySet")] QuerySet* querySet, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("Buffer")] Buffer* destination, [NativeTypeName("uint64_t")] ulong destinationOffset);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderSetLabel([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderWriteTimestamp([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder, [NativeTypeName("QuerySet")] QuerySet* querySet, [NativeTypeName("uint32_t")] uint queryIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderAddRef([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuCommandEncoderRelease([NativeTypeName("CommandEncoder")] CommandEncoder* commandEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderDispatchWorkgroups([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, [NativeTypeName("uint32_t")] uint workgroupCountX, [NativeTypeName("uint32_t")] uint workgroupCountY, [NativeTypeName("uint32_t")] uint workgroupCountZ);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderDispatchWorkgroupsIndirect([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, [NativeTypeName("Buffer")] Buffer* indirectBuffer, [NativeTypeName("uint64_t")] ulong indirectOffset);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderEnd([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderInsertDebugMarker([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, StringView markerLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderPopDebugGroup([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderPushDebugGroup([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, StringView groupLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderSetBindGroup([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, [NativeTypeName("uint32_t")] uint groupIndex, [NativeTypeName("BindGroup")] BindGroup* group, [NativeTypeName("size_t")] nuint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* dynamicOffsets);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderSetLabel([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderSetPipeline([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder, [NativeTypeName("ComputePipeline")] ComputePipeline* pipeline);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderAddRef([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePassEncoderRelease([NativeTypeName("ComputePassEncoder")] ComputePassEncoder* computePassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BindGroupLayout")]
        public static extern BindGroupLayout* wgpuComputePipelineGetBindGroupLayout([NativeTypeName("ComputePipeline")] ComputePipeline* computePipeline, [NativeTypeName("uint32_t")] uint groupIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePipelineSetLabel([NativeTypeName("ComputePipeline")] ComputePipeline* computePipeline, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePipelineAddRef([NativeTypeName("ComputePipeline")] ComputePipeline* computePipeline);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuComputePipelineRelease([NativeTypeName("ComputePipeline")] ComputePipeline* computePipeline);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BindGroup")]
        public static extern BindGroup* wgpuDeviceCreateBindGroup([NativeTypeName("Device")] Device* device, [NativeTypeName("const BindGroupDescriptor *")] BindGroupDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BindGroupLayout")]
        public static extern BindGroupLayout* wgpuDeviceCreateBindGroupLayout([NativeTypeName("Device")] Device* device, [NativeTypeName("const BindGroupLayoutDescriptor *")] BindGroupLayoutDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Buffer")]
        public static extern Buffer* wgpuDeviceCreateBuffer([NativeTypeName("Device")] Device* device, [NativeTypeName("const BufferDescriptor *")] BufferDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("CommandEncoder")]
        public static extern CommandEncoder* wgpuDeviceCreateCommandEncoder([NativeTypeName("Device")] Device* device, [NativeTypeName("const CommandEncoderDescriptor *")] CommandEncoderDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ComputePipeline")]
        public static extern ComputePipeline* wgpuDeviceCreateComputePipeline([NativeTypeName("Device")] Device* device, [NativeTypeName("const ComputePipelineDescriptor *")] ComputePipelineDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuDeviceCreateComputePipelineAsync([NativeTypeName("Device")] Device* device, [NativeTypeName("const ComputePipelineDescriptor *")] ComputePipelineDescriptor* descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PipelineLayout")]
        public static extern PipelineLayout* wgpuDeviceCreatePipelineLayout([NativeTypeName("Device")] Device* device, [NativeTypeName("const PipelineLayoutDescriptor *")] PipelineLayoutDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("QuerySet")]
        public static extern QuerySet* wgpuDeviceCreateQuerySet([NativeTypeName("Device")] Device* device, [NativeTypeName("const QuerySetDescriptor *")] QuerySetDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("RenderBundleEncoder")]
        public static extern RenderBundleEncoder* wgpuDeviceCreateRenderBundleEncoder([NativeTypeName("Device")] Device* device, [NativeTypeName("const RenderBundleEncoderDescriptor *")] RenderBundleEncoderDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("RenderPipeline")]
        public static extern RenderPipeline* wgpuDeviceCreateRenderPipeline([NativeTypeName("Device")] Device* device, [NativeTypeName("const RenderPipelineDescriptor *")] RenderPipelineDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuDeviceCreateRenderPipelineAsync([NativeTypeName("Device")] Device* device, [NativeTypeName("const RenderPipelineDescriptor *")] RenderPipelineDescriptor* descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sampler")]
        public static extern Sampler* wgpuDeviceCreateSampler([NativeTypeName("Device")] Device* device, [NativeTypeName("const SamplerDescriptor *")] SamplerDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ShaderModule")]
        public static extern ShaderModule* wgpuDeviceCreateShaderModule([NativeTypeName("Device")] Device* device, [NativeTypeName("const ShaderModuleDescriptor *")] ShaderModuleDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Texture")]
        public static extern Texture* wgpuDeviceCreateTexture([NativeTypeName("Device")] Device* device, [NativeTypeName("const TextureDescriptor *")] TextureDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuDeviceDestroy([NativeTypeName("Device")] Device* device);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuDeviceGetAdapterInfo([NativeTypeName("Device")] Device* device, AdapterInfo* adapterInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuDeviceGetFeatures([NativeTypeName("Device")] Device* device, SupportedFeatures* features);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuDeviceGetLimits([NativeTypeName("Device")] Device* device, Limits* limits);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuDeviceGetLostFuture([NativeTypeName("Device")] Device* device);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Queue")]
        public static extern Queue* wgpuDeviceGetQueue([NativeTypeName("Device")] Device* device);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Bool")]
        public static extern uint wgpuDeviceHasFeature([NativeTypeName("Device")] Device* device, FeatureName feature);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuDevicePopErrorScope([NativeTypeName("Device")] Device* device, PopErrorScopeCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuDevicePushErrorScope([NativeTypeName("Device")] Device* device, ErrorFilter filter);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuDeviceSetLabel([NativeTypeName("Device")] Device* device, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuDeviceAddRef([NativeTypeName("Device")] Device* device);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuDeviceRelease([NativeTypeName("Device")] Device* device);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuExternalTextureSetLabel([NativeTypeName("ExternalTexture")] ExternalTexture* externalTexture, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuExternalTextureAddRef([NativeTypeName("ExternalTexture")] ExternalTexture* externalTexture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuExternalTextureRelease([NativeTypeName("ExternalTexture")] ExternalTexture* externalTexture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Surface")]
        public static extern Surface* wgpuInstanceCreateSurface([NativeTypeName("Instance")] Instance* instance, [NativeTypeName("const SurfaceDescriptor *")] SurfaceDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuInstanceGetWGSLLanguageFeatures([NativeTypeName("Instance")] Instance* instance, SupportedWGSLLanguageFeatures* features);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Bool")]
        public static extern uint wgpuInstanceHasWGSLLanguageFeature([NativeTypeName("Instance")] Instance* instance, WGSLLanguageFeatureName feature);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuInstanceProcessEvents([NativeTypeName("Instance")] Instance* instance);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuInstanceRequestAdapter([NativeTypeName("Instance")] Instance* instance, [NativeTypeName("const RequestAdapterOptions *")] RequestAdapterOptions* options, RequestAdapterCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern WaitStatus wgpuInstanceWaitAny([NativeTypeName("Instance")] Instance* instance, [NativeTypeName("size_t")] nuint futureCount, FutureWaitInfo* futures, [NativeTypeName("uint64_t")] ulong timeoutNS);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuInstanceAddRef([NativeTypeName("Instance")] Instance* instance);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuInstanceRelease([NativeTypeName("Instance")] Instance* instance);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuPipelineLayoutSetLabel([NativeTypeName("PipelineLayout")] PipelineLayout* pipelineLayout, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuPipelineLayoutAddRef([NativeTypeName("PipelineLayout")] PipelineLayout* pipelineLayout);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuPipelineLayoutRelease([NativeTypeName("PipelineLayout")] PipelineLayout* pipelineLayout);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQuerySetDestroy([NativeTypeName("QuerySet")] QuerySet* querySet);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint wgpuQuerySetGetCount([NativeTypeName("QuerySet")] QuerySet* querySet);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern QueryType wgpuQuerySetGetType([NativeTypeName("QuerySet")] QuerySet* querySet);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQuerySetSetLabel([NativeTypeName("QuerySet")] QuerySet* querySet, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQuerySetAddRef([NativeTypeName("QuerySet")] QuerySet* querySet);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQuerySetRelease([NativeTypeName("QuerySet")] QuerySet* querySet);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuQueueOnSubmittedWorkDone([NativeTypeName("Queue")] Queue* queue, QueueWorkDoneCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQueueSetLabel([NativeTypeName("Queue")] Queue* queue, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQueueSubmit([NativeTypeName("Queue")] Queue* queue, [NativeTypeName("size_t")] nuint commandCount, [NativeTypeName("const CommandBuffer *")] CommandBuffer** commands);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQueueWriteBuffer([NativeTypeName("Queue")] Queue* queue, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong bufferOffset, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQueueWriteTexture([NativeTypeName("Queue")] Queue* queue, [NativeTypeName("const TexelCopyTextureInfo *")] TexelCopyTextureInfo* destination, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("const TexelCopyBufferLayout *")] TexelCopyBufferLayout* dataLayout, [NativeTypeName("const Extent3D *")] Extent3D* writeSize);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQueueAddRef([NativeTypeName("Queue")] Queue* queue);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuQueueRelease([NativeTypeName("Queue")] Queue* queue);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleSetLabel([NativeTypeName("RenderBundle")] RenderBundle* renderBundle, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleAddRef([NativeTypeName("RenderBundle")] RenderBundle* renderBundle);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleRelease([NativeTypeName("RenderBundle")] RenderBundle* renderBundle);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderDraw([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("uint32_t")] uint vertexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderDrawIndexed([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("uint32_t")] uint indexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstIndex, [NativeTypeName("int32_t")] int baseVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderDrawIndexedIndirect([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("Buffer")] Buffer* indirectBuffer, [NativeTypeName("uint64_t")] ulong indirectOffset);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderDrawIndirect([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("Buffer")] Buffer* indirectBuffer, [NativeTypeName("uint64_t")] ulong indirectOffset);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("RenderBundle")]
        public static extern RenderBundle* wgpuRenderBundleEncoderFinish([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("const RenderBundleDescriptor *")] RenderBundleDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderInsertDebugMarker([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, StringView markerLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderPopDebugGroup([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderPushDebugGroup([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, StringView groupLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderSetBindGroup([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("uint32_t")] uint groupIndex, [NativeTypeName("BindGroup")] BindGroup* group, [NativeTypeName("size_t")] nuint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* dynamicOffsets);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderSetIndexBuffer([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("Buffer")] Buffer* buffer, IndexFormat format, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("uint64_t")] ulong size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderSetLabel([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderSetPipeline([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("RenderPipeline")] RenderPipeline* pipeline);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderSetVertexBuffer([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder, [NativeTypeName("uint32_t")] uint slot, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("uint64_t")] ulong size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderAddRef([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderBundleEncoderRelease([NativeTypeName("RenderBundleEncoder")] RenderBundleEncoder* renderBundleEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderBeginOcclusionQuery([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("uint32_t")] uint queryIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderDraw([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("uint32_t")] uint vertexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderDrawIndexed([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("uint32_t")] uint indexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstIndex, [NativeTypeName("int32_t")] int baseVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderDrawIndexedIndirect([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("Buffer")] Buffer* indirectBuffer, [NativeTypeName("uint64_t")] ulong indirectOffset);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderDrawIndirect([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("Buffer")] Buffer* indirectBuffer, [NativeTypeName("uint64_t")] ulong indirectOffset);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderEnd([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderEndOcclusionQuery([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderExecuteBundles([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("size_t")] nuint bundleCount, [NativeTypeName("const RenderBundle *")] RenderBundle** bundles);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderInsertDebugMarker([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, StringView markerLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderPopDebugGroup([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderPushDebugGroup([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, StringView groupLabel);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetBindGroup([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("uint32_t")] uint groupIndex, [NativeTypeName("BindGroup")] BindGroup* group, [NativeTypeName("size_t")] nuint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* dynamicOffsets);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetBlendConstant([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("const Color *")] Color* color);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetIndexBuffer([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("Buffer")] Buffer* buffer, IndexFormat format, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("uint64_t")] ulong size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetLabel([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetPipeline([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("RenderPipeline")] RenderPipeline* pipeline);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetScissorRect([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("uint32_t")] uint x, [NativeTypeName("uint32_t")] uint y, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetStencilReference([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("uint32_t")] uint reference);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetVertexBuffer([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, [NativeTypeName("uint32_t")] uint slot, [NativeTypeName("Buffer")] Buffer* buffer, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("uint64_t")] ulong size);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderSetViewport([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderAddRef([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPassEncoderRelease([NativeTypeName("RenderPassEncoder")] RenderPassEncoder* renderPassEncoder);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BindGroupLayout")]
        public static extern BindGroupLayout* wgpuRenderPipelineGetBindGroupLayout([NativeTypeName("RenderPipeline")] RenderPipeline* renderPipeline, [NativeTypeName("uint32_t")] uint groupIndex);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPipelineSetLabel([NativeTypeName("RenderPipeline")] RenderPipeline* renderPipeline, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPipelineAddRef([NativeTypeName("RenderPipeline")] RenderPipeline* renderPipeline);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuRenderPipelineRelease([NativeTypeName("RenderPipeline")] RenderPipeline* renderPipeline);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSamplerSetLabel([NativeTypeName("Sampler")] Sampler* sampler, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSamplerAddRef([NativeTypeName("Sampler")] Sampler* sampler);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSamplerRelease([NativeTypeName("Sampler")] Sampler* sampler);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Future wgpuShaderModuleGetCompilationInfo([NativeTypeName("ShaderModule")] ShaderModule* shaderModule, CompilationInfoCallbackInfo callbackInfo);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuShaderModuleSetLabel([NativeTypeName("ShaderModule")] ShaderModule* shaderModule, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuShaderModuleAddRef([NativeTypeName("ShaderModule")] ShaderModule* shaderModule);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuShaderModuleRelease([NativeTypeName("ShaderModule")] ShaderModule* shaderModule);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSupportedFeaturesFreeMembers(SupportedFeatures supportedFeatures);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSupportedInstanceFeaturesFreeMembers(SupportedInstanceFeatures supportedInstanceFeatures);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSupportedWGSLLanguageFeaturesFreeMembers(SupportedWGSLLanguageFeatures supportedWGSLLanguageFeatures);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSurfaceConfigure([NativeTypeName("Surface")] Surface* surface, [NativeTypeName("const SurfaceConfiguration *")] SurfaceConfiguration* config);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuSurfaceGetCapabilities([NativeTypeName("Surface")] Surface* surface, [NativeTypeName("Adapter")] Adapter* adapter, SurfaceCapabilities* capabilities);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSurfaceGetCurrentTexture([NativeTypeName("Surface")] Surface* surface, SurfaceTexture* surfaceTexture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Status wgpuSurfacePresent([NativeTypeName("Surface")] Surface* surface);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSurfaceSetLabel([NativeTypeName("Surface")] Surface* surface, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSurfaceUnconfigure([NativeTypeName("Surface")] Surface* surface);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSurfaceAddRef([NativeTypeName("Surface")] Surface* surface);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSurfaceRelease([NativeTypeName("Surface")] Surface* surface);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuSurfaceCapabilitiesFreeMembers(SurfaceCapabilities surfaceCapabilities);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("TextureView")]
        public static extern TextureView* wgpuTextureCreateView([NativeTypeName("Texture")] Texture* texture, [NativeTypeName("const TextureViewDescriptor *")] TextureViewDescriptor* descriptor);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuTextureDestroy([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint wgpuTextureGetDepthOrArrayLayers([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern TextureDimension wgpuTextureGetDimension([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern TextureFormat wgpuTextureGetFormat([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint wgpuTextureGetHeight([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint wgpuTextureGetMipLevelCount([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint wgpuTextureGetSampleCount([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern TextureViewDimension wgpuTextureGetTextureBindingViewDimension([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("TextureUsage")]
        public static extern ulong wgpuTextureGetUsage([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint wgpuTextureGetWidth([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuTextureSetLabel([NativeTypeName("Texture")] Texture* texture, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuTextureAddRef([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuTextureRelease([NativeTypeName("Texture")] Texture* texture);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuTextureViewSetLabel([NativeTypeName("TextureView")] TextureView* textureView, StringView label);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuTextureViewAddRef([NativeTypeName("TextureView")] TextureView* textureView);

        [DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void wgpuTextureViewRelease([NativeTypeName("TextureView")] TextureView* textureView);
    }
}


