// This file is generated.

using System;

namespace Vulkan
{
    public enum VkImageLayout
    {
        ///<summary>Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)</summary>
        Undefined = 0,
        ///<summary>General layout when image can be used for any kind of access</summary>
        General = 1,
        ///<summary>Optimal layout when image is only used for color attachment read/write</summary>
        ColorAttachmentOptimal = 2,
        ///<summary>Optimal layout when image is only used for depth/stencil attachment read/write</summary>
        DepthStencilAttachmentOptimal = 3,
        ///<summary>Optimal layout when image is used for read only depth/stencil attachment and shader access</summary>
        DepthStencilReadOnlyOptimal = 4,
        ///<summary>Optimal layout when image is used for read only shader access</summary>
        ShaderReadOnlyOptimal = 5,
        ///<summary>Optimal layout when image is used only as source of transfer operations</summary>
        TransferSrcOptimal = 6,
        ///<summary>Optimal layout when image is used only as destination of transfer operations</summary>
        TransferDstOptimal = 7,
        ///<summary>Initial layout used when the data is populated by the CPU</summary>
        Preinitialized = 8,
        PresentSrcKHR = 1000001002,
        SharedPresentKHR = 1000111000,
        ShadingRateOptimalNV = 1000164003,
        FragmentDensityMapOptimalEXT = 1000218000,
    }
    public static partial class RawConstants
    {
        ///<summary>Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_UNDEFINED = VkImageLayout.Undefined;
        ///<summary>General layout when image can be used for any kind of access</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_GENERAL = VkImageLayout.General;
        ///<summary>Optimal layout when image is only used for color attachment read/write</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = VkImageLayout.ColorAttachmentOptimal;
        ///<summary>Optimal layout when image is only used for depth/stencil attachment read/write</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = VkImageLayout.DepthStencilAttachmentOptimal;
        ///<summary>Optimal layout when image is used for read only depth/stencil attachment and shader access</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = VkImageLayout.DepthStencilReadOnlyOptimal;
        ///<summary>Optimal layout when image is used for read only shader access</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = VkImageLayout.ShaderReadOnlyOptimal;
        ///<summary>Optimal layout when image is used only as source of transfer operations</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = VkImageLayout.TransferSrcOptimal;
        ///<summary>Optimal layout when image is used only as destination of transfer operations</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = VkImageLayout.TransferDstOptimal;
        ///<summary>Initial layout used when the data is populated by the CPU</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_PREINITIALIZED = VkImageLayout.Preinitialized;
        public const VkImageLayout VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = VkImageLayout.PresentSrcKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = VkImageLayout.SharedPresentKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV = VkImageLayout.ShadingRateOptimalNV;
        public const VkImageLayout VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = VkImageLayout.FragmentDensityMapOptimalEXT;
    }

    public enum VkAttachmentLoadOp
    {
        Load = 0,
        Clear = 1,
        DontCare = 2,
    }
    public static partial class RawConstants
    {
        public const VkAttachmentLoadOp VK_ATTACHMENT_LOAD_OP_LOAD = VkAttachmentLoadOp.Load;
        public const VkAttachmentLoadOp VK_ATTACHMENT_LOAD_OP_CLEAR = VkAttachmentLoadOp.Clear;
        public const VkAttachmentLoadOp VK_ATTACHMENT_LOAD_OP_DONT_CARE = VkAttachmentLoadOp.DontCare;
    }

    public enum VkAttachmentStoreOp
    {
        Store = 0,
        DontCare = 1,
        NoneQcom = 1000301000,
    }
    public static partial class RawConstants
    {
        public const VkAttachmentStoreOp VK_ATTACHMENT_STORE_OP_STORE = VkAttachmentStoreOp.Store;
        public const VkAttachmentStoreOp VK_ATTACHMENT_STORE_OP_DONT_CARE = VkAttachmentStoreOp.DontCare;
        public const VkAttachmentStoreOp VK_ATTACHMENT_STORE_OP_NONE_QCOM = VkAttachmentStoreOp.NoneQcom;
    }

    public enum VkImageType
    {
        Image1D = 0,
        Image2D = 1,
        Image3D = 2,
    }
    public static partial class RawConstants
    {
        public const VkImageType VK_IMAGE_TYPE_1D = VkImageType.Image1D;
        public const VkImageType VK_IMAGE_TYPE_2D = VkImageType.Image2D;
        public const VkImageType VK_IMAGE_TYPE_3D = VkImageType.Image3D;
    }

    public enum VkImageTiling
    {
        Optimal = 0,
        Linear = 1,
        DrmFormatModifierEXT = 1000158000,
    }
    public static partial class RawConstants
    {
        public const VkImageTiling VK_IMAGE_TILING_OPTIMAL = VkImageTiling.Optimal;
        public const VkImageTiling VK_IMAGE_TILING_LINEAR = VkImageTiling.Linear;
        public const VkImageTiling VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = VkImageTiling.DrmFormatModifierEXT;
    }

    public enum VkImageViewType
    {
        Image1D = 0,
        Image2D = 1,
        Image3D = 2,
        ImageCube = 3,
        Image1DArray = 4,
        Image2DArray = 5,
        ImageCubeArray = 6,
    }
    public static partial class RawConstants
    {
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_1D = VkImageViewType.Image1D;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_2D = VkImageViewType.Image2D;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_3D = VkImageViewType.Image3D;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_CUBE = VkImageViewType.ImageCube;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_1D_ARRAY = VkImageViewType.Image1DArray;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_2D_ARRAY = VkImageViewType.Image2DArray;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = VkImageViewType.ImageCubeArray;
    }

    public enum VkCommandBufferLevel
    {
        Primary = 0,
        Secondary = 1,
    }
    public static partial class RawConstants
    {
        public const VkCommandBufferLevel VK_COMMAND_BUFFER_LEVEL_PRIMARY = VkCommandBufferLevel.Primary;
        public const VkCommandBufferLevel VK_COMMAND_BUFFER_LEVEL_SECONDARY = VkCommandBufferLevel.Secondary;
    }

    public enum VkComponentSwizzle
    {
        Identity = 0,
        Zero = 1,
        One = 2,
        R = 3,
        G = 4,
        B = 5,
        A = 6,
    }
    public static partial class RawConstants
    {
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_IDENTITY = VkComponentSwizzle.Identity;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_ZERO = VkComponentSwizzle.Zero;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_ONE = VkComponentSwizzle.One;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_R = VkComponentSwizzle.R;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_G = VkComponentSwizzle.G;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_B = VkComponentSwizzle.B;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_A = VkComponentSwizzle.A;
    }

    public enum VkDescriptorType
    {
        Sampler = 0,
        CombinedImageSampler = 1,
        SampledImage = 2,
        StorageImage = 3,
        UniformTexelBuffer = 4,
        StorageTexelBuffer = 5,
        UniformBuffer = 6,
        StorageBuffer = 7,
        UniformBufferDynamic = 8,
        StorageBufferDynamic = 9,
        InputAttachment = 10,
        InlineUniformBlockEXT = 1000138000,
        AccelerationStructureKHR = 1000150000,
        AccelerationStructureNV = 1000165000,
        MutableValve = 1000351000,
    }
    public static partial class RawConstants
    {
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_SAMPLER = VkDescriptorType.Sampler;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = VkDescriptorType.CombinedImageSampler;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = VkDescriptorType.SampledImage;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = VkDescriptorType.StorageImage;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = VkDescriptorType.UniformTexelBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = VkDescriptorType.StorageTexelBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = VkDescriptorType.UniformBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = VkDescriptorType.StorageBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = VkDescriptorType.UniformBufferDynamic;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = VkDescriptorType.StorageBufferDynamic;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = VkDescriptorType.InputAttachment;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT = VkDescriptorType.InlineUniformBlockEXT;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR = VkDescriptorType.AccelerationStructureKHR;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV = VkDescriptorType.AccelerationStructureNV;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_MUTABLE_VALVE = VkDescriptorType.MutableValve;
    }

    public enum VkQueryType
    {
        Occlusion = 0,
        ///<summary>Optional</summary>
        PipelineStatistics = 1,
        Timestamp = 2,
        Reserved8 = 1000023008,
        Reserved4 = 1000024004,
        TransformFeedbackStreamEXT = 1000028004,
        PerformanceQueryKHR = 1000116000,
        AccelerationStructureCompactedSizeKHR = 1000150000,
        AccelerationStructureSerializationSizeKHR = 1000150001,
        AccelerationStructureCompactedSizeNV = 1000165000,
        PerformanceQueryIntel = 1000210000,
    }
    public static partial class RawConstants
    {
        public const VkQueryType VK_QUERY_TYPE_OCCLUSION = VkQueryType.Occlusion;
        ///<summary>Optional</summary>
        public const VkQueryType VK_QUERY_TYPE_PIPELINE_STATISTICS = VkQueryType.PipelineStatistics;
        public const VkQueryType VK_QUERY_TYPE_TIMESTAMP = VkQueryType.Timestamp;
        public const VkQueryType VK_QUERY_TYPE_RESERVED_8 = VkQueryType.Reserved8;
        public const VkQueryType VK_QUERY_TYPE_RESERVED_4 = VkQueryType.Reserved4;
        public const VkQueryType VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = VkQueryType.TransformFeedbackStreamEXT;
        public const VkQueryType VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR = VkQueryType.PerformanceQueryKHR;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR = VkQueryType.AccelerationStructureCompactedSizeKHR;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = VkQueryType.AccelerationStructureSerializationSizeKHR;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = VkQueryType.AccelerationStructureCompactedSizeNV;
        public const VkQueryType VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = VkQueryType.PerformanceQueryIntel;
    }

    public enum VkBorderColor
    {
        FloatTransparentBlack = 0,
        IntTransparentBlack = 1,
        FloatOpaqueBlack = 2,
        IntOpaqueBlack = 3,
        FloatOpaqueWhite = 4,
        IntOpaqueWhite = 5,
        FloatCustomEXT = 1000287003,
        IntCustomEXT = 1000287004,
    }
    public static partial class RawConstants
    {
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = VkBorderColor.FloatTransparentBlack;
        public const VkBorderColor VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = VkBorderColor.IntTransparentBlack;
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = VkBorderColor.FloatOpaqueBlack;
        public const VkBorderColor VK_BORDER_COLOR_INT_OPAQUE_BLACK = VkBorderColor.IntOpaqueBlack;
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = VkBorderColor.FloatOpaqueWhite;
        public const VkBorderColor VK_BORDER_COLOR_INT_OPAQUE_WHITE = VkBorderColor.IntOpaqueWhite;
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_CUSTOM_EXT = VkBorderColor.FloatCustomEXT;
        public const VkBorderColor VK_BORDER_COLOR_INT_CUSTOM_EXT = VkBorderColor.IntCustomEXT;
    }

    public enum VkPipelineBindPoint
    {
        Graphics = 0,
        Compute = 1,
        RayTracingKHR = 1000347000,
    }
    public static partial class RawConstants
    {
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_GRAPHICS = VkPipelineBindPoint.Graphics;
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_COMPUTE = VkPipelineBindPoint.Compute;
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR = VkPipelineBindPoint.RayTracingKHR;
    }

    public enum VkPipelineCacheHeaderVersion
    {
        One = 1,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCacheHeaderVersion VK_PIPELINE_CACHE_HEADER_VERSION_ONE = VkPipelineCacheHeaderVersion.One;
    }

    [Flags]
    public enum VkPipelineCacheCreateFlags
    {
        None = 0,
        Reserved1EXT = 2,
        ExternallySynchronizedEXT = 1,
        Reserved2EXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCacheCreateFlags VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_EXT = VkPipelineCacheCreateFlags.Reserved1EXT;
        public const VkPipelineCacheCreateFlags VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT_EXT = VkPipelineCacheCreateFlags.ExternallySynchronizedEXT;
        public const VkPipelineCacheCreateFlags VK_PIPELINE_CACHE_CREATE_RESERVED_2_BIT_EXT = VkPipelineCacheCreateFlags.Reserved2EXT;
    }

    public enum VkPrimitiveTopology
    {
        PointList = 0,
        LineList = 1,
        LineStrip = 2,
        TriangleList = 3,
        TriangleStrip = 4,
        TriangleFan = 5,
        LineListWithAdjacency = 6,
        LineStripWithAdjacency = 7,
        TriangleListWithAdjacency = 8,
        TriangleStripWithAdjacency = 9,
        PatchList = 10,
    }
    public static partial class RawConstants
    {
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_POINT_LIST = VkPrimitiveTopology.PointList;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_LIST = VkPrimitiveTopology.LineList;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = VkPrimitiveTopology.LineStrip;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = VkPrimitiveTopology.TriangleList;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = VkPrimitiveTopology.TriangleStrip;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = VkPrimitiveTopology.TriangleFan;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY = VkPrimitiveTopology.LineListWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY = VkPrimitiveTopology.LineStripWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY = VkPrimitiveTopology.TriangleListWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY = VkPrimitiveTopology.TriangleStripWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_PATCH_LIST = VkPrimitiveTopology.PatchList;
    }

    public enum VkSharingMode
    {
        Exclusive = 0,
        Concurrent = 1,
    }
    public static partial class RawConstants
    {
        public const VkSharingMode VK_SHARING_MODE_EXCLUSIVE = VkSharingMode.Exclusive;
        public const VkSharingMode VK_SHARING_MODE_CONCURRENT = VkSharingMode.Concurrent;
    }

    public enum VkIndexType
    {
        Uint16 = 0,
        Uint32 = 1,
        NoneKHR = 1000150000,
        Uint8EXT = 1000265000,
    }
    public static partial class RawConstants
    {
        public const VkIndexType VK_INDEX_TYPE_UINT16 = VkIndexType.Uint16;
        public const VkIndexType VK_INDEX_TYPE_UINT32 = VkIndexType.Uint32;
        public const VkIndexType VK_INDEX_TYPE_NONE_KHR = VkIndexType.NoneKHR;
        public const VkIndexType VK_INDEX_TYPE_UINT8_EXT = VkIndexType.Uint8EXT;
    }

    public enum VkFilter
    {
        Nearest = 0,
        Linear = 1,
        CubicImg = 1000015000,
    }
    public static partial class RawConstants
    {
        public const VkFilter VK_FILTER_NEAREST = VkFilter.Nearest;
        public const VkFilter VK_FILTER_LINEAR = VkFilter.Linear;
        public const VkFilter VK_FILTER_CUBIC_IMG = VkFilter.CubicImg;
    }

    public enum VkSamplerMipmapMode
    {
        ///<summary>Choose nearest mip level</summary>
        Nearest = 0,
        ///<summary>Linear filter between mip levels</summary>
        Linear = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Choose nearest mip level</summary>
        public const VkSamplerMipmapMode VK_SAMPLER_MIPMAP_MODE_NEAREST = VkSamplerMipmapMode.Nearest;
        ///<summary>Linear filter between mip levels</summary>
        public const VkSamplerMipmapMode VK_SAMPLER_MIPMAP_MODE_LINEAR = VkSamplerMipmapMode.Linear;
    }

    public enum VkSamplerAddressMode
    {
        Repeat = 0,
        MirroredRepeat = 1,
        ClampToEdge = 2,
        ClampToBorder = 3,
        ///<summary>Note that this defines what was previously a core enum, and so uses the 'value' attribute rather than 'offset', and does not have a suffix. This is a special case, and should not be repeated</summary>
        MirrorClampToEdge = 4,
    }
    public static partial class RawConstants
    {
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_REPEAT = VkSamplerAddressMode.Repeat;
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT = VkSamplerAddressMode.MirroredRepeat;
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE = VkSamplerAddressMode.ClampToEdge;
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER = VkSamplerAddressMode.ClampToBorder;
        ///<summary>Note that this defines what was previously a core enum, and so uses the 'value' attribute rather than 'offset', and does not have a suffix. This is a special case, and should not be repeated</summary>
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = VkSamplerAddressMode.MirrorClampToEdge;
    }

    public enum VkCompareOp
    {
        Never = 0,
        Less = 1,
        Equal = 2,
        LessOrEqual = 3,
        Greater = 4,
        NotEqual = 5,
        GreaterOrEqual = 6,
        Always = 7,
    }
    public static partial class RawConstants
    {
        public const VkCompareOp VK_COMPARE_OP_NEVER = VkCompareOp.Never;
        public const VkCompareOp VK_COMPARE_OP_LESS = VkCompareOp.Less;
        public const VkCompareOp VK_COMPARE_OP_EQUAL = VkCompareOp.Equal;
        public const VkCompareOp VK_COMPARE_OP_LESS_OR_EQUAL = VkCompareOp.LessOrEqual;
        public const VkCompareOp VK_COMPARE_OP_GREATER = VkCompareOp.Greater;
        public const VkCompareOp VK_COMPARE_OP_NOT_EQUAL = VkCompareOp.NotEqual;
        public const VkCompareOp VK_COMPARE_OP_GREATER_OR_EQUAL = VkCompareOp.GreaterOrEqual;
        public const VkCompareOp VK_COMPARE_OP_ALWAYS = VkCompareOp.Always;
    }

    public enum VkPolygonMode
    {
        Fill = 0,
        Line = 1,
        Point = 2,
        FillRectangleNV = 1000153000,
    }
    public static partial class RawConstants
    {
        public const VkPolygonMode VK_POLYGON_MODE_FILL = VkPolygonMode.Fill;
        public const VkPolygonMode VK_POLYGON_MODE_LINE = VkPolygonMode.Line;
        public const VkPolygonMode VK_POLYGON_MODE_POINT = VkPolygonMode.Point;
        public const VkPolygonMode VK_POLYGON_MODE_FILL_RECTANGLE_NV = VkPolygonMode.FillRectangleNV;
    }

    public enum VkFrontFace
    {
        CounterClockwise = 0,
        Clockwise = 1,
    }
    public static partial class RawConstants
    {
        public const VkFrontFace VK_FRONT_FACE_COUNTER_CLOCKWISE = VkFrontFace.CounterClockwise;
        public const VkFrontFace VK_FRONT_FACE_CLOCKWISE = VkFrontFace.Clockwise;
    }

    public enum VkBlendFactor
    {
        Zero = 0,
        One = 1,
        SrcColor = 2,
        OneMinusSrcColor = 3,
        DstColor = 4,
        OneMinusDstColor = 5,
        SrcAlpha = 6,
        OneMinusSrcAlpha = 7,
        DstAlpha = 8,
        OneMinusDstAlpha = 9,
        ConstantColor = 10,
        OneMinusConstantColor = 11,
        ConstantAlpha = 12,
        OneMinusConstantAlpha = 13,
        SrcAlphaSaturate = 14,
        Src1Color = 15,
        OneMinusSrc1Color = 16,
        Src1Alpha = 17,
        OneMinusSrc1Alpha = 18,
    }
    public static partial class RawConstants
    {
        public const VkBlendFactor VK_BLEND_FACTOR_ZERO = VkBlendFactor.Zero;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE = VkBlendFactor.One;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC_COLOR = VkBlendFactor.SrcColor;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR = VkBlendFactor.OneMinusSrcColor;
        public const VkBlendFactor VK_BLEND_FACTOR_DST_COLOR = VkBlendFactor.DstColor;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR = VkBlendFactor.OneMinusDstColor;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC_ALPHA = VkBlendFactor.SrcAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA = VkBlendFactor.OneMinusSrcAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_DST_ALPHA = VkBlendFactor.DstAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA = VkBlendFactor.OneMinusDstAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_CONSTANT_COLOR = VkBlendFactor.ConstantColor;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR = VkBlendFactor.OneMinusConstantColor;
        public const VkBlendFactor VK_BLEND_FACTOR_CONSTANT_ALPHA = VkBlendFactor.ConstantAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA = VkBlendFactor.OneMinusConstantAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC_ALPHA_SATURATE = VkBlendFactor.SrcAlphaSaturate;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC1_COLOR = VkBlendFactor.Src1Color;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR = VkBlendFactor.OneMinusSrc1Color;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC1_ALPHA = VkBlendFactor.Src1Alpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA = VkBlendFactor.OneMinusSrc1Alpha;
    }

    public enum VkBlendOp
    {
        Add = 0,
        Subtract = 1,
        ReverseSubtract = 2,
        Min = 3,
        Max = 4,
        ZeroEXT = 1000148000,
        SrcEXT = 1000148001,
        DstEXT = 1000148002,
        SrcOverEXT = 1000148003,
        DstOverEXT = 1000148004,
        SrcInEXT = 1000148005,
        DstInEXT = 1000148006,
        SrcOutEXT = 1000148007,
        DstOutEXT = 1000148008,
        SrcAtopEXT = 1000148009,
        DstAtopEXT = 1000148010,
        XorEXT = 1000148011,
        MultiplyEXT = 1000148012,
        ScreenEXT = 1000148013,
        OverlayEXT = 1000148014,
        DarkenEXT = 1000148015,
        LightenEXT = 1000148016,
        ColordodgeEXT = 1000148017,
        ColorburnEXT = 1000148018,
        HardlightEXT = 1000148019,
        SoftlightEXT = 1000148020,
        DifferenceEXT = 1000148021,
        ExclusionEXT = 1000148022,
        InvertEXT = 1000148023,
        InvertRgbEXT = 1000148024,
        LineardodgeEXT = 1000148025,
        LinearburnEXT = 1000148026,
        VividlightEXT = 1000148027,
        LinearlightEXT = 1000148028,
        PinlightEXT = 1000148029,
        HardmixEXT = 1000148030,
        HslHueEXT = 1000148031,
        HslSaturationEXT = 1000148032,
        HslColorEXT = 1000148033,
        HslLuminosityEXT = 1000148034,
        PlusEXT = 1000148035,
        PlusClampedEXT = 1000148036,
        PlusClampedAlphaEXT = 1000148037,
        PlusDarkerEXT = 1000148038,
        MinusEXT = 1000148039,
        MinusClampedEXT = 1000148040,
        ContrastEXT = 1000148041,
        InvertOvgEXT = 1000148042,
        RedEXT = 1000148043,
        GreenEXT = 1000148044,
        BlueEXT = 1000148045,
    }
    public static partial class RawConstants
    {
        public const VkBlendOp VK_BLEND_OP_ADD = VkBlendOp.Add;
        public const VkBlendOp VK_BLEND_OP_SUBTRACT = VkBlendOp.Subtract;
        public const VkBlendOp VK_BLEND_OP_REVERSE_SUBTRACT = VkBlendOp.ReverseSubtract;
        public const VkBlendOp VK_BLEND_OP_MIN = VkBlendOp.Min;
        public const VkBlendOp VK_BLEND_OP_MAX = VkBlendOp.Max;
        public const VkBlendOp VK_BLEND_OP_ZERO_EXT = VkBlendOp.ZeroEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_EXT = VkBlendOp.SrcEXT;
        public const VkBlendOp VK_BLEND_OP_DST_EXT = VkBlendOp.DstEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_OVER_EXT = VkBlendOp.SrcOverEXT;
        public const VkBlendOp VK_BLEND_OP_DST_OVER_EXT = VkBlendOp.DstOverEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_IN_EXT = VkBlendOp.SrcInEXT;
        public const VkBlendOp VK_BLEND_OP_DST_IN_EXT = VkBlendOp.DstInEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_OUT_EXT = VkBlendOp.SrcOutEXT;
        public const VkBlendOp VK_BLEND_OP_DST_OUT_EXT = VkBlendOp.DstOutEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_ATOP_EXT = VkBlendOp.SrcAtopEXT;
        public const VkBlendOp VK_BLEND_OP_DST_ATOP_EXT = VkBlendOp.DstAtopEXT;
        public const VkBlendOp VK_BLEND_OP_XOR_EXT = VkBlendOp.XorEXT;
        public const VkBlendOp VK_BLEND_OP_MULTIPLY_EXT = VkBlendOp.MultiplyEXT;
        public const VkBlendOp VK_BLEND_OP_SCREEN_EXT = VkBlendOp.ScreenEXT;
        public const VkBlendOp VK_BLEND_OP_OVERLAY_EXT = VkBlendOp.OverlayEXT;
        public const VkBlendOp VK_BLEND_OP_DARKEN_EXT = VkBlendOp.DarkenEXT;
        public const VkBlendOp VK_BLEND_OP_LIGHTEN_EXT = VkBlendOp.LightenEXT;
        public const VkBlendOp VK_BLEND_OP_COLORDODGE_EXT = VkBlendOp.ColordodgeEXT;
        public const VkBlendOp VK_BLEND_OP_COLORBURN_EXT = VkBlendOp.ColorburnEXT;
        public const VkBlendOp VK_BLEND_OP_HARDLIGHT_EXT = VkBlendOp.HardlightEXT;
        public const VkBlendOp VK_BLEND_OP_SOFTLIGHT_EXT = VkBlendOp.SoftlightEXT;
        public const VkBlendOp VK_BLEND_OP_DIFFERENCE_EXT = VkBlendOp.DifferenceEXT;
        public const VkBlendOp VK_BLEND_OP_EXCLUSION_EXT = VkBlendOp.ExclusionEXT;
        public const VkBlendOp VK_BLEND_OP_INVERT_EXT = VkBlendOp.InvertEXT;
        public const VkBlendOp VK_BLEND_OP_INVERT_RGB_EXT = VkBlendOp.InvertRgbEXT;
        public const VkBlendOp VK_BLEND_OP_LINEARDODGE_EXT = VkBlendOp.LineardodgeEXT;
        public const VkBlendOp VK_BLEND_OP_LINEARBURN_EXT = VkBlendOp.LinearburnEXT;
        public const VkBlendOp VK_BLEND_OP_VIVIDLIGHT_EXT = VkBlendOp.VividlightEXT;
        public const VkBlendOp VK_BLEND_OP_LINEARLIGHT_EXT = VkBlendOp.LinearlightEXT;
        public const VkBlendOp VK_BLEND_OP_PINLIGHT_EXT = VkBlendOp.PinlightEXT;
        public const VkBlendOp VK_BLEND_OP_HARDMIX_EXT = VkBlendOp.HardmixEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_HUE_EXT = VkBlendOp.HslHueEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_SATURATION_EXT = VkBlendOp.HslSaturationEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_COLOR_EXT = VkBlendOp.HslColorEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_LUMINOSITY_EXT = VkBlendOp.HslLuminosityEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_EXT = VkBlendOp.PlusEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_CLAMPED_EXT = VkBlendOp.PlusClampedEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT = VkBlendOp.PlusClampedAlphaEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_DARKER_EXT = VkBlendOp.PlusDarkerEXT;
        public const VkBlendOp VK_BLEND_OP_MINUS_EXT = VkBlendOp.MinusEXT;
        public const VkBlendOp VK_BLEND_OP_MINUS_CLAMPED_EXT = VkBlendOp.MinusClampedEXT;
        public const VkBlendOp VK_BLEND_OP_CONTRAST_EXT = VkBlendOp.ContrastEXT;
        public const VkBlendOp VK_BLEND_OP_INVERT_OVG_EXT = VkBlendOp.InvertOvgEXT;
        public const VkBlendOp VK_BLEND_OP_RED_EXT = VkBlendOp.RedEXT;
        public const VkBlendOp VK_BLEND_OP_GREEN_EXT = VkBlendOp.GreenEXT;
        public const VkBlendOp VK_BLEND_OP_BLUE_EXT = VkBlendOp.BlueEXT;
    }

    public enum VkStencilOp
    {
        Keep = 0,
        Zero = 1,
        Replace = 2,
        IncrementAndClamp = 3,
        DecrementAndClamp = 4,
        Invert = 5,
        IncrementAndWrap = 6,
        DecrementAndWrap = 7,
    }
    public static partial class RawConstants
    {
        public const VkStencilOp VK_STENCIL_OP_KEEP = VkStencilOp.Keep;
        public const VkStencilOp VK_STENCIL_OP_ZERO = VkStencilOp.Zero;
        public const VkStencilOp VK_STENCIL_OP_REPLACE = VkStencilOp.Replace;
        public const VkStencilOp VK_STENCIL_OP_INCREMENT_AND_CLAMP = VkStencilOp.IncrementAndClamp;
        public const VkStencilOp VK_STENCIL_OP_DECREMENT_AND_CLAMP = VkStencilOp.DecrementAndClamp;
        public const VkStencilOp VK_STENCIL_OP_INVERT = VkStencilOp.Invert;
        public const VkStencilOp VK_STENCIL_OP_INCREMENT_AND_WRAP = VkStencilOp.IncrementAndWrap;
        public const VkStencilOp VK_STENCIL_OP_DECREMENT_AND_WRAP = VkStencilOp.DecrementAndWrap;
    }

    public enum VkLogicOp
    {
        Clear = 0,
        And = 1,
        AndReverse = 2,
        Copy = 3,
        AndInverted = 4,
        NoOp = 5,
        Xor = 6,
        Or = 7,
        Nor = 8,
        Equivalent = 9,
        Invert = 10,
        OrReverse = 11,
        CopyInverted = 12,
        OrInverted = 13,
        Nand = 14,
        Set = 15,
    }
    public static partial class RawConstants
    {
        public const VkLogicOp VK_LOGIC_OP_CLEAR = VkLogicOp.Clear;
        public const VkLogicOp VK_LOGIC_OP_AND = VkLogicOp.And;
        public const VkLogicOp VK_LOGIC_OP_AND_REVERSE = VkLogicOp.AndReverse;
        public const VkLogicOp VK_LOGIC_OP_COPY = VkLogicOp.Copy;
        public const VkLogicOp VK_LOGIC_OP_AND_INVERTED = VkLogicOp.AndInverted;
        public const VkLogicOp VK_LOGIC_OP_NO_OP = VkLogicOp.NoOp;
        public const VkLogicOp VK_LOGIC_OP_XOR = VkLogicOp.Xor;
        public const VkLogicOp VK_LOGIC_OP_OR = VkLogicOp.Or;
        public const VkLogicOp VK_LOGIC_OP_NOR = VkLogicOp.Nor;
        public const VkLogicOp VK_LOGIC_OP_EQUIVALENT = VkLogicOp.Equivalent;
        public const VkLogicOp VK_LOGIC_OP_INVERT = VkLogicOp.Invert;
        public const VkLogicOp VK_LOGIC_OP_OR_REVERSE = VkLogicOp.OrReverse;
        public const VkLogicOp VK_LOGIC_OP_COPY_INVERTED = VkLogicOp.CopyInverted;
        public const VkLogicOp VK_LOGIC_OP_OR_INVERTED = VkLogicOp.OrInverted;
        public const VkLogicOp VK_LOGIC_OP_NAND = VkLogicOp.Nand;
        public const VkLogicOp VK_LOGIC_OP_SET = VkLogicOp.Set;
    }

