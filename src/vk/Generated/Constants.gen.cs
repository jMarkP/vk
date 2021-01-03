// This file is generated.

using System.Runtime.InteropServices;

namespace Vulkan
{
    public static partial class VulkanNative
    {
        public const uint MaxPhysicalDeviceNameSize = 256;
        public const uint UuidSize = 16;
        public const uint LuidSize = 8;
        public const uint LuidSizeKHR = 8;
        public const uint MaxExtensionNameSize = 256;
        public const uint MaxDescriptionSize = 256;
        public const uint MaxMemoryTypes = 32;
        ///<summary>The maximum number of unique memory heaps, each of which supporting 1 or more memory types</summary>
        public const uint MaxMemoryHeaps = 16;
        public const float LodClampNone = 1000.0f;
        public const uint RemainingMipLevels = (~0U);
        public const uint RemainingArrayLayers = (~0U);
        public const ulong WholeSize = (~0UL);
        public const uint AttachmentUnused = (~0U);
        public const uint True = 1;
        public const uint False = 0;
        public const uint QueueFamilyIgnored = (~0U);
        public const uint QueueFamilyExternal = (~0U-1);
        public const uint QueueFamilyExternalKHR = (~0U-1);
        public const uint QueueFamilyForeignEXT = (~0U-2);
        public const uint SubpassExternal = (~0U);
        public const uint MaxDeviceGroupSize = 32;
        public const uint MaxDeviceGroupSizeKHR = 32;
        public const uint MaxDriverNameSize = 256;
        public const uint MaxDriverNameSizeKHR = 256;
        public const uint MaxDriverInfoSize = 256;
        public const uint MaxDriverInfoSizeKHR = 256;
        public const uint ShaderUnusedKHR = (~0U);
        public const uint ShaderUnusedNV = (~0U);
        ///<summary></summary>
        public const uint KHRSurfaceSpecVersion = 25;
        ///<summary></summary>
        public const uint KHRSurfaceExtensionName = "VK_KHR_surface";
        ///<summary></summary>
        public const uint KHRSwapchainSpecVersion = 70;
        ///<summary></summary>
        public const uint KHRSwapchainExtensionName = "VK_KHR_swapchain";
        ///<summary></summary>
        public const uint KHRDisplaySpecVersion = 23;
        ///<summary></summary>
        public const uint KHRDisplayExtensionName = "VK_KHR_display";
        ///<summary></summary>
        public const uint KHRDisplaySwapchainSpecVersion = 10;
        ///<summary></summary>
        public const uint KHRDisplaySwapchainExtensionName = "VK_KHR_display_swapchain";
        ///<summary></summary>
        public const uint KHRXlibSurfaceSpecVersion = 6;
        ///<summary></summary>
        public const uint KHRXlibSurfaceExtensionName = "VK_KHR_xlib_surface";
        ///<summary></summary>
        public const uint KHRXcbSurfaceSpecVersion = 6;
        ///<summary></summary>
        public const uint KHRXcbSurfaceExtensionName = "VK_KHR_xcb_surface";
        ///<summary></summary>
        public const uint KHRWaylandSurfaceSpecVersion = 6;
        ///<summary></summary>
        public const uint KHRWaylandSurfaceExtensionName = "VK_KHR_wayland_surface";
        ///<summary></summary>
        public const uint KHRMirSurfaceSpecVersion = 4;
        ///<summary></summary>
        public const uint KHRMirSurfaceExtensionName = "VK_KHR_mir_surface";
        ///<summary></summary>
        public const uint KHRAndroidSurfaceSpecVersion = 6;
        ///<summary></summary>
        public const uint KHRAndroidSurfaceExtensionName = "VK_KHR_android_surface";
        ///<summary></summary>
        public const uint KHRWin32SurfaceSpecVersion = 6;
        ///<summary></summary>
        public const uint KHRWin32SurfaceExtensionName = "VK_KHR_win32_surface";
        ///<summary></summary>
        public const uint AndroidNativeBufferSpecVersion = 8;
        ///<summary></summary>
        public const uint AndroidNativeBufferNumber = 11;
        ///<summary></summary>
        public const uint AndroidNativeBufferName = "VK_ANDROID_native_buffer";
        ///<summary></summary>
        public const uint AndroidNativeBufferExtensionName = "VK_ANDROID_native_buffer";
        ///<summary></summary>
        public const uint EXTDebugReportSpecVersion = 9;
        ///<summary></summary>
        public const uint EXTDebugReportExtensionName = "VK_EXT_debug_report";
        ///<summary></summary>
        public const uint NVGlslShaderSpecVersion = 1;
        ///<summary></summary>
        public const uint NVGlslShaderExtensionName = "VK_NV_glsl_shader";
        ///<summary></summary>
        public const uint EXTDepthRangeUnrestrictedSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDepthRangeUnrestrictedExtensionName = "VK_EXT_depth_range_unrestricted";
        ///<summary></summary>
        public const uint KHRSamplerMirrorClampToEdgeSpecVersion = 3;
        ///<summary></summary>
        public const uint KHRSamplerMirrorClampToEdgeExtensionName = "VK_KHR_sampler_mirror_clamp_to_edge";
        ///<summary></summary>
        public const uint ImgFilterCubicSpecVersion = 1;
        ///<summary></summary>
        public const uint ImgFilterCubicExtensionName = "VK_IMG_filter_cubic";
        ///<summary></summary>
        public const uint AMDExtension17SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension17ExtensionName = "VK_AMD_extension_17";
        ///<summary></summary>
        public const uint AMDExtension18SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension18ExtensionName = "VK_AMD_extension_18";
        ///<summary></summary>
        public const uint AMDRasterizationOrderSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDRasterizationOrderExtensionName = "VK_AMD_rasterization_order";
        ///<summary></summary>
        public const uint AMDExtension20SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension20ExtensionName = "VK_AMD_extension_20";
        ///<summary></summary>
        public const uint AMDShaderTrinaryMinmaxSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDShaderTrinaryMinmaxExtensionName = "VK_AMD_shader_trinary_minmax";
        ///<summary></summary>
        public const uint AMDShaderExplicitVertexParameterSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDShaderExplicitVertexParameterExtensionName = "VK_AMD_shader_explicit_vertex_parameter";
        ///<summary></summary>
        public const uint EXTDebugMarkerSpecVersion = 4;
        ///<summary></summary>
        public const uint EXTDebugMarkerExtensionName = "VK_EXT_debug_marker";
        ///<summary></summary>
        public const uint AMDExtension24SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension24ExtensionName = "VK_AMD_extension_24";
        ///<summary></summary>
        public const uint AMDExtension25SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension25ExtensionName = "VK_AMD_extension_25";
        ///<summary></summary>
        public const uint AMDGcnShaderSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDGcnShaderExtensionName = "VK_AMD_gcn_shader";
        ///<summary></summary>
        public const uint NVDedicatedAllocationSpecVersion = 1;
        ///<summary></summary>
        public const uint NVDedicatedAllocationExtensionName = "VK_NV_dedicated_allocation";
        ///<summary></summary>
        public const uint EXTExtension28SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension28ExtensionName = "VK_NV_extension_28";
        ///<summary></summary>
        public const uint EXTTransformFeedbackSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTTransformFeedbackExtensionName = "VK_EXT_transform_feedback";
        ///<summary></summary>
        public const uint NVXExtension30SpecVersion = 0;
        ///<summary></summary>
        public const uint NVXExtension30ExtensionName = "VK_NVX_extension_30";
        ///<summary></summary>
        public const uint NVXImageViewHandleSpecVersion = 2;
        ///<summary></summary>
        public const uint NVXImageViewHandleExtensionName = "VK_NVX_image_view_handle";
        ///<summary></summary>
        public const uint AMDExtension32SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension32ExtensionName = "VK_AMD_extension_32";
        ///<summary></summary>
        public const uint AMDExtension33SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension33ExtensionName = "VK_AMD_extension_33";
        ///<summary></summary>
        public const uint AMDDrawIndirectCountSpecVersion = 2;
        ///<summary></summary>
        public const uint AMDDrawIndirectCountExtensionName = "VK_AMD_draw_indirect_count";
        ///<summary></summary>
        public const uint AMDExtension35SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension35ExtensionName = "VK_AMD_extension_35";
        ///<summary></summary>
        public const uint AMDNegativeViewportHeightSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDNegativeViewportHeightExtensionName = "VK_AMD_negative_viewport_height";
        ///<summary></summary>
        public const uint AMDGpuShaderHalfFloatSpecVersion = 2;
        ///<summary></summary>
        public const uint AMDGpuShaderHalfFloatExtensionName = "VK_AMD_gpu_shader_half_float";
        ///<summary></summary>
        public const uint AMDShaderBallotSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDShaderBallotExtensionName = "VK_AMD_shader_ballot";
        ///<summary></summary>
        public const uint AMDExtension39SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension39ExtensionName = "VK_AMD_extension_39";
        ///<summary></summary>
        public const uint AMDExtension40SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension40ExtensionName = "VK_AMD_extension_40";
        ///<summary></summary>
        public const uint AMDExtension41SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension41ExtensionName = "VK_AMD_extension_41";
        ///<summary></summary>
        public const uint AMDTextureGatherBiasLodSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDTextureGatherBiasLodExtensionName = "VK_AMD_texture_gather_bias_lod";
        ///<summary></summary>
        public const uint AMDShaderInfoSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDShaderInfoExtensionName = "VK_AMD_shader_info";
        ///<summary></summary>
        public const uint AMDExtension44SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension44ExtensionName = "VK_AMD_extension_44";
        ///<summary></summary>
        public const uint AMDExtension45SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension45ExtensionName = "VK_AMD_extension_45";
        ///<summary></summary>
        public const uint AMDExtension46SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension46ExtensionName = "VK_AMD_extension_46";
        ///<summary></summary>
        public const uint AMDShaderImageLoadStoreLodSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDShaderImageLoadStoreLodExtensionName = "VK_AMD_shader_image_load_store_lod";
        ///<summary></summary>
        public const uint NVXExtension48SpecVersion = 0;
        ///<summary></summary>
        public const uint NVXExtension48ExtensionName = "VK_NVX_extension_48";
        ///<summary></summary>
        public const uint GoogleExtension49SpecVersion = 0;
        ///<summary></summary>
        public const uint GoogleExtension49ExtensionName = "VK_GOOGLE_extension_49";
        ///<summary></summary>
        public const uint GgpStreamDescriptorSurfaceSpecVersion = 1;
        ///<summary></summary>
        public const uint GgpStreamDescriptorSurfaceExtensionName = "VK_GGP_stream_descriptor_surface";
        ///<summary></summary>
        public const uint NVCornerSampledImageSpecVersion = 2;
        ///<summary></summary>
        public const uint NVCornerSampledImageExtensionName = "VK_NV_corner_sampled_image";
        ///<summary></summary>
        public const uint NVExtension52SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension52ExtensionName = "VK_NV_extension_52";
        ///<summary></summary>
        public const uint NVExtension53SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension53ExtensionName = "VK_NV_extension_53";
        ///<summary></summary>
        public const uint KHRMultiviewSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRMultiviewExtensionName = "VK_KHR_multiview";
        ///<summary></summary>
        public const uint ImgFormatPvrtcSpecVersion = 1;
        ///<summary></summary>
        public const uint ImgFormatPvrtcExtensionName = "VK_IMG_format_pvrtc";
        ///<summary></summary>
        public const uint NVExternalMemoryCapabilitiesSpecVersion = 1;
        ///<summary></summary>
        public const uint NVExternalMemoryCapabilitiesExtensionName = "VK_NV_external_memory_capabilities";
        ///<summary></summary>
        public const uint NVExternalMemorySpecVersion = 1;
        ///<summary></summary>
        public const uint NVExternalMemoryExtensionName = "VK_NV_external_memory";
        ///<summary></summary>
        public const uint NVExternalMemoryWin32SpecVersion = 1;
        ///<summary></summary>
        public const uint NVExternalMemoryWin32ExtensionName = "VK_NV_external_memory_win32";
        ///<summary></summary>
        public const uint NVWin32KeyedMutexSpecVersion = 2;
        ///<summary></summary>
        public const uint NVWin32KeyedMutexExtensionName = "VK_NV_win32_keyed_mutex";
        ///<summary></summary>
        public const uint KHRGetPhysicalDeviceProperties2SpecVersion = 2;
        ///<summary></summary>
        public const uint KHRGetPhysicalDeviceProperties2ExtensionName = "VK_KHR_get_physical_device_properties2";
        ///<summary></summary>
        public const uint KHRDeviceGroupSpecVersion = 4;
        ///<summary></summary>
        public const uint KHRDeviceGroupExtensionName = "VK_KHR_device_group";
        ///<summary></summary>
        public const uint EXTValidationSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTValidationExtensionName = "VK_EXT_validation_flags";
        ///<summary></summary>
        public const uint NnViSurfaceSpecVersion = 1;
        ///<summary></summary>
        public const uint NnViSurfaceExtensionName = "VK_NN_vi_surface";
        ///<summary></summary>
        public const uint KHRShaderDrawParametersSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRShaderDrawParametersExtensionName = "VK_KHR_shader_draw_parameters";
        ///<summary></summary>
        public const uint EXTShaderSubgroupBallotSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTShaderSubgroupBallotExtensionName = "VK_EXT_shader_subgroup_ballot";
        ///<summary></summary>
        public const uint EXTShaderSubgroupVoteSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTShaderSubgroupVoteExtensionName = "VK_EXT_shader_subgroup_vote";
        ///<summary></summary>
        public const uint EXTTextureCompressionAstcHdrSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTTextureCompressionAstcHdrExtensionName = "VK_EXT_texture_compression_astc_hdr";
        ///<summary></summary>
        public const uint EXTAstcDecodeModeSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTAstcDecodeModeExtensionName = "VK_EXT_astc_decode_mode";
        ///<summary></summary>
        public const uint ImgExtension69SpecVersion = 0;
        ///<summary></summary>
        public const uint ImgExtension69ExtensionName = "VK_IMG_extension_69";
        ///<summary></summary>
        public const uint KHRMaintenance1SpecVersion = 2;
        ///<summary></summary>
        public const uint KHRMaintenance1ExtensionName = "VK_KHR_maintenance1";
        ///<summary></summary>
        public const uint KHRDeviceGroupCreationSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRDeviceGroupCreationExtensionName = "VK_KHR_device_group_creation";
        ///<summary></summary>
        public const uint KHRExternalMemoryCapabilitiesSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalMemoryCapabilitiesExtensionName = "VK_KHR_external_memory_capabilities";
        ///<summary></summary>
        public const uint KHRExternalMemorySpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalMemoryExtensionName = "VK_KHR_external_memory";
        ///<summary></summary>
        public const uint KHRExternalMemoryWin32SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalMemoryWin32ExtensionName = "VK_KHR_external_memory_win32";
        ///<summary></summary>
        public const uint KHRExternalMemoryFdSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalMemoryFdExtensionName = "VK_KHR_external_memory_fd";
        ///<summary></summary>
        public const uint KHRWin32KeyedMutexSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRWin32KeyedMutexExtensionName = "VK_KHR_win32_keyed_mutex";
        ///<summary></summary>
        public const uint KHRExternalSemaphoreCapabilitiesSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalSemaphoreCapabilitiesExtensionName = "VK_KHR_external_semaphore_capabilities";
        ///<summary></summary>
        public const uint KHRExternalSemaphoreSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalSemaphoreExtensionName = "VK_KHR_external_semaphore";
        ///<summary></summary>
        public const uint KHRExternalSemaphoreWin32SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalSemaphoreWin32ExtensionName = "VK_KHR_external_semaphore_win32";
        ///<summary></summary>
        public const uint KHRExternalSemaphoreFdSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalSemaphoreFdExtensionName = "VK_KHR_external_semaphore_fd";
        ///<summary></summary>
        public const uint KHRPushDescriptorSpecVersion = 2;
        ///<summary></summary>
        public const uint KHRPushDescriptorExtensionName = "VK_KHR_push_descriptor";
        ///<summary></summary>
        public const uint EXTConditionalRenderingSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTConditionalRenderingExtensionName = "VK_EXT_conditional_rendering";
        ///<summary></summary>
        public const uint KHRShaderFloat16Int8SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRShaderFloat16Int8ExtensionName = "VK_KHR_shader_float16_int8";
        ///<summary></summary>
        public const uint KHR16bitStorageSpecVersion = 1;
        ///<summary></summary>
        public const uint KHR16bitStorageExtensionName = "VK_KHR_16bit_storage";
        ///<summary></summary>
        public const uint KHRIncrementalPresentSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRIncrementalPresentExtensionName = "VK_KHR_incremental_present";
        ///<summary></summary>
        public const uint KHRDescriptorUpdateTemplateSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRDescriptorUpdateTemplateExtensionName = "VK_KHR_descriptor_update_template";
        ///<summary></summary>
        public const uint NVXDeviceGeneratedCommandsSpecVersion = 3;
        ///<summary></summary>
        public const uint NVXDeviceGeneratedCommandsExtensionName = "VK_NVX_device_generated_commands";
        ///<summary></summary>
        public const uint NVClipSpaceWScalingSpecVersion = 1;
        ///<summary></summary>
        public const uint NVClipSpaceWScalingExtensionName = "VK_NV_clip_space_w_scaling";
        ///<summary></summary>
        public const uint EXTDirectModeDisplaySpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDirectModeDisplayExtensionName = "VK_EXT_direct_mode_display";
        ///<summary></summary>
        public const uint EXTAcquireXlibDisplaySpecVersion = 1;
        ///<summary></summary>
        public const uint EXTAcquireXlibDisplayExtensionName = "VK_EXT_acquire_xlib_display";
        ///<summary></summary>
        public const uint EXTDisplaySurfaceCounterSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDisplaySurfaceCounterExtensionName = "VK_EXT_display_surface_counter";
        ///<summary></summary>
        public const uint EXTDisplayControlSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDisplayControlExtensionName = "VK_EXT_display_control";
        ///<summary></summary>
        public const uint GoogleDisplayTimingSpecVersion = 1;
        ///<summary></summary>
        public const uint GoogleDisplayTimingExtensionName = "VK_GOOGLE_display_timing";
        ///<summary></summary>
        public const uint NVSampleMaskOverrideCoverageSpecVersion = 1;
        ///<summary></summary>
        public const uint NVSampleMaskOverrideCoverageExtensionName = "VK_NV_sample_mask_override_coverage";
        ///<summary></summary>
        public const uint NVGeometryShaderPassthroughSpecVersion = 1;
        ///<summary></summary>
        public const uint NVGeometryShaderPassthroughExtensionName = "VK_NV_geometry_shader_passthrough";
        ///<summary></summary>
        public const uint NVViewportArray2SpecVersion = 1;
        ///<summary></summary>
        public const uint NVViewportArray2ExtensionName = "VK_NV_viewport_array2";
        ///<summary></summary>
        public const uint NVXMultiviewPerViewAttributesSpecVersion = 1;
        ///<summary></summary>
        public const uint NVXMultiviewPerViewAttributesExtensionName = "VK_NVX_multiview_per_view_attributes";
        ///<summary></summary>
        public const uint NVViewportSwizzleSpecVersion = 1;
        ///<summary></summary>
        public const uint NVViewportSwizzleExtensionName = "VK_NV_viewport_swizzle";
        ///<summary></summary>
        public const uint EXTDiscardRectanglesSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDiscardRectanglesExtensionName = "VK_EXT_discard_rectangles";
        ///<summary></summary>
        public const uint NVExtension101SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension101ExtensionName = "VK_NV_extension_101";
        ///<summary></summary>
        public const uint EXTConservativeRasterizationSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTConservativeRasterizationExtensionName = "VK_EXT_conservative_rasterization";
        ///<summary></summary>
        public const uint EXTDepthClipEnableSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDepthClipEnableExtensionName = "VK_EXT_depth_clip_enable";
        ///<summary></summary>
        public const uint NVExtension104SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension104ExtensionName = "VK_NV_extension_104";
        ///<summary></summary>
        public const uint EXTSwapchainColorSpaceSpecVersion = 4;
        ///<summary></summary>
        public const uint EXTSwapchainColorSpaceExtensionName = "VK_EXT_swapchain_colorspace";
        ///<summary></summary>
        public const uint EXTHdrMetadataSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTHdrMetadataExtensionName = "VK_EXT_hdr_metadata";
        ///<summary></summary>
        public const uint ImgExtension107SpecVersion = 0;
        ///<summary></summary>
        public const uint ImgExtension107ExtensionName = "VK_IMG_extension_107";
        ///<summary></summary>
        public const uint ImgExtension108SpecVersion = 0;
        ///<summary></summary>
        public const uint ImgExtension108ExtensionName = "VK_IMG_extension_108";
        ///<summary></summary>
        public const uint KHRImagelessFramebufferSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRImagelessFramebufferExtensionName = "VK_KHR_imageless_framebuffer";
        ///<summary></summary>
        public const uint KHRCreateRenderpass2SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRCreateRenderpass2ExtensionName = "VK_KHR_create_renderpass2";
        ///<summary></summary>
        public const uint ImgExtension111SpecVersion = 0;
        ///<summary></summary>
        public const uint ImgExtension111ExtensionName = "VK_IMG_extension_111";
        ///<summary></summary>
        public const uint KHRSharedPresentableImageSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRSharedPresentableImageExtensionName = "VK_KHR_shared_presentable_image";
        ///<summary></summary>
        public const uint KHRExternalFenceCapabilitiesSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalFenceCapabilitiesExtensionName = "VK_KHR_external_fence_capabilities";
        ///<summary></summary>
        public const uint KHRExternalFenceSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalFenceExtensionName = "VK_KHR_external_fence";
        ///<summary></summary>
        public const uint KHRExternalFenceWin32SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalFenceWin32ExtensionName = "VK_KHR_external_fence_win32";
        ///<summary></summary>
        public const uint KHRExternalFenceFdSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRExternalFenceFdExtensionName = "VK_KHR_external_fence_fd";
        ///<summary></summary>
        public const uint KHRPerformanceQuerySpecVersion = 1;
        ///<summary></summary>
        public const uint KHRPerformanceQueryExtensionName = "VK_KHR_performance_query";
        ///<summary></summary>
        public const uint KHRMaintenance2SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRMaintenance2ExtensionName = "VK_KHR_maintenance2";
        ///<summary></summary>
        public const uint KHRExtension119SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension119ExtensionName = "VK_KHR_extension_119";
        ///<summary></summary>
        public const uint KHRGetSurfaceCapabilities2SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRGetSurfaceCapabilities2ExtensionName = "VK_KHR_get_surface_capabilities2";
        ///<summary></summary>
        public const uint KHRVariablePointersSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRVariablePointersExtensionName = "VK_KHR_variable_pointers";
        ///<summary></summary>
        public const uint KHRGetDisplayProperties2SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRGetDisplayProperties2ExtensionName = "VK_KHR_get_display_properties2";
        ///<summary></summary>
        public const uint MvkIosSurfaceSpecVersion = 3;
        ///<summary></summary>
        public const uint MvkIosSurfaceExtensionName = "VK_MVK_ios_surface";
        ///<summary></summary>
        public const uint MvkMacosSurfaceSpecVersion = 3;
        ///<summary></summary>
        public const uint MvkMacosSurfaceExtensionName = "VK_MVK_macos_surface";
        ///<summary></summary>
        public const uint MvkMoltenvkSpecVersion = 0;
        ///<summary></summary>
        public const uint MvkMoltenvkExtensionName = "VK_MVK_moltenvk";
        ///<summary></summary>
        public const uint EXTExternalMemoryDmaBufSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTExternalMemoryDmaBufExtensionName = "VK_EXT_external_memory_dma_buf";
        ///<summary></summary>
        public const uint EXTQueueFamilyForeignSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTQueueFamilyForeignExtensionName = "VK_EXT_queue_family_foreign";
        ///<summary></summary>
        public const uint KHRDedicatedAllocationSpecVersion = 3;
        ///<summary></summary>
        public const uint KHRDedicatedAllocationExtensionName = "VK_KHR_dedicated_allocation";
        ///<summary></summary>
        public const uint EXTDebugUtilsSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTDebugUtilsExtensionName = "VK_EXT_debug_utils";
        ///<summary></summary>
        public const uint AndroidExternalMemoryAndroidHardwareBufferSpecVersion = 3;
        ///<summary></summary>
        public const uint AndroidExternalMemoryAndroidHardwareBufferExtensionName = "VK_ANDROID_external_memory_android_hardware_buffer";
        ///<summary></summary>
        public const uint EXTSamplerFilterMinmaxSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTSamplerFilterMinmaxExtensionName = "VK_EXT_sampler_filter_minmax";
        ///<summary></summary>
        public const uint KHRStorageBufferStorageClassSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRStorageBufferStorageClassExtensionName = "VK_KHR_storage_buffer_storage_class";
        ///<summary></summary>
        public const uint AMDGpuShaderInt16SpecVersion = 2;
        ///<summary></summary>
        public const uint AMDGpuShaderInt16ExtensionName = "VK_AMD_gpu_shader_int16";
        ///<summary></summary>
        public const uint AMDExtension134SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension134ExtensionName = "VK_AMD_extension_134";
        ///<summary></summary>
        public const uint AMDExtension135SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension135ExtensionName = "VK_AMD_extension_135";
        ///<summary></summary>
        public const uint AMDExtension136SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension136ExtensionName = "VK_AMD_extension_136";
        ///<summary></summary>
        public const uint AMDMixedAttachmentSamplesSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDMixedAttachmentSamplesExtensionName = "VK_AMD_mixed_attachment_samples";
        ///<summary></summary>
        public const uint AMDShaderFragmentMaskSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDShaderFragmentMaskExtensionName = "VK_AMD_shader_fragment_mask";
        ///<summary></summary>
        public const uint EXTInlineUniformBlockSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTInlineUniformBlockExtensionName = "VK_EXT_inline_uniform_block";
        ///<summary></summary>
        public const uint AMDExtension140SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension140ExtensionName = "VK_AMD_extension_140";
        ///<summary></summary>
        public const uint EXTShaderStencilExportSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTShaderStencilExportExtensionName = "VK_EXT_shader_stencil_export";
        ///<summary></summary>
        public const uint AMDExtension142SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension142ExtensionName = "VK_AMD_extension_142";
        ///<summary></summary>
        public const uint AMDExtension143SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension143ExtensionName = "VK_AMD_extension_143";
        ///<summary></summary>
        public const uint EXTSampleLocationsSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTSampleLocationsExtensionName = "VK_EXT_sample_locations";
        ///<summary></summary>
        public const uint KHRRelaxedBlockLayoutSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRRelaxedBlockLayoutExtensionName = "VK_KHR_relaxed_block_layout";
        ///<summary></summary>
        public const uint KHRGetMemoryRequirements2SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRGetMemoryRequirements2ExtensionName = "VK_KHR_get_memory_requirements2";
        ///<summary></summary>
        public const uint KHRImageFormatListSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRImageFormatListExtensionName = "VK_KHR_image_format_list";
        ///<summary></summary>
        public const uint EXTBlendOperationAdvancedSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTBlendOperationAdvancedExtensionName = "VK_EXT_blend_operation_advanced";
        ///<summary></summary>
        public const uint NVFragmentCoverageToColorSpecVersion = 1;
        ///<summary></summary>
        public const uint NVFragmentCoverageToColorExtensionName = "VK_NV_fragment_coverage_to_color";
        ///<summary></summary>
        public const uint KHRAccelerationStructureSpecVersion = 11;
        ///<summary></summary>
        public const uint KHRAccelerationStructureExtensionName = "VK_KHR_acceleration_structure";
        ///<summary></summary>
        public const uint KHRRayTracingPipelineSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRRayTracingPipelineExtensionName = "VK_KHR_ray_tracing_pipeline";
        ///<summary></summary>
        public const uint KHRRayQuerySpecVersion = 1;
        ///<summary></summary>
        public const uint KHRRayQueryExtensionName = "VK_KHR_ray_query";
        ///<summary></summary>
        public const uint NVExtension152SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension152ExtensionName = "VK_NV_extension_152";
        ///<summary></summary>
        public const uint NVFramebufferMixedSamplesSpecVersion = 1;
        ///<summary></summary>
        public const uint NVFramebufferMixedSamplesExtensionName = "VK_NV_framebuffer_mixed_samples";
        ///<summary></summary>
        public const uint NVFillRectangleSpecVersion = 1;
        ///<summary></summary>
        public const uint NVFillRectangleExtensionName = "VK_NV_fill_rectangle";
        ///<summary></summary>
        public const uint NVShaderSmBuiltinsSpecVersion = 1;
        ///<summary></summary>
        public const uint NVShaderSmBuiltinsExtensionName = "VK_NV_shader_sm_builtins";
        ///<summary></summary>
        public const uint EXTPostDepthCoverageSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTPostDepthCoverageExtensionName = "VK_EXT_post_depth_coverage";
        ///<summary></summary>
        public const uint KHRSamplerYcbcrConversionSpecVersion = 14;
        ///<summary></summary>
        public const uint KHRSamplerYcbcrConversionExtensionName = "VK_KHR_sampler_ycbcr_conversion";
        ///<summary></summary>
        public const uint KHRBindMemory2SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRBindMemory2ExtensionName = "VK_KHR_bind_memory2";
        ///<summary></summary>
        public const uint EXTImageDrmFormatModifierSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTImageDrmFormatModifierExtensionName = "VK_EXT_image_drm_format_modifier";
        ///<summary></summary>
        public const uint EXTExtension160SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension160ExtensionName = "VK_EXT_extension_160";
        ///<summary></summary>
        public const uint EXTValidationCacheSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTValidationCacheExtensionName = "VK_EXT_validation_cache";
        ///<summary></summary>
        public const uint EXTDescriptorIndexingSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTDescriptorIndexingExtensionName = "VK_EXT_descriptor_indexing";
        ///<summary></summary>
        public const uint EXTShaderViewportIndexLayerSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTShaderViewportIndexLayerExtensionName = "VK_EXT_shader_viewport_index_layer";
        ///<summary></summary>
        public const uint KHRPortabilitySubsetSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRPortabilitySubsetExtensionName = "VK_KHR_portability_subset";
        ///<summary></summary>
        public const uint NVShadingRateImageSpecVersion = 3;
        ///<summary></summary>
        public const uint NVShadingRateImageExtensionName = "VK_NV_shading_rate_image";
        ///<summary></summary>
        public const uint NVRayTracingSpecVersion = 3;
        ///<summary></summary>
        public const uint NVRayTracingExtensionName = "VK_NV_ray_tracing";
        ///<summary></summary>
        public const uint NVRepresentativeFragmentTestSpecVersion = 2;
        ///<summary></summary>
        public const uint NVRepresentativeFragmentTestExtensionName = "VK_NV_representative_fragment_test";
        ///<summary></summary>
        public const uint EXTExtension168SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension168ExtensionName = "VK_NV_extension_168";
        ///<summary></summary>
        public const uint KHRMaintenance3SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRMaintenance3ExtensionName = "VK_KHR_maintenance3";
        ///<summary></summary>
        public const uint KHRDrawIndirectCountSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRDrawIndirectCountExtensionName = "VK_KHR_draw_indirect_count";
        ///<summary></summary>
        public const uint EXTFilterCubicSpecVersion = 3;
        ///<summary></summary>
        public const uint EXTFilterCubicExtensionName = "VK_EXT_filter_cubic";
        ///<summary></summary>
        public const uint QcomRenderPassShaderResolveSpecVersion = 4;
        ///<summary></summary>
        public const uint QcomRenderPassShaderResolveExtensionName = "VK_QCOM_render_pass_shader_resolve";
        ///<summary></summary>
        public const uint QcomExtension173SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension173ExtensionName = "VK_QCOM_extension_173";
        ///<summary></summary>
        public const uint QcomExtension174SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension174ExtensionName = "VK_QCOM_extension_174";
        ///<summary></summary>
        public const uint EXTGlobalPrioritySpecVersion = 2;
        ///<summary></summary>
        public const uint EXTGlobalPriorityExtensionName = "VK_EXT_global_priority";
        ///<summary></summary>
        public const uint KHRShaderSubgroupExtendedTypesSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRShaderSubgroupExtendedTypesExtensionName = "VK_KHR_shader_subgroup_extended_types";
        ///<summary></summary>
        public const uint KHRExtension177SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension177ExtensionName = "VK_KHR_extension_177";
        ///<summary></summary>
        public const uint KHR8bitStorageSpecVersion = 1;
        ///<summary></summary>
        public const uint KHR8bitStorageExtensionName = "VK_KHR_8bit_storage";
        ///<summary></summary>
        public const uint EXTExternalMemoryHostSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTExternalMemoryHostExtensionName = "VK_EXT_external_memory_host";
        ///<summary></summary>
        public const uint AMDBufferMarkerSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDBufferMarkerExtensionName = "VK_AMD_buffer_marker";
        ///<summary></summary>
        public const uint KHRShaderAtomicInt64SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRShaderAtomicInt64ExtensionName = "VK_KHR_shader_atomic_int64";
        ///<summary></summary>
        public const uint KHRShaderClockSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRShaderClockExtensionName = "VK_KHR_shader_clock";
        ///<summary></summary>
        public const uint KHRExtension183SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension183ExtensionName = "VK_AMD_extension_183";
        ///<summary></summary>
        public const uint AMDPipelineCompilerControlSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDPipelineCompilerControlExtensionName = "VK_AMD_pipeline_compiler_control";
        ///<summary></summary>
        public const uint EXTCalibratedTimestampsSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTCalibratedTimestampsExtensionName = "VK_EXT_calibrated_timestamps";
        ///<summary></summary>
        public const uint AMDShaderCorePropertiesSpecVersion = 2;
        ///<summary></summary>
        public const uint AMDShaderCorePropertiesExtensionName = "VK_AMD_shader_core_properties";
        ///<summary></summary>
        public const uint KHRExtension187SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension187ExtensionName = "VK_AMD_extension_187";
        ///<summary></summary>
        public const uint KHRExtension188SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension188ExtensionName = "VK_AMD_extension_188";
        ///<summary></summary>
        public const uint KHRExtension189SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension189ExtensionName = "VK_AMD_extension_189";
        ///<summary></summary>
        public const uint AMDMemoryOverallocationBehaviorSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDMemoryOverallocationBehaviorExtensionName = "VK_AMD_memory_overallocation_behavior";
        ///<summary></summary>
        public const uint EXTVertexAttributeDivisorSpecVersion = 3;
        ///<summary></summary>
        public const uint EXTVertexAttributeDivisorExtensionName = "VK_EXT_vertex_attribute_divisor";
        ///<summary></summary>
        public const uint GgpFrameTokenSpecVersion = 1;
        ///<summary></summary>
        public const uint GgpFrameTokenExtensionName = "VK_GGP_frame_token";
        ///<summary></summary>
        public const uint EXTPipelineCreationFeedbackSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTPipelineCreationFeedbackExtensionName = "VK_EXT_pipeline_creation_feedback";
        ///<summary></summary>
        public const uint GoogleExtension194SpecVersion = 0;
        ///<summary></summary>
        public const uint GoogleExtension194ExtensionName = "VK_GOOGLE_extension_194";
        ///<summary></summary>
        public const uint GoogleExtension195SpecVersion = 0;
        ///<summary></summary>
        public const uint GoogleExtension195ExtensionName = "VK_GOOGLE_extension_195";
        ///<summary></summary>
        public const uint GoogleExtension196SpecVersion = 0;
        ///<summary></summary>
        public const uint GoogleExtension196ExtensionName = "VK_GOOGLE_extension_196";
        ///<summary></summary>
        public const uint KHRDriverPropertiesSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRDriverPropertiesExtensionName = "VK_KHR_driver_properties";
        ///<summary></summary>
        public const uint KHRShaderFloatControlsSpecVersion = 4;
        ///<summary></summary>
        public const uint KHRShaderFloatControlsExtensionName = "VK_KHR_shader_float_controls";
        ///<summary></summary>
        public const uint NVShaderSubgroupPartitionedSpecVersion = 1;
        ///<summary></summary>
        public const uint NVShaderSubgroupPartitionedExtensionName = "VK_NV_shader_subgroup_partitioned";
        ///<summary></summary>
        public const uint KHRDepthStencilResolveSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRDepthStencilResolveExtensionName = "VK_KHR_depth_stencil_resolve";
        ///<summary></summary>
        public const uint KHRSwapchainMutableFormatSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRSwapchainMutableFormatExtensionName = "VK_KHR_swapchain_mutable_format";
        ///<summary></summary>
        public const uint NVComputeShaderDerivativesSpecVersion = 1;
        ///<summary></summary>
        public const uint NVComputeShaderDerivativesExtensionName = "VK_NV_compute_shader_derivatives";
        ///<summary></summary>
        public const uint NVMeshShaderSpecVersion = 1;
        ///<summary></summary>
        public const uint NVMeshShaderExtensionName = "VK_NV_mesh_shader";
        ///<summary></summary>
        public const uint NVFragmentShaderBarycentricSpecVersion = 1;
        ///<summary></summary>
        public const uint NVFragmentShaderBarycentricExtensionName = "VK_NV_fragment_shader_barycentric";
        ///<summary></summary>
        public const uint NVShaderImageFootprintSpecVersion = 2;
        ///<summary></summary>
        public const uint NVShaderImageFootprintExtensionName = "VK_NV_shader_image_footprint";
        ///<summary></summary>
        public const uint NVScissorExclusiveSpecVersion = 1;
        ///<summary></summary>
        public const uint NVScissorExclusiveExtensionName = "VK_NV_scissor_exclusive";
        ///<summary></summary>
        public const uint NVDeviceDiagnosticCheckpointsSpecVersion = 2;
        ///<summary></summary>
        public const uint NVDeviceDiagnosticCheckpointsExtensionName = "VK_NV_device_diagnostic_checkpoints";
        ///<summary></summary>
        public const uint KHRTimelineSemaphoreSpecVersion = 2;
        ///<summary></summary>
        public const uint KHRTimelineSemaphoreExtensionName = "VK_KHR_timeline_semaphore";
        ///<summary></summary>
        public const uint KHRExtension209SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension209ExtensionName = "VK_KHR_extension_209";
        ///<summary></summary>
        public const uint IntelShaderIntegerFunctions2SpecVersion = 1;
        ///<summary></summary>
        public const uint IntelShaderIntegerFunctions2ExtensionName = "VK_INTEL_shader_integer_functions2";
        ///<summary></summary>
        public const uint IntelPerformanceQuerySpecVersion = 2;
        ///<summary></summary>
        public const uint IntelPerformanceQueryExtensionName = "VK_INTEL_performance_query";
        ///<summary></summary>
        public const uint KHRVulkanMemoryModelSpecVersion = 3;
        ///<summary></summary>
        public const uint KHRVulkanMemoryModelExtensionName = "VK_KHR_vulkan_memory_model";
        ///<summary></summary>
        public const uint EXTPciBusInfoSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTPciBusInfoExtensionName = "VK_EXT_pci_bus_info";
        ///<summary></summary>
        public const uint AMDDisplayNativeHdrSpecVersion = 1;
        ///<summary></summary>
        public const uint AMDDisplayNativeHdrExtensionName = "VK_AMD_display_native_hdr";
        ///<summary></summary>
        public const uint FuchsiaImagepipeSurfaceSpecVersion = 1;
        ///<summary></summary>
        public const uint FuchsiaImagepipeSurfaceExtensionName = "VK_FUCHSIA_imagepipe_surface";
        ///<summary></summary>
        public const uint KHRShaderTerminateInvocationSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRShaderTerminateInvocationExtensionName = "VK_KHR_shader_terminate_invocation";
        ///<summary></summary>
        public const uint KHRExtension217SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension217ExtensionName = "VK_KHR_extension_217";
        ///<summary></summary>
        public const uint EXTMetalSurfaceSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTMetalSurfaceExtensionName = "VK_EXT_metal_surface";
        ///<summary></summary>
        public const uint EXTFragmentDensityMapSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTFragmentDensityMapExtensionName = "VK_EXT_fragment_density_map";
        ///<summary></summary>
        public const uint EXTExtension220SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension220ExtensionName = "VK_EXT_extension_220";
        ///<summary></summary>
        public const uint KHRExtension221SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension221ExtensionName = "VK_KHR_extension_221";
        ///<summary></summary>
        public const uint EXTScalarBlockLayoutSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTScalarBlockLayoutExtensionName = "VK_EXT_scalar_block_layout";
        ///<summary></summary>
        public const uint EXTExtension223SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension223ExtensionName = "VK_EXT_extension_223";
        ///<summary></summary>
        public const uint GoogleHlslFunctionality1SpecVersion = 1;
        ///<summary></summary>
        public const uint GoogleHlslFunctionality1ExtensionName = "VK_GOOGLE_hlsl_functionality1";
        ///<summary></summary>
        public const uint GoogleDecorateStringSpecVersion = 1;
        ///<summary></summary>
        public const uint GoogleDecorateStringExtensionName = "VK_GOOGLE_decorate_string";
        ///<summary></summary>
        public const uint EXTSubgroupSizeControlSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTSubgroupSizeControlExtensionName = "VK_EXT_subgroup_size_control";
        ///<summary></summary>
        public const uint KHRFragmentShadingRateSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRFragmentShadingRateExtensionName = "VK_KHR_fragment_shading_rate";
        ///<summary></summary>
        public const uint AMDShaderCoreProperties2SpecVersion = 1;
        ///<summary></summary>
        public const uint AMDShaderCoreProperties2ExtensionName = "VK_AMD_shader_core_properties2";
        ///<summary></summary>
        public const uint AMDExtension229SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension229ExtensionName = "VK_AMD_extension_229";
        ///<summary></summary>
        public const uint AMDDeviceCoherentMemorySpecVersion = 1;
        ///<summary></summary>
        public const uint AMDDeviceCoherentMemoryExtensionName = "VK_AMD_device_coherent_memory";
        ///<summary></summary>
        public const uint AMDExtension231SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension231ExtensionName = "VK_AMD_extension_231";
        ///<summary></summary>
        public const uint AMDExtension232SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension232ExtensionName = "VK_AMD_extension_232";
        ///<summary></summary>
        public const uint AMDExtension233SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension233ExtensionName = "VK_AMD_extension_233";
        ///<summary></summary>
        public const uint AMDExtension234SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension234ExtensionName = "VK_AMD_extension_234";
        ///<summary></summary>
        public const uint EXTShaderImageAtomicInt64SpecVersion = 1;
        ///<summary></summary>
        public const uint EXTShaderImageAtomicInt64ExtensionName = "VK_EXT_shader_image_atomic_int64";
        ///<summary></summary>
        public const uint AMDExtension236SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension236ExtensionName = "VK_AMD_extension_236";
        ///<summary></summary>
        public const uint KHRSpirv14SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRSpirv14ExtensionName = "VK_KHR_spirv_1_4";
        ///<summary></summary>
        public const uint EXTMemoryBudgetSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTMemoryBudgetExtensionName = "VK_EXT_memory_budget";
        ///<summary></summary>
        public const uint EXTMemoryPrioritySpecVersion = 1;
        ///<summary></summary>
        public const uint EXTMemoryPriorityExtensionName = "VK_EXT_memory_priority";
        ///<summary></summary>
        public const uint KHRSurfaceProtectedCapabilitiesSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRSurfaceProtectedCapabilitiesExtensionName = "VK_KHR_surface_protected_capabilities";
        ///<summary></summary>
        public const uint NVDedicatedAllocationImageAliasingSpecVersion = 1;
        ///<summary></summary>
        public const uint NVDedicatedAllocationImageAliasingExtensionName = "VK_NV_dedicated_allocation_image_aliasing";
        ///<summary></summary>
        public const uint KHRSeparateDepthStencilLayoutsSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRSeparateDepthStencilLayoutsExtensionName = "VK_KHR_separate_depth_stencil_layouts";
        ///<summary></summary>
        public const uint IntelExtension243SpecVersion = 0;
        ///<summary></summary>
        public const uint IntelExtension243ExtensionName = "VK_INTEL_extension_243";
        ///<summary></summary>
        public const uint MesaExtension244SpecVersion = 0;
        ///<summary></summary>
        public const uint MesaExtension244ExtensionName = "VK_MESA_extension_244";
        ///<summary></summary>
        public const uint EXTBufferDeviceAddressSpecVersion = 2;
        ///<summary></summary>
        public const uint EXTBufferDeviceAddressExtensionName = "VK_EXT_buffer_device_address";
        ///<summary></summary>
        public const uint EXTToolingInfoSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTToolingInfoExtensionName = "VK_EXT_tooling_info";
        ///<summary></summary>
        public const uint EXTSeparateStencilUsageSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTSeparateStencilUsageExtensionName = "VK_EXT_separate_stencil_usage";
        ///<summary></summary>
        public const uint EXTValidationFeaturesSpecVersion = 4;
        ///<summary></summary>
        public const uint EXTValidationFeaturesExtensionName = "VK_EXT_validation_features";
        ///<summary></summary>
        public const uint KHRExtension249SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension249ExtensionName = "VK_KHR_extension_249";
        ///<summary></summary>
        public const uint NVCooperativeMatrixSpecVersion = 1;
        ///<summary></summary>
        public const uint NVCooperativeMatrixExtensionName = "VK_NV_cooperative_matrix";
        ///<summary></summary>
        public const uint NVCoverageReductionModeSpecVersion = 1;
        ///<summary></summary>
        public const uint NVCoverageReductionModeExtensionName = "VK_NV_coverage_reduction_mode";
        ///<summary></summary>
        public const uint EXTFragmentShaderInterlockSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTFragmentShaderInterlockExtensionName = "VK_EXT_fragment_shader_interlock";
        ///<summary></summary>
        public const uint EXTYcbcrImageArraysSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTYcbcrImageArraysExtensionName = "VK_EXT_ycbcr_image_arrays";
        ///<summary></summary>
        public const uint KHRUniformBufferStandardLayoutSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRUniformBufferStandardLayoutExtensionName = "VK_KHR_uniform_buffer_standard_layout";
        ///<summary></summary>
        public const uint EXTExtension255SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension255ExtensionName = "VK_EXT_extension_255";
        ///<summary></summary>
        public const uint EXTFullScreenExclusiveSpecVersion = 4;
        ///<summary></summary>
        public const uint EXTFullScreenExclusiveExtensionName = "VK_EXT_full_screen_exclusive";
        ///<summary></summary>
        public const uint EXTHeadlessSurfaceSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTHeadlessSurfaceExtensionName = "VK_EXT_headless_surface";
        ///<summary></summary>
        public const uint KHRBufferDeviceAddressSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRBufferDeviceAddressExtensionName = "VK_KHR_buffer_device_address";
        ///<summary></summary>
        public const uint EXTExtension259SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension259ExtensionName = "VK_EXT_extension_259";
        ///<summary></summary>
        public const uint EXTLineRasterizationSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTLineRasterizationExtensionName = "VK_EXT_line_rasterization";
        ///<summary></summary>
        public const uint EXTShaderAtomicFloatSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTShaderAtomicFloatExtensionName = "VK_EXT_shader_atomic_float";
        ///<summary></summary>
        public const uint EXTHostQueryResetSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTHostQueryResetExtensionName = "VK_EXT_host_query_reset";
        ///<summary></summary>
        public const uint GoogleExtension263SpecVersion = 0;
        ///<summary></summary>
        public const uint GoogleExtension263ExtensionName = "VK_GGP_extension_263";
        ///<summary></summary>
        public const uint BrcmExtension264SpecVersion = 0;
        ///<summary></summary>
        public const uint BrcmExtension264ExtensionName = "VK_BRCM_extension_264";
        ///<summary></summary>
        public const uint BrcmExtension265SpecVersion = 0;
        ///<summary></summary>
        public const uint BrcmExtension265ExtensionName = "VK_BRCM_extension_265";
        ///<summary></summary>
        public const uint EXTIndexTypeUint8SpecVersion = 1;
        ///<summary></summary>
        public const uint EXTIndexTypeUint8ExtensionName = "VK_EXT_index_type_uint8";
        ///<summary></summary>
        public const uint EXTExtension267SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension267 = "VK_EXT_extension_267";
        ///<summary></summary>
        public const uint EXTExtendedDynamicStateSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTExtendedDynamicStateExtensionName = "VK_EXT_extended_dynamic_state";
        ///<summary></summary>
        public const uint KHRDeferredHostOperationsSpecVersion = 4;
        ///<summary></summary>
        public const uint KHRDeferredHostOperationsExtensionName = "VK_KHR_deferred_host_operations";
        ///<summary></summary>
        public const uint KHRPipelineExecutablePropertiesSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRPipelineExecutablePropertiesExtensionName = "VK_KHR_pipeline_executable_properties";
        ///<summary></summary>
        public const uint IntelExtension271SpecVersion = 0;
        ///<summary></summary>
        public const uint IntelExtension271 = "VK_KHR_extension_271";
        ///<summary></summary>
        public const uint IntelExtension272SpecVersion = 0;
        ///<summary></summary>
        public const uint IntelExtension272 = "VK_KHR_extension_272";
        ///<summary></summary>
        public const uint IntelExtension273SpecVersion = 0;
        ///<summary></summary>
        public const uint IntelExtension273 = "VK_KHR_extension_273";
        ///<summary></summary>
        public const uint IntelExtension274SpecVersion = 0;
        ///<summary></summary>
        public const uint IntelExtension274 = "VK_KHR_extension_274";
        ///<summary></summary>
        public const uint KHRExtension275SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension275 = "VK_KHR_extension_275";
        ///<summary></summary>
        public const uint KHRExtension276SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension276 = "VK_KHR_extension_276";
        ///<summary></summary>
        public const uint EXTShaderDemoteToHelperInvocationSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTShaderDemoteToHelperInvocationExtensionName = "VK_EXT_shader_demote_to_helper_invocation";
        ///<summary></summary>
        public const uint NVDeviceGeneratedCommandsSpecVersion = 3;
        ///<summary></summary>
        public const uint NVDeviceGeneratedCommandsExtensionName = "VK_NV_device_generated_commands";
        ///<summary></summary>
        public const uint NVExtension279SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension279 = "VK_NV_extension_279";
        ///<summary></summary>
        public const uint KHRExtension280SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension280 = "VK_KHR_extension_280";
        ///<summary></summary>
        public const uint ArmExtension281SpecVersion = 0;
        ///<summary></summary>
        public const uint ArmExtension281 = "VK_ARM_extension_281";
        ///<summary></summary>
        public const uint EXTTexelBufferAlignmentSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTTexelBufferAlignmentExtensionName = "VK_EXT_texel_buffer_alignment";
        ///<summary></summary>
        public const uint QcomRenderPassTransformSpecVersion = 1;
        ///<summary></summary>
        public const uint QcomRenderPassTransformExtensionName = "VK_QCOM_render_pass_transform";
        ///<summary></summary>
        public const uint EXTExtension284SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension284 = "VK_EXT_extension_284";
        ///<summary></summary>
        public const uint EXTDeviceMemoryReportSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDeviceMemoryReportExtensionName = "VK_EXT_device_memory_report";
        ///<summary></summary>
        public const uint EXTExtension286SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension286 = "VK_EXT_extension_286";
        ///<summary></summary>
        public const uint EXTRobustness2SpecVersion = 1;
        ///<summary></summary>
        public const uint EXTRobustness2ExtensionName = "VK_EXT_robustness2";
        ///<summary></summary>
        public const uint EXTCustomBorderColorSpecVersion = 12;
        ///<summary></summary>
        public const uint EXTCustomBorderColorExtensionName = "VK_EXT_custom_border_color";
        ///<summary></summary>
        public const uint EXTExtension289SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension289ExtensionName = "VK_EXT_extension_289";
        ///<summary></summary>
        public const uint GoogleUserTypeSpecVersion = 1;
        ///<summary></summary>
        public const uint GoogleUserTypeExtensionName = "VK_GOOGLE_user_type";
        ///<summary></summary>
        public const uint KHRPipelineLibrarySpecVersion = 1;
        ///<summary></summary>
        public const uint KHRPipelineLibraryExtensionName = "VK_KHR_pipeline_library";
        ///<summary></summary>
        public const uint NVExtension292SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension292ExtensionName = "VK_NV_extension_292";
        ///<summary></summary>
        public const uint NVExtension293SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension293ExtensionName = "VK_NV_extension_293";
        ///<summary></summary>
        public const uint KHRShaderNonSemanticInfoSpecVersion = 1;
        ///<summary></summary>
        public const uint KHRShaderNonSemanticInfoExtensionName = "VK_KHR_shader_non_semantic_info";
        ///<summary></summary>
        public const uint KHRExtension295SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension295ExtensionName = "VK_KHR_extension_295";
        ///<summary></summary>
        public const uint EXTPrivateDataSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTPrivateDataExtensionName = "VK_EXT_private_data";
        ///<summary></summary>
        public const uint KHRExtension297SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension297ExtensionName = "VK_KHR_extension_297";
        ///<summary></summary>
        public const uint EXTPipelineCreationCacheControlSpecVersion = 3;
        ///<summary></summary>
        public const uint EXTPipelineCreationCacheControlExtensionName = "VK_EXT_pipeline_creation_cache_control";
        ///<summary></summary>
        public const uint KHRExtension299SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension299ExtensionName = "VK_KHR_extension_299";
        ///<summary></summary>
        public const uint KHRExtension300SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension300ExtensionName = "VK_KHR_extension_300";
        ///<summary></summary>
        public const uint NVDeviceDiagnosticsConfigSpecVersion = 1;
        ///<summary></summary>
        public const uint NVDeviceDiagnosticsConfigExtensionName = "VK_NV_device_diagnostics_config";
        ///<summary></summary>
        public const uint QcomRenderPassStoreOpsSpecVersion = 2;
        ///<summary></summary>
        public const uint QcomRenderPassStoreOpsExtensionName = "VK_QCOM_render_pass_store_ops";
        ///<summary></summary>
        public const uint QcomExtension303SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension303ExtensionName = "VK_QCOM_extension_303";
        ///<summary></summary>
        public const uint QcomExtension304SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension304ExtensionName = "VK_QCOM_extension_304";
        ///<summary></summary>
        public const uint QcomExtension305SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension305ExtensionName = "VK_QCOM_extension_305";
        ///<summary></summary>
        public const uint QcomExtension306SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension306ExtensionName = "VK_QCOM_extension_306";
        ///<summary></summary>
        public const uint QcomExtension307SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension307ExtensionName = "VK_QCOM_extension_307";
        ///<summary></summary>
        public const uint NVExtension308SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension308ExtensionName = "VK_NV_extension_308";
        ///<summary></summary>
        public const uint KHRExtension309SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension309ExtensionName = "VK_KHR_extension_309";
        ///<summary></summary>
        public const uint QcomExtension310SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension310ExtensionName = "VK_QCOM_extension_310";
        ///<summary></summary>
        public const uint NVExtension311SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension311ExtensionName = "VK_NV_extension_311";
        ///<summary></summary>
        public const uint EXTExtension312SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension312ExtensionName = "VK_EXT_extension_312";
        ///<summary></summary>
        public const uint EXTExtension313SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension313ExtensionName = "VK_EXT_extension_313";
        ///<summary></summary>
        public const uint AMDExtension314SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension314ExtensionName = "VK_AMD_extension_314";
        ///<summary></summary>
        public const uint AMDExtension315SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension315ExtensionName = "VK_AMD_extension_315";
        ///<summary></summary>
        public const uint AMDExtension316SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension316ExtensionName = "VK_AMD_extension_316";
        ///<summary></summary>
        public const uint AMDExtension317SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension317ExtensionName = "VK_AMD_extension_317";
        ///<summary></summary>
        public const uint AMDExtension318SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension318ExtensionName = "VK_AMD_extension_318";
        ///<summary></summary>
        public const uint AMDExtension319SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension319ExtensionName = "VK_AMD_extension_319";
        ///<summary></summary>
        public const uint AMDExtension320SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension320ExtensionName = "VK_AMD_extension_320";
        ///<summary></summary>
        public const uint AMDExtension321SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension321ExtensionName = "VK_AMD_extension_321";
        ///<summary></summary>
        public const uint AMDExtension322SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension322ExtensionName = "VK_AMD_extension_322";
        ///<summary></summary>
        public const uint AMDExtension323SpecVersion = 0;
        ///<summary></summary>
        public const uint AMDExtension323ExtensionName = "VK_AMD_extension_323";
        ///<summary></summary>
        public const uint KHRExtension324SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension324ExtensionName = "VK_KHR_extension_324";
        ///<summary></summary>
        public const uint KHRExtension325SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension325ExtensionName = "VK_KHR_extension_325";
        ///<summary></summary>
        public const uint KHRExtension326SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension326ExtensionName = "VK_KHR_extension_326";
        ///<summary></summary>
        public const uint NVFragmentShadingRateEnumsSpecVersion = 1;
        ///<summary></summary>
        public const uint NVFragmentShadingRateEnumsExtensionName = "VK_NV_fragment_shading_rate_enums";
        ///<summary></summary>
        public const uint NVExtension328SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension328ExtensionName = "VK_NV_extension_328";
        ///<summary></summary>
        public const uint NVExtension329SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension329ExtensionName = "VK_NV_extension_329";
        ///<summary></summary>
        public const uint NVExtension330SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension330ExtensionName = "VK_NV_extension_330";
        ///<summary></summary>
        public const uint NVExtension331SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension331ExtensionName = "VK_NV_extension_331";
        ///<summary></summary>
        public const uint NVExtension332SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension332ExtensionName = "VK_NV_extension_332";
        ///<summary></summary>
        public const uint EXTFragmentDensityMap2SpecVersion = 1;
        ///<summary></summary>
        public const uint EXTFragmentDensityMap2ExtensionName = "VK_EXT_fragment_density_map2";
        ///<summary></summary>
        public const uint QcomRotatedCopyCommandsSpecVersion = 0;
        ///<summary></summary>
        public const uint QcomRotatedCopyCommandsExtensionName = "VK_QCOM_rotated_copy_commands";
        ///<summary></summary>
        public const uint KHRExtension335SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension335ExtensionName = "VK_KHR_extension_335";
        ///<summary></summary>
        public const uint EXTImageRobustnessSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTImageRobustnessExtensionName = "VK_EXT_image_robustness";
        ///<summary></summary>
        public const uint KHRExtension337SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension337ExtensionName = "VK_KHR_extension_337";
        ///<summary></summary>
        public const uint KHRCopyCommands2SpecVersion = 1;
        ///<summary></summary>
        public const uint KHRCopyCommands2ExtensionName = "VK_KHR_copy_commands2";
        ///<summary></summary>
        public const uint ArmExtension339SpecVersion = 0;
        ///<summary></summary>
        public const uint ArmExtension339ExtensionName = "VK_ARM_extension_339";
        ///<summary></summary>
        public const uint EXTExtension340SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension340ExtensionName = "VK_EXT_extension_340";
        ///<summary></summary>
        public const uint EXT4444FormatsSpecVersion = 1;
        ///<summary></summary>
        public const uint EXT4444FormatsExtensionName = "VK_EXT_4444_formats";
        ///<summary></summary>
        public const uint EXTExtension342SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension342ExtensionName = "VK_EXT_extension_342";
        ///<summary></summary>
        public const uint ArmExtension343SpecVersion = 0;
        ///<summary></summary>
        public const uint ArmExtension343ExtensionName = "VK_ARM_extension_343";
        ///<summary></summary>
        public const uint ArmExtension344SpecVersion = 0;
        ///<summary></summary>
        public const uint ArmExtension344ExtensionName = "VK_ARM_extension_344";
        ///<summary></summary>
        public const uint ArmExtension345SpecVersion = 0;
        ///<summary></summary>
        public const uint ArmExtension345ExtensionName = "VK_ARM_extension_345";
        ///<summary></summary>
        public const uint NVAcquireWinrtDisplaySpecVersion = 1;
        ///<summary></summary>
        public const uint NVAcquireWinrtDisplayExtensionName = "VK_NV_acquire_winrt_display";
        ///<summary></summary>
        public const uint EXTDirectfbSurfaceSpecVersion = 1;
        ///<summary></summary>
        public const uint EXTDirectfbSurfaceExtensionName = "VK_EXT_directfb_surface";
        ///<summary></summary>
        public const uint KHRExtension350SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension350ExtensionName = "VK_KHR_extension_350";
        ///<summary></summary>
        public const uint NVExtension351SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension351ExtensionName = "VK_NV_extension_351";
        ///<summary></summary>
        public const uint ValveMutableDescriptorTypeSpecVersion = 1;
        ///<summary></summary>
        public const uint ValveMutableDescriptorTypeExtensionName = "VK_VALVE_mutable_descriptor_type";
        ///<summary></summary>
        public const uint EXTExtension353SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension353ExtensionName = "VK_EXT_extension_353";
        ///<summary></summary>
        public const uint EXTExtension354SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension354ExtensionName = "VK_EXT_extension_354";
        ///<summary></summary>
        public const uint EXTExtension355SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension355ExtensionName = "VK_EXT_extension_355";
        ///<summary></summary>
        public const uint EXTVertexAttributeAliasingSpecVersion = 0;
        ///<summary></summary>
        public const uint EXTVertexAttributeAliasingExtensionName = "VK_EXT_vertex_attribute_aliasing";
        ///<summary></summary>
        public const uint KHRExtension358SpecVersion = 0;
        ///<summary></summary>
        public const uint KHRExtension358ExtensionName = "VK_KHR_extension_358";
        ///<summary></summary>
        public const uint EXTExtension362SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension362ExtensionName = "VK_EXT_extension_362";
        ///<summary></summary>
        public const uint EXTExtension363SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension363ExtensionName = "VK_EXT_extension_363";
        ///<summary></summary>
        public const uint EXTExtension364SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension364ExtensionName = "VK_EXT_extension_364";
        ///<summary></summary>
        public const uint EXTExtension365SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension365ExtensionName = "VK_EXT_extension_365";
        ///<summary></summary>
        public const uint EXTExtension366SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension366ExtensionName = "VK_EXT_extension_366";
        ///<summary></summary>
        public const uint EXTExtension367SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension367ExtensionName = "VK_EXT_extension_367";
        ///<summary></summary>
        public const uint EXTExtension368SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension368ExtensionName = "VK_EXT_extension_368";
        ///<summary></summary>
        public const uint QcomExtension369SpecVersion = 0;
        ///<summary></summary>
        public const uint QcomExtension369ExtensionName = "VK_QCOM_extension_369";
        ///<summary></summary>
        public const uint HuaweiExtension370SpecVersion = 0;
        ///<summary></summary>
        public const uint HuaweiExtension370ExtensionName = "VK_HUAWEI_extension_370";
        ///<summary></summary>
        public const uint HuaweiExtension371SpecVersion = 0;
        ///<summary></summary>
        public const uint HuaweiExtension371ExtensionName = "VK_HUAWEI_extension_371";
        ///<summary></summary>
        public const uint NVExtension372SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension372ExtensionName = "VK_NV_extension_372";
        ///<summary></summary>
        public const uint NVExtension373SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension373ExtensionName = "VK_NV_extension_373";
        ///<summary></summary>
        public const uint NVExtension374SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension374ExtensionName = "VK_NV_extension_374";
        ///<summary></summary>
        public const uint NVExtension375SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension375ExtensionName = "VK_NV_extension_375";
        ///<summary></summary>
        public const uint EXTExtension376SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension376ExtensionName = "VK_EXT_extension_376";
        ///<summary></summary>
        public const uint EXTExtension377SpecVersion = 0;
        ///<summary></summary>
        public const uint EXTExtension377ExtensionName = "VK_EXT_extension_377";
        ///<summary></summary>
        public const uint NVExtension378SpecVersion = 0;
        ///<summary></summary>
        public const uint NVExtension378ExtensionName = "VK_NV_extension_378";
    }

