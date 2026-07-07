// Automatically extracted WebGPU Enums

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

    public enum PolygonMode
        {
            Fill = 0,
            Line = 1,
            Point = 2,
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

}