    public enum VkInternalAllocationType
    {
        Executable = 0,
    }
    public static partial class RawConstants
    {
        public const VkInternalAllocationType VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE = VkInternalAllocationType.Executable;
    }

    public enum VkSystemAllocationScope
    {
        Command = 0,
        Object = 1,
        Cache = 2,
        Device = 3,
        Instance = 4,
    }
    public static partial class RawConstants
    {
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_COMMAND = VkSystemAllocationScope.Command;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_OBJECT = VkSystemAllocationScope.Object;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_CACHE = VkSystemAllocationScope.Cache;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_DEVICE = VkSystemAllocationScope.Device;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE = VkSystemAllocationScope.Instance;
    }

    public enum VkPhysicalDeviceType
    {
        Other = 0,
        IntegratedGpu = 1,
        DiscreteGpu = 2,
        VirtualGpu = 3,
        Cpu = 4,
    }
    public static partial class RawConstants
    {
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_OTHER = VkPhysicalDeviceType.Other;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = VkPhysicalDeviceType.IntegratedGpu;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = VkPhysicalDeviceType.DiscreteGpu;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = VkPhysicalDeviceType.VirtualGpu;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_CPU = VkPhysicalDeviceType.Cpu;
    }

    public enum VkVertexInputRate
    {
        Vertex = 0,
        Instance = 1,
    }
    public static partial class RawConstants
    {
        public const VkVertexInputRate VK_VERTEX_INPUT_RATE_VERTEX = VkVertexInputRate.Vertex;
        public const VkVertexInputRate VK_VERTEX_INPUT_RATE_INSTANCE = VkVertexInputRate.Instance;
    }

    public enum VkFormat
    {
        Undefined = 0,
        R4g4UnormPack8 = 1,
        R4g4b4a4UnormPack16 = 2,
        B4g4r4a4UnormPack16 = 3,
        R5g6b5UnormPack16 = 4,
        B5g6r5UnormPack16 = 5,
        R5g5b5a1UnormPack16 = 6,
        B5g5r5a1UnormPack16 = 7,
        A1r5g5b5UnormPack16 = 8,
        R8Unorm = 9,
        R8Snorm = 10,
        R8Uscaled = 11,
        R8Sscaled = 12,
        R8Uint = 13,
        R8Sint = 14,
        R8Srgb = 15,
        R8g8Unorm = 16,
        R8g8Snorm = 17,
        R8g8Uscaled = 18,
        R8g8Sscaled = 19,
        R8g8Uint = 20,
        R8g8Sint = 21,
        R8g8Srgb = 22,
        R8g8b8Unorm = 23,
        R8g8b8Snorm = 24,
        R8g8b8Uscaled = 25,
        R8g8b8Sscaled = 26,
        R8g8b8Uint = 27,
        R8g8b8Sint = 28,
        R8g8b8Srgb = 29,
        B8g8r8Unorm = 30,
        B8g8r8Snorm = 31,
        B8g8r8Uscaled = 32,
        B8g8r8Sscaled = 33,
        B8g8r8Uint = 34,
        B8g8r8Sint = 35,
        B8g8r8Srgb = 36,
        R8g8b8a8Unorm = 37,
        R8g8b8a8Snorm = 38,
        R8g8b8a8Uscaled = 39,
        R8g8b8a8Sscaled = 40,
        R8g8b8a8Uint = 41,
        R8g8b8a8Sint = 42,
        R8g8b8a8Srgb = 43,
        B8g8r8a8Unorm = 44,
        B8g8r8a8Snorm = 45,
        B8g8r8a8Uscaled = 46,
        B8g8r8a8Sscaled = 47,
        B8g8r8a8Uint = 48,
        B8g8r8a8Sint = 49,
        B8g8r8a8Srgb = 50,
        A8b8g8r8UnormPack32 = 51,
        A8b8g8r8SnormPack32 = 52,
        A8b8g8r8UscaledPack32 = 53,
        A8b8g8r8SscaledPack32 = 54,
        A8b8g8r8UintPack32 = 55,
        A8b8g8r8SintPack32 = 56,
        A8b8g8r8SrgbPack32 = 57,
        A2r10g10b10UnormPack32 = 58,
        A2r10g10b10SnormPack32 = 59,
        A2r10g10b10UscaledPack32 = 60,
        A2r10g10b10SscaledPack32 = 61,
        A2r10g10b10UintPack32 = 62,
        A2r10g10b10SintPack32 = 63,
        A2b10g10r10UnormPack32 = 64,
        A2b10g10r10SnormPack32 = 65,
        A2b10g10r10UscaledPack32 = 66,
        A2b10g10r10SscaledPack32 = 67,
        A2b10g10r10UintPack32 = 68,
        A2b10g10r10SintPack32 = 69,
        R16Unorm = 70,
        R16Snorm = 71,
        R16Uscaled = 72,
        R16Sscaled = 73,
        R16Uint = 74,
        R16Sint = 75,
        R16Sfloat = 76,
        R16g16Unorm = 77,
        R16g16Snorm = 78,
        R16g16Uscaled = 79,
        R16g16Sscaled = 80,
        R16g16Uint = 81,
        R16g16Sint = 82,
        R16g16Sfloat = 83,
        R16g16b16Unorm = 84,
        R16g16b16Snorm = 85,
        R16g16b16Uscaled = 86,
        R16g16b16Sscaled = 87,
        R16g16b16Uint = 88,
        R16g16b16Sint = 89,
        R16g16b16Sfloat = 90,
        R16g16b16a16Unorm = 91,
        R16g16b16a16Snorm = 92,
        R16g16b16a16Uscaled = 93,
        R16g16b16a16Sscaled = 94,
        R16g16b16a16Uint = 95,
        R16g16b16a16Sint = 96,
        R16g16b16a16Sfloat = 97,
        R32Uint = 98,
        R32Sint = 99,
        R32Sfloat = 100,
        R32g32Uint = 101,
        R32g32Sint = 102,
        R32g32Sfloat = 103,
        R32g32b32Uint = 104,
        R32g32b32Sint = 105,
        R32g32b32Sfloat = 106,
        R32g32b32a32Uint = 107,
        R32g32b32a32Sint = 108,
        R32g32b32a32Sfloat = 109,
        R64Uint = 110,
        R64Sint = 111,
        R64Sfloat = 112,
        R64g64Uint = 113,
        R64g64Sint = 114,
        R64g64Sfloat = 115,
        R64g64b64Uint = 116,
        R64g64b64Sint = 117,
        R64g64b64Sfloat = 118,
        R64g64b64a64Uint = 119,
        R64g64b64a64Sint = 120,
        R64g64b64a64Sfloat = 121,
        B10g11r11UfloatPack32 = 122,
        E5b9g9r9UfloatPack32 = 123,
        D16Unorm = 124,
        X8D24UnormPack32 = 125,
        D32Sfloat = 126,
        S8Uint = 127,
        D16UnormS8Uint = 128,
        D24UnormS8Uint = 129,
        D32SfloatS8Uint = 130,
        Bc1RgbUnormBlock = 131,
        Bc1RgbSrgbBlock = 132,
        Bc1RgbaUnormBlock = 133,
        Bc1RgbaSrgbBlock = 134,
        Bc2UnormBlock = 135,
        Bc2SrgbBlock = 136,
        Bc3UnormBlock = 137,
        Bc3SrgbBlock = 138,
        Bc4UnormBlock = 139,
        Bc4SnormBlock = 140,
        Bc5UnormBlock = 141,
        Bc5SnormBlock = 142,
        Bc6hUfloatBlock = 143,
        Bc6hSfloatBlock = 144,
        Bc7UnormBlock = 145,
        Bc7SrgbBlock = 146,
        Etc2R8g8b8UnormBlock = 147,
        Etc2R8g8b8SrgbBlock = 148,
        Etc2R8g8b8a1UnormBlock = 149,
        Etc2R8g8b8a1SrgbBlock = 150,
        Etc2R8g8b8a8UnormBlock = 151,
        Etc2R8g8b8a8SrgbBlock = 152,
        EacR11UnormBlock = 153,
        EacR11SnormBlock = 154,
        EacR11g11UnormBlock = 155,
        EacR11g11SnormBlock = 156,
        Astc4x4UnormBlock = 157,
        Astc4x4SrgbBlock = 158,
        Astc5x4UnormBlock = 159,
        Astc5x4SrgbBlock = 160,
        Astc5x5UnormBlock = 161,
        Astc5x5SrgbBlock = 162,
        Astc6x5UnormBlock = 163,
        Astc6x5SrgbBlock = 164,
        Astc6x6UnormBlock = 165,
        Astc6x6SrgbBlock = 166,
        Astc8x5UnormBlock = 167,
        Astc8x5SrgbBlock = 168,
        Astc8x6UnormBlock = 169,
        Astc8x6SrgbBlock = 170,
        Astc8x8UnormBlock = 171,
        Astc8x8SrgbBlock = 172,
        Astc10x5UnormBlock = 173,
        Astc10x5SrgbBlock = 174,
        Astc10x6UnormBlock = 175,
        Astc10x6SrgbBlock = 176,
        Astc10x8UnormBlock = 177,
        Astc10x8SrgbBlock = 178,
        Astc10x10UnormBlock = 179,
        Astc10x10SrgbBlock = 180,
        Astc12x10UnormBlock = 181,
        Astc12x10SrgbBlock = 182,
        Astc12x12UnormBlock = 183,
        Astc12x12SrgbBlock = 184,
        Pvrtc12bppUnormBlockImg = 1000054000,
        Pvrtc14bppUnormBlockImg = 1000054001,
        Pvrtc22bppUnormBlockImg = 1000054002,
        Pvrtc24bppUnormBlockImg = 1000054003,
        Pvrtc12bppSrgbBlockImg = 1000054004,
        Pvrtc14bppSrgbBlockImg = 1000054005,
        Pvrtc22bppSrgbBlockImg = 1000054006,
        Pvrtc24bppSrgbBlockImg = 1000054007,
        Astc4x4SfloatBlockEXT = 1000066000,
        Astc5x4SfloatBlockEXT = 1000066001,
        Astc5x5SfloatBlockEXT = 1000066002,
        Astc6x5SfloatBlockEXT = 1000066003,
        Astc6x6SfloatBlockEXT = 1000066004,
        Astc8x5SfloatBlockEXT = 1000066005,
        Astc8x6SfloatBlockEXT = 1000066006,
        Astc8x8SfloatBlockEXT = 1000066007,
        Astc10x5SfloatBlockEXT = 1000066008,
        Astc10x6SfloatBlockEXT = 1000066009,
        Astc10x8SfloatBlockEXT = 1000066010,
        Astc10x10SfloatBlockEXT = 1000066011,
        Astc12x10SfloatBlockEXT = 1000066012,
        Astc12x12SfloatBlockEXT = 1000066013,
        Astc3x3x3UnormBlockEXT = 1000288000,
        Astc3x3x3SrgbBlockEXT = 1000288001,
        Astc3x3x3SfloatBlockEXT = 1000288002,
        Astc4x3x3UnormBlockEXT = 1000288003,
        Astc4x3x3SrgbBlockEXT = 1000288004,
        Astc4x3x3SfloatBlockEXT = 1000288005,
        Astc4x4x3UnormBlockEXT = 1000288006,
        Astc4x4x3SrgbBlockEXT = 1000288007,
        Astc4x4x3SfloatBlockEXT = 1000288008,
        Astc4x4x4UnormBlockEXT = 1000288009,
        Astc4x4x4SrgbBlockEXT = 1000288010,
        Astc4x4x4SfloatBlockEXT = 1000288011,
        Astc5x4x4UnormBlockEXT = 1000288012,
        Astc5x4x4SrgbBlockEXT = 1000288013,
        Astc5x4x4SfloatBlockEXT = 1000288014,
        Astc5x5x4UnormBlockEXT = 1000288015,
        Astc5x5x4SrgbBlockEXT = 1000288016,
        Astc5x5x4SfloatBlockEXT = 1000288017,
        Astc5x5x5UnormBlockEXT = 1000288018,
        Astc5x5x5SrgbBlockEXT = 1000288019,
        Astc5x5x5SfloatBlockEXT = 1000288020,
        Astc6x5x5UnormBlockEXT = 1000288021,
        Astc6x5x5SrgbBlockEXT = 1000288022,
        Astc6x5x5SfloatBlockEXT = 1000288023,
        Astc6x6x5UnormBlockEXT = 1000288024,
        Astc6x6x5SrgbBlockEXT = 1000288025,
        Astc6x6x5SfloatBlockEXT = 1000288026,
        Astc6x6x6UnormBlockEXT = 1000288027,
        Astc6x6x6SrgbBlockEXT = 1000288028,
        Astc6x6x6SfloatBlockEXT = 1000288029,
        A4r4g4b4UnormPack16EXT = 1000340000,
        A4b4g4r4UnormPack16EXT = 1000340001,
    }
    public static partial class RawConstants
    {
        public const VkFormat VK_FORMAT_UNDEFINED = VkFormat.Undefined;
        public const VkFormat VK_FORMAT_R4G4_UNORM_PACK8 = VkFormat.R4g4UnormPack8;
        public const VkFormat VK_FORMAT_R4G4B4A4_UNORM_PACK16 = VkFormat.R4g4b4a4UnormPack16;
        public const VkFormat VK_FORMAT_B4G4R4A4_UNORM_PACK16 = VkFormat.B4g4r4a4UnormPack16;
        public const VkFormat VK_FORMAT_R5G6B5_UNORM_PACK16 = VkFormat.R5g6b5UnormPack16;
        public const VkFormat VK_FORMAT_B5G6R5_UNORM_PACK16 = VkFormat.B5g6r5UnormPack16;
        public const VkFormat VK_FORMAT_R5G5B5A1_UNORM_PACK16 = VkFormat.R5g5b5a1UnormPack16;
        public const VkFormat VK_FORMAT_B5G5R5A1_UNORM_PACK16 = VkFormat.B5g5r5a1UnormPack16;
        public const VkFormat VK_FORMAT_A1R5G5B5_UNORM_PACK16 = VkFormat.A1r5g5b5UnormPack16;
        public const VkFormat VK_FORMAT_R8_UNORM = VkFormat.R8Unorm;
        public const VkFormat VK_FORMAT_R8_SNORM = VkFormat.R8Snorm;
        public const VkFormat VK_FORMAT_R8_USCALED = VkFormat.R8Uscaled;
        public const VkFormat VK_FORMAT_R8_SSCALED = VkFormat.R8Sscaled;
        public const VkFormat VK_FORMAT_R8_UINT = VkFormat.R8Uint;
        public const VkFormat VK_FORMAT_R8_SINT = VkFormat.R8Sint;
        public const VkFormat VK_FORMAT_R8_SRGB = VkFormat.R8Srgb;
        public const VkFormat VK_FORMAT_R8G8_UNORM = VkFormat.R8g8Unorm;
        public const VkFormat VK_FORMAT_R8G8_SNORM = VkFormat.R8g8Snorm;
        public const VkFormat VK_FORMAT_R8G8_USCALED = VkFormat.R8g8Uscaled;
        public const VkFormat VK_FORMAT_R8G8_SSCALED = VkFormat.R8g8Sscaled;
        public const VkFormat VK_FORMAT_R8G8_UINT = VkFormat.R8g8Uint;
        public const VkFormat VK_FORMAT_R8G8_SINT = VkFormat.R8g8Sint;
        public const VkFormat VK_FORMAT_R8G8_SRGB = VkFormat.R8g8Srgb;
        public const VkFormat VK_FORMAT_R8G8B8_UNORM = VkFormat.R8g8b8Unorm;
        public const VkFormat VK_FORMAT_R8G8B8_SNORM = VkFormat.R8g8b8Snorm;
        public const VkFormat VK_FORMAT_R8G8B8_USCALED = VkFormat.R8g8b8Uscaled;
        public const VkFormat VK_FORMAT_R8G8B8_SSCALED = VkFormat.R8g8b8Sscaled;
        public const VkFormat VK_FORMAT_R8G8B8_UINT = VkFormat.R8g8b8Uint;
        public const VkFormat VK_FORMAT_R8G8B8_SINT = VkFormat.R8g8b8Sint;
        public const VkFormat VK_FORMAT_R8G8B8_SRGB = VkFormat.R8g8b8Srgb;
        public const VkFormat VK_FORMAT_B8G8R8_UNORM = VkFormat.B8g8r8Unorm;
        public const VkFormat VK_FORMAT_B8G8R8_SNORM = VkFormat.B8g8r8Snorm;
        public const VkFormat VK_FORMAT_B8G8R8_USCALED = VkFormat.B8g8r8Uscaled;
        public const VkFormat VK_FORMAT_B8G8R8_SSCALED = VkFormat.B8g8r8Sscaled;
        public const VkFormat VK_FORMAT_B8G8R8_UINT = VkFormat.B8g8r8Uint;
        public const VkFormat VK_FORMAT_B8G8R8_SINT = VkFormat.B8g8r8Sint;
        public const VkFormat VK_FORMAT_B8G8R8_SRGB = VkFormat.B8g8r8Srgb;
        public const VkFormat VK_FORMAT_R8G8B8A8_UNORM = VkFormat.R8g8b8a8Unorm;
        public const VkFormat VK_FORMAT_R8G8B8A8_SNORM = VkFormat.R8g8b8a8Snorm;
        public const VkFormat VK_FORMAT_R8G8B8A8_USCALED = VkFormat.R8g8b8a8Uscaled;
        public const VkFormat VK_FORMAT_R8G8B8A8_SSCALED = VkFormat.R8g8b8a8Sscaled;
        public const VkFormat VK_FORMAT_R8G8B8A8_UINT = VkFormat.R8g8b8a8Uint;
        public const VkFormat VK_FORMAT_R8G8B8A8_SINT = VkFormat.R8g8b8a8Sint;
        public const VkFormat VK_FORMAT_R8G8B8A8_SRGB = VkFormat.R8g8b8a8Srgb;
        public const VkFormat VK_FORMAT_B8G8R8A8_UNORM = VkFormat.B8g8r8a8Unorm;
        public const VkFormat VK_FORMAT_B8G8R8A8_SNORM = VkFormat.B8g8r8a8Snorm;
        public const VkFormat VK_FORMAT_B8G8R8A8_USCALED = VkFormat.B8g8r8a8Uscaled;
        public const VkFormat VK_FORMAT_B8G8R8A8_SSCALED = VkFormat.B8g8r8a8Sscaled;
        public const VkFormat VK_FORMAT_B8G8R8A8_UINT = VkFormat.B8g8r8a8Uint;
        public const VkFormat VK_FORMAT_B8G8R8A8_SINT = VkFormat.B8g8r8a8Sint;
        public const VkFormat VK_FORMAT_B8G8R8A8_SRGB = VkFormat.B8g8r8a8Srgb;
        public const VkFormat VK_FORMAT_A8B8G8R8_UNORM_PACK32 = VkFormat.A8b8g8r8UnormPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SNORM_PACK32 = VkFormat.A8b8g8r8SnormPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_USCALED_PACK32 = VkFormat.A8b8g8r8UscaledPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SSCALED_PACK32 = VkFormat.A8b8g8r8SscaledPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_UINT_PACK32 = VkFormat.A8b8g8r8UintPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SINT_PACK32 = VkFormat.A8b8g8r8SintPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SRGB_PACK32 = VkFormat.A8b8g8r8SrgbPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_UNORM_PACK32 = VkFormat.A2r10g10b10UnormPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_SNORM_PACK32 = VkFormat.A2r10g10b10SnormPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_USCALED_PACK32 = VkFormat.A2r10g10b10UscaledPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_SSCALED_PACK32 = VkFormat.A2r10g10b10SscaledPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_UINT_PACK32 = VkFormat.A2r10g10b10UintPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_SINT_PACK32 = VkFormat.A2r10g10b10SintPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_UNORM_PACK32 = VkFormat.A2b10g10r10UnormPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_SNORM_PACK32 = VkFormat.A2b10g10r10SnormPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_USCALED_PACK32 = VkFormat.A2b10g10r10UscaledPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_SSCALED_PACK32 = VkFormat.A2b10g10r10SscaledPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_UINT_PACK32 = VkFormat.A2b10g10r10UintPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_SINT_PACK32 = VkFormat.A2b10g10r10SintPack32;
        public const VkFormat VK_FORMAT_R16_UNORM = VkFormat.R16Unorm;
        public const VkFormat VK_FORMAT_R16_SNORM = VkFormat.R16Snorm;
        public const VkFormat VK_FORMAT_R16_USCALED = VkFormat.R16Uscaled;
        public const VkFormat VK_FORMAT_R16_SSCALED = VkFormat.R16Sscaled;
        public const VkFormat VK_FORMAT_R16_UINT = VkFormat.R16Uint;
        public const VkFormat VK_FORMAT_R16_SINT = VkFormat.R16Sint;
        public const VkFormat VK_FORMAT_R16_SFLOAT = VkFormat.R16Sfloat;
        public const VkFormat VK_FORMAT_R16G16_UNORM = VkFormat.R16g16Unorm;
        public const VkFormat VK_FORMAT_R16G16_SNORM = VkFormat.R16g16Snorm;
        public const VkFormat VK_FORMAT_R16G16_USCALED = VkFormat.R16g16Uscaled;
        public const VkFormat VK_FORMAT_R16G16_SSCALED = VkFormat.R16g16Sscaled;
        public const VkFormat VK_FORMAT_R16G16_UINT = VkFormat.R16g16Uint;
        public const VkFormat VK_FORMAT_R16G16_SINT = VkFormat.R16g16Sint;
        public const VkFormat VK_FORMAT_R16G16_SFLOAT = VkFormat.R16g16Sfloat;
        public const VkFormat VK_FORMAT_R16G16B16_UNORM = VkFormat.R16g16b16Unorm;
        public const VkFormat VK_FORMAT_R16G16B16_SNORM = VkFormat.R16g16b16Snorm;
        public const VkFormat VK_FORMAT_R16G16B16_USCALED = VkFormat.R16g16b16Uscaled;
        public const VkFormat VK_FORMAT_R16G16B16_SSCALED = VkFormat.R16g16b16Sscaled;
        public const VkFormat VK_FORMAT_R16G16B16_UINT = VkFormat.R16g16b16Uint;
        public const VkFormat VK_FORMAT_R16G16B16_SINT = VkFormat.R16g16b16Sint;
        public const VkFormat VK_FORMAT_R16G16B16_SFLOAT = VkFormat.R16g16b16Sfloat;
        public const VkFormat VK_FORMAT_R16G16B16A16_UNORM = VkFormat.R16g16b16a16Unorm;
        public const VkFormat VK_FORMAT_R16G16B16A16_SNORM = VkFormat.R16g16b16a16Snorm;
        public const VkFormat VK_FORMAT_R16G16B16A16_USCALED = VkFormat.R16g16b16a16Uscaled;
        public const VkFormat VK_FORMAT_R16G16B16A16_SSCALED = VkFormat.R16g16b16a16Sscaled;
        public const VkFormat VK_FORMAT_R16G16B16A16_UINT = VkFormat.R16g16b16a16Uint;
        public const VkFormat VK_FORMAT_R16G16B16A16_SINT = VkFormat.R16g16b16a16Sint;
        public const VkFormat VK_FORMAT_R16G16B16A16_SFLOAT = VkFormat.R16g16b16a16Sfloat;
        public const VkFormat VK_FORMAT_R32_UINT = VkFormat.R32Uint;
        public const VkFormat VK_FORMAT_R32_SINT = VkFormat.R32Sint;
        public const VkFormat VK_FORMAT_R32_SFLOAT = VkFormat.R32Sfloat;
        public const VkFormat VK_FORMAT_R32G32_UINT = VkFormat.R32g32Uint;
        public const VkFormat VK_FORMAT_R32G32_SINT = VkFormat.R32g32Sint;
        public const VkFormat VK_FORMAT_R32G32_SFLOAT = VkFormat.R32g32Sfloat;
        public const VkFormat VK_FORMAT_R32G32B32_UINT = VkFormat.R32g32b32Uint;
        public const VkFormat VK_FORMAT_R32G32B32_SINT = VkFormat.R32g32b32Sint;
        public const VkFormat VK_FORMAT_R32G32B32_SFLOAT = VkFormat.R32g32b32Sfloat;
        public const VkFormat VK_FORMAT_R32G32B32A32_UINT = VkFormat.R32g32b32a32Uint;
        public const VkFormat VK_FORMAT_R32G32B32A32_SINT = VkFormat.R32g32b32a32Sint;
        public const VkFormat VK_FORMAT_R32G32B32A32_SFLOAT = VkFormat.R32g32b32a32Sfloat;
        public const VkFormat VK_FORMAT_R64_UINT = VkFormat.R64Uint;
        public const VkFormat VK_FORMAT_R64_SINT = VkFormat.R64Sint;
        public const VkFormat VK_FORMAT_R64_SFLOAT = VkFormat.R64Sfloat;
        public const VkFormat VK_FORMAT_R64G64_UINT = VkFormat.R64g64Uint;
        public const VkFormat VK_FORMAT_R64G64_SINT = VkFormat.R64g64Sint;
        public const VkFormat VK_FORMAT_R64G64_SFLOAT = VkFormat.R64g64Sfloat;
        public const VkFormat VK_FORMAT_R64G64B64_UINT = VkFormat.R64g64b64Uint;
        public const VkFormat VK_FORMAT_R64G64B64_SINT = VkFormat.R64g64b64Sint;
        public const VkFormat VK_FORMAT_R64G64B64_SFLOAT = VkFormat.R64g64b64Sfloat;
        public const VkFormat VK_FORMAT_R64G64B64A64_UINT = VkFormat.R64g64b64a64Uint;
        public const VkFormat VK_FORMAT_R64G64B64A64_SINT = VkFormat.R64g64b64a64Sint;
        public const VkFormat VK_FORMAT_R64G64B64A64_SFLOAT = VkFormat.R64g64b64a64Sfloat;
        public const VkFormat VK_FORMAT_B10G11R11_UFLOAT_PACK32 = VkFormat.B10g11r11UfloatPack32;
        public const VkFormat VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 = VkFormat.E5b9g9r9UfloatPack32;
        public const VkFormat VK_FORMAT_D16_UNORM = VkFormat.D16Unorm;
        public const VkFormat VK_FORMAT_X8_D24_UNORM_PACK32 = VkFormat.X8D24UnormPack32;
        public const VkFormat VK_FORMAT_D32_SFLOAT = VkFormat.D32Sfloat;
        public const VkFormat VK_FORMAT_S8_UINT = VkFormat.S8Uint;
        public const VkFormat VK_FORMAT_D16_UNORM_S8_UINT = VkFormat.D16UnormS8Uint;
        public const VkFormat VK_FORMAT_D24_UNORM_S8_UINT = VkFormat.D24UnormS8Uint;
        public const VkFormat VK_FORMAT_D32_SFLOAT_S8_UINT = VkFormat.D32SfloatS8Uint;
        public const VkFormat VK_FORMAT_BC1_RGB_UNORM_BLOCK = VkFormat.Bc1RgbUnormBlock;
        public const VkFormat VK_FORMAT_BC1_RGB_SRGB_BLOCK = VkFormat.Bc1RgbSrgbBlock;
        public const VkFormat VK_FORMAT_BC1_RGBA_UNORM_BLOCK = VkFormat.Bc1RgbaUnormBlock;
        public const VkFormat VK_FORMAT_BC1_RGBA_SRGB_BLOCK = VkFormat.Bc1RgbaSrgbBlock;
        public const VkFormat VK_FORMAT_BC2_UNORM_BLOCK = VkFormat.Bc2UnormBlock;
        public const VkFormat VK_FORMAT_BC2_SRGB_BLOCK = VkFormat.Bc2SrgbBlock;
        public const VkFormat VK_FORMAT_BC3_UNORM_BLOCK = VkFormat.Bc3UnormBlock;
        public const VkFormat VK_FORMAT_BC3_SRGB_BLOCK = VkFormat.Bc3SrgbBlock;
        public const VkFormat VK_FORMAT_BC4_UNORM_BLOCK = VkFormat.Bc4UnormBlock;
        public const VkFormat VK_FORMAT_BC4_SNORM_BLOCK = VkFormat.Bc4SnormBlock;
        public const VkFormat VK_FORMAT_BC5_UNORM_BLOCK = VkFormat.Bc5UnormBlock;
        public const VkFormat VK_FORMAT_BC5_SNORM_BLOCK = VkFormat.Bc5SnormBlock;
        public const VkFormat VK_FORMAT_BC6H_UFLOAT_BLOCK = VkFormat.Bc6hUfloatBlock;
        public const VkFormat VK_FORMAT_BC6H_SFLOAT_BLOCK = VkFormat.Bc6hSfloatBlock;
        public const VkFormat VK_FORMAT_BC7_UNORM_BLOCK = VkFormat.Bc7UnormBlock;
        public const VkFormat VK_FORMAT_BC7_SRGB_BLOCK = VkFormat.Bc7SrgbBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK = VkFormat.Etc2R8g8b8UnormBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK = VkFormat.Etc2R8g8b8SrgbBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK = VkFormat.Etc2R8g8b8a1UnormBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK = VkFormat.Etc2R8g8b8a1SrgbBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK = VkFormat.Etc2R8g8b8a8UnormBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK = VkFormat.Etc2R8g8b8a8SrgbBlock;
        public const VkFormat VK_FORMAT_EAC_R11_UNORM_BLOCK = VkFormat.EacR11UnormBlock;
        public const VkFormat VK_FORMAT_EAC_R11_SNORM_BLOCK = VkFormat.EacR11SnormBlock;
        public const VkFormat VK_FORMAT_EAC_R11G11_UNORM_BLOCK = VkFormat.EacR11g11UnormBlock;
        public const VkFormat VK_FORMAT_EAC_R11G11_SNORM_BLOCK = VkFormat.EacR11g11SnormBlock;
        public const VkFormat VK_FORMAT_ASTC_4x4_UNORM_BLOCK = VkFormat.Astc4x4UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_4x4_SRGB_BLOCK = VkFormat.Astc4x4SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_5x4_UNORM_BLOCK = VkFormat.Astc5x4UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_5x4_SRGB_BLOCK = VkFormat.Astc5x4SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_5x5_UNORM_BLOCK = VkFormat.Astc5x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_5x5_SRGB_BLOCK = VkFormat.Astc5x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_6x5_UNORM_BLOCK = VkFormat.Astc6x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_6x5_SRGB_BLOCK = VkFormat.Astc6x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_6x6_UNORM_BLOCK = VkFormat.Astc6x6UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_6x6_SRGB_BLOCK = VkFormat.Astc6x6SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_8x5_UNORM_BLOCK = VkFormat.Astc8x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_8x5_SRGB_BLOCK = VkFormat.Astc8x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_8x6_UNORM_BLOCK = VkFormat.Astc8x6UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_8x6_SRGB_BLOCK = VkFormat.Astc8x6SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_8x8_UNORM_BLOCK = VkFormat.Astc8x8UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_8x8_SRGB_BLOCK = VkFormat.Astc8x8SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x5_UNORM_BLOCK = VkFormat.Astc10x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x5_SRGB_BLOCK = VkFormat.Astc10x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x6_UNORM_BLOCK = VkFormat.Astc10x6UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x6_SRGB_BLOCK = VkFormat.Astc10x6SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x8_UNORM_BLOCK = VkFormat.Astc10x8UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x8_SRGB_BLOCK = VkFormat.Astc10x8SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x10_UNORM_BLOCK = VkFormat.Astc10x10UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x10_SRGB_BLOCK = VkFormat.Astc10x10SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_12x10_UNORM_BLOCK = VkFormat.Astc12x10UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_12x10_SRGB_BLOCK = VkFormat.Astc12x10SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_12x12_UNORM_BLOCK = VkFormat.Astc12x12UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_12x12_SRGB_BLOCK = VkFormat.Astc12x12SrgbBlock;
        public const VkFormat VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc12bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc14bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc22bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc24bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc12bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc14bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc22bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc24bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK_EXT = VkFormat.Astc4x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK_EXT = VkFormat.Astc5x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK_EXT = VkFormat.Astc5x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK_EXT = VkFormat.Astc6x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK_EXT = VkFormat.Astc6x6SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK_EXT = VkFormat.Astc8x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK_EXT = VkFormat.Astc8x6SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK_EXT = VkFormat.Astc8x8SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK_EXT = VkFormat.Astc10x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK_EXT = VkFormat.Astc10x6SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK_EXT = VkFormat.Astc10x8SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK_EXT = VkFormat.Astc10x10SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK_EXT = VkFormat.Astc12x10SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK_EXT = VkFormat.Astc12x12SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_3x3x3_UNORM_BLOCK_EXT = VkFormat.Astc3x3x3UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_3x3x3_SRGB_BLOCK_EXT = VkFormat.Astc3x3x3SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_3x3x3_SFLOAT_BLOCK_EXT = VkFormat.Astc3x3x3SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x3x3_UNORM_BLOCK_EXT = VkFormat.Astc4x3x3UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x3x3_SRGB_BLOCK_EXT = VkFormat.Astc4x3x3SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x3x3_SFLOAT_BLOCK_EXT = VkFormat.Astc4x3x3SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x3_UNORM_BLOCK_EXT = VkFormat.Astc4x4x3UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x3_SRGB_BLOCK_EXT = VkFormat.Astc4x4x3SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x3_SFLOAT_BLOCK_EXT = VkFormat.Astc4x4x3SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x4_UNORM_BLOCK_EXT = VkFormat.Astc4x4x4UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x4_SRGB_BLOCK_EXT = VkFormat.Astc4x4x4SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x4_SFLOAT_BLOCK_EXT = VkFormat.Astc4x4x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x4x4_UNORM_BLOCK_EXT = VkFormat.Astc5x4x4UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x4x4_SRGB_BLOCK_EXT = VkFormat.Astc5x4x4SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x4x4_SFLOAT_BLOCK_EXT = VkFormat.Astc5x4x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x4_UNORM_BLOCK_EXT = VkFormat.Astc5x5x4UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x4_SRGB_BLOCK_EXT = VkFormat.Astc5x5x4SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x4_SFLOAT_BLOCK_EXT = VkFormat.Astc5x5x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x5_UNORM_BLOCK_EXT = VkFormat.Astc5x5x5UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x5_SRGB_BLOCK_EXT = VkFormat.Astc5x5x5SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x5_SFLOAT_BLOCK_EXT = VkFormat.Astc5x5x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x5x5_UNORM_BLOCK_EXT = VkFormat.Astc6x5x5UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x5x5_SRGB_BLOCK_EXT = VkFormat.Astc6x5x5SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x5x5_SFLOAT_BLOCK_EXT = VkFormat.Astc6x5x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x5_UNORM_BLOCK_EXT = VkFormat.Astc6x6x5UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x5_SRGB_BLOCK_EXT = VkFormat.Astc6x6x5SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x5_SFLOAT_BLOCK_EXT = VkFormat.Astc6x6x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x6_UNORM_BLOCK_EXT = VkFormat.Astc6x6x6UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x6_SRGB_BLOCK_EXT = VkFormat.Astc6x6x6SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x6_SFLOAT_BLOCK_EXT = VkFormat.Astc6x6x6SfloatBlockEXT;
        public const VkFormat VK_FORMAT_A4R4G4B4_UNORM_PACK16_EXT = VkFormat.A4r4g4b4UnormPack16EXT;
        public const VkFormat VK_FORMAT_A4B4G4R4_UNORM_PACK16_EXT = VkFormat.A4b4g4r4UnormPack16EXT;
    }