    public static partial class RawConstants
    {
        public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = VulkanNative.MaxPhysicalDeviceNameSize;
        public const uint VK_UUID_SIZE = VulkanNative.UuidSize;
        public const uint VK_LUID_SIZE = VulkanNative.LuidSize;
        public const uint VK_LUID_SIZE_KHR = VulkanNative.LuidSizeKHR;
        public const uint VK_MAX_EXTENSION_NAME_SIZE = VulkanNative.MaxExtensionNameSize;
        public const uint VK_MAX_DESCRIPTION_SIZE = VulkanNative.MaxDescriptionSize;
        public const uint VK_MAX_MEMORY_TYPES = VulkanNative.MaxMemoryTypes;
        ///<summary>The maximum number of unique memory heaps, each of which supporting 1 or more memory types</summary>
        public const uint VK_MAX_MEMORY_HEAPS = VulkanNative.MaxMemoryHeaps;
        public const float VK_LOD_CLAMP_NONE = VulkanNative.LodClampNone;
        public const uint VK_REMAINING_MIP_LEVELS = VulkanNative.RemainingMipLevels;
        public const uint VK_REMAINING_ARRAY_LAYERS = VulkanNative.RemainingArrayLayers;
        public const ulong VK_WHOLE_SIZE = VulkanNative.WholeSize;
        public const uint VK_ATTACHMENT_UNUSED = VulkanNative.AttachmentUnused;
        public const uint VK_TRUE = VulkanNative.True;
        public const uint VK_FALSE = VulkanNative.False;
        public const uint VK_QUEUE_FAMILY_IGNORED = VulkanNative.QueueFamilyIgnored;
        public const uint VK_QUEUE_FAMILY_EXTERNAL = VulkanNative.QueueFamilyExternal;
        public const uint VK_QUEUE_FAMILY_EXTERNAL_KHR = VulkanNative.QueueFamilyExternalKHR;
        public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = VulkanNative.QueueFamilyForeignEXT;
        public const uint VK_SUBPASS_EXTERNAL = VulkanNative.SubpassExternal;
        public const uint VK_MAX_DEVICE_GROUP_SIZE = VulkanNative.MaxDeviceGroupSize;
        public const uint VK_MAX_DEVICE_GROUP_SIZE_KHR = VulkanNative.MaxDeviceGroupSizeKHR;
        public const uint VK_MAX_DRIVER_NAME_SIZE = VulkanNative.MaxDriverNameSize;
        public const uint VK_MAX_DRIVER_NAME_SIZE_KHR = VulkanNative.MaxDriverNameSizeKHR;
        public const uint VK_MAX_DRIVER_INFO_SIZE = VulkanNative.MaxDriverInfoSize;
        public const uint VK_MAX_DRIVER_INFO_SIZE_KHR = VulkanNative.MaxDriverInfoSizeKHR;
        public const uint VK_SHADER_UNUSED_KHR = VulkanNative.ShaderUnusedKHR;
        public const uint VK_SHADER_UNUSED_NV = VulkanNative.ShaderUnusedNV;
        ///<summary></summary>
        public const uint VK_KHR_SURFACE_SPEC_VERSION = VulkanNative.KHRSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SURFACE_EXTENSION_NAME = VulkanNative.KHRSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SWAPCHAIN_SPEC_VERSION = VulkanNative.KHRSwapchainSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SWAPCHAIN_EXTENSION_NAME = VulkanNative.KHRSwapchainExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DISPLAY_SPEC_VERSION = VulkanNative.KHRDisplaySpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DISPLAY_EXTENSION_NAME = VulkanNative.KHRDisplayExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION = VulkanNative.KHRDisplaySwapchainSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME = VulkanNative.KHRDisplaySwapchainExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_XLIB_SURFACE_SPEC_VERSION = VulkanNative.KHRXlibSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_XLIB_SURFACE_EXTENSION_NAME = VulkanNative.KHRXlibSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_XCB_SURFACE_SPEC_VERSION = VulkanNative.KHRXcbSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_XCB_SURFACE_EXTENSION_NAME = VulkanNative.KHRXcbSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_WAYLAND_SURFACE_SPEC_VERSION = VulkanNative.KHRWaylandSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME = VulkanNative.KHRWaylandSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_MIR_SURFACE_SPEC_VERSION = VulkanNative.KHRMirSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_MIR_SURFACE_EXTENSION_NAME = VulkanNative.KHRMirSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_ANDROID_SURFACE_SPEC_VERSION = VulkanNative.KHRAndroidSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_ANDROID_SURFACE_EXTENSION_NAME = VulkanNative.KHRAndroidSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_WIN32_SURFACE_SPEC_VERSION = VulkanNative.KHRWin32SurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_WIN32_SURFACE_EXTENSION_NAME = VulkanNative.KHRWin32SurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_ANDROID_NATIVE_BUFFER_SPEC_VERSION = VulkanNative.AndroidNativeBufferSpecVersion;
        ///<summary></summary>
        public const uint VK_ANDROID_NATIVE_BUFFER_NUMBER = VulkanNative.AndroidNativeBufferNumber;
        ///<summary></summary>
        public const uint VK_ANDROID_NATIVE_BUFFER_NAME = VulkanNative.AndroidNativeBufferName;
        ///<summary></summary>
        public const uint VK_ANDROID_NATIVE_BUFFER_EXTENSION_NAME = VulkanNative.AndroidNativeBufferExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DEBUG_REPORT_SPEC_VERSION = VulkanNative.EXTDebugReportSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DEBUG_REPORT_EXTENSION_NAME = VulkanNative.EXTDebugReportExtensionName;
        ///<summary></summary>
        public const uint VK_NV_GLSL_SHADER_SPEC_VERSION = VulkanNative.NVGlslShaderSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_GLSL_SHADER_EXTENSION_NAME = VulkanNative.NVGlslShaderExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION = VulkanNative.EXTDepthRangeUnrestrictedSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME = VulkanNative.EXTDepthRangeUnrestrictedExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION = VulkanNative.KHRSamplerMirrorClampToEdgeSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME = VulkanNative.KHRSamplerMirrorClampToEdgeExtensionName;
        ///<summary></summary>
        public const uint VK_IMG_FILTER_CUBIC_SPEC_VERSION = VulkanNative.ImgFilterCubicSpecVersion;
        ///<summary></summary>
        public const uint VK_IMG_FILTER_CUBIC_EXTENSION_NAME = VulkanNative.ImgFilterCubicExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_17_SPEC_VERSION = VulkanNative.AMDExtension17SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_17_EXTENSION_NAME = VulkanNative.AMDExtension17ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_18_SPEC_VERSION = VulkanNative.AMDExtension18SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_18_EXTENSION_NAME = VulkanNative.AMDExtension18ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION = VulkanNative.AMDRasterizationOrderSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME = VulkanNative.AMDRasterizationOrderExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_20_SPEC_VERSION = VulkanNative.AMDExtension20SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_20_EXTENSION_NAME = VulkanNative.AMDExtension20ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION = VulkanNative.AMDShaderTrinaryMinmaxSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME = VulkanNative.AMDShaderTrinaryMinmaxExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION = VulkanNative.AMDShaderExplicitVertexParameterSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME = VulkanNative.AMDShaderExplicitVertexParameterExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DEBUG_MARKER_SPEC_VERSION = VulkanNative.EXTDebugMarkerSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DEBUG_MARKER_EXTENSION_NAME = VulkanNative.EXTDebugMarkerExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_24_SPEC_VERSION = VulkanNative.AMDExtension24SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_24_EXTENSION_NAME = VulkanNative.AMDExtension24ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_25_SPEC_VERSION = VulkanNative.AMDExtension25SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_25_EXTENSION_NAME = VulkanNative.AMDExtension25ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_GCN_SHADER_SPEC_VERSION = VulkanNative.AMDGcnShaderSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_GCN_SHADER_EXTENSION_NAME = VulkanNative.AMDGcnShaderExtensionName;
        ///<summary></summary>
        public const uint VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION = VulkanNative.NVDedicatedAllocationSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME = VulkanNative.NVDedicatedAllocationExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_28_SPEC_VERSION = VulkanNative.EXTExtension28SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_28_EXTENSION_NAME = VulkanNative.EXTExtension28ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION = VulkanNative.EXTTransformFeedbackSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME = VulkanNative.EXTTransformFeedbackExtensionName;
        ///<summary></summary>
        public const uint VK_NVX_EXTENSION_30_SPEC_VERSION = VulkanNative.NVXExtension30SpecVersion;
        ///<summary></summary>
        public const uint VK_NVX_EXTENSION_30_EXTENSION_NAME = VulkanNative.NVXExtension30ExtensionName;
        ///<summary></summary>
        public const uint VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION = VulkanNative.NVXImageViewHandleSpecVersion;
        ///<summary></summary>
        public const uint VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME = VulkanNative.NVXImageViewHandleExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_32_SPEC_VERSION = VulkanNative.AMDExtension32SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_32_EXTENSION_NAME = VulkanNative.AMDExtension32ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_33_SPEC_VERSION = VulkanNative.AMDExtension33SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_33_EXTENSION_NAME = VulkanNative.AMDExtension33ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION = VulkanNative.AMDDrawIndirectCountSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME = VulkanNative.AMDDrawIndirectCountExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_35_SPEC_VERSION = VulkanNative.AMDExtension35SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_35_EXTENSION_NAME = VulkanNative.AMDExtension35ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION = VulkanNative.AMDNegativeViewportHeightSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME = VulkanNative.AMDNegativeViewportHeightExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION = VulkanNative.AMDGpuShaderHalfFloatSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME = VulkanNative.AMDGpuShaderHalfFloatExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_BALLOT_SPEC_VERSION = VulkanNative.AMDShaderBallotSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_BALLOT_EXTENSION_NAME = VulkanNative.AMDShaderBallotExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_39_SPEC_VERSION = VulkanNative.AMDExtension39SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_39_EXTENSION_NAME = VulkanNative.AMDExtension39ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_40_SPEC_VERSION = VulkanNative.AMDExtension40SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_40_EXTENSION_NAME = VulkanNative.AMDExtension40ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_41_SPEC_VERSION = VulkanNative.AMDExtension41SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_41_EXTENSION_NAME = VulkanNative.AMDExtension41ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION = VulkanNative.AMDTextureGatherBiasLodSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME = VulkanNative.AMDTextureGatherBiasLodExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_INFO_SPEC_VERSION = VulkanNative.AMDShaderInfoSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_INFO_EXTENSION_NAME = VulkanNative.AMDShaderInfoExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_44_SPEC_VERSION = VulkanNative.AMDExtension44SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_44_EXTENSION_NAME = VulkanNative.AMDExtension44ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_45_SPEC_VERSION = VulkanNative.AMDExtension45SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_45_EXTENSION_NAME = VulkanNative.AMDExtension45ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_46_SPEC_VERSION = VulkanNative.AMDExtension46SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_46_EXTENSION_NAME = VulkanNative.AMDExtension46ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION = VulkanNative.AMDShaderImageLoadStoreLodSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME = VulkanNative.AMDShaderImageLoadStoreLodExtensionName;
        ///<summary></summary>
        public const uint VK_NVX_EXTENSION_48_SPEC_VERSION = VulkanNative.NVXExtension48SpecVersion;
        ///<summary></summary>
        public const uint VK_NVX_EXTENSION_48_EXTENSION_NAME = VulkanNative.NVXExtension48ExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_49_SPEC_VERSION = VulkanNative.GoogleExtension49SpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_49_EXTENSION_NAME = VulkanNative.GoogleExtension49ExtensionName;
        ///<summary></summary>
        public const uint VK_GGP_STREAM_DESCRIPTOR_SURFACE_SPEC_VERSION = VulkanNative.GgpStreamDescriptorSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME = VulkanNative.GgpStreamDescriptorSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION = VulkanNative.NVCornerSampledImageSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME = VulkanNative.NVCornerSampledImageExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_52_SPEC_VERSION = VulkanNative.NVExtension52SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_52_EXTENSION_NAME = VulkanNative.NVExtension52ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_53_SPEC_VERSION = VulkanNative.NVExtension53SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_53_EXTENSION_NAME = VulkanNative.NVExtension53ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_MULTIVIEW_SPEC_VERSION = VulkanNative.KHRMultiviewSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_MULTIVIEW_EXTENSION_NAME = VulkanNative.KHRMultiviewExtensionName;
        ///<summary></summary>
        public const uint VK_IMG_FORMAT_PVRTC_SPEC_VERSION = VulkanNative.ImgFormatPvrtcSpecVersion;
        ///<summary></summary>
        public const uint VK_IMG_FORMAT_PVRTC_EXTENSION_NAME = VulkanNative.ImgFormatPvrtcExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = VulkanNative.NVExternalMemoryCapabilitiesSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME = VulkanNative.NVExternalMemoryCapabilitiesExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTERNAL_MEMORY_SPEC_VERSION = VulkanNative.NVExternalMemorySpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME = VulkanNative.NVExternalMemoryExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = VulkanNative.NVExternalMemoryWin32SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME = VulkanNative.NVExternalMemoryWin32ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION = VulkanNative.NVWin32KeyedMutexSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME = VulkanNative.NVWin32KeyedMutexExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION = VulkanNative.KHRGetPhysicalDeviceProperties2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME = VulkanNative.KHRGetPhysicalDeviceProperties2ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DEVICE_GROUP_SPEC_VERSION = VulkanNative.KHRDeviceGroupSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DEVICE_GROUP_EXTENSION_NAME = VulkanNative.KHRDeviceGroupExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_VALIDATION_FLAGS_SPEC_VERSION = VulkanNative.EXTValidationSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME = VulkanNative.EXTValidationExtensionName;
        ///<summary></summary>
        public const uint VK_NN_VI_SURFACE_SPEC_VERSION = VulkanNative.NnViSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_NN_VI_SURFACE_EXTENSION_NAME = VulkanNative.NnViSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION = VulkanNative.KHRShaderDrawParametersSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME = VulkanNative.KHRShaderDrawParametersExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION = VulkanNative.EXTShaderSubgroupBallotSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME = VulkanNative.EXTShaderSubgroupBallotExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION = VulkanNative.EXTShaderSubgroupVoteSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME = VulkanNative.EXTShaderSubgroupVoteExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION = VulkanNative.EXTTextureCompressionAstcHdrSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME = VulkanNative.EXTTextureCompressionAstcHdrExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION = VulkanNative.EXTAstcDecodeModeSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME = VulkanNative.EXTAstcDecodeModeExtensionName;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_69_SPEC_VERSION = VulkanNative.ImgExtension69SpecVersion;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_69_EXTENSION_NAME = VulkanNative.ImgExtension69ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_MAINTENANCE1_SPEC_VERSION = VulkanNative.KHRMaintenance1SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_MAINTENANCE1_EXTENSION_NAME = VulkanNative.KHRMaintenance1ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION = VulkanNative.KHRDeviceGroupCreationSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME = VulkanNative.KHRDeviceGroupCreationExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = VulkanNative.KHRExternalMemoryCapabilitiesSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME = VulkanNative.KHRExternalMemoryCapabilitiesExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION = VulkanNative.KHRExternalMemorySpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME = VulkanNative.KHRExternalMemoryExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = VulkanNative.KHRExternalMemoryWin32SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME = VulkanNative.KHRExternalMemoryWin32ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION = VulkanNative.KHRExternalMemoryFdSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME = VulkanNative.KHRExternalMemoryFdExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION = VulkanNative.KHRWin32KeyedMutexSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME = VulkanNative.KHRWin32KeyedMutexExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION = VulkanNative.KHRExternalSemaphoreCapabilitiesSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME = VulkanNative.KHRExternalSemaphoreCapabilitiesExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION = VulkanNative.KHRExternalSemaphoreSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME = VulkanNative.KHRExternalSemaphoreExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION = VulkanNative.KHRExternalSemaphoreWin32SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME = VulkanNative.KHRExternalSemaphoreWin32ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION = VulkanNative.KHRExternalSemaphoreFdSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME = VulkanNative.KHRExternalSemaphoreFdExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION = VulkanNative.KHRPushDescriptorSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME = VulkanNative.KHRPushDescriptorExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION = VulkanNative.EXTConditionalRenderingSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME = VulkanNative.EXTConditionalRenderingExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION = VulkanNative.KHRShaderFloat16Int8SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME = VulkanNative.KHRShaderFloat16Int8ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_16BIT_STORAGE_SPEC_VERSION = VulkanNative.KHR16bitStorageSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_16BIT_STORAGE_EXTENSION_NAME = VulkanNative.KHR16bitStorageExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION = VulkanNative.KHRIncrementalPresentSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME = VulkanNative.KHRIncrementalPresentExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION = VulkanNative.KHRDescriptorUpdateTemplateSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME = VulkanNative.KHRDescriptorUpdateTemplateExtensionName;
        ///<summary></summary>
        public const uint VK_NVX_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = VulkanNative.NVXDeviceGeneratedCommandsSpecVersion;
        ///<summary></summary>
        public const uint VK_NVX_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME = VulkanNative.NVXDeviceGeneratedCommandsExtensionName;
        ///<summary></summary>
        public const uint VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION = VulkanNative.NVClipSpaceWScalingSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME = VulkanNative.NVClipSpaceWScalingExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION = VulkanNative.EXTDirectModeDisplaySpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME = VulkanNative.EXTDirectModeDisplayExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_ACQUIRE_XLIB_DISPLAY_SPEC_VERSION = VulkanNative.EXTAcquireXlibDisplaySpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME = VulkanNative.EXTAcquireXlibDisplayExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION = VulkanNative.EXTDisplaySurfaceCounterSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME = VulkanNative.EXTDisplaySurfaceCounterExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DISPLAY_CONTROL_SPEC_VERSION = VulkanNative.EXTDisplayControlSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME = VulkanNative.EXTDisplayControlExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION = VulkanNative.GoogleDisplayTimingSpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME = VulkanNative.GoogleDisplayTimingExtensionName;
        ///<summary></summary>
        public const uint VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION = VulkanNative.NVSampleMaskOverrideCoverageSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME = VulkanNative.NVSampleMaskOverrideCoverageExtensionName;
        ///<summary></summary>
        public const uint VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION = VulkanNative.NVGeometryShaderPassthroughSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME = VulkanNative.NVGeometryShaderPassthroughExtensionName;
        ///<summary></summary>
        public const uint VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION = VulkanNative.NVViewportArray2SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME = VulkanNative.NVViewportArray2ExtensionName;
        ///<summary></summary>
        public const uint VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION = VulkanNative.NVXMultiviewPerViewAttributesSpecVersion;
        ///<summary></summary>
        public const uint VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME = VulkanNative.NVXMultiviewPerViewAttributesExtensionName;
        ///<summary></summary>
        public const uint VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION = VulkanNative.NVViewportSwizzleSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME = VulkanNative.NVViewportSwizzleExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION = VulkanNative.EXTDiscardRectanglesSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME = VulkanNative.EXTDiscardRectanglesExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_101_SPEC_VERSION = VulkanNative.NVExtension101SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_101_EXTENSION_NAME = VulkanNative.NVExtension101ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION = VulkanNative.EXTConservativeRasterizationSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME = VulkanNative.EXTConservativeRasterizationExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION = VulkanNative.EXTDepthClipEnableSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME = VulkanNative.EXTDepthClipEnableExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_104_SPEC_VERSION = VulkanNative.NVExtension104SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_104_EXTENSION_NAME = VulkanNative.NVExtension104ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION = VulkanNative.EXTSwapchainColorSpaceSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME = VulkanNative.EXTSwapchainColorSpaceExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_HDR_METADATA_SPEC_VERSION = VulkanNative.EXTHdrMetadataSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_HDR_METADATA_EXTENSION_NAME = VulkanNative.EXTHdrMetadataExtensionName;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_107_SPEC_VERSION = VulkanNative.ImgExtension107SpecVersion;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_107_EXTENSION_NAME = VulkanNative.ImgExtension107ExtensionName;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_108_SPEC_VERSION = VulkanNative.ImgExtension108SpecVersion;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_108_EXTENSION_NAME = VulkanNative.ImgExtension108ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION = VulkanNative.KHRImagelessFramebufferSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME = VulkanNative.KHRImagelessFramebufferExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION = VulkanNative.KHRCreateRenderpass2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME = VulkanNative.KHRCreateRenderpass2ExtensionName;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_111_SPEC_VERSION = VulkanNative.ImgExtension111SpecVersion;
        ///<summary></summary>
        public const uint VK_IMG_EXTENSION_111_EXTENSION_NAME = VulkanNative.ImgExtension111ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION = VulkanNative.KHRSharedPresentableImageSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME = VulkanNative.KHRSharedPresentableImageExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION = VulkanNative.KHRExternalFenceCapabilitiesSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME = VulkanNative.KHRExternalFenceCapabilitiesExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_SPEC_VERSION = VulkanNative.KHRExternalFenceSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME = VulkanNative.KHRExternalFenceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION = VulkanNative.KHRExternalFenceWin32SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME = VulkanNative.KHRExternalFenceWin32ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION = VulkanNative.KHRExternalFenceFdSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME = VulkanNative.KHRExternalFenceFdExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION = VulkanNative.KHRPerformanceQuerySpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME = VulkanNative.KHRPerformanceQueryExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_MAINTENANCE2_SPEC_VERSION = VulkanNative.KHRMaintenance2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_MAINTENANCE2_EXTENSION_NAME = VulkanNative.KHRMaintenance2ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_119_SPEC_VERSION = VulkanNative.KHRExtension119SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_119_EXTENSION_NAME = VulkanNative.KHRExtension119ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION = VulkanNative.KHRGetSurfaceCapabilities2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME = VulkanNative.KHRGetSurfaceCapabilities2ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_VARIABLE_POINTERS_SPEC_VERSION = VulkanNative.KHRVariablePointersSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME = VulkanNative.KHRVariablePointersExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION = VulkanNative.KHRGetDisplayProperties2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME = VulkanNative.KHRGetDisplayProperties2ExtensionName;
        ///<summary></summary>
        public const uint VK_MVK_IOS_SURFACE_SPEC_VERSION = VulkanNative.MvkIosSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_MVK_IOS_SURFACE_EXTENSION_NAME = VulkanNative.MvkIosSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_MVK_MACOS_SURFACE_SPEC_VERSION = VulkanNative.MvkMacosSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_MVK_MACOS_SURFACE_EXTENSION_NAME = VulkanNative.MvkMacosSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_MVK_MOLTENVK_SPEC_VERSION = VulkanNative.MvkMoltenvkSpecVersion;
        ///<summary></summary>
        public const uint VK_MVK_MOLTENVK_EXTENSION_NAME = VulkanNative.MvkMoltenvkExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION = VulkanNative.EXTExternalMemoryDmaBufSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME = VulkanNative.EXTExternalMemoryDmaBufExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION = VulkanNative.EXTQueueFamilyForeignSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME = VulkanNative.EXTQueueFamilyForeignExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION = VulkanNative.KHRDedicatedAllocationSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME = VulkanNative.KHRDedicatedAllocationExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DEBUG_UTILS_SPEC_VERSION = VulkanNative.EXTDebugUtilsSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DEBUG_UTILS_EXTENSION_NAME = VulkanNative.EXTDebugUtilsExtensionName;
        ///<summary></summary>
        public const uint VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION = VulkanNative.AndroidExternalMemoryAndroidHardwareBufferSpecVersion;
        ///<summary></summary>
        public const uint VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME = VulkanNative.AndroidExternalMemoryAndroidHardwareBufferExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION = VulkanNative.EXTSamplerFilterMinmaxSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME = VulkanNative.EXTSamplerFilterMinmaxExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION = VulkanNative.KHRStorageBufferStorageClassSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME = VulkanNative.KHRStorageBufferStorageClassExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_GPU_SHADER_INT16_SPEC_VERSION = VulkanNative.AMDGpuShaderInt16SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME = VulkanNative.AMDGpuShaderInt16ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_134_SPEC_VERSION = VulkanNative.AMDExtension134SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_134_EXTENSION_NAME = VulkanNative.AMDExtension134ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_135_SPEC_VERSION = VulkanNative.AMDExtension135SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_135_EXTENSION_NAME = VulkanNative.AMDExtension135ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_136_SPEC_VERSION = VulkanNative.AMDExtension136SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_136_EXTENSION_NAME = VulkanNative.AMDExtension136ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION = VulkanNative.AMDMixedAttachmentSamplesSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME = VulkanNative.AMDMixedAttachmentSamplesExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION = VulkanNative.AMDShaderFragmentMaskSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME = VulkanNative.AMDShaderFragmentMaskExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION = VulkanNative.EXTInlineUniformBlockSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME = VulkanNative.EXTInlineUniformBlockExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_140_SPEC_VERSION = VulkanNative.AMDExtension140SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_140_EXTENSION_NAME = VulkanNative.AMDExtension140ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION = VulkanNative.EXTShaderStencilExportSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME = VulkanNative.EXTShaderStencilExportExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_142_SPEC_VERSION = VulkanNative.AMDExtension142SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_142_EXTENSION_NAME = VulkanNative.AMDExtension142ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_143_SPEC_VERSION = VulkanNative.AMDExtension143SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_143_EXTENSION_NAME = VulkanNative.AMDExtension143ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION = VulkanNative.EXTSampleLocationsSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME = VulkanNative.EXTSampleLocationsExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION = VulkanNative.KHRRelaxedBlockLayoutSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME = VulkanNative.KHRRelaxedBlockLayoutExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION = VulkanNative.KHRGetMemoryRequirements2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME = VulkanNative.KHRGetMemoryRequirements2ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION = VulkanNative.KHRImageFormatListSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME = VulkanNative.KHRImageFormatListExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION = VulkanNative.EXTBlendOperationAdvancedSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME = VulkanNative.EXTBlendOperationAdvancedExtensionName;
        ///<summary></summary>
        public const uint VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION = VulkanNative.NVFragmentCoverageToColorSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME = VulkanNative.NVFragmentCoverageToColorExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION = VulkanNative.KHRAccelerationStructureSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME = VulkanNative.KHRAccelerationStructureExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION = VulkanNative.KHRRayTracingPipelineSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME = VulkanNative.KHRRayTracingPipelineExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_RAY_QUERY_SPEC_VERSION = VulkanNative.KHRRayQuerySpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_RAY_QUERY_EXTENSION_NAME = VulkanNative.KHRRayQueryExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_152_SPEC_VERSION = VulkanNative.NVExtension152SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_152_EXTENSION_NAME = VulkanNative.NVExtension152ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION = VulkanNative.NVFramebufferMixedSamplesSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME = VulkanNative.NVFramebufferMixedSamplesExtensionName;
        ///<summary></summary>
        public const uint VK_NV_FILL_RECTANGLE_SPEC_VERSION = VulkanNative.NVFillRectangleSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_FILL_RECTANGLE_EXTENSION_NAME = VulkanNative.NVFillRectangleExtensionName;
        ///<summary></summary>
        public const uint VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION = VulkanNative.NVShaderSmBuiltinsSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME = VulkanNative.NVShaderSmBuiltinsExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION = VulkanNative.EXTPostDepthCoverageSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME = VulkanNative.EXTPostDepthCoverageExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION = VulkanNative.KHRSamplerYcbcrConversionSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME = VulkanNative.KHRSamplerYcbcrConversionExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_BIND_MEMORY_2_SPEC_VERSION = VulkanNative.KHRBindMemory2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_BIND_MEMORY_2_EXTENSION_NAME = VulkanNative.KHRBindMemory2ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION = VulkanNative.EXTImageDrmFormatModifierSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME = VulkanNative.EXTImageDrmFormatModifierExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_160_SPEC_VERSION = VulkanNative.EXTExtension160SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_160_EXTENSION_NAME = VulkanNative.EXTExtension160ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_VALIDATION_CACHE_SPEC_VERSION = VulkanNative.EXTValidationCacheSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_VALIDATION_CACHE_EXTENSION_NAME = VulkanNative.EXTValidationCacheExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION = VulkanNative.EXTDescriptorIndexingSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME = VulkanNative.EXTDescriptorIndexingExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION = VulkanNative.EXTShaderViewportIndexLayerSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME = VulkanNative.EXTShaderViewportIndexLayerExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION = VulkanNative.KHRPortabilitySubsetSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME = VulkanNative.KHRPortabilitySubsetExtensionName;
        ///<summary></summary>
        public const uint VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION = VulkanNative.NVShadingRateImageSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME = VulkanNative.NVShadingRateImageExtensionName;
        ///<summary></summary>
        public const uint VK_NV_RAY_TRACING_SPEC_VERSION = VulkanNative.NVRayTracingSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_RAY_TRACING_EXTENSION_NAME = VulkanNative.NVRayTracingExtensionName;
        ///<summary></summary>
        public const uint VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION = VulkanNative.NVRepresentativeFragmentTestSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME = VulkanNative.NVRepresentativeFragmentTestExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_168_SPEC_VERSION = VulkanNative.EXTExtension168SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_168_EXTENSION_NAME = VulkanNative.EXTExtension168ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_MAINTENANCE3_SPEC_VERSION = VulkanNative.KHRMaintenance3SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_MAINTENANCE3_EXTENSION_NAME = VulkanNative.KHRMaintenance3ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION = VulkanNative.KHRDrawIndirectCountSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME = VulkanNative.KHRDrawIndirectCountExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_FILTER_CUBIC_SPEC_VERSION = VulkanNative.EXTFilterCubicSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_FILTER_CUBIC_EXTENSION_NAME = VulkanNative.EXTFilterCubicExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION = VulkanNative.QcomRenderPassShaderResolveSpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME = VulkanNative.QcomRenderPassShaderResolveExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_173_SPEC_VERSION = VulkanNative.QcomExtension173SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_173_EXTENSION_NAME = VulkanNative.QcomExtension173ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_174_SPEC_VERSION = VulkanNative.QcomExtension174SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_174_EXTENSION_NAME = VulkanNative.QcomExtension174ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION = VulkanNative.EXTGlobalPrioritySpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME = VulkanNative.EXTGlobalPriorityExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION = VulkanNative.KHRShaderSubgroupExtendedTypesSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME = VulkanNative.KHRShaderSubgroupExtendedTypesExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_177_SPEC_VERSION = VulkanNative.KHRExtension177SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_177_EXTENSION_NAME = VulkanNative.KHRExtension177ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_8BIT_STORAGE_SPEC_VERSION = VulkanNative.KHR8bitStorageSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_8BIT_STORAGE_EXTENSION_NAME = VulkanNative.KHR8bitStorageExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION = VulkanNative.EXTExternalMemoryHostSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME = VulkanNative.EXTExternalMemoryHostExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_BUFFER_MARKER_SPEC_VERSION = VulkanNative.AMDBufferMarkerSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_BUFFER_MARKER_EXTENSION_NAME = VulkanNative.AMDBufferMarkerExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION = VulkanNative.KHRShaderAtomicInt64SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME = VulkanNative.KHRShaderAtomicInt64ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_CLOCK_SPEC_VERSION = VulkanNative.KHRShaderClockSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_CLOCK_EXTENSION_NAME = VulkanNative.KHRShaderClockExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_183_SPEC_VERSION = VulkanNative.KHRExtension183SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_183_EXTENSION_NAME = VulkanNative.KHRExtension183ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION = VulkanNative.AMDPipelineCompilerControlSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME = VulkanNative.AMDPipelineCompilerControlExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION = VulkanNative.EXTCalibratedTimestampsSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME = VulkanNative.EXTCalibratedTimestampsExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION = VulkanNative.AMDShaderCorePropertiesSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME = VulkanNative.AMDShaderCorePropertiesExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_187_SPEC_VERSION = VulkanNative.KHRExtension187SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_187_EXTENSION_NAME = VulkanNative.KHRExtension187ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_188_SPEC_VERSION = VulkanNative.KHRExtension188SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_188_EXTENSION_NAME = VulkanNative.KHRExtension188ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_189_SPEC_VERSION = VulkanNative.KHRExtension189SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_189_EXTENSION_NAME = VulkanNative.KHRExtension189ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION = VulkanNative.AMDMemoryOverallocationBehaviorSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME = VulkanNative.AMDMemoryOverallocationBehaviorExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION = VulkanNative.EXTVertexAttributeDivisorSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME = VulkanNative.EXTVertexAttributeDivisorExtensionName;
        ///<summary></summary>
        public const uint VK_GGP_FRAME_TOKEN_SPEC_VERSION = VulkanNative.GgpFrameTokenSpecVersion;
        ///<summary></summary>
        public const uint VK_GGP_FRAME_TOKEN_EXTENSION_NAME = VulkanNative.GgpFrameTokenExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION = VulkanNative.EXTPipelineCreationFeedbackSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME = VulkanNative.EXTPipelineCreationFeedbackExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_194_SPEC_VERSION = VulkanNative.GoogleExtension194SpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_194_EXTENSION_NAME = VulkanNative.GoogleExtension194ExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_195_SPEC_VERSION = VulkanNative.GoogleExtension195SpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_195_EXTENSION_NAME = VulkanNative.GoogleExtension195ExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_196_SPEC_VERSION = VulkanNative.GoogleExtension196SpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_196_EXTENSION_NAME = VulkanNative.GoogleExtension196ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION = VulkanNative.KHRDriverPropertiesSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME = VulkanNative.KHRDriverPropertiesExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION = VulkanNative.KHRShaderFloatControlsSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME = VulkanNative.KHRShaderFloatControlsExtensionName;
        ///<summary></summary>
        public const uint VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION = VulkanNative.NVShaderSubgroupPartitionedSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME = VulkanNative.NVShaderSubgroupPartitionedExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION = VulkanNative.KHRDepthStencilResolveSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME = VulkanNative.KHRDepthStencilResolveExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION = VulkanNative.KHRSwapchainMutableFormatSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME = VulkanNative.KHRSwapchainMutableFormatExtensionName;
        ///<summary></summary>
        public const uint VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION = VulkanNative.NVComputeShaderDerivativesSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME = VulkanNative.NVComputeShaderDerivativesExtensionName;
        ///<summary></summary>
        public const uint VK_NV_MESH_SHADER_SPEC_VERSION = VulkanNative.NVMeshShaderSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_MESH_SHADER_EXTENSION_NAME = VulkanNative.NVMeshShaderExtensionName;
        ///<summary></summary>
        public const uint VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION = VulkanNative.NVFragmentShaderBarycentricSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME = VulkanNative.NVFragmentShaderBarycentricExtensionName;
        ///<summary></summary>
        public const uint VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION = VulkanNative.NVShaderImageFootprintSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME = VulkanNative.NVShaderImageFootprintExtensionName;
        ///<summary></summary>
        public const uint VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION = VulkanNative.NVScissorExclusiveSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME = VulkanNative.NVScissorExclusiveExtensionName;
        ///<summary></summary>
        public const uint VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION = VulkanNative.NVDeviceDiagnosticCheckpointsSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME = VulkanNative.NVDeviceDiagnosticCheckpointsExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION = VulkanNative.KHRTimelineSemaphoreSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME = VulkanNative.KHRTimelineSemaphoreExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_209_SPEC_VERSION = VulkanNative.KHRExtension209SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_209_EXTENSION_NAME = VulkanNative.KHRExtension209ExtensionName;
        ///<summary></summary>
        public const uint VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION = VulkanNative.IntelShaderIntegerFunctions2SpecVersion;
        ///<summary></summary>
        public const uint VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME = VulkanNative.IntelShaderIntegerFunctions2ExtensionName;
        ///<summary></summary>
        public const uint VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION = VulkanNative.IntelPerformanceQuerySpecVersion;
        ///<summary></summary>
        public const uint VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME = VulkanNative.IntelPerformanceQueryExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION = VulkanNative.KHRVulkanMemoryModelSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME = VulkanNative.KHRVulkanMemoryModelExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_PCI_BUS_INFO_SPEC_VERSION = VulkanNative.EXTPciBusInfoSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_PCI_BUS_INFO_EXTENSION_NAME = VulkanNative.EXTPciBusInfoExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION = VulkanNative.AMDDisplayNativeHdrSpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME = VulkanNative.AMDDisplayNativeHdrExtensionName;
        ///<summary></summary>
        public const uint VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION = VulkanNative.FuchsiaImagepipeSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME = VulkanNative.FuchsiaImagepipeSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION = VulkanNative.KHRShaderTerminateInvocationSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME = VulkanNative.KHRShaderTerminateInvocationExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_217_SPEC_VERSION = VulkanNative.KHRExtension217SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_217_EXTENSION_NAME = VulkanNative.KHRExtension217ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_METAL_SURFACE_SPEC_VERSION = VulkanNative.EXTMetalSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_METAL_SURFACE_EXTENSION_NAME = VulkanNative.EXTMetalSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION = VulkanNative.EXTFragmentDensityMapSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME = VulkanNative.EXTFragmentDensityMapExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_220_SPEC_VERSION = VulkanNative.EXTExtension220SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_220_EXTENSION_NAME = VulkanNative.EXTExtension220ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_221_SPEC_VERSION = VulkanNative.KHRExtension221SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_221_EXTENSION_NAME = VulkanNative.KHRExtension221ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION = VulkanNative.EXTScalarBlockLayoutSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME = VulkanNative.EXTScalarBlockLayoutExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_223_SPEC_VERSION = VulkanNative.EXTExtension223SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_223_EXTENSION_NAME = VulkanNative.EXTExtension223ExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION = VulkanNative.GoogleHlslFunctionality1SpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME = VulkanNative.GoogleHlslFunctionality1ExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_DECORATE_STRING_SPEC_VERSION = VulkanNative.GoogleDecorateStringSpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME = VulkanNative.GoogleDecorateStringExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION = VulkanNative.EXTSubgroupSizeControlSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME = VulkanNative.EXTSubgroupSizeControlExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION = VulkanNative.KHRFragmentShadingRateSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME = VulkanNative.KHRFragmentShadingRateExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION = VulkanNative.AMDShaderCoreProperties2SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME = VulkanNative.AMDShaderCoreProperties2ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_229_SPEC_VERSION = VulkanNative.AMDExtension229SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_229_EXTENSION_NAME = VulkanNative.AMDExtension229ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION = VulkanNative.AMDDeviceCoherentMemorySpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME = VulkanNative.AMDDeviceCoherentMemoryExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_231_SPEC_VERSION = VulkanNative.AMDExtension231SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_231_EXTENSION_NAME = VulkanNative.AMDExtension231ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_232_SPEC_VERSION = VulkanNative.AMDExtension232SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_232_EXTENSION_NAME = VulkanNative.AMDExtension232ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_233_SPEC_VERSION = VulkanNative.AMDExtension233SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_233_EXTENSION_NAME = VulkanNative.AMDExtension233ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_234_SPEC_VERSION = VulkanNative.AMDExtension234SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_234_EXTENSION_NAME = VulkanNative.AMDExtension234ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION = VulkanNative.EXTShaderImageAtomicInt64SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME = VulkanNative.EXTShaderImageAtomicInt64ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_236_SPEC_VERSION = VulkanNative.AMDExtension236SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_236_EXTENSION_NAME = VulkanNative.AMDExtension236ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SPIRV_1_4_SPEC_VERSION = VulkanNative.KHRSpirv14SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SPIRV_1_4_EXTENSION_NAME = VulkanNative.KHRSpirv14ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_MEMORY_BUDGET_SPEC_VERSION = VulkanNative.EXTMemoryBudgetSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_MEMORY_BUDGET_EXTENSION_NAME = VulkanNative.EXTMemoryBudgetExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_MEMORY_PRIORITY_SPEC_VERSION = VulkanNative.EXTMemoryPrioritySpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME = VulkanNative.EXTMemoryPriorityExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION = VulkanNative.KHRSurfaceProtectedCapabilitiesSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME = VulkanNative.KHRSurfaceProtectedCapabilitiesExtensionName;
        ///<summary></summary>
        public const uint VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION = VulkanNative.NVDedicatedAllocationImageAliasingSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME = VulkanNative.NVDedicatedAllocationImageAliasingExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION = VulkanNative.KHRSeparateDepthStencilLayoutsSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME = VulkanNative.KHRSeparateDepthStencilLayoutsExtensionName;
        ///<summary></summary>
        public const uint VK_INTEL_EXTENSION_243_SPEC_VERSION = VulkanNative.IntelExtension243SpecVersion;
        ///<summary></summary>
        public const uint VK_INTEL_EXTENSION_243_EXTENSION_NAME = VulkanNative.IntelExtension243ExtensionName;
        ///<summary></summary>
        public const uint VK_MESA_EXTENSION_244_SPEC_VERSION = VulkanNative.MesaExtension244SpecVersion;
        ///<summary></summary>
        public const uint VK_MESA_EXTENSION_244_EXTENSION_NAME = VulkanNative.MesaExtension244ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = VulkanNative.EXTBufferDeviceAddressSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME = VulkanNative.EXTBufferDeviceAddressExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_TOOLING_INFO_SPEC_VERSION = VulkanNative.EXTToolingInfoSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_TOOLING_INFO_EXTENSION_NAME = VulkanNative.EXTToolingInfoExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION = VulkanNative.EXTSeparateStencilUsageSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME = VulkanNative.EXTSeparateStencilUsageExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_VALIDATION_FEATURES_SPEC_VERSION = VulkanNative.EXTValidationFeaturesSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME = VulkanNative.EXTValidationFeaturesExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_249_SPEC_VERSION = VulkanNative.KHRExtension249SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_249_EXTENSION_NAME = VulkanNative.KHRExtension249ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION = VulkanNative.NVCooperativeMatrixSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME = VulkanNative.NVCooperativeMatrixExtensionName;
        ///<summary></summary>
        public const uint VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION = VulkanNative.NVCoverageReductionModeSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME = VulkanNative.NVCoverageReductionModeExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION = VulkanNative.EXTFragmentShaderInterlockSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME = VulkanNative.EXTFragmentShaderInterlockExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION = VulkanNative.EXTYcbcrImageArraysSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME = VulkanNative.EXTYcbcrImageArraysExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION = VulkanNative.KHRUniformBufferStandardLayoutSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME = VulkanNative.KHRUniformBufferStandardLayoutExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_255_SPEC_VERSION = VulkanNative.EXTExtension255SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_255_EXTENSION_NAME = VulkanNative.EXTExtension255ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION = VulkanNative.EXTFullScreenExclusiveSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME = VulkanNative.EXTFullScreenExclusiveExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_HEADLESS_SURFACE_SPEC_VERSION = VulkanNative.EXTHeadlessSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME = VulkanNative.EXTHeadlessSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = VulkanNative.KHRBufferDeviceAddressSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME = VulkanNative.KHRBufferDeviceAddressExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_259_SPEC_VERSION = VulkanNative.EXTExtension259SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_259_EXTENSION_NAME = VulkanNative.EXTExtension259ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_LINE_RASTERIZATION_SPEC_VERSION = VulkanNative.EXTLineRasterizationSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME = VulkanNative.EXTLineRasterizationExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION = VulkanNative.EXTShaderAtomicFloatSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME = VulkanNative.EXTShaderAtomicFloatExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_HOST_QUERY_RESET_SPEC_VERSION = VulkanNative.EXTHostQueryResetSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME = VulkanNative.EXTHostQueryResetExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_263_SPEC_VERSION = VulkanNative.GoogleExtension263SpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_EXTENSION_263_EXTENSION_NAME = VulkanNative.GoogleExtension263ExtensionName;
        ///<summary></summary>
        public const uint VK_BRCM_EXTENSION_264_SPEC_VERSION = VulkanNative.BrcmExtension264SpecVersion;
        ///<summary></summary>
        public const uint VK_BRCM_EXTENSION_264_EXTENSION_NAME = VulkanNative.BrcmExtension264ExtensionName;
        ///<summary></summary>
        public const uint VK_BRCM_EXTENSION_265_SPEC_VERSION = VulkanNative.BrcmExtension265SpecVersion;
        ///<summary></summary>
        public const uint VK_BRCM_EXTENSION_265_EXTENSION_NAME = VulkanNative.BrcmExtension265ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION = VulkanNative.EXTIndexTypeUint8SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME = VulkanNative.EXTIndexTypeUint8ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_267_SPEC_VERSION = VulkanNative.EXTExtension267SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_extension_267 = VulkanNative.EXTExtension267;
        ///<summary></summary>
        public const uint VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION = VulkanNative.EXTExtendedDynamicStateSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME = VulkanNative.EXTExtendedDynamicStateExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION = VulkanNative.KHRDeferredHostOperationsSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME = VulkanNative.KHRDeferredHostOperationsExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION = VulkanNative.KHRPipelineExecutablePropertiesSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME = VulkanNative.KHRPipelineExecutablePropertiesExtensionName;
        ///<summary></summary>
        public const uint VK_INTEL_EXTENSION_271_SPEC_VERSION = VulkanNative.IntelExtension271SpecVersion;
        ///<summary></summary>
        public const uint VK_INTEL_extension_271 = VulkanNative.IntelExtension271;
        ///<summary></summary>
        public const uint VK_INTEL_EXTENSION_272_SPEC_VERSION = VulkanNative.IntelExtension272SpecVersion;
        ///<summary></summary>
        public const uint VK_INTEL_extension_272 = VulkanNative.IntelExtension272;
        ///<summary></summary>
        public const uint VK_INTEL_EXTENSION_273_SPEC_VERSION = VulkanNative.IntelExtension273SpecVersion;
        ///<summary></summary>
        public const uint VK_INTEL_extension_273 = VulkanNative.IntelExtension273;
        ///<summary></summary>
        public const uint VK_INTEL_EXTENSION_274_SPEC_VERSION = VulkanNative.IntelExtension274SpecVersion;
        ///<summary></summary>
        public const uint VK_INTEL_extension_274 = VulkanNative.IntelExtension274;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_275_SPEC_VERSION = VulkanNative.KHRExtension275SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_extension_275 = VulkanNative.KHRExtension275;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_276_SPEC_VERSION = VulkanNative.KHRExtension276SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_extension_276 = VulkanNative.KHRExtension276;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_SPEC_VERSION = VulkanNative.EXTShaderDemoteToHelperInvocationSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_EXTENSION_NAME = VulkanNative.EXTShaderDemoteToHelperInvocationExtensionName;
        ///<summary></summary>
        public const uint VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = VulkanNative.NVDeviceGeneratedCommandsSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME = VulkanNative.NVDeviceGeneratedCommandsExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_279_SPEC_VERSION = VulkanNative.NVExtension279SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_extension_279 = VulkanNative.NVExtension279;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_280_SPEC_VERSION = VulkanNative.KHRExtension280SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_extension_280 = VulkanNative.KHRExtension280;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_281_SPEC_VERSION = VulkanNative.ArmExtension281SpecVersion;
        ///<summary></summary>
        public const uint VK_ARM_extension_281 = VulkanNative.ArmExtension281;
        ///<summary></summary>
        public const uint VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION = VulkanNative.EXTTexelBufferAlignmentSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME = VulkanNative.EXTTexelBufferAlignmentExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION = VulkanNative.QcomRenderPassTransformSpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME = VulkanNative.QcomRenderPassTransformExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_284_SPEC_VERSION = VulkanNative.EXTExtension284SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_extension_284 = VulkanNative.EXTExtension284;
        ///<summary></summary>
        public const uint VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION = VulkanNative.EXTDeviceMemoryReportSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME = VulkanNative.EXTDeviceMemoryReportExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_286_SPEC_VERSION = VulkanNative.EXTExtension286SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_extension_286 = VulkanNative.EXTExtension286;
        ///<summary></summary>
        public const uint VK_EXT_ROBUSTNESS_2_SPEC_VERSION = VulkanNative.EXTRobustness2SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_ROBUSTNESS_2_EXTENSION_NAME = VulkanNative.EXTRobustness2ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION = VulkanNative.EXTCustomBorderColorSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME = VulkanNative.EXTCustomBorderColorExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_289_SPEC_VERSION = VulkanNative.EXTExtension289SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_289_EXTENSION_NAME = VulkanNative.EXTExtension289ExtensionName;
        ///<summary></summary>
        public const uint VK_GOOGLE_USER_TYPE_SPEC_VERSION = VulkanNative.GoogleUserTypeSpecVersion;
        ///<summary></summary>
        public const uint VK_GOOGLE_USER_TYPE_EXTENSION_NAME = VulkanNative.GoogleUserTypeExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION = VulkanNative.KHRPipelineLibrarySpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME = VulkanNative.KHRPipelineLibraryExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_292_SPEC_VERSION = VulkanNative.NVExtension292SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_292_EXTENSION_NAME = VulkanNative.NVExtension292ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_293_SPEC_VERSION = VulkanNative.NVExtension293SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_293_EXTENSION_NAME = VulkanNative.NVExtension293ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION = VulkanNative.KHRShaderNonSemanticInfoSpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME = VulkanNative.KHRShaderNonSemanticInfoExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_295_SPEC_VERSION = VulkanNative.KHRExtension295SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_295_EXTENSION_NAME = VulkanNative.KHRExtension295ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_PRIVATE_DATA_SPEC_VERSION = VulkanNative.EXTPrivateDataSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_PRIVATE_DATA_EXTENSION_NAME = VulkanNative.EXTPrivateDataExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_297_SPEC_VERSION = VulkanNative.KHRExtension297SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_297_EXTENSION_NAME = VulkanNative.KHRExtension297ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION = VulkanNative.EXTPipelineCreationCacheControlSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME = VulkanNative.EXTPipelineCreationCacheControlExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_299_SPEC_VERSION = VulkanNative.KHRExtension299SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_299_EXTENSION_NAME = VulkanNative.KHRExtension299ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_300_SPEC_VERSION = VulkanNative.KHRExtension300SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_300_EXTENSION_NAME = VulkanNative.KHRExtension300ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION = VulkanNative.NVDeviceDiagnosticsConfigSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME = VulkanNative.NVDeviceDiagnosticsConfigExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_render_pass_store_ops_SPEC_VERSION = VulkanNative.QcomRenderPassStoreOpsSpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_render_pass_store_ops_EXTENSION_NAME = VulkanNative.QcomRenderPassStoreOpsExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_303_SPEC_VERSION = VulkanNative.QcomExtension303SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_303_EXTENSION_NAME = VulkanNative.QcomExtension303ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_304_SPEC_VERSION = VulkanNative.QcomExtension304SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_304_EXTENSION_NAME = VulkanNative.QcomExtension304ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_305_SPEC_VERSION = VulkanNative.QcomExtension305SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_305_EXTENSION_NAME = VulkanNative.QcomExtension305ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_306_SPEC_VERSION = VulkanNative.QcomExtension306SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_306_EXTENSION_NAME = VulkanNative.QcomExtension306ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_307_SPEC_VERSION = VulkanNative.QcomExtension307SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_307_EXTENSION_NAME = VulkanNative.QcomExtension307ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_308_SPEC_VERSION = VulkanNative.NVExtension308SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_308_EXTENSION_NAME = VulkanNative.NVExtension308ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_309_SPEC_VERSION = VulkanNative.KHRExtension309SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_309_EXTENSION_NAME = VulkanNative.KHRExtension309ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_extension_310_SPEC_VERSION = VulkanNative.QcomExtension310SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_extension_310_EXTENSION_NAME = VulkanNative.QcomExtension310ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_311_SPEC_VERSION = VulkanNative.NVExtension311SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_311_EXTENSION_NAME = VulkanNative.NVExtension311ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_312_SPEC_VERSION = VulkanNative.EXTExtension312SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_312_EXTENSION_NAME = VulkanNative.EXTExtension312ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_313_SPEC_VERSION = VulkanNative.EXTExtension313SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_313_EXTENSION_NAME = VulkanNative.EXTExtension313ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_314_SPEC_VERSION = VulkanNative.AMDExtension314SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_314_EXTENSION_NAME = VulkanNative.AMDExtension314ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_315_SPEC_VERSION = VulkanNative.AMDExtension315SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_315_EXTENSION_NAME = VulkanNative.AMDExtension315ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_316_SPEC_VERSION = VulkanNative.AMDExtension316SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_316_EXTENSION_NAME = VulkanNative.AMDExtension316ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_317_SPEC_VERSION = VulkanNative.AMDExtension317SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_317_EXTENSION_NAME = VulkanNative.AMDExtension317ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_318_SPEC_VERSION = VulkanNative.AMDExtension318SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_318_EXTENSION_NAME = VulkanNative.AMDExtension318ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_319_SPEC_VERSION = VulkanNative.AMDExtension319SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_319_EXTENSION_NAME = VulkanNative.AMDExtension319ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_320_SPEC_VERSION = VulkanNative.AMDExtension320SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_320_EXTENSION_NAME = VulkanNative.AMDExtension320ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_321_SPEC_VERSION = VulkanNative.AMDExtension321SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_321_EXTENSION_NAME = VulkanNative.AMDExtension321ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_322_SPEC_VERSION = VulkanNative.AMDExtension322SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_322_EXTENSION_NAME = VulkanNative.AMDExtension322ExtensionName;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_323_SPEC_VERSION = VulkanNative.AMDExtension323SpecVersion;
        ///<summary></summary>
        public const uint VK_AMD_EXTENSION_323_EXTENSION_NAME = VulkanNative.AMDExtension323ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_324_SPEC_VERSION = VulkanNative.KHRExtension324SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_324_EXTENSION_NAME = VulkanNative.KHRExtension324ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_325_SPEC_VERSION = VulkanNative.KHRExtension325SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_325_EXTENSION_NAME = VulkanNative.KHRExtension325ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_326_SPEC_VERSION = VulkanNative.KHRExtension326SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_326_EXTENSION_NAME = VulkanNative.KHRExtension326ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION = VulkanNative.NVFragmentShadingRateEnumsSpecVersion;
        ///<summary></summary>
        public const uint VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME = VulkanNative.NVFragmentShadingRateEnumsExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_328_SPEC_VERSION = VulkanNative.NVExtension328SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_328_EXTENSION_NAME = VulkanNative.NVExtension328ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_329_SPEC_VERSION = VulkanNative.NVExtension329SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_329_EXTENSION_NAME = VulkanNative.NVExtension329ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_330_SPEC_VERSION = VulkanNative.NVExtension330SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_330_EXTENSION_NAME = VulkanNative.NVExtension330ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_331_SPEC_VERSION = VulkanNative.NVExtension331SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_331_EXTENSION_NAME = VulkanNative.NVExtension331ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_332_SPEC_VERSION = VulkanNative.NVExtension332SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_332_EXTENSION_NAME = VulkanNative.NVExtension332ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION = VulkanNative.EXTFragmentDensityMap2SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME = VulkanNative.EXTFragmentDensityMap2ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_rotated_copy_commands_SPEC_VERSION = VulkanNative.QcomRotatedCopyCommandsSpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_rotated_copy_commands_EXTENSION_NAME = VulkanNative.QcomRotatedCopyCommandsExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_335_SPEC_VERSION = VulkanNative.KHRExtension335SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_335_EXTENSION_NAME = VulkanNative.KHRExtension335ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION = VulkanNative.EXTImageRobustnessSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME = VulkanNative.EXTImageRobustnessExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_337_SPEC_VERSION = VulkanNative.KHRExtension337SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_337_EXTENSION_NAME = VulkanNative.KHRExtension337ExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_COPY_COMMANDS_2_SPEC_VERSION = VulkanNative.KHRCopyCommands2SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME = VulkanNative.KHRCopyCommands2ExtensionName;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_339_SPEC_VERSION = VulkanNative.ArmExtension339SpecVersion;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_339_EXTENSION_NAME = VulkanNative.ArmExtension339ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_340_SPEC_VERSION = VulkanNative.EXTExtension340SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_340_EXTENSION_NAME = VulkanNative.EXTExtension340ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_4444_FORMATS_SPEC_VERSION = VulkanNative.EXT4444FormatsSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_4444_FORMATS_EXTENSION_NAME = VulkanNative.EXT4444FormatsExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_342_SPEC_VERSION = VulkanNative.EXTExtension342SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_342_EXTENSION_NAME = VulkanNative.EXTExtension342ExtensionName;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_343_SPEC_VERSION = VulkanNative.ArmExtension343SpecVersion;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_343_EXTENSION_NAME = VulkanNative.ArmExtension343ExtensionName;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_344_SPEC_VERSION = VulkanNative.ArmExtension344SpecVersion;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_344_EXTENSION_NAME = VulkanNative.ArmExtension344ExtensionName;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_345_SPEC_VERSION = VulkanNative.ArmExtension345SpecVersion;
        ///<summary></summary>
        public const uint VK_ARM_EXTENSION_345_EXTENSION_NAME = VulkanNative.ArmExtension345ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION = VulkanNative.NVAcquireWinrtDisplaySpecVersion;
        ///<summary></summary>
        public const uint VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME = VulkanNative.NVAcquireWinrtDisplayExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_DIRECTFB_SURFACE_SPEC_VERSION = VulkanNative.EXTDirectfbSurfaceSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_DIRECTFB_SURFACE_EXTENSION_NAME = VulkanNative.EXTDirectfbSurfaceExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_350_SPEC_VERSION = VulkanNative.KHRExtension350SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_350_EXTENSION_NAME = VulkanNative.KHRExtension350ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_351_SPEC_VERSION = VulkanNative.NVExtension351SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_351_EXTENSION_NAME = VulkanNative.NVExtension351ExtensionName;
        ///<summary></summary>
        public const uint VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION = VulkanNative.ValveMutableDescriptorTypeSpecVersion;
        ///<summary></summary>
        public const uint VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME = VulkanNative.ValveMutableDescriptorTypeExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_353_SPEC_VERSION = VulkanNative.EXTExtension353SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_353_EXTENSION_NAME = VulkanNative.EXTExtension353ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_354_SPEC_VERSION = VulkanNative.EXTExtension354SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_354_EXTENSION_NAME = VulkanNative.EXTExtension354ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_355_SPEC_VERSION = VulkanNative.EXTExtension355SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_355_EXTENSION_NAME = VulkanNative.EXTExtension355ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_VERTEX_ATTRIBUTE_ALIASING_SPEC_VERSION = VulkanNative.EXTVertexAttributeAliasingSpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_VERTEX_ATTRIBUTE_ALIASING_EXTENSION_NAME = VulkanNative.EXTVertexAttributeAliasingExtensionName;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_358_SPEC_VERSION = VulkanNative.KHRExtension358SpecVersion;
        ///<summary></summary>
        public const uint VK_KHR_EXTENSION_358_EXTENSION_NAME = VulkanNative.KHRExtension358ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_362_SPEC_VERSION = VulkanNative.EXTExtension362SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_362_EXTENSION_NAME = VulkanNative.EXTExtension362ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_363_SPEC_VERSION = VulkanNative.EXTExtension363SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_363_EXTENSION_NAME = VulkanNative.EXTExtension363ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_364_SPEC_VERSION = VulkanNative.EXTExtension364SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_364_EXTENSION_NAME = VulkanNative.EXTExtension364ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_365_SPEC_VERSION = VulkanNative.EXTExtension365SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_365_EXTENSION_NAME = VulkanNative.EXTExtension365ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_366_SPEC_VERSION = VulkanNative.EXTExtension366SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_366_EXTENSION_NAME = VulkanNative.EXTExtension366ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_367_SPEC_VERSION = VulkanNative.EXTExtension367SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_367_EXTENSION_NAME = VulkanNative.EXTExtension367ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_368_SPEC_VERSION = VulkanNative.EXTExtension368SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_368_EXTENSION_NAME = VulkanNative.EXTExtension368ExtensionName;
        ///<summary></summary>
        public const uint VK_QCOM_EXTENSION_369_SPEC_VERSION = VulkanNative.QcomExtension369SpecVersion;
        ///<summary></summary>
        public const uint VK_QCOM_EXTENSION_369_EXTENSION_NAME = VulkanNative.QcomExtension369ExtensionName;
        ///<summary></summary>
        public const uint VK_HUAWEI_EXTENSION_370_SPEC_VERSION = VulkanNative.HuaweiExtension370SpecVersion;
        ///<summary></summary>
        public const uint VK_HUAWEI_EXTENSION_370_EXTENSION_NAME = VulkanNative.HuaweiExtension370ExtensionName;
        ///<summary></summary>
        public const uint VK_HUAWEI_EXTENSION_371_SPEC_VERSION = VulkanNative.HuaweiExtension371SpecVersion;
        ///<summary></summary>
        public const uint VK_HUAWEI_EXTENSION_371_EXTENSION_NAME = VulkanNative.HuaweiExtension371ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_372_SPEC_VERSION = VulkanNative.NVExtension372SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_372_EXTENSION_NAME = VulkanNative.NVExtension372ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_373_SPEC_VERSION = VulkanNative.NVExtension373SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_373_EXTENSION_NAME = VulkanNative.NVExtension373ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_374_SPEC_VERSION = VulkanNative.NVExtension374SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_374_EXTENSION_NAME = VulkanNative.NVExtension374ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_375_SPEC_VERSION = VulkanNative.NVExtension375SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_375_EXTENSION_NAME = VulkanNative.NVExtension375ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_376_SPEC_VERSION = VulkanNative.EXTExtension376SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_376_EXTENSION_NAME = VulkanNative.EXTExtension376ExtensionName;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_377_SPEC_VERSION = VulkanNative.EXTExtension377SpecVersion;
        ///<summary></summary>
        public const uint VK_EXT_EXTENSION_377_EXTENSION_NAME = VulkanNative.EXTExtension377ExtensionName;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_378_SPEC_VERSION = VulkanNative.NVExtension378SpecVersion;
        ///<summary></summary>
        public const uint VK_NV_EXTENSION_378_EXTENSION_NAME = VulkanNative.NVExtension378ExtensionName;
    }
}