    public enum VkStructureType
    {
        ApplicationInfo = 0,
        InstanceCreateInfo = 1,
        DeviceQueueCreateInfo = 2,
        DeviceCreateInfo = 3,
        SubmitInfo = 4,
        MemoryAllocateInfo = 5,
        MappedMemoryRange = 6,
        BindSparseInfo = 7,
        FenceCreateInfo = 8,
        SemaphoreCreateInfo = 9,
        EventCreateInfo = 10,
        QueryPoolCreateInfo = 11,
        BufferCreateInfo = 12,
        BufferViewCreateInfo = 13,
        ImageCreateInfo = 14,
        ImageViewCreateInfo = 15,
        ShaderModuleCreateInfo = 16,
        PipelineCacheCreateInfo = 17,
        PipelineShaderStageCreateInfo = 18,
        PipelineVertexInputStateCreateInfo = 19,
        PipelineInputAssemblyStateCreateInfo = 20,
        PipelineTessellationStateCreateInfo = 21,
        PipelineViewportStateCreateInfo = 22,
        PipelineRasterizationStateCreateInfo = 23,
        PipelineMultisampleStateCreateInfo = 24,
        PipelineDepthStencilStateCreateInfo = 25,
        PipelineColorBlendStateCreateInfo = 26,
        PipelineDynamicStateCreateInfo = 27,
        GraphicsPipelineCreateInfo = 28,
        ComputePipelineCreateInfo = 29,
        PipelineLayoutCreateInfo = 30,
        SamplerCreateInfo = 31,
        DescriptorSetLayoutCreateInfo = 32,
        DescriptorPoolCreateInfo = 33,
        DescriptorSetAllocateInfo = 34,
        WriteDescriptorSet = 35,
        CopyDescriptorSet = 36,
        FramebufferCreateInfo = 37,
        RenderPassCreateInfo = 38,
        CommandPoolCreateInfo = 39,
        CommandBufferAllocateInfo = 40,
        CommandBufferInheritanceInfo = 41,
        CommandBufferBeginInfo = 42,
        RenderPassBeginInfo = 43,
        BufferMemoryBarrier = 44,
        ImageMemoryBarrier = 45,
        MemoryBarrier = 46,
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        LoaderInstanceCreateInfo = 47,
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        LoaderDeviceCreateInfo = 48,
        SwapchainCreateInfoKHR = 1000001000,
        PresentInfoKHR = 1000001001,
        DeviceGroupPresentCapabilitiesKHR = 1000001007,
        ImageSwapchainCreateInfoKHR = 1000001008,
        BindImageMemorySwapchainInfoKHR = 1000001009,
        AcquireNextImageInfoKHR = 1000001010,
        DeviceGroupPresentInfoKHR = 1000001011,
        DeviceGroupSwapchainCreateInfoKHR = 1000001012,
        DisplayModeCreateInfoKHR = 1000002000,
        DisplaySurfaceCreateInfoKHR = 1000002001,
        DisplayPresentInfoKHR = 1000003000,
        XlibSurfaceCreateInfoKHR = 1000004000,
        XcbSurfaceCreateInfoKHR = 1000005000,
        WaylandSurfaceCreateInfoKHR = 1000006000,
        AndroidSurfaceCreateInfoKHR = 1000008000,
        Win32SurfaceCreateInfoKHR = 1000009000,
        NativeBufferAndroid = 1000010000,
        SwapchainImageCreateInfoAndroid = 1000010001,
        PhysicalDevicePresentationPropertiesAndroid = 1000010002,
        DebugReportCallbackCreateInfoEXT = 1000011000,
        PipelineRasterizationStateRasterizationOrderAMD = 1000018000,
        DebugMarkerObjectNameInfoEXT = 1000022000,
        DebugMarkerObjectTagInfoEXT = 1000022001,
        DebugMarkerMarkerInfoEXT = 1000022002,
        DedicatedAllocationImageCreateInfoNV = 1000026000,
        DedicatedAllocationBufferCreateInfoNV = 1000026001,
        DedicatedAllocationMemoryAllocateInfoNV = 1000026002,
        PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,
        PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,
        PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,
        ImageViewHandleInfoNVX = 1000030000,
        ImageViewAddressPropertiesNVX = 1000030001,
        TextureLodGatherFormatPropertiesAMD = 1000041000,
        StreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,
        ExternalMemoryImageCreateInfoNV = 1000056000,
        ExportMemoryAllocateInfoNV = 1000056001,
        ImportMemoryWin32HandleInfoNV = 1000057000,
        ExportMemoryWin32HandleInfoNV = 1000057001,
        Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
        DeviceGroupPresentCapabilitiesKHR = 1000060007,
        ImageSwapchainCreateInfoKHR = 1000060008,
        BindImageMemorySwapchainInfoKHR = 1000060009,
        AcquireNextImageInfoKHR = 1000060010,
        DeviceGroupPresentInfoKHR = 1000060011,
        DeviceGroupSwapchainCreateInfoKHR = 1000060012,
        ValidationEXT = 1000061000,
        ViSurfaceCreateInfoNn = 1000062000,
        PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT = 1000066000,
        ImageViewAstcDecodeModeEXT = 1000067000,
        PhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,
        ImportMemoryWin32HandleInfoKHR = 1000073000,
        ExportMemoryWin32HandleInfoKHR = 1000073001,
        MemoryWin32HandlePropertiesKHR = 1000073002,
        MemoryGetWin32HandleInfoKHR = 1000073003,
        ImportMemoryFdInfoKHR = 1000074000,
        MemoryFdPropertiesKHR = 1000074001,
        MemoryGetFdInfoKHR = 1000074002,
        Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,
        ImportSemaphoreWin32HandleInfoKHR = 1000078000,
        ExportSemaphoreWin32HandleInfoKHR = 1000078001,
        D3d12FenceSubmitInfoKHR = 1000078002,
        SemaphoreGetWin32HandleInfoKHR = 1000078003,
        ImportSemaphoreFdInfoKHR = 1000079000,
        SemaphoreGetFdInfoKHR = 1000079001,
        PhysicalDevicePushDescriptorPropertiesKHR = 1000080000,
        CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,
        PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,
        ConditionalRenderingBeginInfoEXT = 1000081002,
        PresentRegionsKHR = 1000084000,
        PipelineViewportWScalingStateCreateInfoNV = 1000087000,
        SurfaceCapabilities2EXT = 1000090000,
        DisplayPowerInfoEXT = 1000091000,
        DeviceEventInfoEXT = 1000091001,
        DisplayEventInfoEXT = 1000091002,
        SwapchainCounterCreateInfoEXT = 1000091003,
        PresentTimesInfoGoogle = 1000092000,
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,
        PipelineViewportSwizzleStateCreateInfoNV = 1000098000,
        PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,
        PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,
        PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,
        PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,
        PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,
        PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,
        HdrMetadataEXT = 1000105000,
        SharedPresentSurfaceCapabilitiesKHR = 1000111000,
        ImportFenceWin32HandleInfoKHR = 1000114000,
        ExportFenceWin32HandleInfoKHR = 1000114001,
        FenceGetWin32HandleInfoKHR = 1000114002,
        ImportFenceFdInfoKHR = 1000115000,
        FenceGetFdInfoKHR = 1000115001,
        PhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,
        PhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,
        QueryPoolPerformanceCreateInfoKHR = 1000116002,
        PerformanceQuerySubmitInfoKHR = 1000116003,
        AcquireProfilingLockInfoKHR = 1000116004,
        PerformanceCounterKHR = 1000116005,
        PerformanceCounterDescriptionKHR = 1000116006,
        PhysicalDeviceSurfaceInfo2KHR = 1000119000,
        SurfaceCapabilities2KHR = 1000119001,
        SurfaceFormat2KHR = 1000119002,
        DisplayProperties2KHR = 1000121000,
        DisplayPlaneProperties2KHR = 1000121001,
        DisplayModeProperties2KHR = 1000121002,
        DisplayPlaneInfo2KHR = 1000121003,
        DisplayPlaneCapabilities2KHR = 1000121004,
        IosSurfaceCreateInfoMvk = 1000122000,
        MacosSurfaceCreateInfoMvk = 1000123000,
        DebugUtilsObjectNameInfoEXT = 1000128000,
        DebugUtilsObjectTagInfoEXT = 1000128001,
        DebugUtilsLabelEXT = 1000128002,
        DebugUtilsMessengerCallbackDataEXT = 1000128003,
        DebugUtilsMessengerCreateInfoEXT = 1000128004,
        AndroidHardwareBufferUsageAndroid = 1000129000,
        AndroidHardwareBufferPropertiesAndroid = 1000129001,
        AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        ImportAndroidHardwareBufferInfoAndroid = 1000129003,
        MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        ExternalFormatAndroid = 1000129005,
        PhysicalDeviceInlineUniformBlockFeaturesEXT = 1000138000,
        PhysicalDeviceInlineUniformBlockPropertiesEXT = 1000138001,
        WriteDescriptorSetInlineUniformBlockEXT = 1000138002,
        DescriptorPoolInlineUniformBlockCreateInfoEXT = 1000138003,
        SampleLocationsInfoEXT = 1000143000,
        RenderPassSampleLocationsBeginInfoEXT = 1000143001,
        PipelineSampleLocationsStateCreateInfoEXT = 1000143002,
        PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,
        MultisamplePropertiesEXT = 1000143004,
        PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,
        PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,
        PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,
        PipelineCoverageToColorStateCreateInfoNV = 1000149000,
        WriteDescriptorSetAccelerationStructureKHR = 1000150007,
        AccelerationStructureBuildGeometryInfoKHR = 1000150000,
        AccelerationStructureDeviceAddressInfoKHR = 1000150002,
        AccelerationStructureGeometryAabbsDataKHR = 1000150003,
        AccelerationStructureGeometryInstancesDataKHR = 1000150004,
        AccelerationStructureGeometryTrianglesDataKHR = 1000150005,
        AccelerationStructureGeometryKHR = 1000150006,
        AccelerationStructureVersionInfoKHR = 1000150009,
        CopyAccelerationStructureInfoKHR = 1000150010,
        CopyAccelerationStructureToMemoryInfoKHR = 1000150011,
        CopyMemoryToAccelerationStructureInfoKHR = 1000150012,
        PhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,
        PhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,
        AccelerationStructureCreateInfoKHR = 1000150017,
        AccelerationStructureBuildSizesInfoKHR = 1000150020,
        PhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,
        PhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,
        RayTracingPipelineCreateInfoKHR = 1000347015,
        RayTracingShaderGroupCreateInfoKHR = 1000347016,
        RayTracingPipelineInterfaceCreateInfoKHR = 1000347018,
        PhysicalDeviceRayQueryFeaturesKHR = 1000348013,
        PipelineCoverageModulationStateCreateInfoNV = 1000152000,
        PhysicalDeviceShaderSmBuiltinsFeaturesNV = 1000154000,
        PhysicalDeviceShaderSmBuiltinsPropertiesNV = 1000154001,
        DrmFormatModifierPropertiesListEXT = 1000158000,
        PhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,
        ImageDrmFormatModifierListCreateInfoEXT = 1000158003,
        ImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,
        ImageDrmFormatModifierPropertiesEXT = 1000158005,
        ValidationCacheCreateInfoEXT = 1000160000,
        ShaderModuleValidationCacheCreateInfoEXT = 1000160001,
        PhysicalDevicePortabilitySubsetFeaturesKHR = 1000163000,
        PhysicalDevicePortabilitySubsetPropertiesKHR = 1000163001,
        PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,
        PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,
        PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,
        PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,
        RayTracingPipelineCreateInfoNV = 1000165000,
        AccelerationStructureCreateInfoNV = 1000165001,
        GeometryNV = 1000165003,
        GeometryTrianglesNV = 1000165004,
        GeometryAabbNV = 1000165005,
        BindAccelerationStructureMemoryInfoNV = 1000165006,
        WriteDescriptorSetAccelerationStructureNV = 1000165007,
        AccelerationStructureMemoryRequirementsInfoNV = 1000165008,
        PhysicalDeviceRayTracingPropertiesNV = 1000165009,
        RayTracingShaderGroupCreateInfoNV = 1000165011,
        AccelerationStructureInfoNV = 1000165012,
        PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,
        PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,
        PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,
        FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,
        DeviceQueueGlobalPriorityCreateInfoEXT = 1000174000,
        ImportMemoryHostPointerInfoEXT = 1000178000,
        MemoryHostPointerPropertiesEXT = 1000178001,
        PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,
        PhysicalDeviceShaderClockFeaturesKHR = 1000181000,
        PipelineCompilerControlCreateInfoAMD = 1000183000,
        CalibratedTimestampInfoEXT = 1000184000,
        PhysicalDeviceShaderCorePropertiesAMD = 1000185000,
        DeviceMemoryOverallocationCreateInfoAMD = 1000189000,
        PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,
        PipelineVertexInputDivisorStateCreateInfoEXT = 1000190001,
        PhysicalDeviceVertexAttributeDivisorFeaturesEXT = 1000190002,
        PresentFrameTokenGgp = 1000191000,
        PipelineCreationFeedbackCreateInfoEXT = 1000192000,
        PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
        PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
        PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
        PhysicalDeviceFragmentShaderBarycentricFeaturesNV = 1000203000,
        PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
        PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
        PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
        CheckpointDataNV = 1000206000,
        QueueFamilyCheckpointPropertiesNV = 1000206001,
        PhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
        QueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
        InitializePerformanceApiInfoIntel = 1000210001,
        PerformanceMarkerInfoIntel = 1000210002,
        PerformanceStreamMarkerInfoIntel = 1000210003,
        PerformanceOverrideInfoIntel = 1000210004,
        PerformanceConfigurationAcquireInfoIntel = 1000210005,
        PhysicalDevicePciBusInfoPropertiesEXT = 1000212000,
        DisplayNativeHdrSurfaceCapabilitiesAMD = 1000213000,
        SwapchainDisplayNativeHdrCreateInfoAMD = 1000213001,
        ImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        PhysicalDeviceShaderTerminateInvocationFeaturesKHR = 1000215000,
        MetalSurfaceCreateInfoEXT = 1000217000,
        PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,
        PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,
        RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,
        PhysicalDeviceSubgroupSizeControlPropertiesEXT = 1000225000,
        PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT = 1000225001,
        PhysicalDeviceSubgroupSizeControlFeaturesEXT = 1000225002,
        FragmentShadingRateAttachmentInfoKHR = 1000226000,
        PipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,
        PhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,
        PhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,
        PhysicalDeviceFragmentShadingRateKHR = 1000226004,
        PhysicalDeviceShaderCoreProperties2AMD = 1000227000,
        PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,
        PhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,
        PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,
        PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,
        MemoryPriorityAllocateInfoEXT = 1000238001,
        SurfaceProtectedCapabilitiesKHR = 1000239000,
        PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
        PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,
        BufferDeviceAddressCreateInfoEXT = 1000244002,
        PhysicalDeviceToolPropertiesEXT = 1000245000,
        ValidationFeaturesEXT = 1000247000,
        PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
        CooperativeMatrixPropertiesNV = 1000249001,
        PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
        PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,
        PipelineCoverageReductionStateCreateInfoNV = 1000250001,
        FramebufferMixedSamplesCombinationNV = 1000250002,
        PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,
        PhysicalDeviceYcbcrImageArraysFeaturesEXT = 1000252000,
        SurfaceFullScreenExclusiveInfoEXT = 1000255000,
        SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,
        SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,
        HeadlessSurfaceCreateInfoEXT = 1000256000,
        PhysicalDeviceLineRasterizationFeaturesEXT = 1000259000,
        PipelineRasterizationLineStateCreateInfoEXT = 1000259001,
        PhysicalDeviceLineRasterizationPropertiesEXT = 1000259002,
        PhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,
        PhysicalDeviceIndexTypeUint8FeaturesEXT = 1000265000,
        PhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,
        PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,
        PipelineInfoKHR = 1000269001,
        PipelineExecutablePropertiesKHR = 1000269002,
        PipelineExecutableInfoKHR = 1000269003,
        PipelineExecutableStatisticKHR = 1000269004,
        PipelineExecutableInternalRepresentationKHR = 1000269005,
        PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT = 1000276000,
        PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,
        GraphicsShaderGroupCreateInfoNV = 1000277001,
        GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,
        IndirectCommandsLayoutTokenNV = 1000277003,
        IndirectCommandsLayoutCreateInfoNV = 1000277004,
        GeneratedCommandsInfoNV = 1000277005,
        GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,
        PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,
        PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,
        PhysicalDeviceTexelBufferAlignmentPropertiesEXT = 1000281001,
        CommandBufferInheritanceRenderPassTransformInfoQcom = 1000282000,
        RenderPassTransformBeginInfoQcom = 1000282001,
        PhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,
        DeviceDeviceMemoryReportCreateInfoEXT = 1000284001,
        DeviceMemoryReportCallbackDataEXT = 1000284002,
        PhysicalDeviceRobustness2FeaturesEXT = 1000286000,
        PhysicalDeviceRobustness2PropertiesEXT = 1000286001,
        SamplerCustomBorderColorCreateInfoEXT = 1000287000,
        PhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,
        PhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,
        PipelineLibraryCreateInfoKHR = 1000290000,
        PhysicalDevicePrivateDataFeaturesEXT = 1000295000,
        DevicePrivateDataCreateInfoEXT = 1000295001,
        PrivateDataSlotCreateInfoEXT = 1000295002,
        PhysicalDevicePipelineCreationCacheControlFeaturesEXT = 1000297000,
        PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,
        DeviceDiagnosticsConfigCreateInfoNV = 1000300001,
        ReservedQcom = 1000309000,
        PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,
        PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,
        PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,
        PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,
        PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,
        CopyCommandTransformInfoQcom = 1000333000,
        PhysicalDeviceImageRobustnessFeaturesEXT = 1000335000,
        CopyBufferInfo2KHR = 1000337000,
        CopyImageInfo2KHR = 1000337001,
        CopyBufferToImageInfo2KHR = 1000337002,
        CopyImageToBufferInfo2KHR = 1000337003,
        BlitImageInfo2KHR = 1000337004,
        ResolveImageInfo2KHR = 1000337005,
        BufferCopy2KHR = 1000337006,
        ImageCopy2KHR = 1000337007,
        ImageBlit2KHR = 1000337008,
        BufferImageCopy2KHR = 1000337009,
        ImageResolve2KHR = 1000337010,
        PhysicalDevice4444FormatsFeaturesEXT = 1000340000,
        DirectfbSurfaceCreateInfoEXT = 1000346000,
        PhysicalDeviceMutableDescriptorTypeFeaturesValve = 1000351000,
        MutableDescriptorTypeCreateInfoValve = 1000351002,
    }
    public static partial class RawConstants
    {
        public const VkStructureType VK_STRUCTURE_TYPE_APPLICATION_INFO = VkStructureType.ApplicationInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = VkStructureType.InstanceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = VkStructureType.DeviceQueueCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = VkStructureType.DeviceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBMIT_INFO = VkStructureType.SubmitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO = VkStructureType.MemoryAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = VkStructureType.MappedMemoryRange;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_SPARSE_INFO = VkStructureType.BindSparseInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = VkStructureType.FenceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = VkStructureType.SemaphoreCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = VkStructureType.EventCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = VkStructureType.QueryPoolCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = VkStructureType.BufferCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = VkStructureType.BufferViewCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = VkStructureType.ImageCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = VkStructureType.ImageViewCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = VkStructureType.ShaderModuleCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = VkStructureType.PipelineCacheCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = VkStructureType.PipelineShaderStageCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = VkStructureType.PipelineVertexInputStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = VkStructureType.PipelineInputAssemblyStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = VkStructureType.PipelineTessellationStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = VkStructureType.PipelineViewportStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO = VkStructureType.PipelineRasterizationStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = VkStructureType.PipelineMultisampleStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = VkStructureType.PipelineDepthStencilStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = VkStructureType.PipelineColorBlendStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO = VkStructureType.PipelineDynamicStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = VkStructureType.GraphicsPipelineCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = VkStructureType.ComputePipelineCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = VkStructureType.PipelineLayoutCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = VkStructureType.SamplerCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = VkStructureType.DescriptorSetLayoutCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = VkStructureType.DescriptorPoolCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO = VkStructureType.DescriptorSetAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = VkStructureType.WriteDescriptorSet;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = VkStructureType.CopyDescriptorSet;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = VkStructureType.FramebufferCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = VkStructureType.RenderPassCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO = VkStructureType.CommandPoolCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO = VkStructureType.CommandBufferAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO = VkStructureType.CommandBufferInheritanceInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO = VkStructureType.CommandBufferBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = VkStructureType.RenderPassBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = VkStructureType.BufferMemoryBarrier;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = VkStructureType.ImageMemoryBarrier;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_BARRIER = VkStructureType.MemoryBarrier;
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        public const VkStructureType VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO = VkStructureType.LoaderInstanceCreateInfo;
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        public const VkStructureType VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO = VkStructureType.LoaderDeviceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.SwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_INFO_KHR = VkStructureType.PresentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = VkStructureType.DeviceGroupPresentCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.ImageSwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = VkStructureType.BindImageMemorySwapchainInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = VkStructureType.AcquireNextImageInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = VkStructureType.DeviceGroupPresentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.DeviceGroupSwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR = VkStructureType.DisplayModeCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR = VkStructureType.DisplaySurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR = VkStructureType.DisplayPresentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR = VkStructureType.XlibSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR = VkStructureType.XcbSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR = VkStructureType.WaylandSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR = VkStructureType.AndroidSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR = VkStructureType.Win32SurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_NATIVE_BUFFER_ANDROID = VkStructureType.NativeBufferAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_IMAGE_CREATE_INFO_ANDROID = VkStructureType.SwapchainImageCreateInfoAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENTATION_PROPERTIES_ANDROID = VkStructureType.PhysicalDevicePresentationPropertiesAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT = VkStructureType.DebugReportCallbackCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD = VkStructureType.PipelineRasterizationStateRasterizationOrderAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT = VkStructureType.DebugMarkerObjectNameInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT = VkStructureType.DebugMarkerObjectTagInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT = VkStructureType.DebugMarkerMarkerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV = VkStructureType.DedicatedAllocationImageCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV = VkStructureType.DedicatedAllocationBufferCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV = VkStructureType.DedicatedAllocationMemoryAllocateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT = VkStructureType.PhysicalDeviceTransformFeedbackFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT = VkStructureType.PhysicalDeviceTransformFeedbackPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationStateStreamCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX = VkStructureType.ImageViewHandleInfoNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX = VkStructureType.ImageViewAddressPropertiesNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD = VkStructureType.TextureLodGatherFormatPropertiesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP = VkStructureType.StreamDescriptorSurfaceCreateInfoGgp;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV = VkStructureType.PhysicalDeviceCornerSampledImageFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV = VkStructureType.ExternalMemoryImageCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV = VkStructureType.ExportMemoryAllocateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV = VkStructureType.ImportMemoryWin32HandleInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV = VkStructureType.ExportMemoryWin32HandleInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV = VkStructureType.Win32KeyedMutexAcquireReleaseInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = VkStructureType.DeviceGroupPresentCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.ImageSwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = VkStructureType.BindImageMemorySwapchainInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = VkStructureType.AcquireNextImageInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = VkStructureType.DeviceGroupPresentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.DeviceGroupSwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT = VkStructureType.ValidationEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN = VkStructureType.ViSurfaceCreateInfoNn;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT = VkStructureType.PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT = VkStructureType.ImageViewAstcDecodeModeEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT = VkStructureType.PhysicalDeviceAstcDecodeFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR = VkStructureType.ImportMemoryWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR = VkStructureType.ExportMemoryWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR = VkStructureType.MemoryWin32HandlePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR = VkStructureType.MemoryGetWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR = VkStructureType.ImportMemoryFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR = VkStructureType.MemoryFdPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR = VkStructureType.MemoryGetFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR = VkStructureType.Win32KeyedMutexAcquireReleaseInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = VkStructureType.ImportSemaphoreWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = VkStructureType.ExportSemaphoreWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR = VkStructureType.D3d12FenceSubmitInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR = VkStructureType.SemaphoreGetWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR = VkStructureType.ImportSemaphoreFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR = VkStructureType.SemaphoreGetFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR = VkStructureType.PhysicalDevicePushDescriptorPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT = VkStructureType.CommandBufferInheritanceConditionalRenderingInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT = VkStructureType.PhysicalDeviceConditionalRenderingFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT = VkStructureType.ConditionalRenderingBeginInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR = VkStructureType.PresentRegionsKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportWScalingStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT = VkStructureType.SurfaceCapabilities2EXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT = VkStructureType.DisplayPowerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT = VkStructureType.DeviceEventInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT = VkStructureType.DisplayEventInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT = VkStructureType.SwapchainCounterCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE = VkStructureType.PresentTimesInfoGoogle;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX = VkStructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportSwizzleStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT = VkStructureType.PhysicalDeviceDiscardRectanglePropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT = VkStructureType.PipelineDiscardRectangleStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT = VkStructureType.PhysicalDeviceConservativeRasterizationPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationConservativeStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT = VkStructureType.PhysicalDeviceDepthClipEnableFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationDepthClipStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_HDR_METADATA_EXT = VkStructureType.HdrMetadataEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR = VkStructureType.SharedPresentSurfaceCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR = VkStructureType.ImportFenceWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR = VkStructureType.ExportFenceWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR = VkStructureType.FenceGetWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR = VkStructureType.ImportFenceFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR = VkStructureType.FenceGetFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR = VkStructureType.PhysicalDevicePerformanceQueryFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR = VkStructureType.PhysicalDevicePerformanceQueryPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR = VkStructureType.QueryPoolPerformanceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR = VkStructureType.PerformanceQuerySubmitInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR = VkStructureType.AcquireProfilingLockInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR = VkStructureType.PerformanceCounterKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR = VkStructureType.PerformanceCounterDescriptionKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR = VkStructureType.PhysicalDeviceSurfaceInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR = VkStructureType.SurfaceCapabilities2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR = VkStructureType.SurfaceFormat2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR = VkStructureType.DisplayProperties2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR = VkStructureType.DisplayPlaneProperties2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR = VkStructureType.DisplayModeProperties2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR = VkStructureType.DisplayPlaneInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR = VkStructureType.DisplayPlaneCapabilities2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK = VkStructureType.IosSurfaceCreateInfoMvk;
        public const VkStructureType VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK = VkStructureType.MacosSurfaceCreateInfoMvk;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = VkStructureType.DebugUtilsObjectNameInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT = VkStructureType.DebugUtilsObjectTagInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT = VkStructureType.DebugUtilsLabelEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = VkStructureType.DebugUtilsMessengerCallbackDataEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = VkStructureType.DebugUtilsMessengerCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID = VkStructureType.AndroidHardwareBufferUsageAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID = VkStructureType.AndroidHardwareBufferPropertiesAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID = VkStructureType.AndroidHardwareBufferFormatPropertiesAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = VkStructureType.ImportAndroidHardwareBufferInfoAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = VkStructureType.MemoryGetAndroidHardwareBufferInfoAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID = VkStructureType.ExternalFormatAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT = VkStructureType.PhysicalDeviceInlineUniformBlockFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT = VkStructureType.PhysicalDeviceInlineUniformBlockPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT = VkStructureType.WriteDescriptorSetInlineUniformBlockEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT = VkStructureType.DescriptorPoolInlineUniformBlockCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT = VkStructureType.SampleLocationsInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT = VkStructureType.RenderPassSampleLocationsBeginInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT = VkStructureType.PipelineSampleLocationsStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT = VkStructureType.PhysicalDeviceSampleLocationsPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT = VkStructureType.MultisamplePropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT = VkStructureType.PhysicalDeviceBlendOperationAdvancedFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT = VkStructureType.PhysicalDeviceBlendOperationAdvancedPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT = VkStructureType.PipelineColorBlendAdvancedStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV = VkStructureType.PipelineCoverageToColorStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR = VkStructureType.WriteDescriptorSetAccelerationStructureKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR = VkStructureType.AccelerationStructureBuildGeometryInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR = VkStructureType.AccelerationStructureDeviceAddressInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR = VkStructureType.AccelerationStructureGeometryAabbsDataKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR = VkStructureType.AccelerationStructureGeometryInstancesDataKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR = VkStructureType.AccelerationStructureGeometryTrianglesDataKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR = VkStructureType.AccelerationStructureGeometryKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR = VkStructureType.AccelerationStructureVersionInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR = VkStructureType.CopyAccelerationStructureInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR = VkStructureType.CopyAccelerationStructureToMemoryInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR = VkStructureType.CopyMemoryToAccelerationStructureInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR = VkStructureType.PhysicalDeviceAccelerationStructureFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR = VkStructureType.PhysicalDeviceAccelerationStructurePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR = VkStructureType.AccelerationStructureCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR = VkStructureType.AccelerationStructureBuildSizesInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR = VkStructureType.PhysicalDeviceRayTracingPipelineFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR = VkStructureType.PhysicalDeviceRayTracingPipelinePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR = VkStructureType.RayTracingPipelineCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR = VkStructureType.RayTracingShaderGroupCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR = VkStructureType.RayTracingPipelineInterfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR = VkStructureType.PhysicalDeviceRayQueryFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV = VkStructureType.PipelineCoverageModulationStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV = VkStructureType.PhysicalDeviceShaderSmBuiltinsFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV = VkStructureType.PhysicalDeviceShaderSmBuiltinsPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT = VkStructureType.DrmFormatModifierPropertiesListEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT = VkStructureType.PhysicalDeviceImageDrmFormatModifierInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT = VkStructureType.ImageDrmFormatModifierListCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT = VkStructureType.ImageDrmFormatModifierExplicitCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = VkStructureType.ImageDrmFormatModifierPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT = VkStructureType.ValidationCacheCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT = VkStructureType.ShaderModuleValidationCacheCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR = VkStructureType.PhysicalDevicePortabilitySubsetFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR = VkStructureType.PhysicalDevicePortabilitySubsetPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportShadingRateImageStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV = VkStructureType.PhysicalDeviceShadingRateImageFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV = VkStructureType.PhysicalDeviceShadingRateImagePropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV = VkStructureType.RayTracingPipelineCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV = VkStructureType.AccelerationStructureCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GEOMETRY_NV = VkStructureType.GeometryNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV = VkStructureType.GeometryTrianglesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV = VkStructureType.GeometryAabbNV;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV = VkStructureType.BindAccelerationStructureMemoryInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV = VkStructureType.WriteDescriptorSetAccelerationStructureNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV = VkStructureType.AccelerationStructureMemoryRequirementsInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV = VkStructureType.PhysicalDeviceRayTracingPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV = VkStructureType.RayTracingShaderGroupCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV = VkStructureType.AccelerationStructureInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV = VkStructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV = VkStructureType.PipelineRepresentativeFragmentTestStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT = VkStructureType.PhysicalDeviceImageViewImageFormatInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT = VkStructureType.FilterCubicImageViewImageFormatPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT = VkStructureType.DeviceQueueGlobalPriorityCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT = VkStructureType.ImportMemoryHostPointerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT = VkStructureType.MemoryHostPointerPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT = VkStructureType.PhysicalDeviceExternalMemoryHostPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR = VkStructureType.PhysicalDeviceShaderClockFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD = VkStructureType.PipelineCompilerControlCreateInfoAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT = VkStructureType.CalibratedTimestampInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD = VkStructureType.PhysicalDeviceShaderCorePropertiesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD = VkStructureType.DeviceMemoryOverallocationCreateInfoAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT = VkStructureType.PhysicalDeviceVertexAttributeDivisorPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT = VkStructureType.PipelineVertexInputDivisorStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT = VkStructureType.PhysicalDeviceVertexAttributeDivisorFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP = VkStructureType.PresentFrameTokenGgp;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT = VkStructureType.PipelineCreationFeedbackCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV = VkStructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV = VkStructureType.PhysicalDeviceMeshShaderFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV = VkStructureType.PhysicalDeviceMeshShaderPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV = VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV = VkStructureType.PhysicalDeviceShaderImageFootprintFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportExclusiveScissorStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV = VkStructureType.PhysicalDeviceExclusiveScissorFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV = VkStructureType.CheckpointDataNV;
        public const VkStructureType VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV = VkStructureType.QueueFamilyCheckpointPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL = VkStructureType.PhysicalDeviceShaderIntegerFunctions2FeaturesIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL = VkStructureType.QueryPoolPerformanceQueryCreateInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL = VkStructureType.InitializePerformanceApiInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL = VkStructureType.PerformanceMarkerInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL = VkStructureType.PerformanceStreamMarkerInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL = VkStructureType.PerformanceOverrideInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL = VkStructureType.PerformanceConfigurationAcquireInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT = VkStructureType.PhysicalDevicePciBusInfoPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD = VkStructureType.DisplayNativeHdrSurfaceCapabilitiesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD = VkStructureType.SwapchainDisplayNativeHdrCreateInfoAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA = VkStructureType.ImagepipeSurfaceCreateInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR = VkStructureType.PhysicalDeviceShaderTerminateInvocationFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT = VkStructureType.MetalSurfaceCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMapFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMapPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT = VkStructureType.RenderPassFragmentDensityMapCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT = VkStructureType.PhysicalDeviceSubgroupSizeControlPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT = VkStructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT = VkStructureType.PhysicalDeviceSubgroupSizeControlFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = VkStructureType.FragmentShadingRateAttachmentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR = VkStructureType.PipelineFragmentShadingRateStateCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR = VkStructureType.PhysicalDeviceFragmentShadingRatePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR = VkStructureType.PhysicalDeviceFragmentShadingRateFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR = VkStructureType.PhysicalDeviceFragmentShadingRateKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD = VkStructureType.PhysicalDeviceShaderCoreProperties2AMD;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD = VkStructureType.PhysicalDeviceCoherentMemoryFeaturesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderImageAtomicInt64FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT = VkStructureType.PhysicalDeviceMemoryBudgetPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT = VkStructureType.PhysicalDeviceMemoryPriorityFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT = VkStructureType.MemoryPriorityAllocateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR = VkStructureType.SurfaceProtectedCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV = VkStructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT = VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT = VkStructureType.BufferDeviceAddressCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT = VkStructureType.PhysicalDeviceToolPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT = VkStructureType.ValidationFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV = VkStructureType.CooperativeMatrixPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV = VkStructureType.PhysicalDeviceCoverageReductionModeFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV = VkStructureType.PipelineCoverageReductionStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV = VkStructureType.FramebufferMixedSamplesCombinationNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT = VkStructureType.PhysicalDeviceFragmentShaderInterlockFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT = VkStructureType.PhysicalDeviceYcbcrImageArraysFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT = VkStructureType.SurfaceFullScreenExclusiveInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT = VkStructureType.SurfaceCapabilitiesFullScreenExclusiveEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT = VkStructureType.SurfaceFullScreenExclusiveWin32InfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT = VkStructureType.HeadlessSurfaceCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT = VkStructureType.PhysicalDeviceLineRasterizationFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationLineStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT = VkStructureType.PhysicalDeviceLineRasterizationPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderAtomicFloatFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT = VkStructureType.PhysicalDeviceIndexTypeUint8FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT = VkStructureType.PhysicalDeviceExtendedDynamicStateFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR = VkStructureType.PhysicalDevicePipelineExecutablePropertiesFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR = VkStructureType.PipelineInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR = VkStructureType.PipelineExecutablePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR = VkStructureType.PipelineExecutableInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR = VkStructureType.PipelineExecutableStatisticKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR = VkStructureType.PipelineExecutableInternalRepresentationKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV = VkStructureType.GraphicsShaderGroupCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV = VkStructureType.GraphicsPipelineShaderGroupsCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV = VkStructureType.IndirectCommandsLayoutTokenNV;
        public const VkStructureType VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV = VkStructureType.IndirectCommandsLayoutCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV = VkStructureType.GeneratedCommandsInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV = VkStructureType.GeneratedCommandsMemoryRequirementsInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT = VkStructureType.PhysicalDeviceTexelBufferAlignmentFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT = VkStructureType.PhysicalDeviceTexelBufferAlignmentPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM = VkStructureType.CommandBufferInheritanceRenderPassTransformInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM = VkStructureType.RenderPassTransformBeginInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT = VkStructureType.PhysicalDeviceDeviceMemoryReportFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT = VkStructureType.DeviceDeviceMemoryReportCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT = VkStructureType.DeviceMemoryReportCallbackDataEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT = VkStructureType.PhysicalDeviceRobustness2FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT = VkStructureType.PhysicalDeviceRobustness2PropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT = VkStructureType.SamplerCustomBorderColorCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT = VkStructureType.PhysicalDeviceCustomBorderColorPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT = VkStructureType.PhysicalDeviceCustomBorderColorFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR = VkStructureType.PipelineLibraryCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT = VkStructureType.PhysicalDevicePrivateDataFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT = VkStructureType.DevicePrivateDataCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT = VkStructureType.PrivateDataSlotCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT = VkStructureType.PhysicalDevicePipelineCreationCacheControlFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV = VkStructureType.PhysicalDeviceDiagnosticsConfigFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV = VkStructureType.DeviceDiagnosticsConfigCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_RESERVED_QCOM = VkStructureType.ReservedQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV = VkStructureType.PipelineFragmentShadingRateEnumStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMap2FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMap2PropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM = VkStructureType.CopyCommandTransformInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT = VkStructureType.PhysicalDeviceImageRobustnessFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR = VkStructureType.CopyBufferInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR = VkStructureType.CopyImageInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR = VkStructureType.CopyBufferToImageInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR = VkStructureType.CopyImageToBufferInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR = VkStructureType.BlitImageInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR = VkStructureType.ResolveImageInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR = VkStructureType.BufferCopy2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR = VkStructureType.ImageCopy2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR = VkStructureType.ImageBlit2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR = VkStructureType.BufferImageCopy2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR = VkStructureType.ImageResolve2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT = VkStructureType.PhysicalDevice4444FormatsFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT = VkStructureType.DirectfbSurfaceCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE = VkStructureType.PhysicalDeviceMutableDescriptorTypeFeaturesValve;
        public const VkStructureType VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE = VkStructureType.MutableDescriptorTypeCreateInfoValve;
    }

    public enum VkSubpassContents
    {
        Inline = 0,
        SecondaryCommandBuffers = 1,
    }
    public static partial class RawConstants
    {
        public const VkSubpassContents VK_SUBPASS_CONTENTS_INLINE = VkSubpassContents.Inline;
        public const VkSubpassContents VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS = VkSubpassContents.SecondaryCommandBuffers;
    }

    public enum VkResult
    {
        ///<summary>Command completed successfully</summary>
        Success = 0,
        ///<summary>A fence or query has not yet completed</summary>
        NotReady = 1,
        ///<summary>A wait operation has not completed in the specified time</summary>
        Timeout = 2,
        ///<summary>An event is signaled</summary>
        EventSet = 3,
        ///<summary>An event is unsignaled</summary>
        EventReset = 4,
        ///<summary>A return array was too small for the result</summary>
        Incomplete = 5,
        ///<summary>A host memory allocation has failed</summary>
        ErrorOutOfHostMemory = -1,
        ///<summary>A device memory allocation has failed</summary>
        ErrorOutOfDeviceMemory = -2,
        ///<summary>Initialization of a object has failed</summary>
        ErrorInitializationFailed = -3,
        ///<summary>The logical device has been lost. See <<devsandqueues-lost-device>></summary>
        ErrorDeviceLost = -4,
        ///<summary>Mapping of a memory object has failed</summary>
        ErrorMemoryMapFailed = -5,
        ///<summary>Layer specified does not exist</summary>
        ErrorLayerNotPresent = -6,
        ///<summary>Extension specified does not exist</summary>
        ErrorExtensionNotPresent = -7,
        ///<summary>Requested feature is not available on this device</summary>
        ErrorFeatureNotPresent = -8,
        ///<summary>Unable to find a Vulkan driver</summary>
        ErrorIncompatibleDriver = -9,
        ///<summary>Too many objects of the type have already been created</summary>
        ErrorTooManyObjects = -10,
        ///<summary>Requested format is not supported on this device</summary>
        ErrorFormatNotSupported = -11,
        ///<summary>A requested pool allocation has failed due to fragmentation of the pool's memory</summary>
        ErrorFragmentedPool = -12,
        ///<summary>An unknown error has occurred, due to an implementation or application bug</summary>
        ErrorUnknown = -13,
        ErrorSurfaceLostKHR = -1000000000,
        ErrorNativeWindowInUseKHR = -1000000001,
        SuboptimalKHR = 1000001003,
        ErrorOutOfDateKHR = -1000001004,
        ErrorIncompatibleDisplayKHR = -1000003001,
        ErrorValidationFailedEXT = -1000011001,
        ErrorInvalidShaderNV = -1000012000,
        ErrorInvalidDrmFormatModifierPlaneLayoutEXT = -1000158000,
        ErrorNotPermittedEXT = -1000174001,
        ErrorFullScreenExclusiveModeLostEXT = -1000255000,
        ThreadIdleKHR = 1000268000,
        ThreadDoneKHR = 1000268001,
        OperationDeferredKHR = 1000268002,
        OperationNotDeferredKHR = 1000268003,
        PipelineCompileRequiredEXT = 1000297000,
    }
    public static partial class RawConstants
    {
        ///<summary>Command completed successfully</summary>
        public const VkResult VK_SUCCESS = VkResult.Success;
        ///<summary>A fence or query has not yet completed</summary>
        public const VkResult VK_NOT_READY = VkResult.NotReady;
        ///<summary>A wait operation has not completed in the specified time</summary>
        public const VkResult VK_TIMEOUT = VkResult.Timeout;
        ///<summary>An event is signaled</summary>
        public const VkResult VK_EVENT_SET = VkResult.EventSet;
        ///<summary>An event is unsignaled</summary>
        public const VkResult VK_EVENT_RESET = VkResult.EventReset;
        ///<summary>A return array was too small for the result</summary>
        public const VkResult VK_INCOMPLETE = VkResult.Incomplete;
        ///<summary>A host memory allocation has failed</summary>
        public const VkResult VK_ERROR_OUT_OF_HOST_MEMORY = VkResult.ErrorOutOfHostMemory;
        ///<summary>A device memory allocation has failed</summary>
        public const VkResult VK_ERROR_OUT_OF_DEVICE_MEMORY = VkResult.ErrorOutOfDeviceMemory;
        ///<summary>Initialization of a object has failed</summary>
        public const VkResult VK_ERROR_INITIALIZATION_FAILED = VkResult.ErrorInitializationFailed;
        ///<summary>The logical device has been lost. See <<devsandqueues-lost-device>></summary>
        public const VkResult VK_ERROR_DEVICE_LOST = VkResult.ErrorDeviceLost;
        ///<summary>Mapping of a memory object has failed</summary>
        public const VkResult VK_ERROR_MEMORY_MAP_FAILED = VkResult.ErrorMemoryMapFailed;
        ///<summary>Layer specified does not exist</summary>
        public const VkResult VK_ERROR_LAYER_NOT_PRESENT = VkResult.ErrorLayerNotPresent;
        ///<summary>Extension specified does not exist</summary>
        public const VkResult VK_ERROR_EXTENSION_NOT_PRESENT = VkResult.ErrorExtensionNotPresent;
        ///<summary>Requested feature is not available on this device</summary>
        public const VkResult VK_ERROR_FEATURE_NOT_PRESENT = VkResult.ErrorFeatureNotPresent;
        ///<summary>Unable to find a Vulkan driver</summary>
        public const VkResult VK_ERROR_INCOMPATIBLE_DRIVER = VkResult.ErrorIncompatibleDriver;
        ///<summary>Too many objects of the type have already been created</summary>
        public const VkResult VK_ERROR_TOO_MANY_OBJECTS = VkResult.ErrorTooManyObjects;
        ///<summary>Requested format is not supported on this device</summary>
        public const VkResult VK_ERROR_FORMAT_NOT_SUPPORTED = VkResult.ErrorFormatNotSupported;
        ///<summary>A requested pool allocation has failed due to fragmentation of the pool's memory</summary>
        public const VkResult VK_ERROR_FRAGMENTED_POOL = VkResult.ErrorFragmentedPool;
        ///<summary>An unknown error has occurred, due to an implementation or application bug</summary>
        public const VkResult VK_ERROR_UNKNOWN = VkResult.ErrorUnknown;
        public const VkResult VK_ERROR_SURFACE_LOST_KHR = VkResult.ErrorSurfaceLostKHR;
        public const VkResult VK_ERROR_NATIVE_WINDOW_IN_USE_KHR = VkResult.ErrorNativeWindowInUseKHR;
        public const VkResult VK_SUBOPTIMAL_KHR = VkResult.SuboptimalKHR;
        public const VkResult VK_ERROR_OUT_OF_DATE_KHR = VkResult.ErrorOutOfDateKHR;
        public const VkResult VK_ERROR_INCOMPATIBLE_DISPLAY_KHR = VkResult.ErrorIncompatibleDisplayKHR;
        public const VkResult VK_ERROR_VALIDATION_FAILED_EXT = VkResult.ErrorValidationFailedEXT;
        public const VkResult VK_ERROR_INVALID_SHADER_NV = VkResult.ErrorInvalidShaderNV;
        public const VkResult VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT = VkResult.ErrorInvalidDrmFormatModifierPlaneLayoutEXT;
        public const VkResult VK_ERROR_NOT_PERMITTED_EXT = VkResult.ErrorNotPermittedEXT;
        public const VkResult VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT = VkResult.ErrorFullScreenExclusiveModeLostEXT;
        public const VkResult VK_THREAD_IDLE_KHR = VkResult.ThreadIdleKHR;
        public const VkResult VK_THREAD_DONE_KHR = VkResult.ThreadDoneKHR;
        public const VkResult VK_OPERATION_DEFERRED_KHR = VkResult.OperationDeferredKHR;
        public const VkResult VK_OPERATION_NOT_DEFERRED_KHR = VkResult.OperationNotDeferredKHR;
        public const VkResult VK_PIPELINE_COMPILE_REQUIRED_EXT = VkResult.PipelineCompileRequiredEXT;
    }

    public enum VkDynamicState
    {
        Viewport = 0,
        Scissor = 1,
        LineWidth = 2,
        DepthBias = 3,
        BlendConstants = 4,
        DepthBounds = 5,
        StencilCompareMask = 6,
        StencilWriteMask = 7,
        StencilReference = 8,
        ViewportWScalingNV = 1000087000,
        DiscardRectangleEXT = 1000099000,
        SampleLocationsEXT = 1000143000,
        RayTracingPipelineStackSizeKHR = 1000347000,
        ViewportShadingRatePaletteNV = 1000164004,
        ViewportCoarseSampleOrderNV = 1000164006,
        ExclusiveScissorNV = 1000205001,
        FragmentShadingRateKHR = 1000226000,
        LineStippleEXT = 1000259000,
        CullModeEXT = 1000267000,
        FrontFaceEXT = 1000267001,
        PrimitiveTopologyEXT = 1000267002,
        ViewportWithCountEXT = 1000267003,
        ScissorWithCountEXT = 1000267004,
        VertexInputBindingStrideEXT = 1000267005,
        DepthTestEnableEXT = 1000267006,
        DepthWriteEnableEXT = 1000267007,
        DepthCompareOpEXT = 1000267008,
        DepthBoundsTestEnableEXT = 1000267009,
        StencilTestEnableEXT = 1000267010,
        StencilOpEXT = 1000267011,
    }
    public static partial class RawConstants
    {
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT = VkDynamicState.Viewport;
        public const VkDynamicState VK_DYNAMIC_STATE_SCISSOR = VkDynamicState.Scissor;
        public const VkDynamicState VK_DYNAMIC_STATE_LINE_WIDTH = VkDynamicState.LineWidth;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_BIAS = VkDynamicState.DepthBias;
        public const VkDynamicState VK_DYNAMIC_STATE_BLEND_CONSTANTS = VkDynamicState.BlendConstants;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_BOUNDS = VkDynamicState.DepthBounds;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = VkDynamicState.StencilCompareMask;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = VkDynamicState.StencilWriteMask;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_REFERENCE = VkDynamicState.StencilReference;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = VkDynamicState.ViewportWScalingNV;
        public const VkDynamicState VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = VkDynamicState.DiscardRectangleEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = VkDynamicState.SampleLocationsEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR = VkDynamicState.RayTracingPipelineStackSizeKHR;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = VkDynamicState.ViewportShadingRatePaletteNV;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = VkDynamicState.ViewportCoarseSampleOrderNV;
        public const VkDynamicState VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = VkDynamicState.ExclusiveScissorNV;
        public const VkDynamicState VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR = VkDynamicState.FragmentShadingRateKHR;
        public const VkDynamicState VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = VkDynamicState.LineStippleEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_CULL_MODE_EXT = VkDynamicState.CullModeEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_FRONT_FACE_EXT = VkDynamicState.FrontFaceEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT = VkDynamicState.PrimitiveTopologyEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT = VkDynamicState.ViewportWithCountEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT = VkDynamicState.ScissorWithCountEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT = VkDynamicState.VertexInputBindingStrideEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT = VkDynamicState.DepthTestEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT = VkDynamicState.DepthWriteEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT = VkDynamicState.DepthCompareOpEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT = VkDynamicState.DepthBoundsTestEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT = VkDynamicState.StencilTestEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_OP_EXT = VkDynamicState.StencilOpEXT;
    }

    public enum VkDescriptorUpdateTemplateType
    {
        ///<summary>Create descriptor update template for descriptor set updates</summary>
        DescriptorSet = 0,
        ///<summary>Create descriptor update template for pushed descriptor updates</summary>
        PushDescriptorsKHR = 1,
        ///<summary>Create descriptor update template for pushed descriptor updates</summary>
        PushDescriptorsKHR = 1,
        ///<summary>Create descriptor update template for pushed descriptor updates</summary>
        PushDescriptorsKHR = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Create descriptor update template for descriptor set updates</summary>
        public const VkDescriptorUpdateTemplateType VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET = VkDescriptorUpdateTemplateType.DescriptorSet;
        ///<summary>Create descriptor update template for pushed descriptor updates</summary>
        public const VkDescriptorUpdateTemplateType VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR = VkDescriptorUpdateTemplateType.PushDescriptorsKHR;
        ///<summary>Create descriptor update template for pushed descriptor updates</summary>
        public const VkDescriptorUpdateTemplateType VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR = VkDescriptorUpdateTemplateType.PushDescriptorsKHR;
        ///<summary>Create descriptor update template for pushed descriptor updates</summary>
        public const VkDescriptorUpdateTemplateType VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR = VkDescriptorUpdateTemplateType.PushDescriptorsKHR;
    }

    public enum VkObjectType
    {
        Unknown = 0,
        Instance = 1,
        PhysicalDevice = 2,
        Device = 3,
        Queue = 4,
        Semaphore = 5,
        CommandBuffer = 6,
        Fence = 7,
        DeviceMemory = 8,
        Buffer = 9,
        Image = 10,
        Event = 11,
        QueryPool = 12,
        BufferView = 13,
        ImageView = 14,
        ShaderModule = 15,
        PipelineCache = 16,
        PipelineLayout = 17,
        RenderPass = 18,
        Pipeline = 19,
        DescriptorSetLayout = 20,
        Sampler = 21,
        DescriptorPool = 22,
        DescriptorSet = 23,
        Framebuffer = 24,
        CommandPool = 25,
        SurfaceKHR = 1000000000,
        SwapchainKHR = 1000001000,
        DisplayKHR = 1000002000,
        DisplayModeKHR = 1000002001,
        DebugReportCallbackEXT = 1000011000,
        DebugUtilsMessengerEXT = 1000128000,
        AccelerationStructureKHR = 1000150000,
        ValidationCacheEXT = 1000160000,
        AccelerationStructureNV = 1000165000,
        PerformanceConfigurationIntel = 1000210000,
        DeferredOperationKHR = 1000268000,
        IndirectCommandsLayoutNV = 1000277000,
        PrivateDataSlotEXT = 1000295000,
    }
    public static partial class RawConstants
    {
        public const VkObjectType VK_OBJECT_TYPE_UNKNOWN = VkObjectType.Unknown;
        public const VkObjectType VK_OBJECT_TYPE_INSTANCE = VkObjectType.Instance;
        public const VkObjectType VK_OBJECT_TYPE_PHYSICAL_DEVICE = VkObjectType.PhysicalDevice;
        public const VkObjectType VK_OBJECT_TYPE_DEVICE = VkObjectType.Device;
        public const VkObjectType VK_OBJECT_TYPE_QUEUE = VkObjectType.Queue;
        public const VkObjectType VK_OBJECT_TYPE_SEMAPHORE = VkObjectType.Semaphore;
        public const VkObjectType VK_OBJECT_TYPE_COMMAND_BUFFER = VkObjectType.CommandBuffer;
        public const VkObjectType VK_OBJECT_TYPE_FENCE = VkObjectType.Fence;
        public const VkObjectType VK_OBJECT_TYPE_DEVICE_MEMORY = VkObjectType.DeviceMemory;
        public const VkObjectType VK_OBJECT_TYPE_BUFFER = VkObjectType.Buffer;
        public const VkObjectType VK_OBJECT_TYPE_IMAGE = VkObjectType.Image;
        public const VkObjectType VK_OBJECT_TYPE_EVENT = VkObjectType.Event;
        public const VkObjectType VK_OBJECT_TYPE_QUERY_POOL = VkObjectType.QueryPool;
        public const VkObjectType VK_OBJECT_TYPE_BUFFER_VIEW = VkObjectType.BufferView;
        public const VkObjectType VK_OBJECT_TYPE_IMAGE_VIEW = VkObjectType.ImageView;
        public const VkObjectType VK_OBJECT_TYPE_SHADER_MODULE = VkObjectType.ShaderModule;
        public const VkObjectType VK_OBJECT_TYPE_PIPELINE_CACHE = VkObjectType.PipelineCache;
        public const VkObjectType VK_OBJECT_TYPE_PIPELINE_LAYOUT = VkObjectType.PipelineLayout;
        public const VkObjectType VK_OBJECT_TYPE_RENDER_PASS = VkObjectType.RenderPass;
        public const VkObjectType VK_OBJECT_TYPE_PIPELINE = VkObjectType.Pipeline;
        public const VkObjectType VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT = VkObjectType.DescriptorSetLayout;
        public const VkObjectType VK_OBJECT_TYPE_SAMPLER = VkObjectType.Sampler;
        public const VkObjectType VK_OBJECT_TYPE_DESCRIPTOR_POOL = VkObjectType.DescriptorPool;
        public const VkObjectType VK_OBJECT_TYPE_DESCRIPTOR_SET = VkObjectType.DescriptorSet;
        public const VkObjectType VK_OBJECT_TYPE_FRAMEBUFFER = VkObjectType.Framebuffer;
        public const VkObjectType VK_OBJECT_TYPE_COMMAND_POOL = VkObjectType.CommandPool;
        public const VkObjectType VK_OBJECT_TYPE_SURFACE_KHR = VkObjectType.SurfaceKHR;
        public const VkObjectType VK_OBJECT_TYPE_SWAPCHAIN_KHR = VkObjectType.SwapchainKHR;
        public const VkObjectType VK_OBJECT_TYPE_DISPLAY_KHR = VkObjectType.DisplayKHR;
        public const VkObjectType VK_OBJECT_TYPE_DISPLAY_MODE_KHR = VkObjectType.DisplayModeKHR;
        public const VkObjectType VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT = VkObjectType.DebugReportCallbackEXT;
        public const VkObjectType VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = VkObjectType.DebugUtilsMessengerEXT;
        public const VkObjectType VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR = VkObjectType.AccelerationStructureKHR;
        public const VkObjectType VK_OBJECT_TYPE_VALIDATION_CACHE_EXT = VkObjectType.ValidationCacheEXT;
        public const VkObjectType VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV = VkObjectType.AccelerationStructureNV;
        public const VkObjectType VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL = VkObjectType.PerformanceConfigurationIntel;
        public const VkObjectType VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR = VkObjectType.DeferredOperationKHR;
        public const VkObjectType VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV = VkObjectType.IndirectCommandsLayoutNV;
        public const VkObjectType VK_OBJECT_TYPE_PRIVATE_DATA_SLOT_EXT = VkObjectType.PrivateDataSlotEXT;
    }

    [Flags]
    public enum VkQueueFlags
    {
        None = 0,
        ///<summary>Queue supports graphics operations</summary>
        Graphics = 1,
        ///<summary>Queue supports compute operations</summary>
        Compute = 2,
        ///<summary>Queue supports transfer operations</summary>
        Transfer = 4,
        ///<summary>Queue supports sparse resource memory management operations</summary>
        SparseBinding = 8,
        Reserved6KHR = 64,
        Reserved5KHR = 32,
    }
    public static partial class RawConstants
    {
        ///<summary>Queue supports graphics operations</summary>
        public const VkQueueFlags VK_QUEUE_GRAPHICS_BIT = VkQueueFlags.Graphics;
        ///<summary>Queue supports compute operations</summary>
        public const VkQueueFlags VK_QUEUE_COMPUTE_BIT = VkQueueFlags.Compute;
        ///<summary>Queue supports transfer operations</summary>
        public const VkQueueFlags VK_QUEUE_TRANSFER_BIT = VkQueueFlags.Transfer;
        ///<summary>Queue supports sparse resource memory management operations</summary>
        public const VkQueueFlags VK_QUEUE_SPARSE_BINDING_BIT = VkQueueFlags.SparseBinding;
        public const VkQueueFlags VK_QUEUE_RESERVED_6_BIT_KHR = VkQueueFlags.Reserved6KHR;
        public const VkQueueFlags VK_QUEUE_RESERVED_5_BIT_KHR = VkQueueFlags.Reserved5KHR;
    }

    [Flags]
    public enum VkCullModeFlags
    {
        None = 0,
        Front = 1,
        Back = 2,
        FrontAndBack = 3,
    }
    public static partial class RawConstants
    {
        public const VkCullModeFlags VK_CULL_MODE_NONE = VkCullModeFlags.None;
        public const VkCullModeFlags VK_CULL_MODE_FRONT_BIT = VkCullModeFlags.Front;
        public const VkCullModeFlags VK_CULL_MODE_BACK_BIT = VkCullModeFlags.Back;
        public const VkCullModeFlags VK_CULL_MODE_FRONT_AND_BACK = VkCullModeFlags.FrontAndBack;
    }

    [Flags]
    public enum VkRenderPassCreateFlags
    {
        None = 0,
        Reserved0KHR = 1,
        TransformQcom = 2,
    }
    public static partial class RawConstants
    {
        public const VkRenderPassCreateFlags VK_RENDER_PASS_CREATE_RESERVED_0_BIT_KHR = VkRenderPassCreateFlags.Reserved0KHR;
        public const VkRenderPassCreateFlags VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM = VkRenderPassCreateFlags.TransformQcom;
    }

    [Flags]
    public enum VkDeviceQueueCreateFlags
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkMemoryPropertyFlags
    {
        None = 0,
        ///<summary>If otherwise stated, then allocate memory on device</summary>
        DeviceLocal = 1,
        ///<summary>Memory is mappable by host</summary>
        HostVisible = 2,
        ///<summary>Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache</summary>
        HostCoherent = 4,
        ///<summary>Memory will be cached by the host</summary>
        HostCached = 8,
        ///<summary>Memory may be allocated by the driver when it is required</summary>
        LazilyAllocated = 16,
        DeviceCoherentAMD = 64,
        DeviceUncachedAMD = 128,
    }
    public static partial class RawConstants
    {
        ///<summary>If otherwise stated, then allocate memory on device</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = VkMemoryPropertyFlags.DeviceLocal;
        ///<summary>Memory is mappable by host</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = VkMemoryPropertyFlags.HostVisible;
        ///<summary>Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = VkMemoryPropertyFlags.HostCoherent;
        ///<summary>Memory will be cached by the host</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_HOST_CACHED_BIT = VkMemoryPropertyFlags.HostCached;
        ///<summary>Memory may be allocated by the driver when it is required</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = VkMemoryPropertyFlags.LazilyAllocated;
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD = VkMemoryPropertyFlags.DeviceCoherentAMD;
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD = VkMemoryPropertyFlags.DeviceUncachedAMD;
    }

    [Flags]
    public enum VkMemoryHeapFlags
    {
        None = 0,
        ///<summary>If set, heap represents device memory</summary>
        DeviceLocal = 1,
        Reserved2KHR = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>If set, heap represents device memory</summary>
        public const VkMemoryHeapFlags VK_MEMORY_HEAP_DEVICE_LOCAL_BIT = VkMemoryHeapFlags.DeviceLocal;
        public const VkMemoryHeapFlags VK_MEMORY_HEAP_RESERVED_2_BIT_KHR = VkMemoryHeapFlags.Reserved2KHR;
    }

    [Flags]
    public enum VkAccessFlags
    {
        None = 0,
        ///<summary>Controls coherency of indirect command reads</summary>
        IndirectCommandRead = 1,
        ///<summary>Controls coherency of index reads</summary>
        IndexRead = 2,
        ///<summary>Controls coherency of vertex attribute reads</summary>
        VertexAttributeRead = 4,
        ///<summary>Controls coherency of uniform buffer reads</summary>
        UniformRead = 8,
        ///<summary>Controls coherency of input attachment reads</summary>
        InputAttachmentRead = 16,
        ///<summary>Controls coherency of shader reads</summary>
        ShaderRead = 32,
        ///<summary>Controls coherency of shader writes</summary>
        ShaderWrite = 64,
        ///<summary>Controls coherency of color attachment reads</summary>
        ColorAttachmentRead = 128,
        ///<summary>Controls coherency of color attachment writes</summary>
        ColorAttachmentWrite = 256,
        ///<summary>Controls coherency of depth/stencil attachment reads</summary>
        DepthStencilAttachmentRead = 512,
        ///<summary>Controls coherency of depth/stencil attachment writes</summary>
        DepthStencilAttachmentWrite = 1024,
        ///<summary>Controls coherency of transfer reads</summary>
        TransferRead = 2048,
        ///<summary>Controls coherency of transfer writes</summary>
        TransferWrite = 4096,
        ///<summary>Controls coherency of host reads</summary>
        HostRead = 8192,
        ///<summary>Controls coherency of host writes</summary>
        HostWrite = 16384,
        ///<summary>Controls coherency of memory reads</summary>
        MemoryRead = 32768,
        ///<summary>Controls coherency of memory writes</summary>
        MemoryWrite = 65536,
        Reserved30KHR = 1073741824,
        Reserved28KHR = 268435456,
        Reserved29KHR = 536870912,
        TransformFeedbackWriteEXT = 33554432,
        TransformFeedbackCounterReadEXT = 67108864,
        TransformFeedbackCounterWriteEXT = 134217728,
        ///<summary>read access flag for reading conditional rendering predicate</summary>
        ConditionalRenderingReadEXT = 1048576,
        ColorAttachmentReadNoncoherentEXT = 524288,
        AccelerationStructureReadKHR = 2097152,
        AccelerationStructureWriteKHR = 4194304,
        ShadingRateImageReadNV = 8388608,
        FragmentDensityMapReadEXT = 16777216,
        CommandPreprocessReadNV = 131072,
        CommandPreprocessWriteNV = 262144,
    }
    public static partial class RawConstants
    {
        ///<summary>Controls coherency of indirect command reads</summary>
        public const VkAccessFlags VK_ACCESS_INDIRECT_COMMAND_READ_BIT = VkAccessFlags.IndirectCommandRead;
        ///<summary>Controls coherency of index reads</summary>
        public const VkAccessFlags VK_ACCESS_INDEX_READ_BIT = VkAccessFlags.IndexRead;
        ///<summary>Controls coherency of vertex attribute reads</summary>
        public const VkAccessFlags VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT = VkAccessFlags.VertexAttributeRead;
        ///<summary>Controls coherency of uniform buffer reads</summary>
        public const VkAccessFlags VK_ACCESS_UNIFORM_READ_BIT = VkAccessFlags.UniformRead;
        ///<summary>Controls coherency of input attachment reads</summary>
        public const VkAccessFlags VK_ACCESS_INPUT_ATTACHMENT_READ_BIT = VkAccessFlags.InputAttachmentRead;
        ///<summary>Controls coherency of shader reads</summary>
        public const VkAccessFlags VK_ACCESS_SHADER_READ_BIT = VkAccessFlags.ShaderRead;
        ///<summary>Controls coherency of shader writes</summary>
        public const VkAccessFlags VK_ACCESS_SHADER_WRITE_BIT = VkAccessFlags.ShaderWrite;
        ///<summary>Controls coherency of color attachment reads</summary>
        public const VkAccessFlags VK_ACCESS_COLOR_ATTACHMENT_READ_BIT = VkAccessFlags.ColorAttachmentRead;
        ///<summary>Controls coherency of color attachment writes</summary>
        public const VkAccessFlags VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT = VkAccessFlags.ColorAttachmentWrite;
        ///<summary>Controls coherency of depth/stencil attachment reads</summary>
        public const VkAccessFlags VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT = VkAccessFlags.DepthStencilAttachmentRead;
        ///<summary>Controls coherency of depth/stencil attachment writes</summary>
        public const VkAccessFlags VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = VkAccessFlags.DepthStencilAttachmentWrite;
        ///<summary>Controls coherency of transfer reads</summary>
        public const VkAccessFlags VK_ACCESS_TRANSFER_READ_BIT = VkAccessFlags.TransferRead;
        ///<summary>Controls coherency of transfer writes</summary>
        public const VkAccessFlags VK_ACCESS_TRANSFER_WRITE_BIT = VkAccessFlags.TransferWrite;
        ///<summary>Controls coherency of host reads</summary>
        public const VkAccessFlags VK_ACCESS_HOST_READ_BIT = VkAccessFlags.HostRead;
        ///<summary>Controls coherency of host writes</summary>
        public const VkAccessFlags VK_ACCESS_HOST_WRITE_BIT = VkAccessFlags.HostWrite;
        ///<summary>Controls coherency of memory reads</summary>
        public const VkAccessFlags VK_ACCESS_MEMORY_READ_BIT = VkAccessFlags.MemoryRead;
        ///<summary>Controls coherency of memory writes</summary>
        public const VkAccessFlags VK_ACCESS_MEMORY_WRITE_BIT = VkAccessFlags.MemoryWrite;
        public const VkAccessFlags VK_ACCESS_RESERVED_30_BIT_KHR = VkAccessFlags.Reserved30KHR;
        public const VkAccessFlags VK_ACCESS_RESERVED_28_BIT_KHR = VkAccessFlags.Reserved28KHR;
        public const VkAccessFlags VK_ACCESS_RESERVED_29_BIT_KHR = VkAccessFlags.Reserved29KHR;
        public const VkAccessFlags VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = VkAccessFlags.TransformFeedbackWriteEXT;
        public const VkAccessFlags VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = VkAccessFlags.TransformFeedbackCounterReadEXT;
        public const VkAccessFlags VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = VkAccessFlags.TransformFeedbackCounterWriteEXT;
        ///<summary>read access flag for reading conditional rendering predicate</summary>
        public const VkAccessFlags VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT = VkAccessFlags.ConditionalRenderingReadEXT;
        public const VkAccessFlags VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = VkAccessFlags.ColorAttachmentReadNoncoherentEXT;
        public const VkAccessFlags VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR = VkAccessFlags.AccelerationStructureReadKHR;
        public const VkAccessFlags VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = VkAccessFlags.AccelerationStructureWriteKHR;
        public const VkAccessFlags VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV = VkAccessFlags.ShadingRateImageReadNV;
        public const VkAccessFlags VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = VkAccessFlags.FragmentDensityMapReadEXT;
        public const VkAccessFlags VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_NV = VkAccessFlags.CommandPreprocessReadNV;
        public const VkAccessFlags VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_NV = VkAccessFlags.CommandPreprocessWriteNV;
    }

    [Flags]
    public enum VkBufferUsageFlags
    {
        None = 0,
        ///<summary>Can be used as a source of transfer operations</summary>
        TransferSrc = 1,
        ///<summary>Can be used as a destination of transfer operations</summary>
        TransferDst = 2,
        ///<summary>Can be used as TBO</summary>
        UniformTexelBuffer = 4,
        ///<summary>Can be used as IBO</summary>
        StorageTexelBuffer = 8,
        ///<summary>Can be used as UBO</summary>
        UniformBuffer = 16,
        ///<summary>Can be used as SSBO</summary>
        StorageBuffer = 32,
        ///<summary>Can be used as source of fixed-function index fetch (index buffer)</summary>
        IndexBuffer = 64,
        ///<summary>Can be used as source of fixed-function vertex fetch (VBO)</summary>
        VertexBuffer = 128,
        ///<summary>Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)</summary>
        IndirectBuffer = 256,
        Reserved15KHR = 32768,
        Reserved16KHR = 65536,
        Reserved13KHR = 8192,
        Reserved14KHR = 16384,
        TransformFeedbackBufferEXT = 2048,
        TransformFeedbackCounterBufferEXT = 4096,
        ///<summary>Specifies the buffer can be used as predicate in conditional rendering</summary>
        ConditionalRenderingEXT = 512,
        AccelerationStructureBuildInputReadOnlyKHR = 524288,
        AccelerationStructureStorageKHR = 1048576,
        ShaderBindingTableKHR = 1024,
        Reserved18Qcom = 262144,
    }
    public static partial class RawConstants
    {
        ///<summary>Can be used as a source of transfer operations</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFER_SRC_BIT = VkBufferUsageFlags.TransferSrc;
        ///<summary>Can be used as a destination of transfer operations</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFER_DST_BIT = VkBufferUsageFlags.TransferDst;
        ///<summary>Can be used as TBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = VkBufferUsageFlags.UniformTexelBuffer;
        ///<summary>Can be used as IBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = VkBufferUsageFlags.StorageTexelBuffer;
        ///<summary>Can be used as UBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = VkBufferUsageFlags.UniformBuffer;
        ///<summary>Can be used as SSBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = VkBufferUsageFlags.StorageBuffer;
        ///<summary>Can be used as source of fixed-function index fetch (index buffer)</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_INDEX_BUFFER_BIT = VkBufferUsageFlags.IndexBuffer;
        ///<summary>Can be used as source of fixed-function vertex fetch (VBO)</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = VkBufferUsageFlags.VertexBuffer;
        ///<summary>Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = VkBufferUsageFlags.IndirectBuffer;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESERVED_15_BIT_KHR = VkBufferUsageFlags.Reserved15KHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESERVED_16_BIT_KHR = VkBufferUsageFlags.Reserved16KHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESERVED_13_BIT_KHR = VkBufferUsageFlags.Reserved13KHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESERVED_14_BIT_KHR = VkBufferUsageFlags.Reserved14KHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = VkBufferUsageFlags.TransformFeedbackBufferEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = VkBufferUsageFlags.TransformFeedbackCounterBufferEXT;
        ///<summary>Specifies the buffer can be used as predicate in conditional rendering</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT = VkBufferUsageFlags.ConditionalRenderingEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = VkBufferUsageFlags.AccelerationStructureBuildInputReadOnlyKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = VkBufferUsageFlags.AccelerationStructureStorageKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR = VkBufferUsageFlags.ShaderBindingTableKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESERVED_18_BIT_QCOM = VkBufferUsageFlags.Reserved18Qcom;
    }

    [Flags]
    public enum VkBufferCreateFlags
    {
        None = 0,
        ///<summary>Buffer should support sparse backing</summary>
        SparseBinding = 1,
        ///<summary>Buffer should support sparse backing with partial residency</summary>
        SparseResidency = 2,
        ///<summary>Buffer should support constent data access to physical memory ranges mapped into multiple locations of sparse buffers</summary>
        SparseAliased = 4,
        Reserved5NV = 32,
    }
    public static partial class RawConstants
    {
        ///<summary>Buffer should support sparse backing</summary>
        public const VkBufferCreateFlags VK_BUFFER_CREATE_SPARSE_BINDING_BIT = VkBufferCreateFlags.SparseBinding;
        ///<summary>Buffer should support sparse backing with partial residency</summary>
        public const VkBufferCreateFlags VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = VkBufferCreateFlags.SparseResidency;
        ///<summary>Buffer should support constent data access to physical memory ranges mapped into multiple locations of sparse buffers</summary>
        public const VkBufferCreateFlags VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = VkBufferCreateFlags.SparseAliased;
        public const VkBufferCreateFlags VK_BUFFER_CREATE_RESERVED_5_BIT_NV = VkBufferCreateFlags.Reserved5NV;
    }

    [Flags]
    public enum VkShaderStageFlags
    {
        None = 0,
        Vertex = 1,
        TessellationControl = 2,
        TessellationEvaluation = 4,
        Geometry = 8,
        Fragment = 16,
        Compute = 32,
        AllGraphics = 31,
        All = 2147483647,
        RaygenKHR = 256,
        AnyHitKHR = 512,
        ClosestHitKHR = 1024,
        MissKHR = 2048,
        IntersectionKHR = 4096,
        CallableKHR = 8192,
        TaskNV = 64,
        MeshNV = 128,
    }
    public static partial class RawConstants
    {
        public const VkShaderStageFlags VK_SHADER_STAGE_VERTEX_BIT = VkShaderStageFlags.Vertex;
        public const VkShaderStageFlags VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = VkShaderStageFlags.TessellationControl;
        public const VkShaderStageFlags VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = VkShaderStageFlags.TessellationEvaluation;
        public const VkShaderStageFlags VK_SHADER_STAGE_GEOMETRY_BIT = VkShaderStageFlags.Geometry;
        public const VkShaderStageFlags VK_SHADER_STAGE_FRAGMENT_BIT = VkShaderStageFlags.Fragment;
        public const VkShaderStageFlags VK_SHADER_STAGE_COMPUTE_BIT = VkShaderStageFlags.Compute;
        public const VkShaderStageFlags VK_SHADER_STAGE_ALL_GRAPHICS = VkShaderStageFlags.AllGraphics;
        public const VkShaderStageFlags VK_SHADER_STAGE_ALL = VkShaderStageFlags.All;
        public const VkShaderStageFlags VK_SHADER_STAGE_RAYGEN_BIT_KHR = VkShaderStageFlags.RaygenKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_ANY_HIT_BIT_KHR = VkShaderStageFlags.AnyHitKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR = VkShaderStageFlags.ClosestHitKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_MISS_BIT_KHR = VkShaderStageFlags.MissKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_INTERSECTION_BIT_KHR = VkShaderStageFlags.IntersectionKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_CALLABLE_BIT_KHR = VkShaderStageFlags.CallableKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_TASK_BIT_NV = VkShaderStageFlags.TaskNV;
        public const VkShaderStageFlags VK_SHADER_STAGE_MESH_BIT_NV = VkShaderStageFlags.MeshNV;
    }

    [Flags]
    public enum VkImageUsageFlags
    {
        None = 0,
        ///<summary>Can be used as a source of transfer operations</summary>
        TransferSrc = 1,
        ///<summary>Can be used as a destination of transfer operations</summary>
        TransferDst = 2,
        ///<summary>Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        Sampled = 4,
        ///<summary>Can be used as storage image (STORAGE_IMAGE descriptor type)</summary>
        Storage = 8,
        ///<summary>Can be used as framebuffer color attachment</summary>
        ColorAttachment = 16,
        ///<summary>Can be used as framebuffer depth/stencil attachment</summary>
        DepthStencilAttachment = 32,
        ///<summary>Image data not needed outside of rendering</summary>
        TransientAttachment = 64,
        ///<summary>Can be used as framebuffer input attachment</summary>
        InputAttachment = 128,
        Reserved13KHR = 8192,
        Reserved14KHR = 16384,
        Reserved15KHR = 32768,
        Reserved10KHR = 1024,
        Reserved11KHR = 2048,
        Reserved12KHR = 4096,
        ShadingRateImageNV = 256,
        Reserved16Qcom = 65536,
        Reserved17Qcom = 131072,
        FragmentDensityMapEXT = 512,
    }
    public static partial class RawConstants
    {
        ///<summary>Can be used as a source of transfer operations</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_TRANSFER_SRC_BIT = VkImageUsageFlags.TransferSrc;
        ///<summary>Can be used as a destination of transfer operations</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_TRANSFER_DST_BIT = VkImageUsageFlags.TransferDst;
        ///<summary>Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_SAMPLED_BIT = VkImageUsageFlags.Sampled;
        ///<summary>Can be used as storage image (STORAGE_IMAGE descriptor type)</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_STORAGE_BIT = VkImageUsageFlags.Storage;
        ///<summary>Can be used as framebuffer color attachment</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = VkImageUsageFlags.ColorAttachment;
        ///<summary>Can be used as framebuffer depth/stencil attachment</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = VkImageUsageFlags.DepthStencilAttachment;
        ///<summary>Image data not needed outside of rendering</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = VkImageUsageFlags.TransientAttachment;
        ///<summary>Can be used as framebuffer input attachment</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = VkImageUsageFlags.InputAttachment;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_13_BIT_KHR = VkImageUsageFlags.Reserved13KHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_14_BIT_KHR = VkImageUsageFlags.Reserved14KHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_15_BIT_KHR = VkImageUsageFlags.Reserved15KHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_10_BIT_KHR = VkImageUsageFlags.Reserved10KHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_11_BIT_KHR = VkImageUsageFlags.Reserved11KHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_12_BIT_KHR = VkImageUsageFlags.Reserved12KHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV = VkImageUsageFlags.ShadingRateImageNV;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_16_BIT_QCOM = VkImageUsageFlags.Reserved16Qcom;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_17_BIT_QCOM = VkImageUsageFlags.Reserved17Qcom;
        public const VkImageUsageFlags VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT = VkImageUsageFlags.FragmentDensityMapEXT;
    }

    [Flags]
    public enum VkImageCreateFlags
    {
        None = 0,
        ///<summary>Image should support sparse backing</summary>
        SparseBinding = 1,
        ///<summary>Image should support sparse backing with partial residency</summary>
        SparseResidency = 2,
        ///<summary>Image should support constent data access to physical memory ranges mapped into multiple locations of sparse images</summary>
        SparseAliased = 4,
        ///<summary>Allows image views to have different format than the base image</summary>
        MutableFormat = 8,
        ///<summary>Allows creating image views with cube type from the created image</summary>
        CubeCompatible = 16,
        CornerSampledNV = 8192,
        SampleLocationsCompatibleDepthEXT = 4096,
        SubsampledEXT = 16384,
        Reserved15NV = 32768,
    }
    public static partial class RawConstants
    {
        ///<summary>Image should support sparse backing</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_SPARSE_BINDING_BIT = VkImageCreateFlags.SparseBinding;
        ///<summary>Image should support sparse backing with partial residency</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = VkImageCreateFlags.SparseResidency;
        ///<summary>Image should support constent data access to physical memory ranges mapped into multiple locations of sparse images</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = VkImageCreateFlags.SparseAliased;
        ///<summary>Allows image views to have different format than the base image</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = VkImageCreateFlags.MutableFormat;
        ///<summary>Allows creating image views with cube type from the created image</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = VkImageCreateFlags.CubeCompatible;
        public const VkImageCreateFlags VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV = VkImageCreateFlags.CornerSampledNV;
        public const VkImageCreateFlags VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = VkImageCreateFlags.SampleLocationsCompatibleDepthEXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT = VkImageCreateFlags.SubsampledEXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_RESERVED_15_BIT_NV = VkImageCreateFlags.Reserved15NV;
    }

    [Flags]
    public enum VkImageViewCreateFlags
    {
        None = 0,
        FragmentDensityMapDynamicEXT = 1,
        FragmentDensityMapDeferredEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkImageViewCreateFlags VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT = VkImageViewCreateFlags.FragmentDensityMapDynamicEXT;
        public const VkImageViewCreateFlags VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT = VkImageViewCreateFlags.FragmentDensityMapDeferredEXT;
    }

    [Flags]
    public enum VkSamplerCreateFlags
    {
        None = 0,
        SubsampledEXT = 1,
        SubsampledCoarseReconstructionEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkSamplerCreateFlags VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = VkSamplerCreateFlags.SubsampledEXT;
        public const VkSamplerCreateFlags VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = VkSamplerCreateFlags.SubsampledCoarseReconstructionEXT;
    }

    [Flags]
    public enum VkPipelineCreateFlags
    {
        None = 0,
        DisableOptimization = 1,
        AllowDerivatives = 2,
        Derivative = 4,
        RayTracingNoNullAnyHitShadersKHR = 16384,
        RayTracingNoNullClosestHitShadersKHR = 32768,
        RayTracingNoNullMissShadersKHR = 65536,
        RayTracingNoNullIntersectionShadersKHR = 131072,
        RayTracingSkipTrianglesKHR = 4096,
        RayTracingSkipAabbsKHR = 8192,
        RayTracingShaderGroupHandleCaptureReplayKHR = 524288,
        DeferCompileNV = 32,
        CaptureStatisticsKHR = 64,
        CaptureInternalRepresentationsKHR = 128,
        IndirectBindableNV = 262144,
        LibraryKHR = 2048,
        FailOnPipelineCompileRequiredEXT = 256,
        EarlyReturnOnFailureEXT = 512,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = VkPipelineCreateFlags.DisableOptimization;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = VkPipelineCreateFlags.AllowDerivatives;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DERIVATIVE_BIT = VkPipelineCreateFlags.Derivative;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullAnyHitShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullClosestHitShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullMissShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullIntersectionShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = VkPipelineCreateFlags.RayTracingSkipTrianglesKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR = VkPipelineCreateFlags.RayTracingSkipAabbsKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = VkPipelineCreateFlags.RayTracingShaderGroupHandleCaptureReplayKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV = VkPipelineCreateFlags.DeferCompileNV;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR = VkPipelineCreateFlags.CaptureStatisticsKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = VkPipelineCreateFlags.CaptureInternalRepresentationsKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV = VkPipelineCreateFlags.IndirectBindableNV;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_LIBRARY_BIT_KHR = VkPipelineCreateFlags.LibraryKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT = VkPipelineCreateFlags.FailOnPipelineCompileRequiredEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT = VkPipelineCreateFlags.EarlyReturnOnFailureEXT;
    }

    [Flags]
    public enum VkPipelineShaderStageCreateFlags
    {
        None = 0,
        Reserved2NV = 4,
        AllowVaryingSubgroupSizeEXT = 1,
        RequireFullSubgroupsEXT = 2,
        Reserved3KHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkPipelineShaderStageCreateFlags VK_PIPELINE_SHADER_STAGE_CREATE_RESERVED_2_BIT_NV = VkPipelineShaderStageCreateFlags.Reserved2NV;
        public const VkPipelineShaderStageCreateFlags VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = VkPipelineShaderStageCreateFlags.AllowVaryingSubgroupSizeEXT;
        public const VkPipelineShaderStageCreateFlags VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = VkPipelineShaderStageCreateFlags.RequireFullSubgroupsEXT;
        public const VkPipelineShaderStageCreateFlags VK_PIPELINE_SHADER_STAGE_CREATE_RESERVED_3_BIT_KHR = VkPipelineShaderStageCreateFlags.Reserved3KHR;
    }

    [Flags]
    public enum VkColorComponentFlags
    {
        None = 0,
        R = 1,
        G = 2,
        B = 4,
        A = 8,
    }
    public static partial class RawConstants
    {
        public const VkColorComponentFlags VK_COLOR_COMPONENT_R_BIT = VkColorComponentFlags.R;
        public const VkColorComponentFlags VK_COLOR_COMPONENT_G_BIT = VkColorComponentFlags.G;
        public const VkColorComponentFlags VK_COLOR_COMPONENT_B_BIT = VkColorComponentFlags.B;
        public const VkColorComponentFlags VK_COLOR_COMPONENT_A_BIT = VkColorComponentFlags.A;
    }

    [Flags]
    public enum VkFenceCreateFlags
    {
        None = 0,
        Signaled = 1,
    }
    public static partial class RawConstants
    {
        public const VkFenceCreateFlags VK_FENCE_CREATE_SIGNALED_BIT = VkFenceCreateFlags.Signaled;
    }

    [Flags]
    public enum VkFormatFeatureFlags
    {
        None = 0,
        ///<summary>Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        SampledImage = 1,
        ///<summary>Format can be used for storage images (STORAGE_IMAGE descriptor type)</summary>
        StorageImage = 2,
        ///<summary>Format supports atomic operations in case it is used for storage images</summary>
        StorageImageAtomic = 4,
        ///<summary>Format can be used for uniform texel buffers (TBOs)</summary>
        UniformTexelBuffer = 8,
        ///<summary>Format can be used for storage texel buffers (IBOs)</summary>
        StorageTexelBuffer = 16,
        ///<summary>Format supports atomic operations in case it is used for storage texel buffers</summary>
        StorageTexelBufferAtomic = 32,
        ///<summary>Format can be used for vertex buffers (VBOs)</summary>
        VertexBuffer = 64,
        ///<summary>Format can be used for color attachment images</summary>
        ColorAttachment = 128,
        ///<summary>Format supports blending in case it is used for color attachment images</summary>
        ColorAttachmentBlend = 256,
        ///<summary>Format can be used for depth/stencil attachment images</summary>
        DepthStencilAttachment = 512,
        ///<summary>Format can be used as the source image of blits with vkCmdBlitImage</summary>
        BlitSrc = 1024,
        ///<summary>Format can be used as the destination image of blits with vkCmdBlitImage</summary>
        BlitDst = 2048,
        ///<summary>Format can be filtered with VK_FILTER_LINEAR when being sampled</summary>
        SampledImageFilterLinear = 4096,
        ///<summary>Format can be filtered with VK_FILTER_CUBIC_IMG when being sampled</summary>
        SampledImageFilterCubicImg = 8192,
        Reserved27KHR = 134217728,
        Reserved28KHR = 268435456,
        Reserved25KHR = 33554432,
        Reserved26KHR = 67108864,
        AccelerationStructureVertexBufferKHR = 536870912,
        FragmentDensityMapEXT = 16777216,
        FragmentShadingRateAttachmentKHR = 1073741824,
    }
    public static partial class RawConstants
    {
        ///<summary>Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = VkFormatFeatureFlags.SampledImage;
        ///<summary>Format can be used for storage images (STORAGE_IMAGE descriptor type)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = VkFormatFeatureFlags.StorageImage;
        ///<summary>Format supports atomic operations in case it is used for storage images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = VkFormatFeatureFlags.StorageImageAtomic;
        ///<summary>Format can be used for uniform texel buffers (TBOs)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = VkFormatFeatureFlags.UniformTexelBuffer;
        ///<summary>Format can be used for storage texel buffers (IBOs)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = VkFormatFeatureFlags.StorageTexelBuffer;
        ///<summary>Format supports atomic operations in case it is used for storage texel buffers</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = VkFormatFeatureFlags.StorageTexelBufferAtomic;
        ///<summary>Format can be used for vertex buffers (VBOs)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = VkFormatFeatureFlags.VertexBuffer;
        ///<summary>Format can be used for color attachment images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = VkFormatFeatureFlags.ColorAttachment;
        ///<summary>Format supports blending in case it is used for color attachment images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = VkFormatFeatureFlags.ColorAttachmentBlend;
        ///<summary>Format can be used for depth/stencil attachment images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = VkFormatFeatureFlags.DepthStencilAttachment;
        ///<summary>Format can be used as the source image of blits with vkCmdBlitImage</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_BLIT_SRC_BIT = VkFormatFeatureFlags.BlitSrc;
        ///<summary>Format can be used as the destination image of blits with vkCmdBlitImage</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_BLIT_DST_BIT = VkFormatFeatureFlags.BlitDst;
        ///<summary>Format can be filtered with VK_FILTER_LINEAR when being sampled</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT = VkFormatFeatureFlags.SampledImageFilterLinear;
        ///<summary>Format can be filtered with VK_FILTER_CUBIC_IMG when being sampled</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG = VkFormatFeatureFlags.SampledImageFilterCubicImg;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_RESERVED_27_BIT_KHR = VkFormatFeatureFlags.Reserved27KHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_RESERVED_28_BIT_KHR = VkFormatFeatureFlags.Reserved28KHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_RESERVED_25_BIT_KHR = VkFormatFeatureFlags.Reserved25KHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_RESERVED_26_BIT_KHR = VkFormatFeatureFlags.Reserved26KHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = VkFormatFeatureFlags.AccelerationStructureVertexBufferKHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT = VkFormatFeatureFlags.FragmentDensityMapEXT;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkFormatFeatureFlags.FragmentShadingRateAttachmentKHR;
    }

    [Flags]
    public enum VkQueryControlFlags
    {
        None = 0,
        ///<summary>Require precise results to be collected by the query</summary>
        Precise = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Require precise results to be collected by the query</summary>
        public const VkQueryControlFlags VK_QUERY_CONTROL_PRECISE_BIT = VkQueryControlFlags.Precise;
    }

    [Flags]
    public enum VkQueryResultFlags
    {
        None = 0,
        ///<summary>Results of the queries are written to the destination buffer as 64-bit values</summary>
        _64 = 1,
        ///<summary>Results of the queries are waited on before proceeding with the result copy</summary>
        Wait = 2,
        ///<summary>Besides the results of the query, the availability of the results is also written</summary>
        WithAvailability = 4,
        ///<summary>Copy the partial results of the query even if the final results are not available</summary>
        Partial = 8,
    }
    public static partial class RawConstants
    {
        ///<summary>Results of the queries are written to the destination buffer as 64-bit values</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_64_BIT = VkQueryResultFlags._64;
        ///<summary>Results of the queries are waited on before proceeding with the result copy</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_WAIT_BIT = VkQueryResultFlags.Wait;
        ///<summary>Besides the results of the query, the availability of the results is also written</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = VkQueryResultFlags.WithAvailability;
        ///<summary>Copy the partial results of the query even if the final results are not available</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_PARTIAL_BIT = VkQueryResultFlags.Partial;
    }

    [Flags]
    public enum VkCommandBufferUsageFlags
    {
        None = 0,
        OneTimeSubmit = 1,
        RenderPassContinue = 2,
        ///<summary>Command buffer may be submitted/executed more than once simultaneously</summary>
        SimultaneousUse = 4,
    }
    public static partial class RawConstants
    {
        public const VkCommandBufferUsageFlags VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT = VkCommandBufferUsageFlags.OneTimeSubmit;
        public const VkCommandBufferUsageFlags VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT = VkCommandBufferUsageFlags.RenderPassContinue;
        ///<summary>Command buffer may be submitted/executed more than once simultaneously</summary>
        public const VkCommandBufferUsageFlags VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT = VkCommandBufferUsageFlags.SimultaneousUse;
    }

    [Flags]
    public enum VkQueryPipelineStatisticFlags
    {
        None = 0,
        ///<summary>Optional</summary>
        InputAssemblyVertices = 1,
        ///<summary>Optional</summary>
        InputAssemblyPrimitives = 2,
        ///<summary>Optional</summary>
        VertexShaderInvocations = 4,
        ///<summary>Optional</summary>
        GeometryShaderInvocations = 8,
        ///<summary>Optional</summary>
        GeometryShaderPrimitives = 16,
        ///<summary>Optional</summary>
        ClippingInvocations = 32,
        ///<summary>Optional</summary>
        ClippingPrimitives = 64,
        ///<summary>Optional</summary>
        FragmentShaderInvocations = 128,
        ///<summary>Optional</summary>
        TessellationControlShaderPatches = 256,
        ///<summary>Optional</summary>
        TessellationEvaluationShaderInvocations = 512,
        ///<summary>Optional</summary>
        ComputeShaderInvocations = 1024,
    }
    public static partial class RawConstants
    {
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT = VkQueryPipelineStatisticFlags.InputAssemblyVertices;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT = VkQueryPipelineStatisticFlags.InputAssemblyPrimitives;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.VertexShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.GeometryShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT = VkQueryPipelineStatisticFlags.GeometryShaderPrimitives;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.ClippingInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT = VkQueryPipelineStatisticFlags.ClippingPrimitives;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.FragmentShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT = VkQueryPipelineStatisticFlags.TessellationControlShaderPatches;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.TessellationEvaluationShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.ComputeShaderInvocations;
    }

    [Flags]
    public enum VkImageAspectFlags
    {
        None = 0,
        Color = 1,
        Depth = 2,
        Stencil = 4,
        Metadata = 8,
        MemoryPlane0EXT = 128,
        MemoryPlane1EXT = 256,
        MemoryPlane2EXT = 512,
        MemoryPlane3EXT = 1024,
    }
    public static partial class RawConstants
    {
        public const VkImageAspectFlags VK_IMAGE_ASPECT_COLOR_BIT = VkImageAspectFlags.Color;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_DEPTH_BIT = VkImageAspectFlags.Depth;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_STENCIL_BIT = VkImageAspectFlags.Stencil;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_METADATA_BIT = VkImageAspectFlags.Metadata;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT = VkImageAspectFlags.MemoryPlane0EXT;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT = VkImageAspectFlags.MemoryPlane1EXT;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT = VkImageAspectFlags.MemoryPlane2EXT;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT = VkImageAspectFlags.MemoryPlane3EXT;
    }

    [Flags]
    public enum VkSparseImageFormatFlags
    {
        None = 0,
        ///<summary>Image uses a single mip tail region for all array layers</summary>
        SingleMiptail = 1,
        ///<summary>Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-tail mip levels.</summary>
        AlignedMipSize = 2,
        ///<summary>Image uses a non-standard sparse image block dimensions</summary>
        NonstandardBlockSize = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>Image uses a single mip tail region for all array layers</summary>
        public const VkSparseImageFormatFlags VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT = VkSparseImageFormatFlags.SingleMiptail;
        ///<summary>Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-tail mip levels.</summary>
        public const VkSparseImageFormatFlags VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT = VkSparseImageFormatFlags.AlignedMipSize;
        ///<summary>Image uses a non-standard sparse image block dimensions</summary>
        public const VkSparseImageFormatFlags VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT = VkSparseImageFormatFlags.NonstandardBlockSize;
    }

    [Flags]
    public enum VkSparseMemoryBindFlags
    {
        None = 0,
        ///<summary>Operation binds resource metadata to memory</summary>
        Metadata = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Operation binds resource metadata to memory</summary>
        public const VkSparseMemoryBindFlags VK_SPARSE_MEMORY_BIND_METADATA_BIT = VkSparseMemoryBindFlags.Metadata;
    }

    [Flags]
    public enum VkPipelineStageFlags
    {
        None = 0,
        ///<summary>Before subsequent commands are processed</summary>
        TopOfPipe = 1,
        ///<summary>Draw/DispatchIndirect command fetch</summary>
        DrawIndirect = 2,
        ///<summary>Vertex/index fetch</summary>
        VertexInput = 4,
        ///<summary>Vertex shading</summary>
        VertexShader = 8,
        ///<summary>Tessellation control shading</summary>
        TessellationControlShader = 16,
        ///<summary>Tessellation evaluation shading</summary>
        TessellationEvaluationShader = 32,
        ///<summary>Geometry shading</summary>
        GeometryShader = 64,
        ///<summary>Fragment shading</summary>
        FragmentShader = 128,
        ///<summary>Early fragment (depth and stencil) tests</summary>
        EarlyFragmentTests = 256,
        ///<summary>Late fragment (depth and stencil) tests</summary>
        LateFragmentTests = 512,
        ///<summary>Color attachment writes</summary>
        ColorAttachmentOutput = 1024,
        ///<summary>Compute shading</summary>
        ComputeShader = 2048,
        ///<summary>Transfer/copy operations</summary>
        Transfer = 4096,
        ///<summary>After previous commands have completed</summary>
        BottomOfPipe = 8192,
        ///<summary>Indicates host (CPU) is a source/sink of the dependency</summary>
        Host = 16384,
        ///<summary>All stages of the graphics pipeline</summary>
        AllGraphics = 32768,
        ///<summary>All stages supported on the queue</summary>
        AllCommands = 65536,
        Reserved27KHR = 134217728,
        Reserved26KHR = 67108864,
        TransformFeedbackEXT = 16777216,
        ///<summary>A pipeline stage for conditional rendering predicate fetch</summary>
        ConditionalRenderingEXT = 262144,
        AccelerationStructureBuildKHR = 33554432,
        RayTracingShaderKHR = 2097152,
        ShadingRateImageNV = 4194304,
        TaskShaderNV = 524288,
        MeshShaderNV = 1048576,
        FragmentDensityProcessEXT = 8388608,
        CommandPreprocessNV = 131072,
    }
    public static partial class RawConstants
    {
        ///<summary>Before subsequent commands are processed</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = VkPipelineStageFlags.TopOfPipe;
        ///<summary>Draw/DispatchIndirect command fetch</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = VkPipelineStageFlags.DrawIndirect;
        ///<summary>Vertex/index fetch</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = VkPipelineStageFlags.VertexInput;
        ///<summary>Vertex shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = VkPipelineStageFlags.VertexShader;
        ///<summary>Tessellation control shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT = VkPipelineStageFlags.TessellationControlShader;
        ///<summary>Tessellation evaluation shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT = VkPipelineStageFlags.TessellationEvaluationShader;
        ///<summary>Geometry shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = VkPipelineStageFlags.GeometryShader;
        ///<summary>Fragment shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = VkPipelineStageFlags.FragmentShader;
        ///<summary>Early fragment (depth and stencil) tests</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = VkPipelineStageFlags.EarlyFragmentTests;
        ///<summary>Late fragment (depth and stencil) tests</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = VkPipelineStageFlags.LateFragmentTests;
        ///<summary>Color attachment writes</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = VkPipelineStageFlags.ColorAttachmentOutput;
        ///<summary>Compute shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = VkPipelineStageFlags.ComputeShader;
        ///<summary>Transfer/copy operations</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TRANSFER_BIT = VkPipelineStageFlags.Transfer;
        ///<summary>After previous commands have completed</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT = VkPipelineStageFlags.BottomOfPipe;
        ///<summary>Indicates host (CPU) is a source/sink of the dependency</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_HOST_BIT = VkPipelineStageFlags.Host;
        ///<summary>All stages of the graphics pipeline</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT = VkPipelineStageFlags.AllGraphics;
        ///<summary>All stages supported on the queue</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_ALL_COMMANDS_BIT = VkPipelineStageFlags.AllCommands;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_RESERVED_27_BIT_KHR = VkPipelineStageFlags.Reserved27KHR;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_RESERVED_26_BIT_KHR = VkPipelineStageFlags.Reserved26KHR;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT = VkPipelineStageFlags.TransformFeedbackEXT;
        ///<summary>A pipeline stage for conditional rendering predicate fetch</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT = VkPipelineStageFlags.ConditionalRenderingEXT;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = VkPipelineStageFlags.AccelerationStructureBuildKHR;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR = VkPipelineStageFlags.RayTracingShaderKHR;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV = VkPipelineStageFlags.ShadingRateImageNV;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV = VkPipelineStageFlags.TaskShaderNV;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV = VkPipelineStageFlags.MeshShaderNV;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT = VkPipelineStageFlags.FragmentDensityProcessEXT;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV = VkPipelineStageFlags.CommandPreprocessNV;
    }

    [Flags]
    public enum VkCommandPoolCreateFlags
    {
        None = 0,
        ///<summary>Command buffers have a short lifetime</summary>
        Transient = 1,
        ///<summary>Command buffers may release their memory individually</summary>
        ResetCommandBuffer = 2,
    }
    public static partial class RawConstants
    {
        ///<summary>Command buffers have a short lifetime</summary>
        public const VkCommandPoolCreateFlags VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = VkCommandPoolCreateFlags.Transient;
        ///<summary>Command buffers may release their memory individually</summary>
        public const VkCommandPoolCreateFlags VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = VkCommandPoolCreateFlags.ResetCommandBuffer;
    }

    [Flags]
    public enum VkCommandPoolResetFlags
    {
        None = 0,
        ///<summary>Release resources owned by the pool</summary>
        ReleaseResources = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Release resources owned by the pool</summary>
        public const VkCommandPoolResetFlags VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT = VkCommandPoolResetFlags.ReleaseResources;
    }

    [Flags]
    public enum VkCommandBufferResetFlags
    {
        None = 0,
        ///<summary>Release resources owned by the buffer</summary>
        ReleaseResources = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Release resources owned by the buffer</summary>
        public const VkCommandBufferResetFlags VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = VkCommandBufferResetFlags.ReleaseResources;
    }

    [Flags]
    public enum VkSampleCountFlags
    {
        None = 0,
        ///<summary>Sample count 1 supported</summary>
        Count1 = 1,
        ///<summary>Sample count 2 supported</summary>
        Count2 = 2,
        ///<summary>Sample count 4 supported</summary>
        Count4 = 4,
        ///<summary>Sample count 8 supported</summary>
        Count8 = 8,
        ///<summary>Sample count 16 supported</summary>
        Count16 = 16,
        ///<summary>Sample count 32 supported</summary>
        Count32 = 32,
        ///<summary>Sample count 64 supported</summary>
        Count64 = 64,
    }
    public static partial class RawConstants
    {
        ///<summary>Sample count 1 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_1_BIT = VkSampleCountFlags.Count1;
        ///<summary>Sample count 2 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_2_BIT = VkSampleCountFlags.Count2;
        ///<summary>Sample count 4 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_4_BIT = VkSampleCountFlags.Count4;
        ///<summary>Sample count 8 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_8_BIT = VkSampleCountFlags.Count8;
        ///<summary>Sample count 16 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_16_BIT = VkSampleCountFlags.Count16;
        ///<summary>Sample count 32 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_32_BIT = VkSampleCountFlags.Count32;
        ///<summary>Sample count 64 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_64_BIT = VkSampleCountFlags.Count64;
    }

    [Flags]
    public enum VkAttachmentDescriptionFlags
    {
        None = 0,
        ///<summary>The attachment may alias physical memory of another attachment in the same render pass</summary>
        MayAlias = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>The attachment may alias physical memory of another attachment in the same render pass</summary>
        public const VkAttachmentDescriptionFlags VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT = VkAttachmentDescriptionFlags.MayAlias;
    }

    [Flags]
    public enum VkStencilFaceFlags
    {
        None = 0,
        ///<summary>Front face</summary>
        Front = 1,
        ///<summary>Back face</summary>
        Back = 2,
        ///<summary>Front and back faces</summary>
        FrontAndBack = 3,
        ///<summary>Alias for backwards compatibility</summary>
        FrontAndBack = 3,
    }
    public static partial class RawConstants
    {
        ///<summary>Front face</summary>
        public const VkStencilFaceFlags VK_STENCIL_FACE_FRONT_BIT = VkStencilFaceFlags.Front;
        ///<summary>Back face</summary>
        public const VkStencilFaceFlags VK_STENCIL_FACE_BACK_BIT = VkStencilFaceFlags.Back;
        ///<summary>Front and back faces</summary>
        public const VkStencilFaceFlags VK_STENCIL_FACE_FRONT_AND_BACK = VkStencilFaceFlags.FrontAndBack;
        ///<summary>Alias for backwards compatibility</summary>
        public const VkStencilFaceFlags VK_STENCIL_FRONT_AND_BACK = VkStencilFaceFlags.FrontAndBack;
    }

    [Flags]
    public enum VkDescriptorPoolCreateFlags
    {
        None = 0,
        ///<summary>Descriptor sets may be freed individually</summary>
        FreeDescriptorSet = 1,
        HostOnlyValve = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>Descriptor sets may be freed individually</summary>
        public const VkDescriptorPoolCreateFlags VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = VkDescriptorPoolCreateFlags.FreeDescriptorSet;
        public const VkDescriptorPoolCreateFlags VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE = VkDescriptorPoolCreateFlags.HostOnlyValve;
    }

    [Flags]
    public enum VkDependencyFlags
    {
        None = 0,
        ///<summary>Dependency is per pixel region </summary>
        ByRegion = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Dependency is per pixel region </summary>
        public const VkDependencyFlags VK_DEPENDENCY_BY_REGION_BIT = VkDependencyFlags.ByRegion;
    }

    public enum VkSemaphoreType
    {
        Binary = 0,
        Timeline = 1,
    }
    public static partial class RawConstants
    {
        public const VkSemaphoreType VK_SEMAPHORE_TYPE_BINARY = VkSemaphoreType.Binary;
        public const VkSemaphoreType VK_SEMAPHORE_TYPE_TIMELINE = VkSemaphoreType.Timeline;
    }

    [Flags]
    public enum VkSemaphoreWaitFlags
    {
        None = 0,
        Any = 1,
    }
    public static partial class RawConstants
    {
        public const VkSemaphoreWaitFlags VK_SEMAPHORE_WAIT_ANY_BIT = VkSemaphoreWaitFlags.Any;
    }

    public enum VkPresentModeKHR
    {
        ImmediateKHR = 0,
        MailboxKHR = 1,
        FifoKHR = 2,
        FifoRelaxedKHR = 3,
        SharedDemandRefreshKHR = 1000111000,
        SharedContinuousRefreshKHR = 1000111001,
    }
    public static partial class RawConstants
    {
        public const VkPresentModeKHR VK_PRESENT_MODE_IMMEDIATE_KHR = VkPresentModeKHR.ImmediateKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_MAILBOX_KHR = VkPresentModeKHR.MailboxKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_FIFO_KHR = VkPresentModeKHR.FifoKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_FIFO_RELAXED_KHR = VkPresentModeKHR.FifoRelaxedKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR = VkPresentModeKHR.SharedDemandRefreshKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR = VkPresentModeKHR.SharedContinuousRefreshKHR;
    }

    public enum VkColorSpaceKHR
    {
        SrgbNonlinearKHR = 0,
        ///<summary>Backwards-compatible alias containing a typo</summary>
        VK_COLORSPACE_SRGB_NONLINEAR_KHR = 0,
        DisplayP3NonlinearEXT = 1000104001,
        ExtendedSrgbLinearEXT = 1000104002,
        DisplayP3LinearEXT = 1000104003,
        DciP3NonlinearEXT = 1000104004,
        Bt709LinearEXT = 1000104005,
        Bt709NonlinearEXT = 1000104006,
        Bt2020LinearEXT = 1000104007,
        Hdr10St2084EXT = 1000104008,
        DolbyvisionEXT = 1000104009,
        Hdr10HlgEXT = 1000104010,
        AdobergbLinearEXT = 1000104011,
        AdobergbNonlinearEXT = 1000104012,
        PassThroughEXT = 1000104013,
        ExtendedSrgbNonlinearEXT = 1000104014,
        DisplayNativeAMD = 1000213000,
    }
    public static partial class RawConstants
    {
        public const VkColorSpaceKHR VK_COLOR_SPACE_SRGB_NONLINEAR_KHR = VkColorSpaceKHR.SrgbNonlinearKHR;
        ///<summary>Backwards-compatible alias containing a typo</summary>
        public const VkColorSpaceKHR VK_COLORSPACE_SRGB_NONLINEAR_KHR = VkColorSpaceKHR.VK_COLORSPACE_SRGB_NONLINEAR_KHR;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT = VkColorSpaceKHR.DisplayP3NonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT = VkColorSpaceKHR.ExtendedSrgbLinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT = VkColorSpaceKHR.DisplayP3LinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT = VkColorSpaceKHR.DciP3NonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_BT709_LINEAR_EXT = VkColorSpaceKHR.Bt709LinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_BT709_NONLINEAR_EXT = VkColorSpaceKHR.Bt709NonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_BT2020_LINEAR_EXT = VkColorSpaceKHR.Bt2020LinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_HDR10_ST2084_EXT = VkColorSpaceKHR.Hdr10St2084EXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DOLBYVISION_EXT = VkColorSpaceKHR.DolbyvisionEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_HDR10_HLG_EXT = VkColorSpaceKHR.Hdr10HlgEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT = VkColorSpaceKHR.AdobergbLinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT = VkColorSpaceKHR.AdobergbNonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_PASS_THROUGH_EXT = VkColorSpaceKHR.PassThroughEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT = VkColorSpaceKHR.ExtendedSrgbNonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DISPLAY_NATIVE_AMD = VkColorSpaceKHR.DisplayNativeAMD;
    }

    [Flags]
    public enum VkDisplayPlaneAlphaFlagsKHR
    {
        None = 0,
        OpaqueKHR = 1,
        GlobalKHR = 2,
        PerPixelKHR = 4,
        PerPixelPremultipliedKHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.OpaqueKHR;
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.GlobalKHR;
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.PerPixelKHR;
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.PerPixelPremultipliedKHR;
    }

    [Flags]
    public enum VkCompositeAlphaFlagsKHR
    {
        None = 0,
        OpaqueKHR = 1,
        PreMultipliedKHR = 2,
        PostMultipliedKHR = 4,
        InheritKHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = VkCompositeAlphaFlagsKHR.OpaqueKHR;
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = VkCompositeAlphaFlagsKHR.PreMultipliedKHR;
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = VkCompositeAlphaFlagsKHR.PostMultipliedKHR;
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = VkCompositeAlphaFlagsKHR.InheritKHR;
    }

    [Flags]
    public enum VkSurfaceTransformFlagsKHR
    {
        None = 0,
        IdentityKHR = 1,
        Rotate90KHR = 2,
        Rotate180KHR = 4,
        Rotate270KHR = 8,
        HorizontalMirrorKHR = 16,
        HorizontalMirrorRotate90KHR = 32,
        HorizontalMirrorRotate180KHR = 64,
        HorizontalMirrorRotate270KHR = 128,
        InheritKHR = 256,
    }
    public static partial class RawConstants
    {
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR = VkSurfaceTransformFlagsKHR.IdentityKHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR = VkSurfaceTransformFlagsKHR.Rotate90KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR = VkSurfaceTransformFlagsKHR.Rotate180KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR = VkSurfaceTransformFlagsKHR.Rotate270KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorKHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorRotate90KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorRotate180KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorRotate270KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR = VkSurfaceTransformFlagsKHR.InheritKHR;
    }

    [Flags]
    public enum VkSwapchainImageUsageFlagsANDROID
    {
        None = 0,
        SharedAndroid = 1,
    }
    public static partial class RawConstants
    {
        public const VkSwapchainImageUsageFlagsANDROID VK_SWAPCHAIN_IMAGE_USAGE_SHARED_BIT_ANDROID = VkSwapchainImageUsageFlagsANDROID.SharedAndroid;
    }

    public enum VkTimeDomainEXT
    {
        DeviceEXT = 0,
        ClockMonotonicEXT = 1,
        ClockMonotonicRawEXT = 2,
        QueryPerformanceCounterEXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkTimeDomainEXT VK_TIME_DOMAIN_DEVICE_EXT = VkTimeDomainEXT.DeviceEXT;
        public const VkTimeDomainEXT VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = VkTimeDomainEXT.ClockMonotonicEXT;
        public const VkTimeDomainEXT VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = VkTimeDomainEXT.ClockMonotonicRawEXT;
        public const VkTimeDomainEXT VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = VkTimeDomainEXT.QueryPerformanceCounterEXT;
    }

    [Flags]
    public enum VkDebugReportFlagsEXT
    {
        None = 0,
        InformationEXT = 1,
        WarningEXT = 2,
        PerformanceWarningEXT = 4,
        ErrorEXT = 8,
        DebugEXT = 16,
    }
    public static partial class RawConstants
    {
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_INFORMATION_BIT_EXT = VkDebugReportFlagsEXT.InformationEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_WARNING_BIT_EXT = VkDebugReportFlagsEXT.WarningEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = VkDebugReportFlagsEXT.PerformanceWarningEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_ERROR_BIT_EXT = VkDebugReportFlagsEXT.ErrorEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_DEBUG_BIT_EXT = VkDebugReportFlagsEXT.DebugEXT;
    }

    public enum VkDebugReportObjectTypeEXT
    {
        UnknownEXT = 0,
        InstanceEXT = 1,
        PhysicalDeviceEXT = 2,
        DeviceEXT = 3,
        QueueEXT = 4,
        SemaphoreEXT = 5,
        CommandBufferEXT = 6,
        FenceEXT = 7,
        DeviceMemoryEXT = 8,
        BufferEXT = 9,
        ImageEXT = 10,
        EventEXT = 11,
        QueryPoolEXT = 12,
        BufferViewEXT = 13,
        ImageViewEXT = 14,
        ShaderModuleEXT = 15,
        PipelineCacheEXT = 16,
        PipelineLayoutEXT = 17,
        RenderPassEXT = 18,
        PipelineEXT = 19,
        DescriptorSetLayoutEXT = 20,
        SamplerEXT = 21,
        DescriptorPoolEXT = 22,
        DescriptorSetEXT = 23,
        FramebufferEXT = 24,
        CommandPoolEXT = 25,
        SurfaceKHREXT = 26,
        SwapchainKHREXT = 27,
        DebugReportCallbackEXTEXT = 28,
        ///<summary>Backwards-compatible alias containing a typo</summary>
        DebugReportEXT = 28,
        DisplayKHREXT = 29,
        DisplayModeKHREXT = 30,
        ValidationCacheEXTEXT = 33,
        ///<summary>Backwards-compatible alias containing a typo</summary>
        ValidationCacheEXT = 33,
        SamplerYcbcrConversionEXT = 1000011000,
        DescriptorUpdateTemplateEXT = 1000011000,
        AccelerationStructureKHREXT = 1000150000,
        SamplerYcbcrConversionEXT = 1000156000,
        AccelerationStructureNVEXT = 1000165000,
    }
    public static partial class RawConstants
    {
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT = VkDebugReportObjectTypeEXT.UnknownEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT = VkDebugReportObjectTypeEXT.InstanceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT = VkDebugReportObjectTypeEXT.PhysicalDeviceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT = VkDebugReportObjectTypeEXT.DeviceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT = VkDebugReportObjectTypeEXT.QueueEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT = VkDebugReportObjectTypeEXT.SemaphoreEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT = VkDebugReportObjectTypeEXT.CommandBufferEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT = VkDebugReportObjectTypeEXT.FenceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT = VkDebugReportObjectTypeEXT.DeviceMemoryEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT = VkDebugReportObjectTypeEXT.BufferEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT = VkDebugReportObjectTypeEXT.ImageEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT = VkDebugReportObjectTypeEXT.EventEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT = VkDebugReportObjectTypeEXT.QueryPoolEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT = VkDebugReportObjectTypeEXT.BufferViewEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT = VkDebugReportObjectTypeEXT.ImageViewEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT = VkDebugReportObjectTypeEXT.ShaderModuleEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT = VkDebugReportObjectTypeEXT.PipelineCacheEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT = VkDebugReportObjectTypeEXT.PipelineLayoutEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT = VkDebugReportObjectTypeEXT.RenderPassEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT = VkDebugReportObjectTypeEXT.PipelineEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT = VkDebugReportObjectTypeEXT.DescriptorSetLayoutEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT = VkDebugReportObjectTypeEXT.SamplerEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT = VkDebugReportObjectTypeEXT.DescriptorPoolEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT = VkDebugReportObjectTypeEXT.DescriptorSetEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT = VkDebugReportObjectTypeEXT.FramebufferEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT = VkDebugReportObjectTypeEXT.CommandPoolEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT = VkDebugReportObjectTypeEXT.SurfaceKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT = VkDebugReportObjectTypeEXT.SwapchainKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT = VkDebugReportObjectTypeEXT.DebugReportCallbackEXTEXT;
        ///<summary>Backwards-compatible alias containing a typo</summary>
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT = VkDebugReportObjectTypeEXT.DebugReportEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT = VkDebugReportObjectTypeEXT.DisplayKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT = VkDebugReportObjectTypeEXT.DisplayModeKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT = VkDebugReportObjectTypeEXT.ValidationCacheEXTEXT;
        ///<summary>Backwards-compatible alias containing a typo</summary>
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT = VkDebugReportObjectTypeEXT.ValidationCacheEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = VkDebugReportObjectTypeEXT.SamplerYcbcrConversionEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT = VkDebugReportObjectTypeEXT.DescriptorUpdateTemplateEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT = VkDebugReportObjectTypeEXT.AccelerationStructureKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = VkDebugReportObjectTypeEXT.SamplerYcbcrConversionEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT = VkDebugReportObjectTypeEXT.AccelerationStructureNVEXT;
    }

    public enum VkDeviceMemoryReportEventTypeEXT
    {
        AllocateEXT = 0,
        FreeEXT = 1,
        ImportEXT = 2,
        UnimportEXT = 3,
        AllocationFailedEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT = VkDeviceMemoryReportEventTypeEXT.AllocateEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT = VkDeviceMemoryReportEventTypeEXT.FreeEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT = VkDeviceMemoryReportEventTypeEXT.ImportEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT = VkDeviceMemoryReportEventTypeEXT.UnimportEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT = VkDeviceMemoryReportEventTypeEXT.AllocationFailedEXT;
    }

    public enum VkRasterizationOrderAMD
    {
        StrictAMD = 0,
        RelaxedAMD = 1,
    }
    public static partial class RawConstants
    {
        public const VkRasterizationOrderAMD VK_RASTERIZATION_ORDER_STRICT_AMD = VkRasterizationOrderAMD.StrictAMD;
        public const VkRasterizationOrderAMD VK_RASTERIZATION_ORDER_RELAXED_AMD = VkRasterizationOrderAMD.RelaxedAMD;
    }

    [Flags]
    public enum VkExternalMemoryHandleTypeFlagsNV
    {
        None = 0,
        OpaqueWin32NV = 1,
        OpaqueWin32KmtNV = 2,
        D3d11ImageNV = 4,
        D3d11ImageKmtNV = 8,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.OpaqueWin32NV;
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.OpaqueWin32KmtNV;
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.D3d11ImageNV;
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.D3d11ImageKmtNV;
    }

    [Flags]
    public enum VkExternalMemoryFeatureFlagsNV
    {
        None = 0,
        DedicatedOnlyNV = 1,
        ExportableNV = 2,
        ImportableNV = 4,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryFeatureFlagsNV VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV = VkExternalMemoryFeatureFlagsNV.DedicatedOnlyNV;
        public const VkExternalMemoryFeatureFlagsNV VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV = VkExternalMemoryFeatureFlagsNV.ExportableNV;
        public const VkExternalMemoryFeatureFlagsNV VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV = VkExternalMemoryFeatureFlagsNV.ImportableNV;
    }

    public enum VkValidationCheckEXT
    {
        AllEXT = 0,
        ShadersEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkValidationCheckEXT VK_VALIDATION_CHECK_ALL_EXT = VkValidationCheckEXT.AllEXT;
        public const VkValidationCheckEXT VK_VALIDATION_CHECK_SHADERS_EXT = VkValidationCheckEXT.ShadersEXT;
    }

    public enum VkValidationFeatureEnableEXT
    {
        GpuAssistedEXT = 0,
        GpuAssistedReserveBindingSlotEXT = 1,
        BestPracticesEXT = 2,
        DebugPrintfEXT = 3,
        SynchronizationValidationEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = VkValidationFeatureEnableEXT.GpuAssistedEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = VkValidationFeatureEnableEXT.GpuAssistedReserveBindingSlotEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = VkValidationFeatureEnableEXT.BestPracticesEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT = VkValidationFeatureEnableEXT.DebugPrintfEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT = VkValidationFeatureEnableEXT.SynchronizationValidationEXT;
    }

    public enum VkValidationFeatureDisableEXT
    {
        AllEXT = 0,
        ShadersEXT = 1,
        ThreadSafetyEXT = 2,
        ApiParametersEXT = 3,
        ObjectLifetimesEXT = 4,
        CoreChecksEXT = 5,
        UniqueHandlesEXT = 6,
    }
    public static partial class RawConstants
    {
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_ALL_EXT = VkValidationFeatureDisableEXT.AllEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT = VkValidationFeatureDisableEXT.ShadersEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT = VkValidationFeatureDisableEXT.ThreadSafetyEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT = VkValidationFeatureDisableEXT.ApiParametersEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT = VkValidationFeatureDisableEXT.ObjectLifetimesEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT = VkValidationFeatureDisableEXT.CoreChecksEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT = VkValidationFeatureDisableEXT.UniqueHandlesEXT;
    }

    [Flags]
    public enum VkSubgroupFeatureFlags
    {
        None = 0,
        ///<summary>Basic subgroup operations</summary>
        Basic = 1,
        ///<summary>Vote subgroup operations</summary>
        Vote = 2,
        ///<summary>Arithmetic subgroup operations</summary>
        Arithmetic = 4,
        ///<summary>Ballot subgroup operations</summary>
        Ballot = 8,
        ///<summary>Shuffle subgroup operations</summary>
        Shuffle = 16,
        ///<summary>Shuffle relative subgroup operations</summary>
        ShuffleRelative = 32,
        ///<summary>Clustered subgroup operations</summary>
        Clustered = 64,
        ///<summary>Quad subgroup operations</summary>
        Quad = 128,
        PartitionedNV = 256,
    }
    public static partial class RawConstants
    {
        ///<summary>Basic subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_BASIC_BIT = VkSubgroupFeatureFlags.Basic;
        ///<summary>Vote subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_VOTE_BIT = VkSubgroupFeatureFlags.Vote;
        ///<summary>Arithmetic subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = VkSubgroupFeatureFlags.Arithmetic;
        ///<summary>Ballot subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_BALLOT_BIT = VkSubgroupFeatureFlags.Ballot;
        ///<summary>Shuffle subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_SHUFFLE_BIT = VkSubgroupFeatureFlags.Shuffle;
        ///<summary>Shuffle relative subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = VkSubgroupFeatureFlags.ShuffleRelative;
        ///<summary>Clustered subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_CLUSTERED_BIT = VkSubgroupFeatureFlags.Clustered;
        ///<summary>Quad subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_QUAD_BIT = VkSubgroupFeatureFlags.Quad;
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = VkSubgroupFeatureFlags.PartitionedNV;
    }

    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagsNV
    {
        None = 0,
        ExplicitPreprocessNV = 1,
        IndexedSequencesNV = 2,
        UnorderedSequencesNV = 4,
    }
    public static partial class RawConstants
    {
        public const VkIndirectCommandsLayoutUsageFlagsNV VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_NV = VkIndirectCommandsLayoutUsageFlagsNV.ExplicitPreprocessNV;
        public const VkIndirectCommandsLayoutUsageFlagsNV VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NV = VkIndirectCommandsLayoutUsageFlagsNV.IndexedSequencesNV;
        public const VkIndirectCommandsLayoutUsageFlagsNV VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NV = VkIndirectCommandsLayoutUsageFlagsNV.UnorderedSequencesNV;
    }

    [Flags]
    public enum VkIndirectStateFlagsNV
    {
        None = 0,
        FlagFrontfaceNV = 1,
    }
    public static partial class RawConstants
    {
        public const VkIndirectStateFlagsNV VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV = VkIndirectStateFlagsNV.FlagFrontfaceNV;
    }

    public enum VkIndirectCommandsTokenTypeNV
    {
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV = 0,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV = 1,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV = 2,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV = 3,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV = 4,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV = 5,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV = 6,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV = 7,
    }
    public static partial class RawConstants
    {
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV;
    }

    [Flags]
    public enum VkPrivateDataSlotCreateFlagsEXT
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkDescriptorSetLayoutCreateFlags
    {
        None = 0,
        ///<summary>Descriptors are pushed via flink:vkCmdPushDescriptorSetKHR</summary>
        PushDescriptorKHR = 1,
        HostOnlyPoolValve = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>Descriptors are pushed via flink:vkCmdPushDescriptorSetKHR</summary>
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR = VkDescriptorSetLayoutCreateFlags.PushDescriptorKHR;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE = VkDescriptorSetLayoutCreateFlags.HostOnlyPoolValve;
    }

    [Flags]
    public enum VkExternalMemoryHandleTypeFlags
    {
        None = 0,
        OpaqueFd = 1,
        OpaqueWin32 = 2,
        OpaqueWin32Kmt = 4,
        D3d11Texture = 8,
        D3d11TextureKmt = 16,
        D3d12Heap = 32,
        D3d12Resource = 64,
        DmaBufEXT = 512,
        AndroidHardwareBufferAndroid = 1024,
        HostAllocationEXT = 128,
        HostMappedForeignMemoryEXT = 256,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT = VkExternalMemoryHandleTypeFlags.OpaqueFd;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT = VkExternalMemoryHandleTypeFlags.OpaqueWin32;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT = VkExternalMemoryHandleTypeFlags.D3d11Texture;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT = VkExternalMemoryHandleTypeFlags.D3d11TextureKmt;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT = VkExternalMemoryHandleTypeFlags.D3d12Heap;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT = VkExternalMemoryHandleTypeFlags.D3d12Resource;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT = VkExternalMemoryHandleTypeFlags.DmaBufEXT;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID = VkExternalMemoryHandleTypeFlags.AndroidHardwareBufferAndroid;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT = VkExternalMemoryHandleTypeFlags.HostAllocationEXT;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT = VkExternalMemoryHandleTypeFlags.HostMappedForeignMemoryEXT;
    }

    [Flags]
    public enum VkExternalMemoryFeatureFlags
    {
        None = 0,
        DedicatedOnly = 1,
        Exportable = 2,
        Importable = 4,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryFeatureFlags VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT = VkExternalMemoryFeatureFlags.DedicatedOnly;
        public const VkExternalMemoryFeatureFlags VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT = VkExternalMemoryFeatureFlags.Exportable;
        public const VkExternalMemoryFeatureFlags VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT = VkExternalMemoryFeatureFlags.Importable;
    }

    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlags
    {
        None = 0,
        OpaqueFd = 1,
        OpaqueWin32 = 2,
        OpaqueWin32Kmt = 4,
        D3d12Fence = 8,
        D3d11Fence = 8,
        SyncFd = 16,
    }
    public static partial class RawConstants
    {
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT = VkExternalSemaphoreHandleTypeFlags.OpaqueFd;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT = VkExternalSemaphoreHandleTypeFlags.OpaqueWin32;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT = VkExternalSemaphoreHandleTypeFlags.D3d12Fence;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D11_FENCE_BIT = VkExternalSemaphoreHandleTypeFlags.D3d11Fence;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT = VkExternalSemaphoreHandleTypeFlags.SyncFd;
    }

    [Flags]
    public enum VkExternalSemaphoreFeatureFlags
    {
        None = 0,
        Exportable = 1,
        Importable = 2,
    }
    public static partial class RawConstants
    {
        public const VkExternalSemaphoreFeatureFlags VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT = VkExternalSemaphoreFeatureFlags.Exportable;
        public const VkExternalSemaphoreFeatureFlags VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT = VkExternalSemaphoreFeatureFlags.Importable;
    }

    [Flags]
    public enum VkSemaphoreImportFlags
    {
        None = 0,
        Temporary = 1,
    }
    public static partial class RawConstants
    {
        public const VkSemaphoreImportFlags VK_SEMAPHORE_IMPORT_TEMPORARY_BIT = VkSemaphoreImportFlags.Temporary;
    }

    [Flags]
    public enum VkExternalFenceHandleTypeFlags
    {
        None = 0,
        OpaqueFd = 1,
        OpaqueWin32 = 2,
        OpaqueWin32Kmt = 4,
        SyncFd = 8,
    }
    public static partial class RawConstants
    {
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT = VkExternalFenceHandleTypeFlags.OpaqueFd;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT = VkExternalFenceHandleTypeFlags.OpaqueWin32;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = VkExternalFenceHandleTypeFlags.OpaqueWin32Kmt;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT = VkExternalFenceHandleTypeFlags.SyncFd;
    }

    [Flags]
    public enum VkExternalFenceFeatureFlags
    {
        None = 0,
        Exportable = 1,
        Importable = 2,
    }
    public static partial class RawConstants
    {
        public const VkExternalFenceFeatureFlags VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = VkExternalFenceFeatureFlags.Exportable;
        public const VkExternalFenceFeatureFlags VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = VkExternalFenceFeatureFlags.Importable;
    }

    [Flags]
    public enum VkFenceImportFlags
    {
        None = 0,
        Temporary = 1,
    }
    public static partial class RawConstants
    {
        public const VkFenceImportFlags VK_FENCE_IMPORT_TEMPORARY_BIT = VkFenceImportFlags.Temporary;
    }

    [Flags]
    public enum VkSurfaceCounterFlagsEXT
    {
        None = 0,
        VblankEXT = 1,
        ///<summary>Backwards-compatible alias containing a typo</summary>
        VblankEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkSurfaceCounterFlagsEXT VK_SURFACE_COUNTER_VBLANK_BIT_EXT = VkSurfaceCounterFlagsEXT.VblankEXT;
        ///<summary>Backwards-compatible alias containing a typo</summary>
        public const VkSurfaceCounterFlagsEXT VK_SURFACE_COUNTER_VBLANK_EXT = VkSurfaceCounterFlagsEXT.VblankEXT;
    }

    public enum VkDisplayPowerStateEXT
    {
        OffEXT = 0,
        SuspendEXT = 1,
        OnEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkDisplayPowerStateEXT VK_DISPLAY_POWER_STATE_OFF_EXT = VkDisplayPowerStateEXT.OffEXT;
        public const VkDisplayPowerStateEXT VK_DISPLAY_POWER_STATE_SUSPEND_EXT = VkDisplayPowerStateEXT.SuspendEXT;
        public const VkDisplayPowerStateEXT VK_DISPLAY_POWER_STATE_ON_EXT = VkDisplayPowerStateEXT.OnEXT;
    }

    public enum VkDeviceEventTypeEXT
    {
        DisplayHotplugEXT = 0,
    }
    public static partial class RawConstants
    {
        public const VkDeviceEventTypeEXT VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT = VkDeviceEventTypeEXT.DisplayHotplugEXT;
    }

    public enum VkDisplayEventTypeEXT
    {
        FirstPixelOutEXT = 0,
    }
    public static partial class RawConstants
    {
        public const VkDisplayEventTypeEXT VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT = VkDisplayEventTypeEXT.FirstPixelOutEXT;
    }

    [Flags]
    public enum VkPeerMemoryFeatureFlags
    {
        None = 0,
        ///<summary>Can read with vkCmdCopy commands</summary>
        CopySrc = 1,
        ///<summary>Can write with vkCmdCopy commands</summary>
        CopyDst = 2,
        ///<summary>Can read with any access type/command</summary>
        GenericSrc = 4,
        ///<summary>Can write with and access type/command</summary>
        GenericDst = 8,
    }
    public static partial class RawConstants
    {
        ///<summary>Can read with vkCmdCopy commands</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = VkPeerMemoryFeatureFlags.CopySrc;
        ///<summary>Can write with vkCmdCopy commands</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = VkPeerMemoryFeatureFlags.CopyDst;
        ///<summary>Can read with any access type/command</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = VkPeerMemoryFeatureFlags.GenericSrc;
        ///<summary>Can write with and access type/command</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = VkPeerMemoryFeatureFlags.GenericDst;
    }

    [Flags]
    public enum VkMemoryAllocateFlags
    {
        None = 0,
        ///<summary>Force allocation on specific devices</summary>
        DeviceMask = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Force allocation on specific devices</summary>
        public const VkMemoryAllocateFlags VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT = VkMemoryAllocateFlags.DeviceMask;
    }

    [Flags]
    public enum VkDeviceGroupPresentModeFlagsKHR
    {
        None = 0,
        ///<summary>Present from local memory</summary>
        LocalKHR = 1,
        ///<summary>Present from remote memory</summary>
        RemoteKHR = 2,
        ///<summary>Present sum of local and/or remote memory</summary>
        SumKHR = 4,
        ///<summary>Each physical device presents from local memory</summary>
        LocalMultiDeviceKHR = 8,
    }
    public static partial class RawConstants
    {
        ///<summary>Present from local memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.LocalKHR;
        ///<summary>Present from remote memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.RemoteKHR;
        ///<summary>Present sum of local and/or remote memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.SumKHR;
        ///<summary>Each physical device presents from local memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.LocalMultiDeviceKHR;
    }

    [Flags]
    public enum VkSwapchainCreateFlagsKHR
    {
        None = 0,
        ///<summary>Allow images with VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</summary>
        SplitInstanceBindRegionsKHR = 1,
        ///<summary>Swapchain is protected</summary>
        ProtectedKHR = 2,
        ///<summary>Allow images with VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</summary>
        SplitInstanceBindRegionsKHR = 1,
        MutableFormatKHR = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>Allow images with VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</summary>
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = VkSwapchainCreateFlagsKHR.SplitInstanceBindRegionsKHR;
        ///<summary>Swapchain is protected</summary>
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = VkSwapchainCreateFlagsKHR.ProtectedKHR;
        ///<summary>Allow images with VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</summary>
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = VkSwapchainCreateFlagsKHR.SplitInstanceBindRegionsKHR;
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = VkSwapchainCreateFlagsKHR.MutableFormatKHR;
    }

    public enum VkViewportCoordinateSwizzleNV
    {
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = 0,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = 1,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = 2,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = 3,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = 4,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = 5,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = 6,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = 7,
    }
    public static partial class RawConstants
    {
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV;
    }

    public enum VkDiscardRectangleModeEXT
    {
        InclusiveEXT = 0,
        ExclusiveEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkDiscardRectangleModeEXT VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT = VkDiscardRectangleModeEXT.InclusiveEXT;
        public const VkDiscardRectangleModeEXT VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT = VkDiscardRectangleModeEXT.ExclusiveEXT;
    }

    [Flags]
    public enum VkSubpassDescriptionFlags
    {
        None = 0,
        PerViewAttributesNVX = 1,
        PerViewPositionXOnlyNVX = 2,
        FragmentRegionQcom = 4,
        ShaderResolveQcom = 8,
    }
    public static partial class RawConstants
    {
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX = VkSubpassDescriptionFlags.PerViewAttributesNVX;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX = VkSubpassDescriptionFlags.PerViewPositionXOnlyNVX;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM = VkSubpassDescriptionFlags.FragmentRegionQcom;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM = VkSubpassDescriptionFlags.ShaderResolveQcom;
    }

    public enum VkPointClippingBehavior
    {
        AllClipPlanes = 0,
        UserClipPlanesOnly = 1,
    }
    public static partial class RawConstants
    {
        public const VkPointClippingBehavior VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = VkPointClippingBehavior.AllClipPlanes;
        public const VkPointClippingBehavior VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = VkPointClippingBehavior.UserClipPlanesOnly;
    }

    public enum VkSamplerReductionMode
    {
        WeightedAverage = 0,
        Min = 1,
        Max = 2,
    }
    public static partial class RawConstants
    {
        public const VkSamplerReductionMode VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE = VkSamplerReductionMode.WeightedAverage;
        public const VkSamplerReductionMode VK_SAMPLER_REDUCTION_MODE_MIN = VkSamplerReductionMode.Min;
        public const VkSamplerReductionMode VK_SAMPLER_REDUCTION_MODE_MAX = VkSamplerReductionMode.Max;
    }

    public enum VkTessellationDomainOrigin
    {
        UpperLeft = 0,
        LowerLeft = 1,
    }
    public static partial class RawConstants
    {
        public const VkTessellationDomainOrigin VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT = VkTessellationDomainOrigin.UpperLeft;
        public const VkTessellationDomainOrigin VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT = VkTessellationDomainOrigin.LowerLeft;
    }

    public enum VkSamplerYcbcrModelConversion
    {
        RgbIdentity = 0,
        ///<summary>just range expansion</summary>
        YcbcrIdentity = 1,
        ///<summary>aka HD YUV</summary>
        Ycbcr709 = 2,
        ///<summary>aka SD YUV</summary>
        Ycbcr601 = 3,
        ///<summary>aka UHD YUV</summary>
        Ycbcr2020 = 4,
    }
    public static partial class RawConstants
    {
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY = VkSamplerYcbcrModelConversion.RgbIdentity;
        ///<summary>just range expansion</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY = VkSamplerYcbcrModelConversion.YcbcrIdentity;
        ///<summary>aka HD YUV</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 = VkSamplerYcbcrModelConversion.Ycbcr709;
        ///<summary>aka SD YUV</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 = VkSamplerYcbcrModelConversion.Ycbcr601;
        ///<summary>aka UHD YUV</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 = VkSamplerYcbcrModelConversion.Ycbcr2020;
    }

    public enum VkSamplerYcbcrRange
    {
        ///<summary>Luma 0..1 maps to 0..255, chroma -0.5..0.5 to 1..255 (clamped)</summary>
        ItuFull = 0,
        ///<summary>Luma 0..1 maps to 16..235, chroma -0.5..0.5 to 16..240</summary>
        ItuNarrow = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Luma 0..1 maps to 0..255, chroma -0.5..0.5 to 1..255 (clamped)</summary>
        public const VkSamplerYcbcrRange VK_SAMPLER_YCBCR_RANGE_ITU_FULL = VkSamplerYcbcrRange.ItuFull;
        ///<summary>Luma 0..1 maps to 16..235, chroma -0.5..0.5 to 16..240</summary>
        public const VkSamplerYcbcrRange VK_SAMPLER_YCBCR_RANGE_ITU_NARROW = VkSamplerYcbcrRange.ItuNarrow;
    }

    public enum VkChromaLocation
    {
        CositedEven = 0,
        Midpoint = 1,
    }
    public static partial class RawConstants
    {
        public const VkChromaLocation VK_CHROMA_LOCATION_COSITED_EVEN = VkChromaLocation.CositedEven;
        public const VkChromaLocation VK_CHROMA_LOCATION_MIDPOINT = VkChromaLocation.Midpoint;
    }

    public enum VkBlendOverlapEXT
    {
        UncorrelatedEXT = 0,
        DisjointEXT = 1,
        ConjointEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkBlendOverlapEXT VK_BLEND_OVERLAP_UNCORRELATED_EXT = VkBlendOverlapEXT.UncorrelatedEXT;
        public const VkBlendOverlapEXT VK_BLEND_OVERLAP_DISJOINT_EXT = VkBlendOverlapEXT.DisjointEXT;
        public const VkBlendOverlapEXT VK_BLEND_OVERLAP_CONJOINT_EXT = VkBlendOverlapEXT.ConjointEXT;
    }

    public enum VkCoverageModulationModeNV
    {
        VK_COVERAGE_MODULATION_MODE_NONE_NV = 0,
        VK_COVERAGE_MODULATION_MODE_RGB_NV = 1,
        VK_COVERAGE_MODULATION_MODE_ALPHA_NV = 2,
        VK_COVERAGE_MODULATION_MODE_RGBA_NV = 3,
    }
    public static partial class RawConstants
    {
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_NONE_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_NONE_NV;
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_RGB_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_RGB_NV;
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_ALPHA_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_ALPHA_NV;
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_RGBA_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_RGBA_NV;
    }

    public enum VkCoverageReductionModeNV
    {
        VK_COVERAGE_REDUCTION_MODE_MERGE_NV = 0,
        VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkCoverageReductionModeNV VK_COVERAGE_REDUCTION_MODE_MERGE_NV = VkCoverageReductionModeNV.VK_COVERAGE_REDUCTION_MODE_MERGE_NV;
        public const VkCoverageReductionModeNV VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV = VkCoverageReductionModeNV.VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV;
    }

    public enum VkValidationCacheHeaderVersionEXT
    {
        OneEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkValidationCacheHeaderVersionEXT VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT = VkValidationCacheHeaderVersionEXT.OneEXT;
    }

    public enum VkShaderInfoTypeAMD
    {
        StatisticsAMD = 0,
        BinaryAMD = 1,
        DisassemblyAMD = 2,
    }
    public static partial class RawConstants
    {
        public const VkShaderInfoTypeAMD VK_SHADER_INFO_TYPE_STATISTICS_AMD = VkShaderInfoTypeAMD.StatisticsAMD;
        public const VkShaderInfoTypeAMD VK_SHADER_INFO_TYPE_BINARY_AMD = VkShaderInfoTypeAMD.BinaryAMD;
        public const VkShaderInfoTypeAMD VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD = VkShaderInfoTypeAMD.DisassemblyAMD;
    }

    public enum VkQueueGlobalPriorityEXT
    {
        LowEXT = 128,
        MediumEXT = 256,
        HighEXT = 512,
        RealtimeEXT = 1024,
    }
    public static partial class RawConstants
    {
        public const VkQueueGlobalPriorityEXT VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = VkQueueGlobalPriorityEXT.LowEXT;
        public const VkQueueGlobalPriorityEXT VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = VkQueueGlobalPriorityEXT.MediumEXT;
        public const VkQueueGlobalPriorityEXT VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = VkQueueGlobalPriorityEXT.HighEXT;
        public const VkQueueGlobalPriorityEXT VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = VkQueueGlobalPriorityEXT.RealtimeEXT;
    }

    [Flags]
    public enum VkDebugUtilsMessageSeverityFlagsEXT
    {
        None = 0,
        VerboseEXT = 1,
        InfoEXT = 16,
        WarningEXT = 256,
        ErrorEXT = 4096,
    }
    public static partial class RawConstants
    {
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.VerboseEXT;
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.InfoEXT;
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.WarningEXT;
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.ErrorEXT;
    }

    [Flags]
    public enum VkDebugUtilsMessageTypeFlagsEXT
    {
        None = 0,
        GeneralEXT = 1,
        ValidationEXT = 2,
        PerformanceEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkDebugUtilsMessageTypeFlagsEXT VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT = VkDebugUtilsMessageTypeFlagsEXT.GeneralEXT;
        public const VkDebugUtilsMessageTypeFlagsEXT VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT = VkDebugUtilsMessageTypeFlagsEXT.ValidationEXT;
        public const VkDebugUtilsMessageTypeFlagsEXT VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT = VkDebugUtilsMessageTypeFlagsEXT.PerformanceEXT;
    }

    public enum VkConservativeRasterizationModeEXT
    {
        DisabledEXT = 0,
        OverestimateEXT = 1,
        UnderestimateEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkConservativeRasterizationModeEXT VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT = VkConservativeRasterizationModeEXT.DisabledEXT;
        public const VkConservativeRasterizationModeEXT VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT = VkConservativeRasterizationModeEXT.OverestimateEXT;
        public const VkConservativeRasterizationModeEXT VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT = VkConservativeRasterizationModeEXT.UnderestimateEXT;
    }

    [Flags]
    public enum VkDescriptorBindingFlags
    {
        None = 0,
        UpdateAfterBind = 1,
        UpdateUnusedWhilePending = 2,
        PartiallyBound = 4,
        VariableDescriptorCount = 8,
        Reserved4Qcom = 16,
    }
    public static partial class RawConstants
    {
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT = VkDescriptorBindingFlags.UpdateAfterBind;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT = VkDescriptorBindingFlags.UpdateUnusedWhilePending;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT = VkDescriptorBindingFlags.PartiallyBound;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT = VkDescriptorBindingFlags.VariableDescriptorCount;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_RESERVED_4_BIT_QCOM = VkDescriptorBindingFlags.Reserved4Qcom;
    }

    public enum VkVendorId
    {
        ///<summary>Vivante vendor ID</summary>
        Viv = 65537,
        ///<summary>VeriSilicon vendor ID</summary>
        Vsi = 65538,
        ///<summary>Kazan Software Renderer</summary>
        Kazan = 65539,
        ///<summary>Codeplay Software Ltd. vendor ID</summary>
        Codeplay = 65540,
        ///<summary>Mesa vendor ID</summary>
        Mesa = 65541,
        ///<summary>PoCL vendor ID</summary>
        Pocl = 65542,
    }
    public static partial class RawConstants
    {
        ///<summary>Vivante vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_VIV = VkVendorId.Viv;
        ///<summary>VeriSilicon vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_VSI = VkVendorId.Vsi;
        ///<summary>Kazan Software Renderer</summary>
        public const VkVendorId VK_VENDOR_ID_KAZAN = VkVendorId.Kazan;
        ///<summary>Codeplay Software Ltd. vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_CODEPLAY = VkVendorId.Codeplay;
        ///<summary>Mesa vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_MESA = VkVendorId.Mesa;
        ///<summary>PoCL vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_POCL = VkVendorId.Pocl;
    }

    public enum VkDriverId
    {
        ///<summary>Advanced Micro Devices, Inc.</summary>
        AMDProprietary = 1,
        ///<summary>Advanced Micro Devices, Inc.</summary>
        AMDOpenSource = 2,
        ///<summary>Mesa open source project</summary>
        MesaRadv = 3,
        ///<summary>NVIDIA Corporation</summary>
        NvidiaProprietary = 4,
        ///<summary>Intel Corporation</summary>
        IntelProprietaryWindows = 5,
        ///<summary>Intel Corporation</summary>
        IntelOpenSourceMesa = 6,
        ///<summary>Imagination Technologies</summary>
        ImaginationProprietary = 7,
        ///<summary>Qualcomm Technologies, Inc.</summary>
        QualcommProprietary = 8,
        ///<summary>Arm Limited</summary>
        ArmProprietary = 9,
        ///<summary>Google LLC</summary>
        GoogleSwiftshader = 10,
        ///<summary>Google LLC</summary>
        GgpProprietary = 11,
        ///<summary>Broadcom Inc.</summary>
        BroadcomProprietary = 12,
        ///<summary>Mesa</summary>
        MesaLlvmpipe = 13,
        ///<summary>MoltenVK</summary>
        Moltenvk = 14,
    }
    public static partial class RawConstants
    {
        ///<summary>Advanced Micro Devices, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_AMD_PROPRIETARY = VkDriverId.AMDProprietary;
        ///<summary>Advanced Micro Devices, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_AMD_OPEN_SOURCE = VkDriverId.AMDOpenSource;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_RADV = VkDriverId.MesaRadv;
        ///<summary>NVIDIA Corporation</summary>
        public const VkDriverId VK_DRIVER_ID_NVIDIA_PROPRIETARY = VkDriverId.NvidiaProprietary;
        ///<summary>Intel Corporation</summary>
        public const VkDriverId VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS = VkDriverId.IntelProprietaryWindows;
        ///<summary>Intel Corporation</summary>
        public const VkDriverId VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA = VkDriverId.IntelOpenSourceMesa;
        ///<summary>Imagination Technologies</summary>
        public const VkDriverId VK_DRIVER_ID_IMAGINATION_PROPRIETARY = VkDriverId.ImaginationProprietary;
        ///<summary>Qualcomm Technologies, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_QUALCOMM_PROPRIETARY = VkDriverId.QualcommProprietary;
        ///<summary>Arm Limited</summary>
        public const VkDriverId VK_DRIVER_ID_ARM_PROPRIETARY = VkDriverId.ArmProprietary;
        ///<summary>Google LLC</summary>
        public const VkDriverId VK_DRIVER_ID_GOOGLE_SWIFTSHADER = VkDriverId.GoogleSwiftshader;
        ///<summary>Google LLC</summary>
        public const VkDriverId VK_DRIVER_ID_GGP_PROPRIETARY = VkDriverId.GgpProprietary;
        ///<summary>Broadcom Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_BROADCOM_PROPRIETARY = VkDriverId.BroadcomProprietary;
        ///<summary>Mesa</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_LLVMPIPE = VkDriverId.MesaLlvmpipe;
        ///<summary>MoltenVK</summary>
        public const VkDriverId VK_DRIVER_ID_MOLTENVK = VkDriverId.Moltenvk;
    }

    [Flags]
    public enum VkConditionalRenderingFlagsEXT
    {
        None = 0,
        InvertedEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkConditionalRenderingFlagsEXT VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT = VkConditionalRenderingFlagsEXT.InvertedEXT;
    }

    [Flags]
    public enum VkResolveModeFlags
    {
        None = 0,
        SampleZero = 1,
        Average = 2,
        Min = 4,
        Max = 8,
    }
    public static partial class RawConstants
    {
        public const VkResolveModeFlags VK_RESOLVE_MODE_NONE = VkResolveModeFlags.None;
        public const VkResolveModeFlags VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = VkResolveModeFlags.SampleZero;
        public const VkResolveModeFlags VK_RESOLVE_MODE_AVERAGE_BIT = VkResolveModeFlags.Average;
        public const VkResolveModeFlags VK_RESOLVE_MODE_MIN_BIT = VkResolveModeFlags.Min;
        public const VkResolveModeFlags VK_RESOLVE_MODE_MAX_BIT = VkResolveModeFlags.Max;
    }

    public enum VkShadingRatePaletteEntryNV
    {
        VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV = 0,
        VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV = 1,
        VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV = 2,
        VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV = 3,
        VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV = 4,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV = 5,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV = 6,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV = 7,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV = 8,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV = 10,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV = 11,
    }
    public static partial class RawConstants
    {
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV;
    }

    public enum VkCoarseSampleOrderTypeNV
    {
        VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = 0,
        VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = 1,
        VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = 2,
        VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = 3,
    }
    public static partial class RawConstants
    {
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV;
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV;
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV;
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV;
    }

    [Flags]
    public enum VkGeometryInstanceFlagsKHR
    {
        None = 0,
        TriangleFacingCullDisableKHR = 1,
        TriangleFrontCounterclockwiseKHR = 2,
        ForceOpaqueKHR = 4,
        ForceNoOpaqueKHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR = VkGeometryInstanceFlagsKHR.TriangleFacingCullDisableKHR;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR = VkGeometryInstanceFlagsKHR.TriangleFrontCounterclockwiseKHR;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR = VkGeometryInstanceFlagsKHR.ForceOpaqueKHR;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR = VkGeometryInstanceFlagsKHR.ForceNoOpaqueKHR;
    }

    [Flags]
    public enum VkGeometryFlagsKHR
    {
        None = 0,
        OpaqueKHR = 1,
        NoDuplicateAnyHitInvocationKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkGeometryFlagsKHR VK_GEOMETRY_OPAQUE_BIT_KHR = VkGeometryFlagsKHR.OpaqueKHR;
        public const VkGeometryFlagsKHR VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = VkGeometryFlagsKHR.NoDuplicateAnyHitInvocationKHR;
    }

    [Flags]
    public enum VkBuildAccelerationStructureFlagsKHR
    {
        None = 0,
        AllowUpdateKHR = 1,
        AllowCompactionKHR = 2,
        PreferFastTraceKHR = 4,
        PreferFastBuildKHR = 8,
        LowMemoryKHR = 16,
    }
    public static partial class RawConstants
    {
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.AllowUpdateKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.AllowCompactionKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.PreferFastTraceKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.PreferFastBuildKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.LowMemoryKHR;
    }

    [Flags]
    public enum VkAccelerationStructureCreateFlagsKHR
    {
        None = 0,
        DeviceAddressCaptureReplayKHR = 1,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureCreateFlagsKHR VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = VkAccelerationStructureCreateFlagsKHR.DeviceAddressCaptureReplayKHR;
    }

    public enum VkCopyAccelerationStructureModeKHR
    {
        CloneKHR = 0,
        CompactKHR = 1,
        SerializeKHR = 2,
        DeserializeKHR = 3,
    }
    public static partial class RawConstants
    {
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR = VkCopyAccelerationStructureModeKHR.CloneKHR;
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR = VkCopyAccelerationStructureModeKHR.CompactKHR;
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR = VkCopyAccelerationStructureModeKHR.SerializeKHR;
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR = VkCopyAccelerationStructureModeKHR.DeserializeKHR;
    }

    public enum VkBuildAccelerationStructureModeKHR
    {
        BuildKHR = 0,
        UpdateKHR = 1,
    }
    public static partial class RawConstants
    {
        public const VkBuildAccelerationStructureModeKHR VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR = VkBuildAccelerationStructureModeKHR.BuildKHR;
        public const VkBuildAccelerationStructureModeKHR VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR = VkBuildAccelerationStructureModeKHR.UpdateKHR;
    }

    public enum VkAccelerationStructureTypeKHR
    {
        TopLevelKHR = 0,
        BottomLevelKHR = 1,
        GenericKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureTypeKHR VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR = VkAccelerationStructureTypeKHR.TopLevelKHR;
        public const VkAccelerationStructureTypeKHR VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR = VkAccelerationStructureTypeKHR.BottomLevelKHR;
        public const VkAccelerationStructureTypeKHR VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR = VkAccelerationStructureTypeKHR.GenericKHR;
    }

    public enum VkGeometryTypeKHR
    {
        TrianglesKHR = 0,
        AabbsKHR = 1,
        InstancesKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkGeometryTypeKHR VK_GEOMETRY_TYPE_TRIANGLES_KHR = VkGeometryTypeKHR.TrianglesKHR;
        public const VkGeometryTypeKHR VK_GEOMETRY_TYPE_AABBS_KHR = VkGeometryTypeKHR.AabbsKHR;
        public const VkGeometryTypeKHR VK_GEOMETRY_TYPE_INSTANCES_KHR = VkGeometryTypeKHR.InstancesKHR;
    }

    public enum VkAccelerationStructureMemoryRequirementsTypeNV
    {
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = 0,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = 1,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = 2,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureMemoryRequirementsTypeNV VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = VkAccelerationStructureMemoryRequirementsTypeNV.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV;
        public const VkAccelerationStructureMemoryRequirementsTypeNV VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = VkAccelerationStructureMemoryRequirementsTypeNV.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV;
        public const VkAccelerationStructureMemoryRequirementsTypeNV VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = VkAccelerationStructureMemoryRequirementsTypeNV.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV;
    }

    public enum VkAccelerationStructureBuildTypeKHR
    {
        HostKHR = 0,
        DeviceKHR = 1,
        HostOrDeviceKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureBuildTypeKHR VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR = VkAccelerationStructureBuildTypeKHR.HostKHR;
        public const VkAccelerationStructureBuildTypeKHR VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR = VkAccelerationStructureBuildTypeKHR.DeviceKHR;
        public const VkAccelerationStructureBuildTypeKHR VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR = VkAccelerationStructureBuildTypeKHR.HostOrDeviceKHR;
    }

    public enum VkRayTracingShaderGroupTypeKHR
    {
        GeneralKHR = 0,
        TrianglesHitGroupKHR = 1,
        ProceduralHitGroupKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkRayTracingShaderGroupTypeKHR VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR = VkRayTracingShaderGroupTypeKHR.GeneralKHR;
        public const VkRayTracingShaderGroupTypeKHR VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR = VkRayTracingShaderGroupTypeKHR.TrianglesHitGroupKHR;
        public const VkRayTracingShaderGroupTypeKHR VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR = VkRayTracingShaderGroupTypeKHR.ProceduralHitGroupKHR;
    }

    public enum VkAccelerationStructureCompatibilityKHR
    {
        CompatibleKHR = 0,
        IncompatibleKHR = 1,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureCompatibilityKHR VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR = VkAccelerationStructureCompatibilityKHR.CompatibleKHR;
        public const VkAccelerationStructureCompatibilityKHR VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR = VkAccelerationStructureCompatibilityKHR.IncompatibleKHR;
    }

    public enum VkShaderGroupShaderKHR
    {
        GeneralKHR = 0,
        ClosestHitKHR = 1,
        AnyHitKHR = 2,
        IntersectionKHR = 3,
    }
    public static partial class RawConstants
    {
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_GENERAL_KHR = VkShaderGroupShaderKHR.GeneralKHR;
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR = VkShaderGroupShaderKHR.ClosestHitKHR;
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_ANY_HIT_KHR = VkShaderGroupShaderKHR.AnyHitKHR;
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_INTERSECTION_KHR = VkShaderGroupShaderKHR.IntersectionKHR;
    }

    public enum VkMemoryOverallocationBehaviorAMD
    {
        DefaultAMD = 0,
        AllowedAMD = 1,
        DisallowedAMD = 2,
    }
    public static partial class RawConstants
    {
        public const VkMemoryOverallocationBehaviorAMD VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = VkMemoryOverallocationBehaviorAMD.DefaultAMD;
        public const VkMemoryOverallocationBehaviorAMD VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = VkMemoryOverallocationBehaviorAMD.AllowedAMD;
        public const VkMemoryOverallocationBehaviorAMD VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = VkMemoryOverallocationBehaviorAMD.DisallowedAMD;
    }

    [Flags]
    public enum VkFramebufferCreateFlags
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    public enum VkScopeNV
    {
        VK_SCOPE_DEVICE_NV = 1,
        VK_SCOPE_WORKGROUP_NV = 2,
        VK_SCOPE_SUBGROUP_NV = 3,
        VK_SCOPE_QUEUE_FAMILY_NV = 5,
    }
    public static partial class RawConstants
    {
        public const VkScopeNV VK_SCOPE_DEVICE_NV = VkScopeNV.VK_SCOPE_DEVICE_NV;
        public const VkScopeNV VK_SCOPE_WORKGROUP_NV = VkScopeNV.VK_SCOPE_WORKGROUP_NV;
        public const VkScopeNV VK_SCOPE_SUBGROUP_NV = VkScopeNV.VK_SCOPE_SUBGROUP_NV;
        public const VkScopeNV VK_SCOPE_QUEUE_FAMILY_NV = VkScopeNV.VK_SCOPE_QUEUE_FAMILY_NV;
    }

    public enum VkComponentTypeNV
    {
        VK_COMPONENT_TYPE_FLOAT16_NV = 0,
        VK_COMPONENT_TYPE_FLOAT32_NV = 1,
        VK_COMPONENT_TYPE_FLOAT64_NV = 2,
        VK_COMPONENT_TYPE_SINT8_NV = 3,
        VK_COMPONENT_TYPE_SINT16_NV = 4,
        VK_COMPONENT_TYPE_SINT32_NV = 5,
        VK_COMPONENT_TYPE_SINT64_NV = 6,
        VK_COMPONENT_TYPE_UINT8_NV = 7,
        VK_COMPONENT_TYPE_UINT16_NV = 8,
        VK_COMPONENT_TYPE_UINT32_NV = 9,
        VK_COMPONENT_TYPE_UINT64_NV = 10,
    }
    public static partial class RawConstants
    {
        public const VkComponentTypeNV VK_COMPONENT_TYPE_FLOAT16_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_FLOAT16_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_FLOAT32_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_FLOAT32_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_FLOAT64_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_FLOAT64_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_SINT8_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_SINT8_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_SINT16_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_SINT16_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_SINT32_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_SINT32_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_SINT64_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_SINT64_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_UINT8_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_UINT8_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_UINT16_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_UINT16_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_UINT32_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_UINT32_NV;
        public const VkComponentTypeNV VK_COMPONENT_TYPE_UINT64_NV = VkComponentTypeNV.VK_COMPONENT_TYPE_UINT64_NV;
    }

    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagsNV
    {
        None = 0,
        EnableShaderDebugInfoNV = 1,
        EnableResourceTrackingNV = 2,
        EnableAutomaticCheckpointsNV = 4,
    }
    public static partial class RawConstants
    {
        public const VkDeviceDiagnosticsConfigFlagsNV VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV = VkDeviceDiagnosticsConfigFlagsNV.EnableShaderDebugInfoNV;
        public const VkDeviceDiagnosticsConfigFlagsNV VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV = VkDeviceDiagnosticsConfigFlagsNV.EnableResourceTrackingNV;
        public const VkDeviceDiagnosticsConfigFlagsNV VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV = VkDeviceDiagnosticsConfigFlagsNV.EnableAutomaticCheckpointsNV;
    }

    [Flags]
    public enum VkPipelineCreationFeedbackFlagsEXT
    {
        None = 0,
        ValidEXT = 1,
        ApplicationPipelineCacheHitEXT = 2,
        BasePipelineAccelerationEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCreationFeedbackFlagsEXT VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT = VkPipelineCreationFeedbackFlagsEXT.ValidEXT;
        public const VkPipelineCreationFeedbackFlagsEXT VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT = VkPipelineCreationFeedbackFlagsEXT.ApplicationPipelineCacheHitEXT;
        public const VkPipelineCreationFeedbackFlagsEXT VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT = VkPipelineCreationFeedbackFlagsEXT.BasePipelineAccelerationEXT;
    }

    public enum VkFullScreenExclusiveEXT
    {
        DefaultEXT = 0,
        AllowedEXT = 1,
        DisallowedEXT = 2,
        ApplicationControlledEXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT = VkFullScreenExclusiveEXT.DefaultEXT;
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT = VkFullScreenExclusiveEXT.AllowedEXT;
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT = VkFullScreenExclusiveEXT.DisallowedEXT;
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT = VkFullScreenExclusiveEXT.ApplicationControlledEXT;
    }

    public enum VkPerformanceCounterScopeKHR
    {
        CommandBufferKHR = 0,
        RenderPassKHR = 1,
        CommandKHR = 2,
        VK_QUERY_SCOPE_COMMAND_BUFFER_KHR = 0,
        VK_QUERY_SCOPE_RENDER_PASS_KHR = 1,
        VK_QUERY_SCOPE_COMMAND_KHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterScopeKHR VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR = VkPerformanceCounterScopeKHR.CommandBufferKHR;
        public const VkPerformanceCounterScopeKHR VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR = VkPerformanceCounterScopeKHR.RenderPassKHR;
        public const VkPerformanceCounterScopeKHR VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR = VkPerformanceCounterScopeKHR.CommandKHR;
        public const VkPerformanceCounterScopeKHR VK_QUERY_SCOPE_COMMAND_BUFFER_KHR = VkPerformanceCounterScopeKHR.VK_QUERY_SCOPE_COMMAND_BUFFER_KHR;
        public const VkPerformanceCounterScopeKHR VK_QUERY_SCOPE_RENDER_PASS_KHR = VkPerformanceCounterScopeKHR.VK_QUERY_SCOPE_RENDER_PASS_KHR;
        public const VkPerformanceCounterScopeKHR VK_QUERY_SCOPE_COMMAND_KHR = VkPerformanceCounterScopeKHR.VK_QUERY_SCOPE_COMMAND_KHR;
    }

    public enum VkPerformanceCounterUnitKHR
    {
        GenericKHR = 0,
        PercentageKHR = 1,
        NanosecondsKHR = 2,
        BytesKHR = 3,
        BytesPerSecondKHR = 4,
        KelvinKHR = 5,
        WattsKHR = 6,
        VoltsKHR = 7,
        AmpsKHR = 8,
        HertzKHR = 9,
        CyclesKHR = 10,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR = VkPerformanceCounterUnitKHR.GenericKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR = VkPerformanceCounterUnitKHR.PercentageKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR = VkPerformanceCounterUnitKHR.NanosecondsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR = VkPerformanceCounterUnitKHR.BytesKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR = VkPerformanceCounterUnitKHR.BytesPerSecondKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR = VkPerformanceCounterUnitKHR.KelvinKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR = VkPerformanceCounterUnitKHR.WattsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR = VkPerformanceCounterUnitKHR.VoltsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR = VkPerformanceCounterUnitKHR.AmpsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR = VkPerformanceCounterUnitKHR.HertzKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR = VkPerformanceCounterUnitKHR.CyclesKHR;
    }

    public enum VkPerformanceCounterStorageKHR
    {
        Int32KHR = 0,
        Int64KHR = 1,
        Uint32KHR = 2,
        Uint64KHR = 3,
        Float32KHR = 4,
        Float64KHR = 5,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR = VkPerformanceCounterStorageKHR.Int32KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR = VkPerformanceCounterStorageKHR.Int64KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR = VkPerformanceCounterStorageKHR.Uint32KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR = VkPerformanceCounterStorageKHR.Uint64KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR = VkPerformanceCounterStorageKHR.Float32KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR = VkPerformanceCounterStorageKHR.Float64KHR;
    }

    [Flags]
    public enum VkPerformanceCounterDescriptionFlagsKHR
    {
        None = 0,
        PerformanceImpactingKHR = 1,
        ///<summary>Backwards-compatible alias containing a typo</summary>
        PerformanceImpactingKHR = 1,
        ConcurrentlyImpactedKHR = 2,
        ///<summary>Backwards-compatible alias containing a typo</summary>
        ConcurrentlyImpactedKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterDescriptionFlagsKHR VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR = VkPerformanceCounterDescriptionFlagsKHR.PerformanceImpactingKHR;
        ///<summary>Backwards-compatible alias containing a typo</summary>
        public const VkPerformanceCounterDescriptionFlagsKHR VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_KHR = VkPerformanceCounterDescriptionFlagsKHR.PerformanceImpactingKHR;
        public const VkPerformanceCounterDescriptionFlagsKHR VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR = VkPerformanceCounterDescriptionFlagsKHR.ConcurrentlyImpactedKHR;
        ///<summary>Backwards-compatible alias containing a typo</summary>
        public const VkPerformanceCounterDescriptionFlagsKHR VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_KHR = VkPerformanceCounterDescriptionFlagsKHR.ConcurrentlyImpactedKHR;
    }

    [Flags]
    public enum VkAcquireProfilingLockFlagsKHR
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkShaderCorePropertiesFlagsAMD
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    public enum VkPerformanceConfigurationTypeINTEL
    {
        VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = 0,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceConfigurationTypeINTEL VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = VkPerformanceConfigurationTypeINTEL.VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL;
    }

    public enum VkQueryPoolSamplingModeINTEL
    {
        VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = 0,
    }
    public static partial class RawConstants
    {
        public const VkQueryPoolSamplingModeINTEL VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = VkQueryPoolSamplingModeINTEL.VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL;
    }

    public enum VkPerformanceOverrideTypeINTEL
    {
        VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL = 0,
        VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL = 1,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceOverrideTypeINTEL VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL = VkPerformanceOverrideTypeINTEL.VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL;
        public const VkPerformanceOverrideTypeINTEL VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL = VkPerformanceOverrideTypeINTEL.VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL;
    }

    public enum VkPerformanceParameterTypeINTEL
    {
        VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL = 0,
        VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL = 1,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceParameterTypeINTEL VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL = VkPerformanceParameterTypeINTEL.VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL;
        public const VkPerformanceParameterTypeINTEL VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL = VkPerformanceParameterTypeINTEL.VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL;
    }

    public enum VkPerformanceValueTypeINTEL
    {
        VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = 0,
        VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = 1,
        VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = 2,
        VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = 3,
        VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = 4,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL;
    }

    public enum VkShaderFloatControlsIndependence
    {
        _32Only = 0,
        All = 1,
        None = 2,
    }
    public static partial class RawConstants
    {
        public const VkShaderFloatControlsIndependence VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY = VkShaderFloatControlsIndependence._32Only;
        public const VkShaderFloatControlsIndependence VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL = VkShaderFloatControlsIndependence.All;
        public const VkShaderFloatControlsIndependence VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE = VkShaderFloatControlsIndependence.None;
    }

    public enum VkPipelineExecutableStatisticFormatKHR
    {
        Bool32KHR = 0,
        Int64KHR = 1,
        Uint64KHR = 2,
        Float64KHR = 3,
    }
    public static partial class RawConstants
    {
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR = VkPipelineExecutableStatisticFormatKHR.Bool32KHR;
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR = VkPipelineExecutableStatisticFormatKHR.Int64KHR;
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR = VkPipelineExecutableStatisticFormatKHR.Uint64KHR;
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR = VkPipelineExecutableStatisticFormatKHR.Float64KHR;
    }

    public enum VkLineRasterizationModeEXT
    {
        DefaultEXT = 0,
        RectangularEXT = 1,
        BresenhamEXT = 2,
        RectangularSmoothEXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT = VkLineRasterizationModeEXT.DefaultEXT;
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT = VkLineRasterizationModeEXT.RectangularEXT;
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT = VkLineRasterizationModeEXT.BresenhamEXT;
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT = VkLineRasterizationModeEXT.RectangularSmoothEXT;
    }

    [Flags]
    public enum VkShaderModuleCreateFlags
    {
        None = 0,
        Reserved0NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkShaderModuleCreateFlags VK_SHADER_MODULE_CREATE_RESERVED_0_BIT_NV = VkShaderModuleCreateFlags.Reserved0NV;
    }

    [Flags]
    public enum VkPipelineCompilerControlFlagsAMD
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkToolPurposeFlagsEXT
    {
        None = 0,
        ValidationEXT = 1,
        ProfilingEXT = 2,
        TracingEXT = 4,
        AdditionalFeaturesEXT = 8,
        ModifyingFeaturesEXT = 16,
        DebugReportingEXT = 32,
        DebugMarkersEXT = 64,
        DebugReportingEXT = 32,
        DebugMarkersEXT = 64,
    }
    public static partial class RawConstants
    {
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_VALIDATION_BIT_EXT = VkToolPurposeFlagsEXT.ValidationEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_PROFILING_BIT_EXT = VkToolPurposeFlagsEXT.ProfilingEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_TRACING_BIT_EXT = VkToolPurposeFlagsEXT.TracingEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT = VkToolPurposeFlagsEXT.AdditionalFeaturesEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT = VkToolPurposeFlagsEXT.ModifyingFeaturesEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = VkToolPurposeFlagsEXT.DebugReportingEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = VkToolPurposeFlagsEXT.DebugMarkersEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = VkToolPurposeFlagsEXT.DebugReportingEXT;
        public const VkToolPurposeFlagsEXT VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = VkToolPurposeFlagsEXT.DebugMarkersEXT;
    }

    public enum VkFragmentShadingRateCombinerOpKHR
    {
        KeepKHR = 0,
        ReplaceKHR = 1,
        MinKHR = 2,
        MaxKHR = 3,
        MulKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR = VkFragmentShadingRateCombinerOpKHR.KeepKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR = VkFragmentShadingRateCombinerOpKHR.ReplaceKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR = VkFragmentShadingRateCombinerOpKHR.MinKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR = VkFragmentShadingRateCombinerOpKHR.MaxKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR = VkFragmentShadingRateCombinerOpKHR.MulKHR;
    }

    public enum VkFragmentShadingRateNV
    {
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 1,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 4,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 5,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 6,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 10,
        VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 11,
        VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 12,
        VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 13,
        VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 14,
        VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV = 15,
    }
    public static partial class RawConstants
    {
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV;
    }

    public enum VkFragmentShadingRateTypeNV
    {
        VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV = 0,
        VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkFragmentShadingRateTypeNV VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV = VkFragmentShadingRateTypeNV.VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV;
        public const VkFragmentShadingRateTypeNV VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV = VkFragmentShadingRateTypeNV.VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV;
    }
}
