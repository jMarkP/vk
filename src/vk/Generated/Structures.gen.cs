// This file is generated.

using System;

namespace Vulkan
{
    public unsafe partial struct VkBaseOutStructure
    {
        public VkStructureType sType;
        public VkBaseOutStructure* pNext;
    }

    public unsafe partial struct VkBaseInStructure
    {
        public VkStructureType sType;
        public VkBaseInStructure* pNext;
    }

    public unsafe partial struct VkOffset2D
    {
        public int x;
        public int y;
    }

    public unsafe partial struct VkOffset3D
    {
        public int x;
        public int y;
        public int z;
    }

    public unsafe partial struct VkExtent2D
    {
        public uint width;
        public uint height;
    }

    public unsafe partial struct VkExtent3D
    {
        public uint width;
        public uint height;
        public uint depth;
    }

    public unsafe partial struct VkViewport
    {
        public float x;
        public float y;
        public float width;
        public float height;
        public float minDepth;
        public float maxDepth;
    }

    public unsafe partial struct VkRect2D
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
    }

    public unsafe partial struct VkClearRect
    {
        public VkRect2D rect;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public unsafe partial struct VkComponentMapping
    {
        public VkComponentSwizzle r;
        public VkComponentSwizzle g;
        public VkComponentSwizzle b;
        public VkComponentSwizzle a;
    }

    public unsafe partial struct VkPhysicalDeviceProperties
    {
        public uint apiVersion;
        public uint driverVersion;
        public uint vendorID;
        public uint deviceID;
        public VkPhysicalDeviceType deviceType;
        public fixed byte deviceName[(int)VulkanNative.MaxPhysicalDeviceNameSize];
        public fixed byte pipelineCacheUUID[(int)VulkanNative.UuidSize];
        public VkPhysicalDeviceLimits limits;
        public VkPhysicalDeviceSparseProperties sparseProperties;
    }

    public unsafe partial struct VkExtensionProperties
    {
        public fixed byte extensionName[(int)VulkanNative.MaxExtensionNameSize];
        public uint specVersion;
    }

    public unsafe partial struct VkLayerProperties
    {
        public fixed byte layerName[(int)VulkanNative.MaxExtensionNameSize];
        public uint specVersion;
        public uint implementationVersion;
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
    }

    public unsafe partial struct VkApplicationInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pApplicationName;
        public uint applicationVersion;
        public byte* pEngineName;
        public uint engineVersion;
        public uint apiVersion;
        public static VkApplicationInfo New()
        {
            VkApplicationInfo ret = new VkApplicationInfo();
            ret.sType = VkStructureType.ApplicationInfo;
            return ret;
        }
    }

    public unsafe partial struct VkAllocationCallbacks
    {
        public void* pUserData;
        public IntPtr pfnAllocation;
        public IntPtr pfnReallocation;
        public IntPtr pfnFree;
        public IntPtr pfnInternalAllocation;
        public IntPtr pfnInternalFree;
    }

    public unsafe partial struct VkDeviceQueueCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueCount;
        public float* pQueuePriorities;
        public static VkDeviceQueueCreateInfo New()
        {
            VkDeviceQueueCreateInfo ret = new VkDeviceQueueCreateInfo();
            ret.sType = VkStructureType.DeviceQueueCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint queueCreateInfoCount;
        public VkDeviceQueueCreateInfo* pQueueCreateInfos;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
        public static VkDeviceCreateInfo New()
        {
            VkDeviceCreateInfo ret = new VkDeviceCreateInfo();
            ret.sType = VkStructureType.DeviceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkInstanceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkApplicationInfo* pApplicationInfo;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public static VkInstanceCreateInfo New()
        {
            VkInstanceCreateInfo ret = new VkInstanceCreateInfo();
            ret.sType = VkStructureType.InstanceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyProperties
    {
        public VkQueueFlags queueFlags;
        public uint queueCount;
        public uint timestampValidBits;
        public VkExtent3D minImageTransferGranularity;
    }

    public unsafe partial struct VkPhysicalDeviceMemoryProperties
    {
        public uint memoryTypeCount;
        public VkMemoryType memoryTypes_0;
        public VkMemoryType memoryTypes_1;
        public VkMemoryType memoryTypes_2;
        public VkMemoryType memoryTypes_3;
        public VkMemoryType memoryTypes_4;
        public VkMemoryType memoryTypes_5;
        public VkMemoryType memoryTypes_6;
        public VkMemoryType memoryTypes_7;
        public VkMemoryType memoryTypes_8;
        public VkMemoryType memoryTypes_9;
        public VkMemoryType memoryTypes_10;
        public VkMemoryType memoryTypes_11;
        public VkMemoryType memoryTypes_12;
        public VkMemoryType memoryTypes_13;
        public VkMemoryType memoryTypes_14;
        public VkMemoryType memoryTypes_15;
        public VkMemoryType memoryTypes_16;
        public VkMemoryType memoryTypes_17;
        public VkMemoryType memoryTypes_18;
        public VkMemoryType memoryTypes_19;
        public VkMemoryType memoryTypes_20;
        public VkMemoryType memoryTypes_21;
        public VkMemoryType memoryTypes_22;
        public VkMemoryType memoryTypes_23;
        public VkMemoryType memoryTypes_24;
        public VkMemoryType memoryTypes_25;
        public VkMemoryType memoryTypes_26;
        public VkMemoryType memoryTypes_27;
        public VkMemoryType memoryTypes_28;
        public VkMemoryType memoryTypes_29;
        public VkMemoryType memoryTypes_30;
        public VkMemoryType memoryTypes_31;
        public uint memoryHeapCount;
        public VkMemoryHeap memoryHeaps_0;
        public VkMemoryHeap memoryHeaps_1;
        public VkMemoryHeap memoryHeaps_2;
        public VkMemoryHeap memoryHeaps_3;
        public VkMemoryHeap memoryHeaps_4;
        public VkMemoryHeap memoryHeaps_5;
        public VkMemoryHeap memoryHeaps_6;
        public VkMemoryHeap memoryHeaps_7;
        public VkMemoryHeap memoryHeaps_8;
        public VkMemoryHeap memoryHeaps_9;
        public VkMemoryHeap memoryHeaps_10;
        public VkMemoryHeap memoryHeaps_11;
        public VkMemoryHeap memoryHeaps_12;
        public VkMemoryHeap memoryHeaps_13;
        public VkMemoryHeap memoryHeaps_14;
        public VkMemoryHeap memoryHeaps_15;
    }

    public unsafe partial struct VkMemoryAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeIndex;
        public static VkMemoryAllocateInfo New()
        {
            VkMemoryAllocateInfo ret = new VkMemoryAllocateInfo();
            ret.sType = VkStructureType.MemoryAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryRequirements
    {
        public ulong size;
        public ulong alignment;
        public uint memoryTypeBits;
    }

    public unsafe partial struct VkSparseImageFormatProperties
    {
        public VkImageAspectFlags aspectMask;
        public VkExtent3D imageGranularity;
        public VkSparseImageFormatFlags flags;
    }

    public unsafe partial struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties formatProperties;
        public uint imageMipTailFirstLod;
        public ulong imageMipTailSize;
        public ulong imageMipTailOffset;
        public ulong imageMipTailStride;
    }

    public unsafe partial struct VkMemoryType
    {
        public VkMemoryPropertyFlags propertyFlags;
        public uint heapIndex;
    }

    public unsafe partial struct VkMemoryHeap
    {
        public ulong size;
        public VkMemoryHeapFlags flags;
    }

    public unsafe partial struct VkMappedMemoryRange
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        public static VkMappedMemoryRange New()
        {
            VkMappedMemoryRange ret = new VkMappedMemoryRange();
            ret.sType = VkStructureType.MappedMemoryRange;
            return ret;
        }
    }

    public unsafe partial struct VkFormatProperties
    {
        public VkFormatFeatureFlags linearTilingFeatures;
        public VkFormatFeatureFlags optimalTilingFeatures;
        public VkFormatFeatureFlags bufferFeatures;
    }

    public unsafe partial struct VkImageFormatProperties
    {
        public VkExtent3D maxExtent;
        public uint maxMipLevels;
        public uint maxArrayLayers;
        public VkSampleCountFlags sampleCounts;
        public ulong maxResourceSize;
    }

    public unsafe partial struct VkDescriptorBufferInfo
    {
        public VkBuffer buffer;
        public ulong offset;
        public ulong range;
    }

    public unsafe partial struct VkDescriptorImageInfo
    {
        public VkSampler sampler;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
    }

    public unsafe partial struct VkWriteDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public VkDescriptorImageInfo* pImageInfo;
        public VkDescriptorBufferInfo* pBufferInfo;
        public VkBufferView* pTexelBufferView;
        public static VkWriteDescriptorSet New()
        {
            VkWriteDescriptorSet ret = new VkWriteDescriptorSet();
            ret.sType = VkStructureType.WriteDescriptorSet;
            return ret;
        }
    }

    public unsafe partial struct VkCopyDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet srcSet;
        public uint srcBinding;
        public uint srcArrayElement;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public static VkCopyDescriptorSet New()
        {
            VkCopyDescriptorSet ret = new VkCopyDescriptorSet();
            ret.sType = VkStructureType.CopyDescriptorSet;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateFlags flags;
        public ulong size;
        public VkBufferUsageFlags usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public static VkBufferCreateInfo New()
        {
            VkBufferCreateInfo ret = new VkBufferCreateInfo();
            ret.sType = VkStructureType.BufferCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferViewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBuffer buffer;
        public VkFormat format;
        public ulong offset;
        public ulong range;
        public static VkBufferViewCreateInfo New()
        {
            VkBufferViewCreateInfo ret = new VkBufferViewCreateInfo();
            ret.sType = VkStructureType.BufferViewCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageSubresource
    {
        public VkImageAspectFlags aspectMask;
        public uint mipLevel;
        public uint arrayLayer;
    }

    public unsafe partial struct VkImageSubresourceLayers
    {
        public VkImageAspectFlags aspectMask;
        public uint mipLevel;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public unsafe partial struct VkImageSubresourceRange
    {
        public VkImageAspectFlags aspectMask;
        public uint baseMipLevel;
        public uint levelCount;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public unsafe partial struct VkMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public static VkMemoryBarrier New()
        {
            VkMemoryBarrier ret = new VkMemoryBarrier();
            ret.sType = VkStructureType.MemoryBarrier;
            return ret;
        }
    }

    public unsafe partial struct VkBufferMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public static VkBufferMemoryBarrier New()
        {
            VkBufferMemoryBarrier ret = new VkBufferMemoryBarrier();
            ret.sType = VkStructureType.BufferMemoryBarrier;
            return ret;
        }
    }

    public unsafe partial struct VkImageMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
        public static VkImageMemoryBarrier New()
        {
            VkImageMemoryBarrier ret = new VkImageMemoryBarrier();
            ret.sType = VkStructureType.ImageMemoryBarrier;
            return ret;
        }
    }

    public unsafe partial struct VkImageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlags flags;
        public VkImageType imageType;
        public VkFormat format;
        public VkExtent3D extent;
        public uint mipLevels;
        public uint arrayLayers;
        public VkSampleCountFlags samples;
        public VkImageTiling tiling;
        public VkImageUsageFlags usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkImageLayout initialLayout;
        public static VkImageCreateInfo New()
        {
            VkImageCreateInfo ret = new VkImageCreateInfo();
            ret.sType = VkStructureType.ImageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSubresourceLayout
    {
        public ulong offset;
        public ulong size;
        public ulong rowPitch;
        public ulong arrayPitch;
        public ulong depthPitch;
    }

    public unsafe partial struct VkImageViewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageViewCreateFlags flags;
        public VkImage image;
        public VkImageViewType viewType;
        public VkFormat format;
        public VkComponentMapping components;
        public VkImageSubresourceRange subresourceRange;
        public static VkImageViewCreateInfo New()
        {
            VkImageViewCreateInfo ret = new VkImageViewCreateInfo();
            ret.sType = VkStructureType.ImageViewCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCopy
    {
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
    }

    public unsafe partial struct VkSparseMemoryBind
    {
        public ulong resourceOffset;
        public ulong size;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlags flags;
    }

    public unsafe partial struct VkSparseImageMemoryBind
    {
        public VkImageSubresource subresource;
        public VkOffset3D offset;
        public VkExtent3D extent;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlags flags;
    }

    public unsafe partial struct VkSparseBufferMemoryBindInfo
    {
        public VkBuffer buffer;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
    }

    public unsafe partial struct VkSparseImageOpaqueMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
    }

    public unsafe partial struct VkSparseImageMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseImageMemoryBind* pBinds;
    }

    public unsafe partial struct VkBindSparseInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint bufferBindCount;
        public VkSparseBufferMemoryBindInfo* pBufferBinds;
        public uint imageOpaqueBindCount;
        public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
        public uint imageBindCount;
        public VkSparseImageMemoryBindInfo* pImageBinds;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
        public static VkBindSparseInfo New()
        {
            VkBindSparseInfo ret = new VkBindSparseInfo();
            ret.sType = VkStructureType.BindSparseInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageCopy
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }

    public unsafe partial struct VkImageBlit
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffsets_0;
        public VkOffset3D srcOffsets_1;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffsets_0;
        public VkOffset3D dstOffsets_1;
    }

    public unsafe partial struct VkBufferImageCopy
    {
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }

    public unsafe partial struct VkImageResolve
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }

    public unsafe partial struct VkShaderModuleCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderModuleCreateFlags flags;
        public UIntPtr codeSize;
        public uint* pCode;
        public static VkShaderModuleCreateInfo New()
        {
            VkShaderModuleCreateInfo ret = new VkShaderModuleCreateInfo();
            ret.sType = VkStructureType.ShaderModuleCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutBinding
    {
        public uint binding;
        public VkDescriptorType descriptorType;
        public uint descriptorCount;
        public VkShaderStageFlags stageFlags;
        public VkSampler* pImmutableSamplers;
    }

    public unsafe partial struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSetLayoutCreateFlags flags;
        public uint bindingCount;
        public VkDescriptorSetLayoutBinding* pBindings;
        public static VkDescriptorSetLayoutCreateInfo New()
        {
            VkDescriptorSetLayoutCreateInfo ret = new VkDescriptorSetLayoutCreateInfo();
            ret.sType = VkStructureType.DescriptorSetLayoutCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorPoolSize
    {
        public VkDescriptorType type;
        public uint descriptorCount;
    }

    public unsafe partial struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPoolCreateFlags flags;
        public uint maxSets;
        public uint poolSizeCount;
        public VkDescriptorPoolSize* pPoolSizes;
        public static VkDescriptorPoolCreateInfo New()
        {
            VkDescriptorPoolCreateInfo ret = new VkDescriptorPoolCreateInfo();
            ret.sType = VkStructureType.DescriptorPoolCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPool descriptorPool;
        public uint descriptorSetCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public static VkDescriptorSetAllocateInfo New()
        {
            VkDescriptorSetAllocateInfo ret = new VkDescriptorSetAllocateInfo();
            ret.sType = VkStructureType.DescriptorSetAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSpecializationMapEntry
    {
        public uint constantID;
        public uint offset;
        public UIntPtr size;
    }

    public unsafe partial struct VkSpecializationInfo
    {
        public uint mapEntryCount;
        public VkSpecializationMapEntry* pMapEntries;
        public UIntPtr dataSize;
        public void* pData;
    }

    public unsafe partial struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineShaderStageCreateFlags flags;
        public VkShaderStageFlags stage;
        public VkShaderModule module;
        public byte* pName;
        public VkSpecializationInfo* pSpecializationInfo;
        public static VkPipelineShaderStageCreateInfo New()
        {
            VkPipelineShaderStageCreateInfo ret = new VkPipelineShaderStageCreateInfo();
            ret.sType = VkStructureType.PipelineShaderStageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkComputePipelineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public VkPipelineShaderStageCreateInfo stage;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkComputePipelineCreateInfo New()
        {
            VkComputePipelineCreateInfo ret = new VkComputePipelineCreateInfo();
            ret.sType = VkStructureType.ComputePipelineCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkVertexInputBindingDescription
    {
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
    }

    public unsafe partial struct VkVertexInputAttributeDescription
    {
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
    }

    public unsafe partial struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint vertexBindingDescriptionCount;
        public VkVertexInputBindingDescription* pVertexBindingDescriptions;
        public uint vertexAttributeDescriptionCount;
        public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
        public static VkPipelineVertexInputStateCreateInfo New()
        {
            VkPipelineVertexInputStateCreateInfo ret = new VkPipelineVertexInputStateCreateInfo();
            ret.sType = VkStructureType.PipelineVertexInputStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkPrimitiveTopology topology;
        public VkBool32 primitiveRestartEnable;
        public static VkPipelineInputAssemblyStateCreateInfo New()
        {
            VkPipelineInputAssemblyStateCreateInfo ret = new VkPipelineInputAssemblyStateCreateInfo();
            ret.sType = VkStructureType.PipelineInputAssemblyStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint patchControlPoints;
        public static VkPipelineTessellationStateCreateInfo New()
        {
            VkPipelineTessellationStateCreateInfo ret = new VkPipelineTessellationStateCreateInfo();
            ret.sType = VkStructureType.PipelineTessellationStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint viewportCount;
        public VkViewport* pViewports;
        public uint scissorCount;
        public VkRect2D* pScissors;
        public static VkPipelineViewportStateCreateInfo New()
        {
            VkPipelineViewportStateCreateInfo ret = new VkPipelineViewportStateCreateInfo();
            ret.sType = VkStructureType.PipelineViewportStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 depthClampEnable;
        public VkBool32 rasterizerDiscardEnable;
        public VkPolygonMode polygonMode;
        public VkCullModeFlags cullMode;
        public VkFrontFace frontFace;
        public VkBool32 depthBiasEnable;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public float lineWidth;
        public static VkPipelineRasterizationStateCreateInfo New()
        {
            VkPipelineRasterizationStateCreateInfo ret = new VkPipelineRasterizationStateCreateInfo();
            ret.sType = VkStructureType.PipelineRasterizationStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkSampleCountFlags rasterizationSamples;
        public VkBool32 sampleShadingEnable;
        public float minSampleShading;
        public uint* pSampleMask;
        public VkBool32 alphaToCoverageEnable;
        public VkBool32 alphaToOneEnable;
        public static VkPipelineMultisampleStateCreateInfo New()
        {
            VkPipelineMultisampleStateCreateInfo ret = new VkPipelineMultisampleStateCreateInfo();
            ret.sType = VkStructureType.PipelineMultisampleStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineColorBlendAttachmentState
    {
        public VkBool32 blendEnable;
        public VkBlendFactor srcColorBlendFactor;
        public VkBlendFactor dstColorBlendFactor;
        public VkBlendOp colorBlendOp;
        public VkBlendFactor srcAlphaBlendFactor;
        public VkBlendFactor dstAlphaBlendFactor;
        public VkBlendOp alphaBlendOp;
        public VkColorComponentFlags colorWriteMask;
    }

    public unsafe partial struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 logicOpEnable;
        public VkLogicOp logicOp;
        public uint attachmentCount;
        public VkPipelineColorBlendAttachmentState* pAttachments;
        public float blendConstants_0;
        public float blendConstants_1;
        public float blendConstants_2;
        public float blendConstants_3;
        public static VkPipelineColorBlendStateCreateInfo New()
        {
            VkPipelineColorBlendStateCreateInfo ret = new VkPipelineColorBlendStateCreateInfo();
            ret.sType = VkStructureType.PipelineColorBlendStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineDynamicStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint dynamicStateCount;
        public VkDynamicState* pDynamicStates;
        public static VkPipelineDynamicStateCreateInfo New()
        {
            VkPipelineDynamicStateCreateInfo ret = new VkPipelineDynamicStateCreateInfo();
            ret.sType = VkStructureType.PipelineDynamicStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkStencilOpState
    {
        public VkStencilOp failOp;
        public VkStencilOp passOp;
        public VkStencilOp depthFailOp;
        public VkCompareOp compareOp;
        public uint compareMask;
        public uint writeMask;
        public uint reference;
    }

    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 depthTestEnable;
        public VkBool32 depthWriteEnable;
        public VkCompareOp depthCompareOp;
        public VkBool32 depthBoundsTestEnable;
        public VkBool32 stencilTestEnable;
        public VkStencilOpState front;
        public VkStencilOpState back;
        public float minDepthBounds;
        public float maxDepthBounds;
        public static VkPipelineDepthStencilStateCreateInfo New()
        {
            VkPipelineDepthStencilStateCreateInfo ret = new VkPipelineDepthStencilStateCreateInfo();
            ret.sType = VkStructureType.PipelineDepthStencilStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        public VkPipelineViewportStateCreateInfo* pViewportState;
        public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
        public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
        public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
        public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkGraphicsPipelineCreateInfo New()
        {
            VkGraphicsPipelineCreateInfo ret = new VkGraphicsPipelineCreateInfo();
            ret.sType = VkStructureType.GraphicsPipelineCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCacheCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCacheCreateFlags flags;
        public UIntPtr initialDataSize;
        public void* pInitialData;
        public static VkPipelineCacheCreateInfo New()
        {
            VkPipelineCacheCreateInfo ret = new VkPipelineCacheCreateInfo();
            ret.sType = VkStructureType.PipelineCacheCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPushConstantRange
    {
        public VkShaderStageFlags stageFlags;
        public uint offset;
        public uint size;
    }

    public unsafe partial struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public static VkPipelineLayoutCreateInfo New()
        {
            VkPipelineLayoutCreateInfo ret = new VkPipelineLayoutCreateInfo();
            ret.sType = VkStructureType.PipelineLayoutCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerCreateFlags flags;
        public VkFilter magFilter;
        public VkFilter minFilter;
        public VkSamplerMipmapMode mipmapMode;
        public VkSamplerAddressMode addressModeU;
        public VkSamplerAddressMode addressModeV;
        public VkSamplerAddressMode addressModeW;
        public float mipLodBias;
        public VkBool32 anisotropyEnable;
        public float maxAnisotropy;
        public VkBool32 compareEnable;
        public VkCompareOp compareOp;
        public float minLod;
        public float maxLod;
        public VkBorderColor borderColor;
        public VkBool32 unnormalizedCoordinates;
        public static VkSamplerCreateInfo New()
        {
            VkSamplerCreateInfo ret = new VkSamplerCreateInfo();
            ret.sType = VkStructureType.SamplerCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPoolCreateFlags flags;
        public uint queueFamilyIndex;
        public static VkCommandPoolCreateInfo New()
        {
            VkCommandPoolCreateInfo ret = new VkCommandPoolCreateInfo();
            ret.sType = VkStructureType.CommandPoolCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPool commandPool;
        public VkCommandBufferLevel level;
        public uint commandBufferCount;
        public static VkCommandBufferAllocateInfo New()
        {
            VkCommandBufferAllocateInfo ret = new VkCommandBufferAllocateInfo();
            ret.sType = VkStructureType.CommandBufferAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkFramebuffer framebuffer;
        public VkBool32 occlusionQueryEnable;
        public VkQueryControlFlags queryFlags;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
        public static VkCommandBufferInheritanceInfo New()
        {
            VkCommandBufferInheritanceInfo ret = new VkCommandBufferInheritanceInfo();
            ret.sType = VkStructureType.CommandBufferInheritanceInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandBufferUsageFlags flags;
        public VkCommandBufferInheritanceInfo* pInheritanceInfo;
        public static VkCommandBufferBeginInfo New()
        {
            VkCommandBufferBeginInfo ret = new VkCommandBufferBeginInfo();
            ret.sType = VkStructureType.CommandBufferBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public VkFramebuffer framebuffer;
        public VkRect2D renderArea;
        public uint clearValueCount;
        public VkClearValue* pClearValues;
        public static VkRenderPassBeginInfo New()
        {
            VkRenderPassBeginInfo ret = new VkRenderPassBeginInfo();
            ret.sType = VkStructureType.RenderPassBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkClearDepthStencilValue
    {
        public float depth;
        public uint stencil;
    }

    public unsafe partial struct VkClearAttachment
    {
        public VkImageAspectFlags aspectMask;
        public uint colorAttachment;
        public VkClearValue clearValue;
    }

    public unsafe partial struct VkAttachmentDescription
    {
        public VkAttachmentDescriptionFlags flags;
        public VkFormat format;
        public VkSampleCountFlags samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
    }

    public unsafe partial struct VkAttachmentReference
    {
        public uint attachment;
        public VkImageLayout layout;
    }

    public unsafe partial struct VkSubpassDescription
    {
        public VkSubpassDescriptionFlags flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint inputAttachmentCount;
        public VkAttachmentReference* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference* pColorAttachments;
        public VkAttachmentReference* pResolveAttachments;
        public VkAttachmentReference* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
    }

    public unsafe partial struct VkSubpassDependency
    {
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlags srcStageMask;
        public VkPipelineStageFlags dstStageMask;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public VkDependencyFlags dependencyFlags;
    }

    public unsafe partial struct VkRenderPassCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlags flags;
        public uint attachmentCount;
        public VkAttachmentDescription* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency* pDependencies;
        public static VkRenderPassCreateInfo New()
        {
            VkRenderPassCreateInfo ret = new VkRenderPassCreateInfo();
            ret.sType = VkStructureType.RenderPassCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkEventCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkEventCreateInfo New()
        {
            VkEventCreateInfo ret = new VkEventCreateInfo();
            ret.sType = VkStructureType.EventCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFenceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFenceCreateFlags flags;
        public static VkFenceCreateInfo New()
        {
            VkFenceCreateInfo ret = new VkFenceCreateInfo();
            ret.sType = VkStructureType.FenceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFeatures
    {
        public VkBool32 robustBufferAccess;
        public VkBool32 fullDrawIndexUint32;
        public VkBool32 imageCubeArray;
        public VkBool32 independentBlend;
        public VkBool32 geometryShader;
        public VkBool32 tessellationShader;
        public VkBool32 sampleRateShading;
        public VkBool32 dualSrcBlend;
        public VkBool32 logicOp;
        public VkBool32 multiDrawIndirect;
        public VkBool32 drawIndirectFirstInstance;
        public VkBool32 depthClamp;
        public VkBool32 depthBiasClamp;
        public VkBool32 fillModeNonSolid;
        public VkBool32 depthBounds;
        public VkBool32 wideLines;
        public VkBool32 largePoints;
        public VkBool32 alphaToOne;
        public VkBool32 multiViewport;
        public VkBool32 samplerAnisotropy;
        public VkBool32 textureCompressionETC2;
        public VkBool32 textureCompressionASTC_LDR;
        public VkBool32 textureCompressionBC;
        public VkBool32 occlusionQueryPrecise;
        public VkBool32 pipelineStatisticsQuery;
        public VkBool32 vertexPipelineStoresAndAtomics;
        public VkBool32 fragmentStoresAndAtomics;
        public VkBool32 shaderTessellationAndGeometryPointSize;
        public VkBool32 shaderImageGatherExtended;
        public VkBool32 shaderStorageImageExtendedFormats;
        public VkBool32 shaderStorageImageMultisample;
        public VkBool32 shaderStorageImageReadWithoutFormat;
        public VkBool32 shaderStorageImageWriteWithoutFormat;
        public VkBool32 shaderUniformBufferArrayDynamicIndexing;
        public VkBool32 shaderSampledImageArrayDynamicIndexing;
        public VkBool32 shaderStorageBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageImageArrayDynamicIndexing;
        public VkBool32 shaderClipDistance;
        public VkBool32 shaderCullDistance;
        public VkBool32 shaderFloat64;
        public VkBool32 shaderInt64;
        public VkBool32 shaderInt16;
        public VkBool32 shaderResourceResidency;
        public VkBool32 shaderResourceMinLod;
        public VkBool32 sparseBinding;
        public VkBool32 sparseResidencyBuffer;
        public VkBool32 sparseResidencyImage2D;
        public VkBool32 sparseResidencyImage3D;
        public VkBool32 sparseResidency2Samples;
        public VkBool32 sparseResidency4Samples;
        public VkBool32 sparseResidency8Samples;
        public VkBool32 sparseResidency16Samples;
        public VkBool32 sparseResidencyAliased;
        public VkBool32 variableMultisampleRate;
        public VkBool32 inheritedQueries;
    }

    public unsafe partial struct VkPhysicalDeviceSparseProperties
    {
        public VkBool32 residencyStandard2DBlockShape;
        public VkBool32 residencyStandard2DMultisampleBlockShape;
        public VkBool32 residencyStandard3DBlockShape;
        public VkBool32 residencyAlignedMipSize;
        public VkBool32 residencyNonResidentStrict;
    }

    public unsafe partial struct VkPhysicalDeviceLimits
    {
        public uint maxImageDimension1D;
        public uint maxImageDimension2D;
        public uint maxImageDimension3D;
        public uint maxImageDimensionCube;
        public uint maxImageArrayLayers;
        public uint maxTexelBufferElements;
        public uint maxUniformBufferRange;
        public uint maxStorageBufferRange;
        public uint maxPushConstantsSize;
        public uint maxMemoryAllocationCount;
        public uint maxSamplerAllocationCount;
        public ulong bufferImageGranularity;
        public ulong sparseAddressSpaceSize;
        public uint maxBoundDescriptorSets;
        public uint maxPerStageDescriptorSamplers;
        public uint maxPerStageDescriptorUniformBuffers;
        public uint maxPerStageDescriptorStorageBuffers;
        public uint maxPerStageDescriptorSampledImages;
        public uint maxPerStageDescriptorStorageImages;
        public uint maxPerStageDescriptorInputAttachments;
        public uint maxPerStageResources;
        public uint maxDescriptorSetSamplers;
        public uint maxDescriptorSetUniformBuffers;
        public uint maxDescriptorSetUniformBuffersDynamic;
        public uint maxDescriptorSetStorageBuffers;
        public uint maxDescriptorSetStorageBuffersDynamic;
        public uint maxDescriptorSetSampledImages;
        public uint maxDescriptorSetStorageImages;
        public uint maxDescriptorSetInputAttachments;
        public uint maxVertexInputAttributes;
        public uint maxVertexInputBindings;
        public uint maxVertexInputAttributeOffset;
        public uint maxVertexInputBindingStride;
        public uint maxVertexOutputComponents;
        public uint maxTessellationGenerationLevel;
        public uint maxTessellationPatchSize;
        public uint maxTessellationControlPerVertexInputComponents;
        public uint maxTessellationControlPerVertexOutputComponents;
        public uint maxTessellationControlPerPatchOutputComponents;
        public uint maxTessellationControlTotalOutputComponents;
        public uint maxTessellationEvaluationInputComponents;
        public uint maxTessellationEvaluationOutputComponents;
        public uint maxGeometryShaderInvocations;
        public uint maxGeometryInputComponents;
        public uint maxGeometryOutputComponents;
        public uint maxGeometryOutputVertices;
        public uint maxGeometryTotalOutputComponents;
        public uint maxFragmentInputComponents;
        public uint maxFragmentOutputAttachments;
        public uint maxFragmentDualSrcAttachments;
        public uint maxFragmentCombinedOutputResources;
        public uint maxComputeSharedMemorySize;
        public uint maxComputeWorkGroupCount_0;
        public uint maxComputeWorkGroupCount_1;
        public uint maxComputeWorkGroupCount_2;
        public uint maxComputeWorkGroupInvocations;
        public uint maxComputeWorkGroupSize_0;
        public uint maxComputeWorkGroupSize_1;
        public uint maxComputeWorkGroupSize_2;
        public uint subPixelPrecisionBits;
        public uint subTexelPrecisionBits;
        public uint mipmapPrecisionBits;
        public uint maxDrawIndexedIndexValue;
        public uint maxDrawIndirectCount;
        public float maxSamplerLodBias;
        public float maxSamplerAnisotropy;
        public uint maxViewports;
        public uint maxViewportDimensions_0;
        public uint maxViewportDimensions_1;
        public float viewportBoundsRange_0;
        public float viewportBoundsRange_1;
        public uint viewportSubPixelBits;
        public UIntPtr minMemoryMapAlignment;
        public ulong minTexelBufferOffsetAlignment;
        public ulong minUniformBufferOffsetAlignment;
        public ulong minStorageBufferOffsetAlignment;
        public int minTexelOffset;
        public uint maxTexelOffset;
        public int minTexelGatherOffset;
        public uint maxTexelGatherOffset;
        public float minInterpolationOffset;
        public float maxInterpolationOffset;
        public uint subPixelInterpolationOffsetBits;
        public uint maxFramebufferWidth;
        public uint maxFramebufferHeight;
        public uint maxFramebufferLayers;
        public VkSampleCountFlags framebufferColorSampleCounts;
        public VkSampleCountFlags framebufferDepthSampleCounts;
        public VkSampleCountFlags framebufferStencilSampleCounts;
        public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
        public uint maxColorAttachments;
        public VkSampleCountFlags sampledImageColorSampleCounts;
        public VkSampleCountFlags sampledImageIntegerSampleCounts;
        public VkSampleCountFlags sampledImageDepthSampleCounts;
        public VkSampleCountFlags sampledImageStencilSampleCounts;
        public VkSampleCountFlags storageImageSampleCounts;
        public uint maxSampleMaskWords;
        public VkBool32 timestampComputeAndGraphics;
        public float timestampPeriod;
        public uint maxClipDistances;
        public uint maxCullDistances;
        public uint maxCombinedClipAndCullDistances;
        public uint discreteQueuePriorities;
        public float pointSizeRange_0;
        public float pointSizeRange_1;
        public float lineWidthRange_0;
        public float lineWidthRange_1;
        public float pointSizeGranularity;
        public float lineWidthGranularity;
        public VkBool32 strictLines;
        public VkBool32 standardSampleLocations;
        public ulong optimalBufferCopyOffsetAlignment;
        public ulong optimalBufferCopyRowPitchAlignment;
        public ulong nonCoherentAtomSize;
    }

    public unsafe partial struct VkSemaphoreCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkSemaphoreCreateInfo New()
        {
            VkSemaphoreCreateInfo ret = new VkSemaphoreCreateInfo();
            ret.sType = VkStructureType.SemaphoreCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkQueryType queryType;
        public uint queryCount;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
        public static VkQueryPoolCreateInfo New()
        {
            VkQueryPoolCreateInfo ret = new VkQueryPoolCreateInfo();
            ret.sType = VkStructureType.QueryPoolCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFramebufferCreateFlags flags;
        public VkRenderPass renderPass;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        public uint width;
        public uint height;
        public uint layers;
        public static VkFramebufferCreateInfo New()
        {
            VkFramebufferCreateInfo ret = new VkFramebufferCreateInfo();
            ret.sType = VkStructureType.FramebufferCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDrawIndirectCommand
    {
        public uint vertexCount;
        public uint instanceCount;
        public uint firstVertex;
        public uint firstInstance;
    }

    public unsafe partial struct VkDrawIndexedIndirectCommand
    {
        public uint indexCount;
        public uint instanceCount;
        public uint firstIndex;
        public int vertexOffset;
        public uint firstInstance;
    }

    public unsafe partial struct VkDispatchIndirectCommand
    {
        public uint x;
        public uint y;
        public uint z;
    }

    public unsafe partial struct VkSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public VkPipelineStageFlags* pWaitDstStageMask;
        public uint commandBufferCount;
        public VkCommandBuffer* pCommandBuffers;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
        public static VkSubmitInfo New()
        {
            VkSubmitInfo ret = new VkSubmitInfo();
            ret.sType = VkStructureType.SubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPropertiesKHR
    {
        public VkDisplayKHR display;
        public byte* displayName;
        public VkExtent2D physicalDimensions;
        public VkExtent2D physicalResolution;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkBool32 planeReorderPossible;
        public VkBool32 persistentContent;
    }

    public unsafe partial struct VkDisplayPlanePropertiesKHR
    {
        public VkDisplayKHR currentDisplay;
        public uint currentStackIndex;
    }

    public unsafe partial struct VkDisplayModeParametersKHR
    {
        public VkExtent2D visibleRegion;
        public uint refreshRate;
    }

    public unsafe partial struct VkDisplayModePropertiesKHR
    {
        public VkDisplayModeKHR displayMode;
        public VkDisplayModeParametersKHR parameters;
    }

    public unsafe partial struct VkDisplayModeCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDisplayModeParametersKHR parameters;
        public static VkDisplayModeCreateInfoKHR New()
        {
            VkDisplayModeCreateInfoKHR ret = new VkDisplayModeCreateInfoKHR();
            ret.sType = VkStructureType.DisplayModeCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneCapabilitiesKHR
    {
        public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
        public VkOffset2D minSrcPosition;
        public VkOffset2D maxSrcPosition;
        public VkExtent2D minSrcExtent;
        public VkExtent2D maxSrcExtent;
        public VkOffset2D minDstPosition;
        public VkOffset2D maxDstPosition;
        public VkExtent2D minDstExtent;
        public VkExtent2D maxDstExtent;
    }

    public unsafe partial struct VkDisplaySurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDisplayModeKHR displayMode;
        public uint planeIndex;
        public uint planeStackIndex;
        public VkSurfaceTransformFlagsKHR transform;
        public float globalAlpha;
        public VkDisplayPlaneAlphaFlagsKHR alphaMode;
        public VkExtent2D imageExtent;
        public static VkDisplaySurfaceCreateInfoKHR New()
        {
            VkDisplaySurfaceCreateInfoKHR ret = new VkDisplaySurfaceCreateInfoKHR();
            ret.sType = VkStructureType.DisplaySurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRect2D srcRect;
        public VkRect2D dstRect;
        public VkBool32 persistent;
        public static VkDisplayPresentInfoKHR New()
        {
            VkDisplayPresentInfoKHR ret = new VkDisplayPresentInfoKHR();
            ret.sType = VkStructureType.DisplayPresentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilitiesKHR
    {
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
        public VkImageUsageFlags supportedUsageFlags;
    }

    public unsafe partial struct VkAndroidSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Android.ANativeWindow* window;
        public static VkAndroidSurfaceCreateInfoKHR New()
        {
            VkAndroidSurfaceCreateInfoKHR ret = new VkAndroidSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.AndroidSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkViSurfaceCreateInfoNN
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public void* window;
        public static VkViSurfaceCreateInfoNN New()
        {
            VkViSurfaceCreateInfoNN ret = new VkViSurfaceCreateInfoNN();
            ret.sType = VkStructureType.ViSurfaceCreateInfoNn;
            return ret;
        }
    }

    public unsafe partial struct VkWaylandSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Wayland.wl_display* display;
        public Wayland.wl_surface* surface;
        public static VkWaylandSurfaceCreateInfoKHR New()
        {
            VkWaylandSurfaceCreateInfoKHR ret = new VkWaylandSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.WaylandSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkWin32SurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Win32.HINSTANCE hinstance;
        public Win32.HWND hwnd;
        public static VkWin32SurfaceCreateInfoKHR New()
        {
            VkWin32SurfaceCreateInfoKHR ret = new VkWin32SurfaceCreateInfoKHR();
            ret.sType = VkStructureType.Win32SurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkXlibSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Xlib.Display* dpy;
        public Xlib.Window window;
        public static VkXlibSurfaceCreateInfoKHR New()
        {
            VkXlibSurfaceCreateInfoKHR ret = new VkXlibSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.XlibSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkXcbSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Xcb.xcb_connection_t* connection;
        public Xcb.xcb_window_t window;
        public static VkXcbSurfaceCreateInfoKHR New()
        {
            VkXcbSurfaceCreateInfoKHR ret = new VkXcbSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.XcbSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDirectFBSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public IDirectFB* dfb;
        public IDirectFBSurface* surface;
        public static VkDirectFBSurfaceCreateInfoEXT New()
        {
            VkDirectFBSurfaceCreateInfoEXT ret = new VkDirectFBSurfaceCreateInfoEXT();
            ret.sType = VkStructureType.DirectfbSurfaceCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImagePipeSurfaceCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public zx_handle_t imagePipeHandle;
        public static VkImagePipeSurfaceCreateInfoFUCHSIA New()
        {
            VkImagePipeSurfaceCreateInfoFUCHSIA ret = new VkImagePipeSurfaceCreateInfoFUCHSIA();
            ret.sType = VkStructureType.ImagepipeSurfaceCreateInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkStreamDescriptorSurfaceCreateInfoGGP
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public GgpStreamDescriptor streamDescriptor;
        public static VkStreamDescriptorSurfaceCreateInfoGGP New()
        {
            VkStreamDescriptorSurfaceCreateInfoGGP ret = new VkStreamDescriptorSurfaceCreateInfoGGP();
            ret.sType = VkStructureType.StreamDescriptorSurfaceCreateInfoGgp;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceFormatKHR
    {
        public VkFormat format;
        public VkColorSpaceKHR colorSpace;
    }

    public unsafe partial struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainCreateFlagsKHR flags;
        public VkSurfaceKHR surface;
        public uint minImageCount;
        public VkFormat imageFormat;
        public VkColorSpaceKHR imageColorSpace;
        public VkExtent2D imageExtent;
        public uint imageArrayLayers;
        public VkImageUsageFlags imageUsage;
        public VkSharingMode imageSharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkSurfaceTransformFlagsKHR preTransform;
        public VkCompositeAlphaFlagsKHR compositeAlpha;
        public VkPresentModeKHR presentMode;
        public VkBool32 clipped;
        public VkSwapchainKHR oldSwapchain;
        public static VkSwapchainCreateInfoKHR New()
        {
            VkSwapchainCreateInfoKHR ret = new VkSwapchainCreateInfoKHR();
            ret.sType = VkStructureType.SwapchainCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint swapchainCount;
        public VkSwapchainKHR* pSwapchains;
        public uint* pImageIndices;
        public VkResult* pResults;
        public static VkPresentInfoKHR New()
        {
            VkPresentInfoKHR ret = new VkPresentInfoKHR();
            ret.sType = VkStructureType.PresentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDebugReportCallbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportFlagsEXT flags;
        public IntPtr pfnCallback;
        public void* pUserData;
        public static VkDebugReportCallbackCreateInfoEXT New()
        {
            VkDebugReportCallbackCreateInfoEXT ret = new VkDebugReportCallbackCreateInfoEXT();
            ret.sType = VkStructureType.DebugReportCallbackCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkValidationFlagsEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint disabledValidationCheckCount;
        public VkValidationCheckEXT* pDisabledValidationChecks;
        public static VkValidationFlagsEXT New()
        {
            VkValidationFlagsEXT ret = new VkValidationFlagsEXT();
            ret.sType = VkStructureType.ValidationEXT;
            return ret;
        }
    }

    public unsafe partial struct VkValidationFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint enabledValidationFeatureCount;
        public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
        public uint disabledValidationFeatureCount;
        public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
        public static VkValidationFeaturesEXT New()
        {
            VkValidationFeaturesEXT ret = new VkValidationFeaturesEXT();
            ret.sType = VkStructureType.ValidationFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRasterizationOrderAMD rasterizationOrder;
        public static VkPipelineRasterizationStateRasterizationOrderAMD New()
        {
            VkPipelineRasterizationStateRasterizationOrderAMD ret = new VkPipelineRasterizationStateRasterizationOrderAMD();
            ret.sType = VkStructureType.PipelineRasterizationStateRasterizationOrderAMD;
            return ret;
        }
    }

    public unsafe partial struct VkDebugMarkerObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong @object;
        public byte* pObjectName;
        public static VkDebugMarkerObjectNameInfoEXT New()
        {
            VkDebugMarkerObjectNameInfoEXT ret = new VkDebugMarkerObjectNameInfoEXT();
            ret.sType = VkStructureType.DebugMarkerObjectNameInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugMarkerObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong @object;
        public ulong tagName;
        public UIntPtr tagSize;
        public void* pTag;
        public static VkDebugMarkerObjectTagInfoEXT New()
        {
            VkDebugMarkerObjectTagInfoEXT ret = new VkDebugMarkerObjectTagInfoEXT();
            ret.sType = VkStructureType.DebugMarkerObjectTagInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugMarkerMarkerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pMarkerName;
        public float color_0;
        public float color_1;
        public float color_2;
        public float color_3;
        public static VkDebugMarkerMarkerInfoEXT New()
        {
            VkDebugMarkerMarkerInfoEXT ret = new VkDebugMarkerMarkerInfoEXT();
            ret.sType = VkStructureType.DebugMarkerMarkerInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocation;
        public static VkDedicatedAllocationImageCreateInfoNV New()
        {
            VkDedicatedAllocationImageCreateInfoNV ret = new VkDedicatedAllocationImageCreateInfoNV();
            ret.sType = VkStructureType.DedicatedAllocationImageCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkDedicatedAllocationBufferCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocation;
        public static VkDedicatedAllocationBufferCreateInfoNV New()
        {
            VkDedicatedAllocationBufferCreateInfoNV ret = new VkDedicatedAllocationBufferCreateInfoNV();
            ret.sType = VkStructureType.DedicatedAllocationBufferCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
        public static VkDedicatedAllocationMemoryAllocateInfoNV New()
        {
            VkDedicatedAllocationMemoryAllocateInfoNV ret = new VkDedicatedAllocationMemoryAllocateInfoNV();
            ret.sType = VkStructureType.DedicatedAllocationMemoryAllocateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties imageFormatProperties;
        public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
    }

    public unsafe partial struct VkExternalMemoryImageCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
        public static VkExternalMemoryImageCreateInfoNV New()
        {
            VkExternalMemoryImageCreateInfoNV ret = new VkExternalMemoryImageCreateInfoNV();
            ret.sType = VkStructureType.ExternalMemoryImageCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryAllocateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
        public static VkExportMemoryAllocateInfoNV New()
        {
            VkExportMemoryAllocateInfoNV ret = new VkExportMemoryAllocateInfoNV();
            ret.sType = VkStructureType.ExportMemoryAllocateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleType;
        public Win32.HANDLE handle;
        public static VkImportMemoryWin32HandleInfoNV New()
        {
            VkImportMemoryWin32HandleInfoNV ret = new VkImportMemoryWin32HandleInfoNV();
            ret.sType = VkStructureType.ImportMemoryWin32HandleInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public static VkExportMemoryWin32HandleInfoNV New()
        {
            VkExportMemoryWin32HandleInfoNV ret = new VkExportMemoryWin32HandleInfoNV();
            ret.sType = VkStructureType.ExportMemoryWin32HandleInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeoutMilliseconds;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
        public static VkWin32KeyedMutexAcquireReleaseInfoNV New()
        {
            VkWin32KeyedMutexAcquireReleaseInfoNV ret = new VkWin32KeyedMutexAcquireReleaseInfoNV();
            ret.sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceGeneratedCommands;
        public static VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV New()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV ret = new VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDevicePrivateDataCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint privateDataSlotRequestCount;
        public static VkDevicePrivateDataCreateInfoEXT New()
        {
            VkDevicePrivateDataCreateInfoEXT ret = new VkDevicePrivateDataCreateInfoEXT();
            ret.sType = VkStructureType.DevicePrivateDataCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPrivateDataSlotCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPrivateDataSlotCreateFlagsEXT flags;
        public static VkPrivateDataSlotCreateInfoEXT New()
        {
            VkPrivateDataSlotCreateInfoEXT ret = new VkPrivateDataSlotCreateInfoEXT();
            ret.sType = VkStructureType.PrivateDataSlotCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePrivateDataFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 privateData;
        public static VkPhysicalDevicePrivateDataFeaturesEXT New()
        {
            VkPhysicalDevicePrivateDataFeaturesEXT ret = new VkPhysicalDevicePrivateDataFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePrivateDataFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxGraphicsShaderGroupCount;
        public uint maxIndirectSequenceCount;
        public uint maxIndirectCommandsTokenCount;
        public uint maxIndirectCommandsStreamCount;
        public uint maxIndirectCommandsTokenOffset;
        public uint maxIndirectCommandsStreamStride;
        public uint minSequencesCountBufferOffsetAlignment;
        public uint minSequencesIndexBufferOffsetAlignment;
        public uint minIndirectCommandsBufferOffsetAlignment;
        public static VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV New()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV ret = new VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkGraphicsShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        public static VkGraphicsShaderGroupCreateInfoNV New()
        {
            VkGraphicsShaderGroupCreateInfoNV ret = new VkGraphicsShaderGroupCreateInfoNV();
            ret.sType = VkStructureType.GraphicsShaderGroupCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint groupCount;
        public VkGraphicsShaderGroupCreateInfoNV* pGroups;
        public uint pipelineCount;
        public VkPipeline* pPipelines;
        public static VkGraphicsPipelineShaderGroupsCreateInfoNV New()
        {
            VkGraphicsPipelineShaderGroupsCreateInfoNV ret = new VkGraphicsPipelineShaderGroupsCreateInfoNV();
            ret.sType = VkStructureType.GraphicsPipelineShaderGroupsCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkBindShaderGroupIndirectCommandNV
    {
        public uint groupIndex;
    }

    public unsafe partial struct VkBindIndexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public VkIndexType indexType;
    }

    public unsafe partial struct VkBindVertexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public uint stride;
    }

    public unsafe partial struct VkSetStateFlagsIndirectCommandNV
    {
        public uint data;
    }

    public unsafe partial struct VkIndirectCommandsStreamNV
    {
        public VkBuffer buffer;
        public ulong offset;
    }

    public unsafe partial struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsTokenTypeNV tokenType;
        public uint stream;
        public uint offset;
        public uint vertexBindingUnit;
        public VkBool32 vertexDynamicStride;
        public VkPipelineLayout pushconstantPipelineLayout;
        public VkShaderStageFlags pushconstantShaderStageFlags;
        public uint pushconstantOffset;
        public uint pushconstantSize;
        public VkIndirectStateFlagsNV indirectStateFlags;
        public uint indexTypeCount;
        public VkIndexType* pIndexTypes;
        public uint* pIndexTypeValues;
        public static VkIndirectCommandsLayoutTokenNV New()
        {
            VkIndirectCommandsLayoutTokenNV ret = new VkIndirectCommandsLayoutTokenNV();
            ret.sType = VkStructureType.IndirectCommandsLayoutTokenNV;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsLayoutUsageFlagsNV flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint tokenCount;
        public VkIndirectCommandsLayoutTokenNV* pTokens;
        public uint streamCount;
        public uint* pStreamStrides;
        public static VkIndirectCommandsLayoutCreateInfoNV New()
        {
            VkIndirectCommandsLayoutCreateInfoNV ret = new VkIndirectCommandsLayoutCreateInfoNV();
            ret.sType = VkStructureType.IndirectCommandsLayoutCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint streamCount;
        public VkIndirectCommandsStreamNV* pStreams;
        public uint sequencesCount;
        public VkBuffer preprocessBuffer;
        public ulong preprocessOffset;
        public ulong preprocessSize;
        public VkBuffer sequencesCountBuffer;
        public ulong sequencesCountOffset;
        public VkBuffer sequencesIndexBuffer;
        public ulong sequencesIndexOffset;
        public static VkGeneratedCommandsInfoNV New()
        {
            VkGeneratedCommandsInfoNV ret = new VkGeneratedCommandsInfoNV();
            ret.sType = VkStructureType.GeneratedCommandsInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsMemoryRequirementsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint maxSequencesCount;
        public static VkGeneratedCommandsMemoryRequirementsInfoNV New()
        {
            VkGeneratedCommandsMemoryRequirementsInfoNV ret = new VkGeneratedCommandsMemoryRequirementsInfoNV();
            ret.sType = VkStructureType.GeneratedCommandsMemoryRequirementsInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFeatures2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceFeatures features;
        public static VkPhysicalDeviceFeatures2 New()
        {
            VkPhysicalDeviceFeatures2 ret = new VkPhysicalDeviceFeatures2();
            ret.sType = VkStructureType.PhysicalDeviceFeatures2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFeatures2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceProperties properties;
        public static VkPhysicalDeviceProperties2 New()
        {
            VkPhysicalDeviceProperties2 ret = new VkPhysicalDeviceProperties2();
            ret.sType = VkStructureType.PhysicalDeviceProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProperties2KHR
    {
    }

    public unsafe partial struct VkFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormatProperties formatProperties;
        public static VkFormatProperties2 New()
        {
            VkFormatProperties2 ret = new VkFormatProperties2();
            ret.sType = VkStructureType.FormatProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkFormatProperties2KHR
    {
    }

    public unsafe partial struct VkImageFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageFormatProperties imageFormatProperties;
        public static VkImageFormatProperties2 New()
        {
            VkImageFormatProperties2 ret = new VkImageFormatProperties2();
            ret.sType = VkStructureType.ImageFormatProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkImageFormatProperties2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceImageFormatInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkImageTiling tiling;
        public VkImageUsageFlags usage;
        public VkImageCreateFlags flags;
        public static VkPhysicalDeviceImageFormatInfo2 New()
        {
            VkPhysicalDeviceImageFormatInfo2 ret = new VkPhysicalDeviceImageFormatInfo2();
            ret.sType = VkStructureType.PhysicalDeviceImageFormatInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageFormatInfo2KHR
    {
    }

    public unsafe partial struct VkQueueFamilyProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueFamilyProperties queueFamilyProperties;
        public static VkQueueFamilyProperties2 New()
        {
            VkQueueFamilyProperties2 ret = new VkQueueFamilyProperties2();
            ret.sType = VkStructureType.QueueFamilyProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyProperties2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceMemoryProperties memoryProperties;
        public static VkPhysicalDeviceMemoryProperties2 New()
        {
            VkPhysicalDeviceMemoryProperties2 ret = new VkPhysicalDeviceMemoryProperties2();
            ret.sType = VkStructureType.PhysicalDeviceMemoryProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryProperties2KHR
    {
    }

    public unsafe partial struct VkSparseImageFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSparseImageFormatProperties properties;
        public static VkSparseImageFormatProperties2 New()
        {
            VkSparseImageFormatProperties2 ret = new VkSparseImageFormatProperties2();
            ret.sType = VkStructureType.SparseImageFormatProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkSparseImageFormatProperties2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkSampleCountFlags samples;
        public VkImageUsageFlags usage;
        public VkImageTiling tiling;
        public static VkPhysicalDeviceSparseImageFormatInfo2 New()
        {
            VkPhysicalDeviceSparseImageFormatInfo2 ret = new VkPhysicalDeviceSparseImageFormatInfo2();
            ret.sType = VkStructureType.PhysicalDeviceSparseImageFormatInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2KHR
    {
    }

    public unsafe partial struct VkPhysicalDevicePushDescriptorPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPushDescriptors;
        public static VkPhysicalDevicePushDescriptorPropertiesKHR New()
        {
            VkPhysicalDevicePushDescriptorPropertiesKHR ret = new VkPhysicalDevicePushDescriptorPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDevicePushDescriptorPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkConformanceVersion
    {
        public byte major;
        public byte minor;
        public byte subminor;
        public byte patch;
    }

    public unsafe partial struct VkConformanceVersionKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDriverId driverID;
        public fixed byte driverName[(int)VulkanNative.MaxDriverNameSize];
        public fixed byte driverInfo[(int)VulkanNative.MaxDriverInfoSize];
        public VkConformanceVersion conformanceVersion;
        public static VkPhysicalDeviceDriverProperties New()
        {
            VkPhysicalDeviceDriverProperties ret = new VkPhysicalDeviceDriverProperties();
            ret.sType = VkStructureType.PhysicalDeviceDriverProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDriverPropertiesKHR
    {
    }

    public unsafe partial struct VkPresentRegionsKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentRegionKHR* pRegions;
        public static VkPresentRegionsKHR New()
        {
            VkPresentRegionsKHR ret = new VkPresentRegionsKHR();
            ret.sType = VkStructureType.PresentRegionsKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPresentRegionKHR
    {
        public uint rectangleCount;
        public VkRectLayerKHR* pRectangles;
    }

    public unsafe partial struct VkRectLayerKHR
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
        public uint layer;
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointersFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 variablePointersStorageBuffer;
        public VkBool32 variablePointers;
        public static VkPhysicalDeviceVariablePointersFeatures New()
        {
            VkPhysicalDeviceVariablePointersFeatures ret = new VkPhysicalDeviceVariablePointersFeatures();
            ret.sType = VkStructureType.PhysicalDeviceVariablePointersFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointersFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointerFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointerFeatures
    {
    }

    public unsafe partial struct VkExternalMemoryProperties
    {
        public VkExternalMemoryFeatureFlags externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
    }

    public unsafe partial struct VkExternalMemoryPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalImageFormatInfo New()
        {
            VkPhysicalDeviceExternalImageFormatInfo ret = new VkPhysicalDeviceExternalImageFormatInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalImageFormatInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfoKHR
    {
    }

    public unsafe partial struct VkExternalImageFormatProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        public static VkExternalImageFormatProperties New()
        {
            VkExternalImageFormatProperties ret = new VkExternalImageFormatProperties();
            ret.sType = VkStructureType.ExternalImageFormatProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalImageFormatPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateFlags flags;
        public VkBufferUsageFlags usage;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalBufferInfo New()
        {
            VkPhysicalDeviceExternalBufferInfo ret = new VkPhysicalDeviceExternalBufferInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalBufferInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalBufferInfoKHR
    {
    }

    public unsafe partial struct VkExternalBufferProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        public static VkExternalBufferProperties New()
        {
            VkExternalBufferProperties ret = new VkExternalBufferProperties();
            ret.sType = VkStructureType.ExternalBufferProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalBufferPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceIDProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[(int)VulkanNative.UuidSize];
        public fixed byte driverUUID[(int)VulkanNative.UuidSize];
        public fixed byte deviceLUID[(int)VulkanNative.LuidSize];
        public uint deviceNodeMask;
        public VkBool32 deviceLUIDValid;
        public static VkPhysicalDeviceIDProperties New()
        {
            VkPhysicalDeviceIDProperties ret = new VkPhysicalDeviceIDProperties();
            ret.sType = VkStructureType.PhysicalDeviceIdProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceIDPropertiesKHR
    {
    }

    public unsafe partial struct VkExternalMemoryImageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        public static VkExternalMemoryImageCreateInfo New()
        {
            VkExternalMemoryImageCreateInfo ret = new VkExternalMemoryImageCreateInfo();
            ret.sType = VkStructureType.ExternalMemoryImageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExternalMemoryImageCreateInfoKHR
    {
    }

    public unsafe partial struct VkExternalMemoryBufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        public static VkExternalMemoryBufferCreateInfo New()
        {
            VkExternalMemoryBufferCreateInfo ret = new VkExternalMemoryBufferCreateInfo();
            ret.sType = VkStructureType.ExternalMemoryBufferCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExternalMemoryBufferCreateInfoKHR
    {
    }

    public unsafe partial struct VkExportMemoryAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        public static VkExportMemoryAllocateInfo New()
        {
            VkExportMemoryAllocateInfo ret = new VkExportMemoryAllocateInfo();
            ret.sType = VkStructureType.ExportMemoryAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryAllocateInfoKHR
    {
    }

    public unsafe partial struct VkImportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public Win32.HANDLE handle;
        public IntPtr name;
        public static VkImportMemoryWin32HandleInfoKHR New()
        {
            VkImportMemoryWin32HandleInfoKHR ret = new VkImportMemoryWin32HandleInfoKHR();
            ret.sType = VkStructureType.ImportMemoryWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public IntPtr name;
        public static VkExportMemoryWin32HandleInfoKHR New()
        {
            VkExportMemoryWin32HandleInfoKHR ret = new VkExportMemoryWin32HandleInfoKHR();
            ret.sType = VkStructureType.ExportMemoryWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryWin32HandlePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryWin32HandlePropertiesKHR New()
        {
            VkMemoryWin32HandlePropertiesKHR ret = new VkMemoryWin32HandlePropertiesKHR();
            ret.sType = VkStructureType.MemoryWin32HandlePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetWin32HandleInfoKHR New()
        {
            VkMemoryGetWin32HandleInfoKHR ret = new VkMemoryGetWin32HandleInfoKHR();
            ret.sType = VkStructureType.MemoryGetWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public int fd;
        public static VkImportMemoryFdInfoKHR New()
        {
            VkImportMemoryFdInfoKHR ret = new VkImportMemoryFdInfoKHR();
            ret.sType = VkStructureType.ImportMemoryFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryFdPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryFdPropertiesKHR New()
        {
            VkMemoryFdPropertiesKHR ret = new VkMemoryFdPropertiesKHR();
            ret.sType = VkStructureType.MemoryFdPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetFdInfoKHR New()
        {
            VkMemoryGetFdInfoKHR ret = new VkMemoryGetFdInfoKHR();
            ret.sType = VkStructureType.MemoryGetFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeouts;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
        public static VkWin32KeyedMutexAcquireReleaseInfoKHR New()
        {
            VkWin32KeyedMutexAcquireReleaseInfoKHR ret = new VkWin32KeyedMutexAcquireReleaseInfoKHR();
            ret.sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalSemaphoreInfo New()
        {
            VkPhysicalDeviceExternalSemaphoreInfo ret = new VkPhysicalDeviceExternalSemaphoreInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalSemaphoreInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfoKHR
    {
    }

    public unsafe partial struct VkExternalSemaphoreProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
        public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
        public static VkExternalSemaphoreProperties New()
        {
            VkExternalSemaphoreProperties ret = new VkExternalSemaphoreProperties();
            ret.sType = VkStructureType.ExternalSemaphoreProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalSemaphorePropertiesKHR
    {
    }

    public unsafe partial struct VkExportSemaphoreCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlags handleTypes;
        public static VkExportSemaphoreCreateInfo New()
        {
            VkExportSemaphoreCreateInfo ret = new VkExportSemaphoreCreateInfo();
            ret.sType = VkStructureType.ExportSemaphoreCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExportSemaphoreCreateInfoKHR
    {
    }

    public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlags flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public Win32.HANDLE handle;
        public IntPtr name;
        public static VkImportSemaphoreWin32HandleInfoKHR New()
        {
            VkImportSemaphoreWin32HandleInfoKHR ret = new VkImportSemaphoreWin32HandleInfoKHR();
            ret.sType = VkStructureType.ImportSemaphoreWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public IntPtr name;
        public static VkExportSemaphoreWin32HandleInfoKHR New()
        {
            VkExportSemaphoreWin32HandleInfoKHR ret = new VkExportSemaphoreWin32HandleInfoKHR();
            ret.sType = VkStructureType.ExportSemaphoreWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValuesCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValuesCount;
        public ulong* pSignalSemaphoreValues;
        public static VkD3D12FenceSubmitInfoKHR New()
        {
            VkD3D12FenceSubmitInfoKHR ret = new VkD3D12FenceSubmitInfoKHR();
            ret.sType = VkStructureType.D3d12FenceSubmitInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkSemaphoreGetWin32HandleInfoKHR New()
        {
            VkSemaphoreGetWin32HandleInfoKHR ret = new VkSemaphoreGetWin32HandleInfoKHR();
            ret.sType = VkStructureType.SemaphoreGetWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportSemaphoreFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlags flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public int fd;
        public static VkImportSemaphoreFdInfoKHR New()
        {
            VkImportSemaphoreFdInfoKHR ret = new VkImportSemaphoreFdInfoKHR();
            ret.sType = VkStructureType.ImportSemaphoreFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkSemaphoreGetFdInfoKHR New()
        {
            VkSemaphoreGetFdInfoKHR ret = new VkSemaphoreGetFdInfoKHR();
            ret.sType = VkStructureType.SemaphoreGetFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalFenceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalFenceInfo New()
        {
            VkPhysicalDeviceExternalFenceInfo ret = new VkPhysicalDeviceExternalFenceInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalFenceInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalFenceInfoKHR
    {
    }

    public unsafe partial struct VkExternalFenceProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
        public VkExternalFenceFeatureFlags externalFenceFeatures;
        public static VkExternalFenceProperties New()
        {
            VkExternalFenceProperties ret = new VkExternalFenceProperties();
            ret.sType = VkStructureType.ExternalFenceProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalFencePropertiesKHR
    {
    }

    public unsafe partial struct VkExportFenceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlags handleTypes;
        public static VkExportFenceCreateInfo New()
        {
            VkExportFenceCreateInfo ret = new VkExportFenceCreateInfo();
            ret.sType = VkStructureType.ExportFenceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExportFenceCreateInfoKHR
    {
    }

    public unsafe partial struct VkImportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlags flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public Win32.HANDLE handle;
        public IntPtr name;
        public static VkImportFenceWin32HandleInfoKHR New()
        {
            VkImportFenceWin32HandleInfoKHR ret = new VkImportFenceWin32HandleInfoKHR();
            ret.sType = VkStructureType.ImportFenceWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkExportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public IntPtr name;
        public static VkExportFenceWin32HandleInfoKHR New()
        {
            VkExportFenceWin32HandleInfoKHR ret = new VkExportFenceWin32HandleInfoKHR();
            ret.sType = VkStructureType.ExportFenceWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkFenceGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlags handleType;
        public static VkFenceGetWin32HandleInfoKHR New()
        {
            VkFenceGetWin32HandleInfoKHR ret = new VkFenceGetWin32HandleInfoKHR();
            ret.sType = VkStructureType.FenceGetWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportFenceFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlags flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public int fd;
        public static VkImportFenceFdInfoKHR New()
        {
            VkImportFenceFdInfoKHR ret = new VkImportFenceFdInfoKHR();
            ret.sType = VkStructureType.ImportFenceFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkFenceGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlags handleType;
        public static VkFenceGetFdInfoKHR New()
        {
            VkFenceGetFdInfoKHR ret = new VkFenceGetFdInfoKHR();
            ret.sType = VkStructureType.FenceGetFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multiview;
        public VkBool32 multiviewGeometryShader;
        public VkBool32 multiviewTessellationShader;
        public static VkPhysicalDeviceMultiviewFeatures New()
        {
            VkPhysicalDeviceMultiviewFeatures ret = new VkPhysicalDeviceMultiviewFeatures();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public static VkPhysicalDeviceMultiviewProperties New()
        {
            VkPhysicalDeviceMultiviewProperties ret = new VkPhysicalDeviceMultiviewProperties();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewPropertiesKHR
    {
    }

    public unsafe partial struct VkRenderPassMultiviewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint subpassCount;
        public uint* pViewMasks;
        public uint dependencyCount;
        public int* pViewOffsets;
        public uint correlationMaskCount;
        public uint* pCorrelationMasks;
        public static VkRenderPassMultiviewCreateInfo New()
        {
            VkRenderPassMultiviewCreateInfo ret = new VkRenderPassMultiviewCreateInfo();
            ret.sType = VkStructureType.RenderPassMultiviewCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassMultiviewCreateInfoKHR
    {
    }

    public unsafe partial struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
        public VkImageUsageFlags supportedUsageFlags;
        public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
        public static VkSurfaceCapabilities2EXT New()
        {
            VkSurfaceCapabilities2EXT ret = new VkSurfaceCapabilities2EXT();
            ret.sType = VkStructureType.SurfaceCapabilities2EXT;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPowerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPowerStateEXT powerState;
        public static VkDisplayPowerInfoEXT New()
        {
            VkDisplayPowerInfoEXT ret = new VkDisplayPowerInfoEXT();
            ret.sType = VkStructureType.DisplayPowerInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceEventTypeEXT deviceEvent;
        public static VkDeviceEventInfoEXT New()
        {
            VkDeviceEventInfoEXT ret = new VkDeviceEventInfoEXT();
            ret.sType = VkStructureType.DeviceEventInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayEventTypeEXT displayEvent;
        public static VkDisplayEventInfoEXT New()
        {
            VkDisplayEventInfoEXT ret = new VkDisplayEventInfoEXT();
            ret.sType = VkStructureType.DisplayEventInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainCounterCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceCounterFlagsEXT surfaceCounters;
        public static VkSwapchainCounterCreateInfoEXT New()
        {
            VkSwapchainCounterCreateInfoEXT ret = new VkSwapchainCounterCreateInfoEXT();
            ret.sType = VkStructureType.SwapchainCounterCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint physicalDeviceCount;
        public VkPhysicalDevice physicalDevices_0;
        public VkPhysicalDevice physicalDevices_1;
        public VkPhysicalDevice physicalDevices_2;
        public VkPhysicalDevice physicalDevices_3;
        public VkPhysicalDevice physicalDevices_4;
        public VkPhysicalDevice physicalDevices_5;
        public VkPhysicalDevice physicalDevices_6;
        public VkPhysicalDevice physicalDevices_7;
        public VkPhysicalDevice physicalDevices_8;
        public VkPhysicalDevice physicalDevices_9;
        public VkPhysicalDevice physicalDevices_10;
        public VkPhysicalDevice physicalDevices_11;
        public VkPhysicalDevice physicalDevices_12;
        public VkPhysicalDevice physicalDevices_13;
        public VkPhysicalDevice physicalDevices_14;
        public VkPhysicalDevice physicalDevices_15;
        public VkPhysicalDevice physicalDevices_16;
        public VkPhysicalDevice physicalDevices_17;
        public VkPhysicalDevice physicalDevices_18;
        public VkPhysicalDevice physicalDevices_19;
        public VkPhysicalDevice physicalDevices_20;
        public VkPhysicalDevice physicalDevices_21;
        public VkPhysicalDevice physicalDevices_22;
        public VkPhysicalDevice physicalDevices_23;
        public VkPhysicalDevice physicalDevices_24;
        public VkPhysicalDevice physicalDevices_25;
        public VkPhysicalDevice physicalDevices_26;
        public VkPhysicalDevice physicalDevices_27;
        public VkPhysicalDevice physicalDevices_28;
        public VkPhysicalDevice physicalDevices_29;
        public VkPhysicalDevice physicalDevices_30;
        public VkPhysicalDevice physicalDevices_31;
        public VkBool32 subsetAllocation;
        public static VkPhysicalDeviceGroupProperties New()
        {
            VkPhysicalDeviceGroupProperties ret = new VkPhysicalDeviceGroupProperties();
            ret.sType = VkStructureType.PhysicalDeviceGroupProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceGroupPropertiesKHR
    {
    }

    public unsafe partial struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryAllocateFlags flags;
        public uint deviceMask;
        public static VkMemoryAllocateFlagsInfo New()
        {
            VkMemoryAllocateFlagsInfo ret = new VkMemoryAllocateFlagsInfo();
            ret.sType = VkStructureType.MemoryAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryAllocateFlagsInfoKHR
    {
    }

    public unsafe partial struct VkBindBufferMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public static VkBindBufferMemoryInfo New()
        {
            VkBindBufferMemoryInfo ret = new VkBindBufferMemoryInfo();
            ret.sType = VkStructureType.BindBufferMemoryInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindBufferMemoryInfoKHR
    {
    }

    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public static VkBindBufferMemoryDeviceGroupInfo New()
        {
            VkBindBufferMemoryDeviceGroupInfo ret = new VkBindBufferMemoryDeviceGroupInfo();
            ret.sType = VkStructureType.BindBufferMemoryDeviceGroupInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfoKHR
    {
    }

    public unsafe partial struct VkBindImageMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public static VkBindImageMemoryInfo New()
        {
            VkBindImageMemoryInfo ret = new VkBindImageMemoryInfo();
            ret.sType = VkStructureType.BindImageMemoryInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindImageMemoryInfoKHR
    {
    }

    public unsafe partial struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public uint splitInstanceBindRegionCount;
        public VkRect2D* pSplitInstanceBindRegions;
        public static VkBindImageMemoryDeviceGroupInfo New()
        {
            VkBindImageMemoryDeviceGroupInfo ret = new VkBindImageMemoryDeviceGroupInfo();
            ret.sType = VkStructureType.BindImageMemoryDeviceGroupInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindImageMemoryDeviceGroupInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
        public uint deviceRenderAreaCount;
        public VkRect2D* pDeviceRenderAreas;
        public static VkDeviceGroupRenderPassBeginInfo New()
        {
            VkDeviceGroupRenderPassBeginInfo ret = new VkDeviceGroupRenderPassBeginInfo();
            ret.sType = VkStructureType.DeviceGroupRenderPassBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupRenderPassBeginInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
        public static VkDeviceGroupCommandBufferBeginInfo New()
        {
            VkDeviceGroupCommandBufferBeginInfo ret = new VkDeviceGroupCommandBufferBeginInfo();
            ret.sType = VkStructureType.DeviceGroupCommandBufferBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public uint* pWaitSemaphoreDeviceIndices;
        public uint commandBufferCount;
        public uint* pCommandBufferDeviceMasks;
        public uint signalSemaphoreCount;
        public uint* pSignalSemaphoreDeviceIndices;
        public static VkDeviceGroupSubmitInfo New()
        {
            VkDeviceGroupSubmitInfo ret = new VkDeviceGroupSubmitInfo();
            ret.sType = VkStructureType.DeviceGroupSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupSubmitInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint resourceDeviceIndex;
        public uint memoryDeviceIndex;
        public static VkDeviceGroupBindSparseInfo New()
        {
            VkDeviceGroupBindSparseInfo ret = new VkDeviceGroupBindSparseInfo();
            ret.sType = VkStructureType.DeviceGroupBindSparseInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupBindSparseInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed uint presentMask[(int)VulkanNative.MaxDeviceGroupSize];
        public VkDeviceGroupPresentModeFlagsKHR modes;
        public static VkDeviceGroupPresentCapabilitiesKHR New()
        {
            VkDeviceGroupPresentCapabilitiesKHR ret = new VkDeviceGroupPresentCapabilitiesKHR();
            ret.sType = VkStructureType.DeviceGroupPresentCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImageSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public static VkImageSwapchainCreateInfoKHR New()
        {
            VkImageSwapchainCreateInfoKHR ret = new VkImageSwapchainCreateInfoKHR();
            ret.sType = VkStructureType.ImageSwapchainCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkBindImageMemorySwapchainInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndex;
        public static VkBindImageMemorySwapchainInfoKHR New()
        {
            VkBindImageMemorySwapchainInfoKHR ret = new VkBindImageMemorySwapchainInfoKHR();
            ret.sType = VkStructureType.BindImageMemorySwapchainInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public ulong timeout;
        public VkSemaphore semaphore;
        public VkFence fence;
        public uint deviceMask;
        public static VkAcquireNextImageInfoKHR New()
        {
            VkAcquireNextImageInfoKHR ret = new VkAcquireNextImageInfoKHR();
            ret.sType = VkStructureType.AcquireNextImageInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public uint* pDeviceMasks;
        public VkDeviceGroupPresentModeFlagsKHR mode;
        public static VkDeviceGroupPresentInfoKHR New()
        {
            VkDeviceGroupPresentInfoKHR ret = new VkDeviceGroupPresentInfoKHR();
            ret.sType = VkStructureType.DeviceGroupPresentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupDeviceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint physicalDeviceCount;
        public VkPhysicalDevice* pPhysicalDevices;
        public static VkDeviceGroupDeviceCreateInfo New()
        {
            VkDeviceGroupDeviceCreateInfo ret = new VkDeviceGroupDeviceCreateInfo();
            ret.sType = VkStructureType.DeviceGroupDeviceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupDeviceCreateInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceGroupPresentModeFlagsKHR modes;
        public static VkDeviceGroupSwapchainCreateInfoKHR New()
        {
            VkDeviceGroupSwapchainCreateInfoKHR ret = new VkDeviceGroupSwapchainCreateInfoKHR();
            ret.sType = VkStructureType.DeviceGroupSwapchainCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorUpdateTemplateEntry
    {
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public UIntPtr offset;
        public UIntPtr stride;
    }

    public unsafe partial struct VkDescriptorUpdateTemplateEntryKHR
    {
    }

    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint descriptorUpdateEntryCount;
        public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
        public VkDescriptorUpdateTemplateType templateType;
        public VkDescriptorSetLayout descriptorSetLayout;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipelineLayout pipelineLayout;
        public uint set;
        public static VkDescriptorUpdateTemplateCreateInfo New()
        {
            VkDescriptorUpdateTemplateCreateInfo ret = new VkDescriptorUpdateTemplateCreateInfo();
            ret.sType = VkStructureType.DescriptorUpdateTemplateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfoKHR
    {
    }

    public unsafe partial struct VkXYColorEXT
    {
        public float x;
        public float y;
    }

    public unsafe partial struct VkHdrMetadataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkXYColorEXT displayPrimaryRed;
        public VkXYColorEXT displayPrimaryGreen;
        public VkXYColorEXT displayPrimaryBlue;
        public VkXYColorEXT whitePoint;
        public float maxLuminance;
        public float minLuminance;
        public float maxContentLightLevel;
        public float maxFrameAverageLightLevel;
        public static VkHdrMetadataEXT New()
        {
            VkHdrMetadataEXT ret = new VkHdrMetadataEXT();
            ret.sType = VkStructureType.HdrMetadataEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 localDimmingSupport;
        public static VkDisplayNativeHdrSurfaceCapabilitiesAMD New()
        {
            VkDisplayNativeHdrSurfaceCapabilitiesAMD ret = new VkDisplayNativeHdrSurfaceCapabilitiesAMD();
            ret.sType = VkStructureType.DisplayNativeHdrSurfaceCapabilitiesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 localDimmingEnable;
        public static VkSwapchainDisplayNativeHdrCreateInfoAMD New()
        {
            VkSwapchainDisplayNativeHdrCreateInfoAMD ret = new VkSwapchainDisplayNativeHdrCreateInfoAMD();
            ret.sType = VkStructureType.SwapchainDisplayNativeHdrCreateInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkRefreshCycleDurationGOOGLE
    {
        public ulong refreshDuration;
    }

    public unsafe partial struct VkPastPresentationTimingGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
        public ulong actualPresentTime;
        public ulong earliestPresentTime;
        public ulong presentMargin;
    }

    public unsafe partial struct VkPresentTimesInfoGOOGLE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentTimeGOOGLE* pTimes;
        public static VkPresentTimesInfoGOOGLE New()
        {
            VkPresentTimesInfoGOOGLE ret = new VkPresentTimesInfoGOOGLE();
            ret.sType = VkStructureType.PresentTimesInfoGoogle;
            return ret;
        }
    }

    public unsafe partial struct VkPresentTimeGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
    }

    public unsafe partial struct VkIOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public void* pView;
        public static VkIOSSurfaceCreateInfoMVK New()
        {
            VkIOSSurfaceCreateInfoMVK ret = new VkIOSSurfaceCreateInfoMVK();
            ret.sType = VkStructureType.IosSurfaceCreateInfoMvk;
            return ret;
        }
    }

    public unsafe partial struct VkMacOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public void* pView;
        public static VkMacOSSurfaceCreateInfoMVK New()
        {
            VkMacOSSurfaceCreateInfoMVK ret = new VkMacOSSurfaceCreateInfoMVK();
            ret.sType = VkStructureType.MacosSurfaceCreateInfoMvk;
            return ret;
        }
    }

    public unsafe partial struct VkMetalSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public CAMetalLayer* pLayer;
        public static VkMetalSurfaceCreateInfoEXT New()
        {
            VkMetalSurfaceCreateInfoEXT ret = new VkMetalSurfaceCreateInfoEXT();
            ret.sType = VkStructureType.MetalSurfaceCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkViewportWScalingNV
    {
        public float xcoeff;
        public float ycoeff;
    }

    public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 viewportWScalingEnable;
        public uint viewportCount;
        public VkViewportWScalingNV* pViewportWScalings;
        public static VkPipelineViewportWScalingStateCreateInfoNV New()
        {
            VkPipelineViewportWScalingStateCreateInfoNV ret = new VkPipelineViewportWScalingStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportWScalingStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkViewportSwizzleNV
    {
        public VkViewportCoordinateSwizzleNV x;
        public VkViewportCoordinateSwizzleNV y;
        public VkViewportCoordinateSwizzleNV z;
        public VkViewportCoordinateSwizzleNV w;
    }

    public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint viewportCount;
        public VkViewportSwizzleNV* pViewportSwizzles;
        public static VkPipelineViewportSwizzleStateCreateInfoNV New()
        {
            VkPipelineViewportSwizzleStateCreateInfoNV ret = new VkPipelineViewportSwizzleStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportSwizzleStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDiscardRectangles;
        public static VkPhysicalDeviceDiscardRectanglePropertiesEXT New()
        {
            VkPhysicalDeviceDiscardRectanglePropertiesEXT ret = new VkPhysicalDeviceDiscardRectanglePropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDiscardRectanglePropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDiscardRectangleModeEXT discardRectangleMode;
        public uint discardRectangleCount;
        public VkRect2D* pDiscardRectangles;
        public static VkPipelineDiscardRectangleStateCreateInfoEXT New()
        {
            VkPipelineDiscardRectangleStateCreateInfoEXT ret = new VkPipelineDiscardRectangleStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineDiscardRectangleStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 perViewPositionAllComponents;
        public static VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX New()
        {
            VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX ret = new VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX;
            return ret;
        }
    }

    public unsafe partial struct VkInputAttachmentAspectReference
    {
        public uint subpass;
        public uint inputAttachmentIndex;
        public VkImageAspectFlags aspectMask;
    }

    public unsafe partial struct VkInputAttachmentAspectReferenceKHR
    {
    }

    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint aspectReferenceCount;
        public VkInputAttachmentAspectReference* pAspectReferences;
        public static VkRenderPassInputAttachmentAspectCreateInfo New()
        {
            VkRenderPassInputAttachmentAspectCreateInfo ret = new VkRenderPassInputAttachmentAspectCreateInfo();
            ret.sType = VkStructureType.RenderPassInputAttachmentAspectCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceKHR surface;
        public static VkPhysicalDeviceSurfaceInfo2KHR New()
        {
            VkPhysicalDeviceSurfaceInfo2KHR ret = new VkPhysicalDeviceSurfaceInfo2KHR();
            ret.sType = VkStructureType.PhysicalDeviceSurfaceInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilities2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceCapabilitiesKHR surfaceCapabilities;
        public static VkSurfaceCapabilities2KHR New()
        {
            VkSurfaceCapabilities2KHR ret = new VkSurfaceCapabilities2KHR();
            ret.sType = VkStructureType.SurfaceCapabilities2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceFormat2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceFormatKHR surfaceFormat;
        public static VkSurfaceFormat2KHR New()
        {
            VkSurfaceFormat2KHR ret = new VkSurfaceFormat2KHR();
            ret.sType = VkStructureType.SurfaceFormat2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPropertiesKHR displayProperties;
        public static VkDisplayProperties2KHR New()
        {
            VkDisplayProperties2KHR ret = new VkDisplayProperties2KHR();
            ret.sType = VkStructureType.DisplayProperties2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPlanePropertiesKHR displayPlaneProperties;
        public static VkDisplayPlaneProperties2KHR New()
        {
            VkDisplayPlaneProperties2KHR ret = new VkDisplayPlaneProperties2KHR();
            ret.sType = VkStructureType.DisplayPlaneProperties2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayModeProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModePropertiesKHR displayModeProperties;
        public static VkDisplayModeProperties2KHR New()
        {
            VkDisplayModeProperties2KHR ret = new VkDisplayModeProperties2KHR();
            ret.sType = VkStructureType.DisplayModeProperties2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModeKHR mode;
        public uint planeIndex;
        public static VkDisplayPlaneInfo2KHR New()
        {
            VkDisplayPlaneInfo2KHR ret = new VkDisplayPlaneInfo2KHR();
            ret.sType = VkStructureType.DisplayPlaneInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneCapabilities2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPlaneCapabilitiesKHR capabilities;
        public static VkDisplayPlaneCapabilities2KHR New()
        {
            VkDisplayPlaneCapabilities2KHR ret = new VkDisplayPlaneCapabilities2KHR();
            ret.sType = VkStructureType.DisplayPlaneCapabilities2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSharedPresentSurfaceCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags sharedPresentSupportedUsageFlags;
        public static VkSharedPresentSurfaceCapabilitiesKHR New()
        {
            VkSharedPresentSurfaceCapabilitiesKHR ret = new VkSharedPresentSurfaceCapabilitiesKHR();
            ret.sType = VkStructureType.SharedPresentSurfaceCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 storageBuffer16BitAccess;
        public VkBool32 uniformAndStorageBuffer16BitAccess;
        public VkBool32 storagePushConstant16;
        public VkBool32 storageInputOutput16;
        public static VkPhysicalDevice16BitStorageFeatures New()
        {
            VkPhysicalDevice16BitStorageFeatures ret = new VkPhysicalDevice16BitStorageFeatures();
            ret.sType = VkStructureType.PhysicalDevice16bitStorageFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice16BitStorageFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint subgroupSize;
        public VkShaderStageFlags supportedStages;
        public VkSubgroupFeatureFlags supportedOperations;
        public VkBool32 quadOperationsInAllStages;
        public static VkPhysicalDeviceSubgroupProperties New()
        {
            VkPhysicalDeviceSubgroupProperties ret = new VkPhysicalDeviceSubgroupProperties();
            ret.sType = VkStructureType.PhysicalDeviceSubgroupProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupExtendedTypes;
        public static VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures New()
        {
            VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures ret = new VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderSubgroupExtendedTypesFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
    {
    }

    public unsafe partial struct VkBufferMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public static VkBufferMemoryRequirementsInfo2 New()
        {
            VkBufferMemoryRequirementsInfo2 ret = new VkBufferMemoryRequirementsInfo2();
            ret.sType = VkStructureType.BufferMemoryRequirementsInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkBufferMemoryRequirementsInfo2KHR
    {
    }

    public unsafe partial struct VkImageMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public static VkImageMemoryRequirementsInfo2 New()
        {
            VkImageMemoryRequirementsInfo2 ret = new VkImageMemoryRequirementsInfo2();
            ret.sType = VkStructureType.ImageMemoryRequirementsInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkImageMemoryRequirementsInfo2KHR
    {
    }

    public unsafe partial struct VkImageSparseMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public static VkImageSparseMemoryRequirementsInfo2 New()
        {
            VkImageSparseMemoryRequirementsInfo2 ret = new VkImageSparseMemoryRequirementsInfo2();
            ret.sType = VkStructureType.ImageSparseMemoryRequirementsInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkImageSparseMemoryRequirementsInfo2KHR
    {
    }

    public unsafe partial struct VkMemoryRequirements2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryRequirements memoryRequirements;
        public static VkMemoryRequirements2 New()
        {
            VkMemoryRequirements2 ret = new VkMemoryRequirements2();
            ret.sType = VkStructureType.MemoryRequirements2;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryRequirements2KHR
    {
    }

    public unsafe partial struct VkSparseImageMemoryRequirements2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSparseImageMemoryRequirements memoryRequirements;
        public static VkSparseImageMemoryRequirements2 New()
        {
            VkSparseImageMemoryRequirements2 ret = new VkSparseImageMemoryRequirements2();
            ret.sType = VkStructureType.SparseImageMemoryRequirements2;
            return ret;
        }
    }

    public unsafe partial struct VkSparseImageMemoryRequirements2KHR
    {
    }

    public unsafe partial struct VkPhysicalDevicePointClippingProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPointClippingBehavior pointClippingBehavior;
        public static VkPhysicalDevicePointClippingProperties New()
        {
            VkPhysicalDevicePointClippingProperties ret = new VkPhysicalDevicePointClippingProperties();
            ret.sType = VkStructureType.PhysicalDevicePointClippingProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePointClippingPropertiesKHR
    {
    }

    public unsafe partial struct VkMemoryDedicatedRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 prefersDedicatedAllocation;
        public VkBool32 requiresDedicatedAllocation;
        public static VkMemoryDedicatedRequirements New()
        {
            VkMemoryDedicatedRequirements ret = new VkMemoryDedicatedRequirements();
            ret.sType = VkStructureType.MemoryDedicatedRequirements;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryDedicatedRequirementsKHR
    {
    }

    public unsafe partial struct VkMemoryDedicatedAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
        public static VkMemoryDedicatedAllocateInfo New()
        {
            VkMemoryDedicatedAllocateInfo ret = new VkMemoryDedicatedAllocateInfo();
            ret.sType = VkStructureType.MemoryDedicatedAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryDedicatedAllocateInfoKHR
    {
    }

    public unsafe partial struct VkImageViewUsageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags usage;
        public static VkImageViewUsageCreateInfo New()
        {
            VkImageViewUsageCreateInfo ret = new VkImageViewUsageCreateInfo();
            ret.sType = VkStructureType.ImageViewUsageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewUsageCreateInfoKHR
    {
    }

    public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTessellationDomainOrigin domainOrigin;
        public static VkPipelineTessellationDomainOriginStateCreateInfo New()
        {
            VkPipelineTessellationDomainOriginStateCreateInfo ret = new VkPipelineTessellationDomainOriginStateCreateInfo();
            ret.sType = VkStructureType.PipelineTessellationDomainOriginStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
    {
    }

    public unsafe partial struct VkSamplerYcbcrConversionInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerYcbcrConversion conversion;
        public static VkSamplerYcbcrConversionInfo New()
        {
            VkSamplerYcbcrConversionInfo ret = new VkSamplerYcbcrConversionInfo();
            ret.sType = VkStructureType.SamplerYcbcrConversionInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerYcbcrConversionInfoKHR
    {
    }

    public unsafe partial struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkSamplerYcbcrModelConversion ycbcrModel;
        public VkSamplerYcbcrRange ycbcrRange;
        public VkComponentMapping components;
        public VkChromaLocation xChromaOffset;
        public VkChromaLocation yChromaOffset;
        public VkFilter chromaFilter;
        public VkBool32 forceExplicitReconstruction;
        public static VkSamplerYcbcrConversionCreateInfo New()
        {
            VkSamplerYcbcrConversionCreateInfo ret = new VkSamplerYcbcrConversionCreateInfo();
            ret.sType = VkStructureType.SamplerYcbcrConversionCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerYcbcrConversionCreateInfoKHR
    {
    }

    public unsafe partial struct VkBindImagePlaneMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlags planeAspect;
        public static VkBindImagePlaneMemoryInfo New()
        {
            VkBindImagePlaneMemoryInfo ret = new VkBindImagePlaneMemoryInfo();
            ret.sType = VkStructureType.BindImagePlaneMemoryInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindImagePlaneMemoryInfoKHR
    {
    }

    public unsafe partial struct VkImagePlaneMemoryRequirementsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlags planeAspect;
        public static VkImagePlaneMemoryRequirementsInfo New()
        {
            VkImagePlaneMemoryRequirementsInfo ret = new VkImagePlaneMemoryRequirementsInfo();
            ret.sType = VkStructureType.ImagePlaneMemoryRequirementsInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImagePlaneMemoryRequirementsInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 samplerYcbcrConversion;
        public static VkPhysicalDeviceSamplerYcbcrConversionFeatures New()
        {
            VkPhysicalDeviceSamplerYcbcrConversionFeatures ret = new VkPhysicalDeviceSamplerYcbcrConversionFeatures();
            ret.sType = VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
    {
    }

    public unsafe partial struct VkSamplerYcbcrConversionImageFormatProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint combinedImageSamplerDescriptorCount;
        public static VkSamplerYcbcrConversionImageFormatProperties New()
        {
            VkSamplerYcbcrConversionImageFormatProperties ret = new VkSamplerYcbcrConversionImageFormatProperties();
            ret.sType = VkStructureType.SamplerYcbcrConversionImageFormatProperties;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
    {
    }

    public unsafe partial struct VkTextureLODGatherFormatPropertiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supportsTextureGatherLODBiasAMD;
        public static VkTextureLODGatherFormatPropertiesAMD New()
        {
            VkTextureLODGatherFormatPropertiesAMD ret = new VkTextureLODGatherFormatPropertiesAMD();
            ret.sType = VkStructureType.TextureLodGatherFormatPropertiesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkConditionalRenderingBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public ulong offset;
        public VkConditionalRenderingFlagsEXT flags;
        public static VkConditionalRenderingBeginInfoEXT New()
        {
            VkConditionalRenderingBeginInfoEXT ret = new VkConditionalRenderingBeginInfoEXT();
            ret.sType = VkStructureType.ConditionalRenderingBeginInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkProtectedSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 protectedSubmit;
        public static VkProtectedSubmitInfo New()
        {
            VkProtectedSubmitInfo ret = new VkProtectedSubmitInfo();
            ret.sType = VkStructureType.ProtectedSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProtectedMemoryFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 protectedMemory;
        public static VkPhysicalDeviceProtectedMemoryFeatures New()
        {
            VkPhysicalDeviceProtectedMemoryFeatures ret = new VkPhysicalDeviceProtectedMemoryFeatures();
            ret.sType = VkStructureType.PhysicalDeviceProtectedMemoryFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProtectedMemoryProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 protectedNoFault;
        public static VkPhysicalDeviceProtectedMemoryProperties New()
        {
            VkPhysicalDeviceProtectedMemoryProperties ret = new VkPhysicalDeviceProtectedMemoryProperties();
            ret.sType = VkStructureType.PhysicalDeviceProtectedMemoryProperties;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceQueueInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueIndex;
        public static VkDeviceQueueInfo2 New()
        {
            VkDeviceQueueInfo2 ret = new VkDeviceQueueInfo2();
            ret.sType = VkStructureType.DeviceQueueInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 coverageToColorEnable;
        public uint coverageToColorLocation;
        public static VkPipelineCoverageToColorStateCreateInfoNV New()
        {
            VkPipelineCoverageToColorStateCreateInfoNV ret = new VkPipelineCoverageToColorStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineCoverageToColorStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 filterMinmaxSingleComponentFormats;
        public VkBool32 filterMinmaxImageComponentMapping;
        public static VkPhysicalDeviceSamplerFilterMinmaxProperties New()
        {
            VkPhysicalDeviceSamplerFilterMinmaxProperties ret = new VkPhysicalDeviceSamplerFilterMinmaxProperties();
            ret.sType = VkStructureType.PhysicalDeviceSamplerFilterMinmaxProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
    {
    }

    public unsafe partial struct VkSampleLocationEXT
    {
        public float x;
        public float y;
    }

    public unsafe partial struct VkSampleLocationsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleLocationsPerPixel;
        public VkExtent2D sampleLocationGridSize;
        public uint sampleLocationsCount;
        public VkSampleLocationEXT* pSampleLocations;
        public static VkSampleLocationsInfoEXT New()
        {
            VkSampleLocationsInfoEXT ret = new VkSampleLocationsInfoEXT();
            ret.sType = VkStructureType.SampleLocationsInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentSampleLocationsEXT
    {
        public uint attachmentIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    public unsafe partial struct VkSubpassSampleLocationsEXT
    {
        public uint subpassIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentInitialSampleLocationsCount;
        public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        public uint postSubpassSampleLocationsCount;
        public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
        public static VkRenderPassSampleLocationsBeginInfoEXT New()
        {
            VkRenderPassSampleLocationsBeginInfoEXT ret = new VkRenderPassSampleLocationsBeginInfoEXT();
            ret.sType = VkStructureType.RenderPassSampleLocationsBeginInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineSampleLocationsStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 sampleLocationsEnable;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
        public static VkPipelineSampleLocationsStateCreateInfoEXT New()
        {
            VkPipelineSampleLocationsStateCreateInfoEXT ret = new VkPipelineSampleLocationsStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineSampleLocationsStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleLocationSampleCounts;
        public VkExtent2D maxSampleLocationGridSize;
        public float sampleLocationCoordinateRange_0;
        public float sampleLocationCoordinateRange_1;
        public uint sampleLocationSubPixelBits;
        public VkBool32 variableSampleLocations;
        public static VkPhysicalDeviceSampleLocationsPropertiesEXT New()
        {
            VkPhysicalDeviceSampleLocationsPropertiesEXT ret = new VkPhysicalDeviceSampleLocationsPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceSampleLocationsPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMultisamplePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxSampleLocationGridSize;
        public static VkMultisamplePropertiesEXT New()
        {
            VkMultisamplePropertiesEXT ret = new VkMultisamplePropertiesEXT();
            ret.sType = VkStructureType.MultisamplePropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerReductionModeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerReductionMode reductionMode;
        public static VkSamplerReductionModeCreateInfo New()
        {
            VkSamplerReductionModeCreateInfo ret = new VkSamplerReductionModeCreateInfo();
            ret.sType = VkStructureType.SamplerReductionModeCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerReductionModeCreateInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 advancedBlendCoherentOperations;
        public static VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT New()
        {
            VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT ret = new VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint advancedBlendMaxColorAttachments;
        public VkBool32 advancedBlendIndependentBlend;
        public VkBool32 advancedBlendNonPremultipliedSrcColor;
        public VkBool32 advancedBlendNonPremultipliedDstColor;
        public VkBool32 advancedBlendCorrelatedOverlap;
        public VkBool32 advancedBlendAllOperations;
        public static VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT New()
        {
            VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT ret = new VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 srcPremultiplied;
        public VkBool32 dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
        public static VkPipelineColorBlendAdvancedStateCreateInfoEXT New()
        {
            VkPipelineColorBlendAdvancedStateCreateInfoEXT ret = new VkPipelineColorBlendAdvancedStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineColorBlendAdvancedStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 inlineUniformBlock;
        public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
        public static VkPhysicalDeviceInlineUniformBlockFeaturesEXT New()
        {
            VkPhysicalDeviceInlineUniformBlockFeaturesEXT ret = new VkPhysicalDeviceInlineUniformBlockFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceInlineUniformBlockFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        public static VkPhysicalDeviceInlineUniformBlockPropertiesEXT New()
        {
            VkPhysicalDeviceInlineUniformBlockPropertiesEXT ret = new VkPhysicalDeviceInlineUniformBlockPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceInlineUniformBlockPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint dataSize;
        public void* pData;
        public static VkWriteDescriptorSetInlineUniformBlockEXT New()
        {
            VkWriteDescriptorSetInlineUniformBlockEXT ret = new VkWriteDescriptorSetInlineUniformBlockEXT();
            ret.sType = VkStructureType.WriteDescriptorSetInlineUniformBlockEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockBindings;
        public static VkDescriptorPoolInlineUniformBlockCreateInfoEXT New()
        {
            VkDescriptorPoolInlineUniformBlockCreateInfoEXT ret = new VkDescriptorPoolInlineUniformBlockCreateInfoEXT();
            ret.sType = VkStructureType.DescriptorPoolInlineUniformBlockCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkCoverageModulationModeNV coverageModulationMode;
        public VkBool32 coverageModulationTableEnable;
        public uint coverageModulationTableCount;
        public float* pCoverageModulationTable;
        public static VkPipelineCoverageModulationStateCreateInfoNV New()
        {
            VkPipelineCoverageModulationStateCreateInfoNV ret = new VkPipelineCoverageModulationStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineCoverageModulationStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImageFormatListCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
        public static VkImageFormatListCreateInfo New()
        {
            VkImageFormatListCreateInfo ret = new VkImageFormatListCreateInfo();
            ret.sType = VkStructureType.ImageFormatListCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageFormatListCreateInfoKHR
    {
    }

    public unsafe partial struct VkValidationCacheCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public UIntPtr initialDataSize;
        public void* pInitialData;
        public static VkValidationCacheCreateInfoEXT New()
        {
            VkValidationCacheCreateInfoEXT ret = new VkValidationCacheCreateInfoEXT();
            ret.sType = VkStructureType.ValidationCacheCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkShaderModuleValidationCacheCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkValidationCacheEXT validationCache;
        public static VkShaderModuleValidationCacheCreateInfoEXT New()
        {
            VkShaderModuleValidationCacheCreateInfoEXT ret = new VkShaderModuleValidationCacheCreateInfoEXT();
            ret.sType = VkStructureType.ShaderModuleValidationCacheCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        public static VkPhysicalDeviceMaintenance3Properties New()
        {
            VkPhysicalDeviceMaintenance3Properties ret = new VkPhysicalDeviceMaintenance3Properties();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance3Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance3PropertiesKHR
    {
    }

    public unsafe partial struct VkDescriptorSetLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supported;
        public static VkDescriptorSetLayoutSupport New()
        {
            VkDescriptorSetLayoutSupport ret = new VkDescriptorSetLayoutSupport();
            ret.sType = VkStructureType.DescriptorSetLayoutSupport;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutSupportKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderDrawParametersFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderDrawParameters;
        public static VkPhysicalDeviceShaderDrawParametersFeatures New()
        {
            VkPhysicalDeviceShaderDrawParametersFeatures ret = new VkPhysicalDeviceShaderDrawParametersFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderDrawParameterFeatures
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderFloat16;
        public VkBool32 shaderInt8;
        public static VkPhysicalDeviceShaderFloat16Int8Features New()
        {
            VkPhysicalDeviceShaderFloat16Int8Features ret = new VkPhysicalDeviceShaderFloat16Int8Features();
            ret.sType = VkStructureType.PhysicalDeviceShaderFloat16Int8Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceFloat16Int8FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
        public VkBool32 shaderDenormPreserveFloat16;
        public VkBool32 shaderDenormPreserveFloat32;
        public VkBool32 shaderDenormPreserveFloat64;
        public VkBool32 shaderDenormFlushToZeroFloat16;
        public VkBool32 shaderDenormFlushToZeroFloat32;
        public VkBool32 shaderDenormFlushToZeroFloat64;
        public VkBool32 shaderRoundingModeRTEFloat16;
        public VkBool32 shaderRoundingModeRTEFloat32;
        public VkBool32 shaderRoundingModeRTEFloat64;
        public VkBool32 shaderRoundingModeRTZFloat16;
        public VkBool32 shaderRoundingModeRTZFloat32;
        public VkBool32 shaderRoundingModeRTZFloat64;
        public static VkPhysicalDeviceFloatControlsProperties New()
        {
            VkPhysicalDeviceFloatControlsProperties ret = new VkPhysicalDeviceFloatControlsProperties();
            ret.sType = VkStructureType.PhysicalDeviceFloatControlsProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFloatControlsPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hostQueryReset;
        public static VkPhysicalDeviceHostQueryResetFeatures New()
        {
            VkPhysicalDeviceHostQueryResetFeatures ret = new VkPhysicalDeviceHostQueryResetFeatures();
            ret.sType = VkStructureType.PhysicalDeviceHostQueryResetFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeaturesEXT
    {
    }

    public unsafe partial struct VkNativeBufferUsage2ANDROID
    {
        public ulong consumer;
        public ulong producer;
    }

    public unsafe partial struct VkNativeBufferANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public void* handle;
        public int stride;
        public int format;
        public int usage;
        public VkNativeBufferUsage2ANDROID usage2;
        public static VkNativeBufferANDROID New()
        {
            VkNativeBufferANDROID ret = new VkNativeBufferANDROID();
            ret.sType = VkStructureType.NativeBufferAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainImageCreateInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainImageUsageFlagsANDROID usage;
        public static VkSwapchainImageCreateInfoANDROID New()
        {
            VkSwapchainImageCreateInfoANDROID ret = new VkSwapchainImageCreateInfoANDROID();
            ret.sType = VkStructureType.SwapchainImageCreateInfoAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentationPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 sharedImage;
        public static VkPhysicalDevicePresentationPropertiesANDROID New()
        {
            VkPhysicalDevicePresentationPropertiesANDROID ret = new VkPhysicalDevicePresentationPropertiesANDROID();
            ret.sType = VkStructureType.PhysicalDevicePresentationPropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkShaderResourceUsageAMD
    {
        public uint numUsedVgprs;
        public uint numUsedSgprs;
        public uint ldsSizePerLocalWorkGroup;
        public UIntPtr ldsUsageSizeInBytes;
        public UIntPtr scratchMemUsageInBytes;
    }

    public unsafe partial struct VkShaderStatisticsInfoAMD
    {
        public VkShaderStageFlags shaderStageMask;
        public VkShaderResourceUsageAMD resourceUsage;
        public uint numPhysicalVgprs;
        public uint numPhysicalSgprs;
        public uint numAvailableVgprs;
        public uint numAvailableSgprs;
        public uint computeWorkGroupSize_0;
        public uint computeWorkGroupSize_1;
        public uint computeWorkGroupSize_2;
    }

    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueGlobalPriorityEXT globalPriority;
        public static VkDeviceQueueGlobalPriorityCreateInfoEXT New()
        {
            VkDeviceQueueGlobalPriorityCreateInfoEXT ret = new VkDeviceQueueGlobalPriorityCreateInfoEXT();
            ret.sType = VkStructureType.DeviceQueueGlobalPriorityCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public byte* pObjectName;
        public static VkDebugUtilsObjectNameInfoEXT New()
        {
            VkDebugUtilsObjectNameInfoEXT ret = new VkDebugUtilsObjectNameInfoEXT();
            ret.sType = VkStructureType.DebugUtilsObjectNameInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public ulong tagName;
        public UIntPtr tagSize;
        public void* pTag;
        public static VkDebugUtilsObjectTagInfoEXT New()
        {
            VkDebugUtilsObjectTagInfoEXT ret = new VkDebugUtilsObjectTagInfoEXT();
            ret.sType = VkStructureType.DebugUtilsObjectTagInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsLabelEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pLabelName;
        public float color_0;
        public float color_1;
        public float color_2;
        public float color_3;
        public static VkDebugUtilsLabelEXT New()
        {
            VkDebugUtilsLabelEXT ret = new VkDebugUtilsLabelEXT();
            ret.sType = VkStructureType.DebugUtilsLabelEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
        public VkDebugUtilsMessageTypeFlagsEXT messageType;
        public IntPtr pfnUserCallback;
        public void* pUserData;
        public static VkDebugUtilsMessengerCreateInfoEXT New()
        {
            VkDebugUtilsMessengerCreateInfoEXT ret = new VkDebugUtilsMessengerCreateInfoEXT();
            ret.sType = VkStructureType.DebugUtilsMessengerCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public byte* pMessageIdName;
        public int messageIdNumber;
        public byte* pMessage;
        public uint queueLabelCount;
        public VkDebugUtilsLabelEXT* pQueueLabels;
        public uint cmdBufLabelCount;
        public VkDebugUtilsLabelEXT* pCmdBufLabels;
        public uint objectCount;
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
        public static VkDebugUtilsMessengerCallbackDataEXT New()
        {
            VkDebugUtilsMessengerCallbackDataEXT ret = new VkDebugUtilsMessengerCallbackDataEXT();
            ret.sType = VkStructureType.DebugUtilsMessengerCallbackDataEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceMemoryReport;
        public static VkPhysicalDeviceDeviceMemoryReportFeaturesEXT New()
        {
            VkPhysicalDeviceDeviceMemoryReportFeaturesEXT ret = new VkPhysicalDeviceDeviceMemoryReportFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDeviceMemoryReportFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceDeviceMemoryReportCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public IntPtr pfnUserCallback;
        public void* pUserData;
        public static VkDeviceDeviceMemoryReportCreateInfoEXT New()
        {
            VkDeviceDeviceMemoryReportCreateInfoEXT ret = new VkDeviceDeviceMemoryReportCreateInfoEXT();
            ret.sType = VkStructureType.DeviceDeviceMemoryReportCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceMemoryReportCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDeviceMemoryReportEventTypeEXT type;
        public ulong memoryObjectId;
        public ulong size;
        public VkObjectType objectType;
        public ulong objectHandle;
        public uint heapIndex;
        public static VkDeviceMemoryReportCallbackDataEXT New()
        {
            VkDeviceMemoryReportCallbackDataEXT ret = new VkDeviceMemoryReportCallbackDataEXT();
            ret.sType = VkStructureType.DeviceMemoryReportCallbackDataEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryHostPointerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public void* pHostPointer;
        public static VkImportMemoryHostPointerInfoEXT New()
        {
            VkImportMemoryHostPointerInfoEXT ret = new VkImportMemoryHostPointerInfoEXT();
            ret.sType = VkStructureType.ImportMemoryHostPointerInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryHostPointerPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryHostPointerPropertiesEXT New()
        {
            VkMemoryHostPointerPropertiesEXT ret = new VkMemoryHostPointerPropertiesEXT();
            ret.sType = VkStructureType.MemoryHostPointerPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong minImportedHostPointerAlignment;
        public static VkPhysicalDeviceExternalMemoryHostPropertiesEXT New()
        {
            VkPhysicalDeviceExternalMemoryHostPropertiesEXT ret = new VkPhysicalDeviceExternalMemoryHostPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceExternalMemoryHostPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float primitiveOverestimationSize;
        public float maxExtraPrimitiveOverestimationSize;
        public float extraPrimitiveOverestimationSizeGranularity;
        public VkBool32 primitiveUnderestimation;
        public VkBool32 conservativePointAndLineRasterization;
        public VkBool32 degenerateTrianglesRasterized;
        public VkBool32 degenerateLinesRasterized;
        public VkBool32 fullyCoveredFragmentShaderInputVariable;
        public VkBool32 conservativeRasterizationPostDepthCoverage;
        public static VkPhysicalDeviceConservativeRasterizationPropertiesEXT New()
        {
            VkPhysicalDeviceConservativeRasterizationPropertiesEXT ret = new VkPhysicalDeviceConservativeRasterizationPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceConservativeRasterizationPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkCalibratedTimestampInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTimeDomainEXT timeDomain;
        public static VkCalibratedTimestampInfoEXT New()
        {
            VkCalibratedTimestampInfoEXT ret = new VkCalibratedTimestampInfoEXT();
            ret.sType = VkStructureType.CalibratedTimestampInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderEngineCount;
        public uint shaderArraysPerEngineCount;
        public uint computeUnitsPerShaderArray;
        public uint simdPerComputeUnit;
        public uint wavefrontsPerSimd;
        public uint wavefrontSize;
        public uint sgprsPerSimd;
        public uint minSgprAllocation;
        public uint maxSgprAllocation;
        public uint sgprAllocationGranularity;
        public uint vgprsPerSimd;
        public uint minVgprAllocation;
        public uint maxVgprAllocation;
        public uint vgprAllocationGranularity;
        public static VkPhysicalDeviceShaderCorePropertiesAMD New()
        {
            VkPhysicalDeviceShaderCorePropertiesAMD ret = new VkPhysicalDeviceShaderCorePropertiesAMD();
            ret.sType = VkStructureType.PhysicalDeviceShaderCorePropertiesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
        public uint activeComputeUnitCount;
        public static VkPhysicalDeviceShaderCoreProperties2AMD New()
        {
            VkPhysicalDeviceShaderCoreProperties2AMD ret = new VkPhysicalDeviceShaderCoreProperties2AMD();
            ret.sType = VkStructureType.PhysicalDeviceShaderCoreProperties2AMD;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
        public float extraPrimitiveOverestimationSize;
        public static VkPipelineRasterizationConservativeStateCreateInfoEXT New()
        {
            VkPipelineRasterizationConservativeStateCreateInfoEXT ret = new VkPipelineRasterizationConservativeStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationConservativeStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32 shaderSampledImageArrayNonUniformIndexing;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageImageArrayNonUniformIndexing;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUpdateUnusedWhilePending;
        public VkBool32 descriptorBindingPartiallyBound;
        public VkBool32 descriptorBindingVariableDescriptorCount;
        public VkBool32 runtimeDescriptorArray;
        public static VkPhysicalDeviceDescriptorIndexingFeatures New()
        {
            VkPhysicalDeviceDescriptorIndexingFeatures ret = new VkPhysicalDeviceDescriptorIndexingFeatures();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorIndexingFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
        public VkBool32 robustBufferAccessUpdateAfterBind;
        public VkBool32 quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public static VkPhysicalDeviceDescriptorIndexingProperties New()
        {
            VkPhysicalDeviceDescriptorIndexingProperties ret = new VkPhysicalDeviceDescriptorIndexingProperties();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorIndexingProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
    {
    }

    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint bindingCount;
        public VkDescriptorBindingFlags* pBindingFlags;
        public static VkDescriptorSetLayoutBindingFlagsCreateInfo New()
        {
            VkDescriptorSetLayoutBindingFlagsCreateInfo ret = new VkDescriptorSetLayoutBindingFlagsCreateInfo();
            ret.sType = VkStructureType.DescriptorSetLayoutBindingCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
    {
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint descriptorSetCount;
        public uint* pDescriptorCounts;
        public static VkDescriptorSetVariableDescriptorCountAllocateInfo New()
        {
            VkDescriptorSetVariableDescriptorCountAllocateInfo ret = new VkDescriptorSetVariableDescriptorCountAllocateInfo();
            ret.sType = VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
    {
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVariableDescriptorCount;
        public static VkDescriptorSetVariableDescriptorCountLayoutSupport New()
        {
            VkDescriptorSetVariableDescriptorCountLayoutSupport ret = new VkDescriptorSetVariableDescriptorCountLayoutSupport();
            ret.sType = VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupport;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
    {
    }

    public unsafe partial struct VkAttachmentDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentDescriptionFlags flags;
        public VkFormat format;
        public VkSampleCountFlags samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
        public static VkAttachmentDescription2 New()
        {
            VkAttachmentDescription2 ret = new VkAttachmentDescription2();
            ret.sType = VkStructureType.AttachmentDescription2;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentDescription2KHR
    {
    }

    public unsafe partial struct VkAttachmentReference2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachment;
        public VkImageLayout layout;
        public VkImageAspectFlags aspectMask;
        public static VkAttachmentReference2 New()
        {
            VkAttachmentReference2 ret = new VkAttachmentReference2();
            ret.sType = VkStructureType.AttachmentReference2;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentReference2KHR
    {
    }

    public unsafe partial struct VkSubpassDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassDescriptionFlags flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint viewMask;
        public uint inputAttachmentCount;
        public VkAttachmentReference2* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference2* pColorAttachments;
        public VkAttachmentReference2* pResolveAttachments;
        public VkAttachmentReference2* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
        public static VkSubpassDescription2 New()
        {
            VkSubpassDescription2 ret = new VkSubpassDescription2();
            ret.sType = VkStructureType.SubpassDescription2;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassDescription2KHR
    {
    }

    public unsafe partial struct VkSubpassDependency2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlags srcStageMask;
        public VkPipelineStageFlags dstStageMask;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public VkDependencyFlags dependencyFlags;
        public int viewOffset;
        public static VkSubpassDependency2 New()
        {
            VkSubpassDependency2 ret = new VkSubpassDependency2();
            ret.sType = VkStructureType.SubpassDependency2;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassDependency2KHR
    {
    }

    public unsafe partial struct VkRenderPassCreateInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlags flags;
        public uint attachmentCount;
        public VkAttachmentDescription2* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription2* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency2* pDependencies;
        public uint correlatedViewMaskCount;
        public uint* pCorrelatedViewMasks;
        public static VkRenderPassCreateInfo2 New()
        {
            VkRenderPassCreateInfo2 ret = new VkRenderPassCreateInfo2();
            ret.sType = VkStructureType.RenderPassCreateInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassCreateInfo2KHR
    {
    }

    public unsafe partial struct VkSubpassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassContents contents;
        public static VkSubpassBeginInfo New()
        {
            VkSubpassBeginInfo ret = new VkSubpassBeginInfo();
            ret.sType = VkStructureType.SubpassBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassBeginInfoKHR
    {
    }

    public unsafe partial struct VkSubpassEndInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkSubpassEndInfo New()
        {
            VkSubpassEndInfo ret = new VkSubpassEndInfo();
            ret.sType = VkStructureType.SubpassEndInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassEndInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 timelineSemaphore;
        public static VkPhysicalDeviceTimelineSemaphoreFeatures New()
        {
            VkPhysicalDeviceTimelineSemaphoreFeatures ret = new VkPhysicalDeviceTimelineSemaphoreFeatures();
            ret.sType = VkStructureType.PhysicalDeviceTimelineSemaphoreFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxTimelineSemaphoreValueDifference;
        public static VkPhysicalDeviceTimelineSemaphoreProperties New()
        {
            VkPhysicalDeviceTimelineSemaphoreProperties ret = new VkPhysicalDeviceTimelineSemaphoreProperties();
            ret.sType = VkStructureType.PhysicalDeviceTimelineSemaphoreProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
    {
    }

    public unsafe partial struct VkSemaphoreTypeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreType semaphoreType;
        public ulong initialValue;
        public static VkSemaphoreTypeCreateInfo New()
        {
            VkSemaphoreTypeCreateInfo ret = new VkSemaphoreTypeCreateInfo();
            ret.sType = VkStructureType.SemaphoreTypeCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreTypeCreateInfoKHR
    {
    }

    public unsafe partial struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValueCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValueCount;
        public ulong* pSignalSemaphoreValues;
        public static VkTimelineSemaphoreSubmitInfo New()
        {
            VkTimelineSemaphoreSubmitInfo ret = new VkTimelineSemaphoreSubmitInfo();
            ret.sType = VkStructureType.TimelineSemaphoreSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkTimelineSemaphoreSubmitInfoKHR
    {
    }

    public unsafe partial struct VkSemaphoreWaitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreWaitFlags flags;
        public uint semaphoreCount;
        public VkSemaphore* pSemaphores;
        public ulong* pValues;
        public static VkSemaphoreWaitInfo New()
        {
            VkSemaphoreWaitInfo ret = new VkSemaphoreWaitInfo();
            ret.sType = VkStructureType.SemaphoreWaitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreWaitInfoKHR
    {
    }

    public unsafe partial struct VkSemaphoreSignalInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        public static VkSemaphoreSignalInfo New()
        {
            VkSemaphoreSignalInfo ret = new VkSemaphoreSignalInfo();
            ret.sType = VkStructureType.SemaphoreSignalInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreSignalInfoKHR
    {
    }

    public unsafe partial struct VkVertexInputBindingDivisorDescriptionEXT
    {
        public uint binding;
        public uint divisor;
    }

    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vertexBindingDivisorCount;
        public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
        public static VkPipelineVertexInputDivisorStateCreateInfoEXT New()
        {
            VkPipelineVertexInputDivisorStateCreateInfoEXT ret = new VkPipelineVertexInputDivisorStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineVertexInputDivisorStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVertexAttribDivisor;
        public static VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT New()
        {
            VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT ret = new VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePCIBusInfoPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pciDomain;
        public uint pciBus;
        public uint pciDevice;
        public uint pciFunction;
        public static VkPhysicalDevicePCIBusInfoPropertiesEXT New()
        {
            VkPhysicalDevicePCIBusInfoPropertiesEXT ret = new VkPhysicalDevicePCIBusInfoPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDevicePciBusInfoPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public AHardwareBuffer* buffer;
        public static VkImportAndroidHardwareBufferInfoANDROID New()
        {
            VkImportAndroidHardwareBufferInfoANDROID ret = new VkImportAndroidHardwareBufferInfoANDROID();
            ret.sType = VkStructureType.ImportAndroidHardwareBufferInfoAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkAndroidHardwareBufferUsageANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong androidHardwareBufferUsage;
        public static VkAndroidHardwareBufferUsageANDROID New()
        {
            VkAndroidHardwareBufferUsageANDROID ret = new VkAndroidHardwareBufferUsageANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferUsageAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkAndroidHardwareBufferPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeBits;
        public static VkAndroidHardwareBufferPropertiesANDROID New()
        {
            VkAndroidHardwareBufferPropertiesANDROID ret = new VkAndroidHardwareBufferPropertiesANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferPropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public static VkMemoryGetAndroidHardwareBufferInfoANDROID New()
        {
            VkMemoryGetAndroidHardwareBufferInfoANDROID ret = new VkMemoryGetAndroidHardwareBufferInfoANDROID();
            ret.sType = VkStructureType.MemoryGetAndroidHardwareBufferInfoAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public VkFormatFeatureFlags formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public static VkAndroidHardwareBufferFormatPropertiesANDROID New()
        {
            VkAndroidHardwareBufferFormatPropertiesANDROID ret = new VkAndroidHardwareBufferFormatPropertiesANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferFormatPropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 conditionalRenderingEnable;
        public static VkCommandBufferInheritanceConditionalRenderingInfoEXT New()
        {
            VkCommandBufferInheritanceConditionalRenderingInfoEXT ret = new VkCommandBufferInheritanceConditionalRenderingInfoEXT();
            ret.sType = VkStructureType.CommandBufferInheritanceConditionalRenderingInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExternalFormatANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong externalFormat;
        public static VkExternalFormatANDROID New()
        {
            VkExternalFormatANDROID ret = new VkExternalFormatANDROID();
            ret.sType = VkStructureType.ExternalFormatAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 storageBuffer8BitAccess;
        public VkBool32 uniformAndStorageBuffer8BitAccess;
        public VkBool32 storagePushConstant8;
        public static VkPhysicalDevice8BitStorageFeatures New()
        {
            VkPhysicalDevice8BitStorageFeatures ret = new VkPhysicalDevice8BitStorageFeatures();
            ret.sType = VkStructureType.PhysicalDevice8bitStorageFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice8BitStorageFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 conditionalRendering;
        public VkBool32 inheritedConditionalRendering;
        public static VkPhysicalDeviceConditionalRenderingFeaturesEXT New()
        {
            VkPhysicalDeviceConditionalRenderingFeaturesEXT ret = new VkPhysicalDeviceConditionalRenderingFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceConditionalRenderingFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vulkanMemoryModel;
        public VkBool32 vulkanMemoryModelDeviceScope;
        public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
        public static VkPhysicalDeviceVulkanMemoryModelFeatures New()
        {
            VkPhysicalDeviceVulkanMemoryModelFeatures ret = new VkPhysicalDeviceVulkanMemoryModelFeatures();
            ret.sType = VkStructureType.PhysicalDeviceVulkanMemoryModelFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferInt64Atomics;
        public VkBool32 shaderSharedInt64Atomics;
        public static VkPhysicalDeviceShaderAtomicInt64Features New()
        {
            VkPhysicalDeviceShaderAtomicInt64Features ret = new VkPhysicalDeviceShaderAtomicInt64Features();
            ret.sType = VkStructureType.PhysicalDeviceShaderAtomicInt64Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferFloat32Atomics;
        public VkBool32 shaderBufferFloat32AtomicAdd;
        public VkBool32 shaderBufferFloat64Atomics;
        public VkBool32 shaderBufferFloat64AtomicAdd;
        public VkBool32 shaderSharedFloat32Atomics;
        public VkBool32 shaderSharedFloat32AtomicAdd;
        public VkBool32 shaderSharedFloat64Atomics;
        public VkBool32 shaderSharedFloat64AtomicAdd;
        public VkBool32 shaderImageFloat32Atomics;
        public VkBool32 shaderImageFloat32AtomicAdd;
        public VkBool32 sparseImageFloat32Atomics;
        public VkBool32 sparseImageFloat32AtomicAdd;
        public static VkPhysicalDeviceShaderAtomicFloatFeaturesEXT New()
        {
            VkPhysicalDeviceShaderAtomicFloatFeaturesEXT ret = new VkPhysicalDeviceShaderAtomicFloatFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderAtomicFloatFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vertexAttributeInstanceRateDivisor;
        public VkBool32 vertexAttributeInstanceRateZeroDivisor;
        public static VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT New()
        {
            VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT ret = new VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags checkpointExecutionStageMask;
        public static VkQueueFamilyCheckpointPropertiesNV New()
        {
            VkQueueFamilyCheckpointPropertiesNV ret = new VkQueueFamilyCheckpointPropertiesNV();
            ret.sType = VkStructureType.QueueFamilyCheckpointPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCheckpointDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags stage;
        public void* pCheckpointMarker;
        public static VkCheckpointDataNV New()
        {
            VkCheckpointDataNV ret = new VkCheckpointDataNV();
            ret.sType = VkStructureType.CheckpointDataNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlags supportedDepthResolveModes;
        public VkResolveModeFlags supportedStencilResolveModes;
        public VkBool32 independentResolveNone;
        public VkBool32 independentResolve;
        public static VkPhysicalDeviceDepthStencilResolveProperties New()
        {
            VkPhysicalDeviceDepthStencilResolveProperties ret = new VkPhysicalDeviceDepthStencilResolveProperties();
            ret.sType = VkStructureType.PhysicalDeviceDepthStencilResolveProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
    {
    }

    public unsafe partial struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlags depthResolveMode;
        public VkResolveModeFlags stencilResolveMode;
        public VkAttachmentReference2* pDepthStencilResolveAttachment;
        public static VkSubpassDescriptionDepthStencilResolve New()
        {
            VkSubpassDescriptionDepthStencilResolve ret = new VkSubpassDescriptionDepthStencilResolve();
            ret.sType = VkStructureType.SubpassDescriptionDepthStencilResolve;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassDescriptionDepthStencilResolveKHR
    {
    }

    public unsafe partial struct VkImageViewASTCDecodeModeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat decodeMode;
        public static VkImageViewASTCDecodeModeEXT New()
        {
            VkImageViewASTCDecodeModeEXT ret = new VkImageViewASTCDecodeModeEXT();
            ret.sType = VkStructureType.ImageViewAstcDecodeModeEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 decodeModeSharedExponent;
        public static VkPhysicalDeviceASTCDecodeFeaturesEXT New()
        {
            VkPhysicalDeviceASTCDecodeFeaturesEXT ret = new VkPhysicalDeviceASTCDecodeFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceAstcDecodeFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 transformFeedback;
        public VkBool32 geometryStreams;
        public static VkPhysicalDeviceTransformFeedbackFeaturesEXT New()
        {
            VkPhysicalDeviceTransformFeedbackFeaturesEXT ret = new VkPhysicalDeviceTransformFeedbackFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTransformFeedbackFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTransformFeedbackStreams;
        public uint maxTransformFeedbackBuffers;
        public ulong maxTransformFeedbackBufferSize;
        public uint maxTransformFeedbackStreamDataSize;
        public uint maxTransformFeedbackBufferDataSize;
        public uint maxTransformFeedbackBufferDataStride;
        public VkBool32 transformFeedbackQueries;
        public VkBool32 transformFeedbackStreamsLinesTriangles;
        public VkBool32 transformFeedbackRasterizationStreamSelect;
        public VkBool32 transformFeedbackDraw;
        public static VkPhysicalDeviceTransformFeedbackPropertiesEXT New()
        {
            VkPhysicalDeviceTransformFeedbackPropertiesEXT ret = new VkPhysicalDeviceTransformFeedbackPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTransformFeedbackPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint rasterizationStream;
        public static VkPipelineRasterizationStateStreamCreateInfoEXT New()
        {
            VkPipelineRasterizationStateStreamCreateInfoEXT ret = new VkPipelineRasterizationStateStreamCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationStateStreamCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 representativeFragmentTest;
        public static VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV New()
        {
            VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV ret = new VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 representativeFragmentTestEnable;
        public static VkPipelineRepresentativeFragmentTestStateCreateInfoNV New()
        {
            VkPipelineRepresentativeFragmentTestStateCreateInfoNV ret = new VkPipelineRepresentativeFragmentTestStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineRepresentativeFragmentTestStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExclusiveScissorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 exclusiveScissor;
        public static VkPhysicalDeviceExclusiveScissorFeaturesNV New()
        {
            VkPhysicalDeviceExclusiveScissorFeaturesNV ret = new VkPhysicalDeviceExclusiveScissorFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceExclusiveScissorFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint exclusiveScissorCount;
        public VkRect2D* pExclusiveScissors;
        public static VkPipelineViewportExclusiveScissorStateCreateInfoNV New()
        {
            VkPipelineViewportExclusiveScissorStateCreateInfoNV ret = new VkPipelineViewportExclusiveScissorStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportExclusiveScissorStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cornerSampledImage;
        public static VkPhysicalDeviceCornerSampledImageFeaturesNV New()
        {
            VkPhysicalDeviceCornerSampledImageFeaturesNV ret = new VkPhysicalDeviceCornerSampledImageFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCornerSampledImageFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 computeDerivativeGroupQuads;
        public VkBool32 computeDerivativeGroupLinear;
        public static VkPhysicalDeviceComputeShaderDerivativesFeaturesNV New()
        {
            VkPhysicalDeviceComputeShaderDerivativesFeaturesNV ret = new VkPhysicalDeviceComputeShaderDerivativesFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentShaderBarycentric;
        public static VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV New()
        {
            VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV ret = new VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imageFootprint;
        public static VkPhysicalDeviceShaderImageFootprintFeaturesNV New()
        {
            VkPhysicalDeviceShaderImageFootprintFeaturesNV ret = new VkPhysicalDeviceShaderImageFootprintFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceShaderImageFootprintFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocationImageAliasing;
        public static VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV New()
        {
            VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV ret = new VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkShadingRatePaletteNV
    {
        public uint shadingRatePaletteEntryCount;
        public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
    }

    public unsafe partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shadingRateImageEnable;
        public uint viewportCount;
        public VkShadingRatePaletteNV* pShadingRatePalettes;
        public static VkPipelineViewportShadingRateImageStateCreateInfoNV New()
        {
            VkPipelineViewportShadingRateImageStateCreateInfoNV ret = new VkPipelineViewportShadingRateImageStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportShadingRateImageStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shadingRateImage;
        public VkBool32 shadingRateCoarseSampleOrder;
        public static VkPhysicalDeviceShadingRateImageFeaturesNV New()
        {
            VkPhysicalDeviceShadingRateImageFeaturesNV ret = new VkPhysicalDeviceShadingRateImageFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceShadingRateImageFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShadingRateImagePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D shadingRateTexelSize;
        public uint shadingRatePaletteSize;
        public uint shadingRateMaxCoarseSamples;
        public static VkPhysicalDeviceShadingRateImagePropertiesNV New()
        {
            VkPhysicalDeviceShadingRateImagePropertiesNV ret = new VkPhysicalDeviceShadingRateImagePropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceShadingRateImagePropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCoarseSampleLocationNV
    {
        public uint pixelX;
        public uint pixelY;
        public uint sample;
    }

    public unsafe partial struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV shadingRate;
        public uint sampleCount;
        public uint sampleLocationCount;
        public VkCoarseSampleLocationNV* pSampleLocations;
    }

    public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCoarseSampleOrderTypeNV sampleOrderType;
        public uint customSampleOrderCount;
        public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
        public static VkPipelineViewportCoarseSampleOrderStateCreateInfoNV New()
        {
            VkPipelineViewportCoarseSampleOrderStateCreateInfoNV ret = new VkPipelineViewportCoarseSampleOrderStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 taskShader;
        public VkBool32 meshShader;
        public static VkPhysicalDeviceMeshShaderFeaturesNV New()
        {
            VkPhysicalDeviceMeshShaderFeaturesNV ret = new VkPhysicalDeviceMeshShaderFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceMeshShaderFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDrawMeshTasksCount;
        public uint maxTaskWorkGroupInvocations;
        public uint maxTaskWorkGroupSize_0;
        public uint maxTaskWorkGroupSize_1;
        public uint maxTaskWorkGroupSize_2;
        public uint maxTaskTotalMemorySize;
        public uint maxTaskOutputCount;
        public uint maxMeshWorkGroupInvocations;
        public uint maxMeshWorkGroupSize_0;
        public uint maxMeshWorkGroupSize_1;
        public uint maxMeshWorkGroupSize_2;
        public uint maxMeshTotalMemorySize;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        public static VkPhysicalDeviceMeshShaderPropertiesNV New()
        {
            VkPhysicalDeviceMeshShaderPropertiesNV ret = new VkPhysicalDeviceMeshShaderPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceMeshShaderPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDrawMeshTasksIndirectCommandNV
    {
        public uint taskCount;
        public uint firstTask;
    }

    public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public static VkRayTracingShaderGroupCreateInfoNV New()
        {
            VkRayTracingShaderGroupCreateInfoNV ret = new VkRayTracingShaderGroupCreateInfoNV();
            ret.sType = VkStructureType.RayTracingShaderGroupCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public void* pShaderGroupCaptureReplayHandle;
        public static VkRayTracingShaderGroupCreateInfoKHR New()
        {
            VkRayTracingShaderGroupCreateInfoKHR ret = new VkRayTracingShaderGroupCreateInfoKHR();
            ret.sType = VkStructureType.RayTracingShaderGroupCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingPipelineCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoNV* pGroups;
        public uint maxRecursionDepth;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkRayTracingPipelineCreateInfoNV New()
        {
            VkRayTracingPipelineCreateInfoNV ret = new VkRayTracingPipelineCreateInfoNV();
            ret.sType = VkStructureType.RayTracingPipelineCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingPipelineCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
        public uint maxPipelineRayRecursionDepth;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkRayTracingPipelineCreateInfoKHR New()
        {
            VkRayTracingPipelineCreateInfoKHR ret = new VkRayTracingPipelineCreateInfoKHR();
            ret.sType = VkStructureType.RayTracingPipelineCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkGeometryTrianglesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer vertexData;
        public ulong vertexOffset;
        public uint vertexCount;
        public ulong vertexStride;
        public VkFormat vertexFormat;
        public VkBuffer indexData;
        public ulong indexOffset;
        public uint indexCount;
        public VkIndexType indexType;
        public VkBuffer transformData;
        public ulong transformOffset;
        public static VkGeometryTrianglesNV New()
        {
            VkGeometryTrianglesNV ret = new VkGeometryTrianglesNV();
            ret.sType = VkStructureType.GeometryTrianglesNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeometryAABBNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer aabbData;
        public uint numAABBs;
        public uint stride;
        public ulong offset;
        public static VkGeometryAABBNV New()
        {
            VkGeometryAABBNV ret = new VkGeometryAABBNV();
            ret.sType = VkStructureType.GeometryAabbNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeometryDataNV
    {
        public VkGeometryTrianglesNV triangles;
        public VkGeometryAABBNV aabbs;
    }

    public unsafe partial struct VkGeometryNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkGeometryDataNV geometry;
        public VkGeometryFlagsKHR flags;
        public static VkGeometryNV New()
        {
            VkGeometryNV ret = new VkGeometryNV();
            ret.sType = VkStructureType.GeometryNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeNV type;
        public VkBuildAccelerationStructureFlagsNV flags;
        public uint instanceCount;
        public uint geometryCount;
        public VkGeometryNV* pGeometries;
        public static VkAccelerationStructureInfoNV New()
        {
            VkAccelerationStructureInfoNV ret = new VkAccelerationStructureInfoNV();
            ret.sType = VkStructureType.AccelerationStructureInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong compactedSize;
        public VkAccelerationStructureInfoNV info;
        public static VkAccelerationStructureCreateInfoNV New()
        {
            VkAccelerationStructureCreateInfoNV ret = new VkAccelerationStructureCreateInfoNV();
            ret.sType = VkStructureType.AccelerationStructureCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureNV accelerationStructure;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public static VkBindAccelerationStructureMemoryInfoNV New()
        {
            VkBindAccelerationStructureMemoryInfoNV ret = new VkBindAccelerationStructureMemoryInfoNV();
            ret.sType = VkStructureType.BindAccelerationStructureMemoryInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureKHR* pAccelerationStructures;
        public static VkWriteDescriptorSetAccelerationStructureKHR New()
        {
            VkWriteDescriptorSetAccelerationStructureKHR ret = new VkWriteDescriptorSetAccelerationStructureKHR();
            ret.sType = VkStructureType.WriteDescriptorSetAccelerationStructureKHR;
            return ret;
        }
    }

    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureNV* pAccelerationStructures;
        public static VkWriteDescriptorSetAccelerationStructureNV New()
        {
            VkWriteDescriptorSetAccelerationStructureNV ret = new VkWriteDescriptorSetAccelerationStructureNV();
            ret.sType = VkStructureType.WriteDescriptorSetAccelerationStructureNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureMemoryRequirementsTypeNV type;
        public VkAccelerationStructureNV accelerationStructure;
        public static VkAccelerationStructureMemoryRequirementsInfoNV New()
        {
            VkAccelerationStructureMemoryRequirementsInfoNV ret = new VkAccelerationStructureMemoryRequirementsInfoNV();
            ret.sType = VkStructureType.AccelerationStructureMemoryRequirementsInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 accelerationStructure;
        public VkBool32 accelerationStructureCaptureReplay;
        public VkBool32 accelerationStructureIndirectBuild;
        public VkBool32 accelerationStructureHostCommands;
        public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
        public static VkPhysicalDeviceAccelerationStructureFeaturesKHR New()
        {
            VkPhysicalDeviceAccelerationStructureFeaturesKHR ret = new VkPhysicalDeviceAccelerationStructureFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceAccelerationStructureFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingPipeline;
        public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
        public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
        public VkBool32 rayTracingPipelineTraceRaysIndirect;
        public VkBool32 rayTraversalPrimitiveCulling;
        public static VkPhysicalDeviceRayTracingPipelineFeaturesKHR New()
        {
            VkPhysicalDeviceRayTracingPipelineFeaturesKHR ret = new VkPhysicalDeviceRayTracingPipelineFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingPipelineFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayQuery;
        public static VkPhysicalDeviceRayQueryFeaturesKHR New()
        {
            VkPhysicalDeviceRayQueryFeaturesKHR ret = new VkPhysicalDeviceRayQueryFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayQueryFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxPrimitiveCount;
        public uint maxPerStageDescriptorAccelerationStructures;
        public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
        public uint maxDescriptorSetAccelerationStructures;
        public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
        public uint minAccelerationStructureScratchOffsetAlignment;
        public static VkPhysicalDeviceAccelerationStructurePropertiesKHR New()
        {
            VkPhysicalDeviceAccelerationStructurePropertiesKHR ret = new VkPhysicalDeviceAccelerationStructurePropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceAccelerationStructurePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRayRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public uint shaderGroupHandleCaptureReplaySize;
        public uint maxRayDispatchInvocationCount;
        public uint shaderGroupHandleAlignment;
        public uint maxRayHitAttributeSize;
        public static VkPhysicalDeviceRayTracingPipelinePropertiesKHR New()
        {
            VkPhysicalDeviceRayTracingPipelinePropertiesKHR ret = new VkPhysicalDeviceRayTracingPipelinePropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingPipelinePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxTriangleCount;
        public uint maxDescriptorSetAccelerationStructures;
        public static VkPhysicalDeviceRayTracingPropertiesNV New()
        {
            VkPhysicalDeviceRayTracingPropertiesNV ret = new VkPhysicalDeviceRayTracingPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkStridedDeviceAddressRegionKHR
    {
        public ulong deviceAddress;
        public ulong stride;
        public ulong size;
    }

    public unsafe partial struct VkTraceRaysIndirectCommandKHR
    {
        public uint width;
        public uint height;
        public uint depth;
    }

    public unsafe partial struct VkDrmFormatModifierPropertiesListEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
        public static VkDrmFormatModifierPropertiesListEXT New()
        {
            VkDrmFormatModifierPropertiesListEXT ret = new VkDrmFormatModifierPropertiesListEXT();
            ret.sType = VkStructureType.DrmFormatModifierPropertiesListEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDrmFormatModifierPropertiesEXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
    }

    public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public static VkPhysicalDeviceImageDrmFormatModifierInfoEXT New()
        {
            VkPhysicalDeviceImageDrmFormatModifierInfoEXT ret = new VkPhysicalDeviceImageDrmFormatModifierInfoEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageDrmFormatModifierInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public ulong* pDrmFormatModifiers;
        public static VkImageDrmFormatModifierListCreateInfoEXT New()
        {
            VkImageDrmFormatModifierListCreateInfoEXT ret = new VkImageDrmFormatModifierListCreateInfoEXT();
            ret.sType = VkStructureType.ImageDrmFormatModifierListCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
        public static VkImageDrmFormatModifierExplicitCreateInfoEXT New()
        {
            VkImageDrmFormatModifierExplicitCreateInfoEXT ret = new VkImageDrmFormatModifierExplicitCreateInfoEXT();
            ret.sType = VkStructureType.ImageDrmFormatModifierExplicitCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageDrmFormatModifierPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public static VkImageDrmFormatModifierPropertiesEXT New()
        {
            VkImageDrmFormatModifierPropertiesEXT ret = new VkImageDrmFormatModifierPropertiesEXT();
            ret.sType = VkStructureType.ImageDrmFormatModifierPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageStencilUsageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags stencilUsage;
        public static VkImageStencilUsageCreateInfo New()
        {
            VkImageStencilUsageCreateInfo ret = new VkImageStencilUsageCreateInfo();
            ret.sType = VkStructureType.ImageStencilUsageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageStencilUsageCreateInfoEXT
    {
    }

    public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
        public static VkDeviceMemoryOverallocationCreateInfoAMD New()
        {
            VkDeviceMemoryOverallocationCreateInfoAMD ret = new VkDeviceMemoryOverallocationCreateInfoAMD();
            ret.sType = VkStructureType.DeviceMemoryOverallocationCreateInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMap;
        public VkBool32 fragmentDensityMapDynamic;
        public VkBool32 fragmentDensityMapNonSubsampledImages;
        public static VkPhysicalDeviceFragmentDensityMapFeaturesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMapFeaturesEXT ret = new VkPhysicalDeviceFragmentDensityMapFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMapDeferred;
        public static VkPhysicalDeviceFragmentDensityMap2FeaturesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMap2FeaturesEXT ret = new VkPhysicalDeviceFragmentDensityMap2FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMap2FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentDensityTexelSize;
        public VkExtent2D maxFragmentDensityTexelSize;
        public VkBool32 fragmentDensityInvocations;
        public static VkPhysicalDeviceFragmentDensityMapPropertiesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMapPropertiesEXT ret = new VkPhysicalDeviceFragmentDensityMapPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subsampledLoads;
        public VkBool32 subsampledCoarseReconstructionEarlyAccess;
        public uint maxSubsampledArrayLayers;
        public uint maxDescriptorSetSubsampledSamplers;
        public static VkPhysicalDeviceFragmentDensityMap2PropertiesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMap2PropertiesEXT ret = new VkPhysicalDeviceFragmentDensityMap2PropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMap2PropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentReference fragmentDensityMapAttachment;
        public static VkRenderPassFragmentDensityMapCreateInfoEXT New()
        {
            VkRenderPassFragmentDensityMapCreateInfoEXT ret = new VkRenderPassFragmentDensityMapCreateInfoEXT();
            ret.sType = VkStructureType.RenderPassFragmentDensityMapCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 scalarBlockLayout;
        public static VkPhysicalDeviceScalarBlockLayoutFeatures New()
        {
            VkPhysicalDeviceScalarBlockLayoutFeatures ret = new VkPhysicalDeviceScalarBlockLayoutFeatures();
            ret.sType = VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
    {
    }

    public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supportsProtected;
        public static VkSurfaceProtectedCapabilitiesKHR New()
        {
            VkSurfaceProtectedCapabilitiesKHR ret = new VkSurfaceProtectedCapabilitiesKHR();
            ret.sType = VkStructureType.SurfaceProtectedCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 uniformBufferStandardLayout;
        public static VkPhysicalDeviceUniformBufferStandardLayoutFeatures New()
        {
            VkPhysicalDeviceUniformBufferStandardLayoutFeatures ret = new VkPhysicalDeviceUniformBufferStandardLayoutFeatures();
            ret.sType = VkStructureType.PhysicalDeviceUniformBufferStandardLayoutFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthClipEnable;
        public static VkPhysicalDeviceDepthClipEnableFeaturesEXT New()
        {
            VkPhysicalDeviceDepthClipEnableFeaturesEXT ret = new VkPhysicalDeviceDepthClipEnableFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDepthClipEnableFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 depthClipEnable;
        public static VkPipelineRasterizationDepthClipStateCreateInfoEXT New()
        {
            VkPipelineRasterizationDepthClipStateCreateInfoEXT ret = new VkPipelineRasterizationDepthClipStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationDepthClipStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed ulong heapBudget[(int)VulkanNative.MaxMemoryHeaps];
        public fixed ulong heapUsage[(int)VulkanNative.MaxMemoryHeaps];
        public static VkPhysicalDeviceMemoryBudgetPropertiesEXT New()
        {
            VkPhysicalDeviceMemoryBudgetPropertiesEXT ret = new VkPhysicalDeviceMemoryBudgetPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMemoryBudgetPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 memoryPriority;
        public static VkPhysicalDeviceMemoryPriorityFeaturesEXT New()
        {
            VkPhysicalDeviceMemoryPriorityFeaturesEXT ret = new VkPhysicalDeviceMemoryPriorityFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMemoryPriorityFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryPriorityAllocateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float priority;
        public static VkMemoryPriorityAllocateInfoEXT New()
        {
            VkMemoryPriorityAllocateInfoEXT ret = new VkMemoryPriorityAllocateInfoEXT();
            ret.sType = VkStructureType.MemoryPriorityAllocateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
        public static VkPhysicalDeviceBufferDeviceAddressFeatures New()
        {
            VkPhysicalDeviceBufferDeviceAddressFeatures ret = new VkPhysicalDeviceBufferDeviceAddressFeatures();
            ret.sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
        public static VkPhysicalDeviceBufferDeviceAddressFeaturesEXT New()
        {
            VkPhysicalDeviceBufferDeviceAddressFeaturesEXT ret = new VkPhysicalDeviceBufferDeviceAddressFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBufferAddressFeaturesEXT
    {
    }

    public unsafe partial struct VkBufferDeviceAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public static VkBufferDeviceAddressInfo New()
        {
            VkBufferDeviceAddressInfo ret = new VkBufferDeviceAddressInfo();
            ret.sType = VkStructureType.BufferDeviceAddressInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferDeviceAddressInfoKHR
    {
    }

    public unsafe partial struct VkBufferDeviceAddressInfoEXT
    {
    }

    public unsafe partial struct VkBufferOpaqueCaptureAddressCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong opaqueCaptureAddress;
        public static VkBufferOpaqueCaptureAddressCreateInfo New()
        {
            VkBufferOpaqueCaptureAddressCreateInfo ret = new VkBufferOpaqueCaptureAddressCreateInfo();
            ret.sType = VkStructureType.BufferOpaqueCaptureAddressCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferOpaqueCaptureAddressCreateInfoKHR
    {
    }

    public unsafe partial struct VkBufferDeviceAddressCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public static VkBufferDeviceAddressCreateInfoEXT New()
        {
            VkBufferDeviceAddressCreateInfoEXT ret = new VkBufferDeviceAddressCreateInfoEXT();
            ret.sType = VkStructureType.BufferDeviceAddressCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageViewType imageViewType;
        public static VkPhysicalDeviceImageViewImageFormatInfoEXT New()
        {
            VkPhysicalDeviceImageViewImageFormatInfoEXT ret = new VkPhysicalDeviceImageViewImageFormatInfoEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageViewImageFormatInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkFilterCubicImageViewImageFormatPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 filterCubic;
        public VkBool32 filterCubicMinmax;
        public static VkFilterCubicImageViewImageFormatPropertiesEXT New()
        {
            VkFilterCubicImageViewImageFormatPropertiesEXT ret = new VkFilterCubicImageViewImageFormatPropertiesEXT();
            ret.sType = VkStructureType.FilterCubicImageViewImageFormatPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imagelessFramebuffer;
        public static VkPhysicalDeviceImagelessFramebufferFeatures New()
        {
            VkPhysicalDeviceImagelessFramebufferFeatures ret = new VkPhysicalDeviceImagelessFramebufferFeatures();
            ret.sType = VkStructureType.PhysicalDeviceImagelessFramebufferFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
    {
    }

    public unsafe partial struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentImageInfoCount;
        public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
        public static VkFramebufferAttachmentsCreateInfo New()
        {
            VkFramebufferAttachmentsCreateInfo ret = new VkFramebufferAttachmentsCreateInfo();
            ret.sType = VkStructureType.FramebufferAttachmentsCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferAttachmentsCreateInfoKHR
    {
    }

    public unsafe partial struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlags flags;
        public VkImageUsageFlags usage;
        public uint width;
        public uint height;
        public uint layerCount;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
        public static VkFramebufferAttachmentImageInfo New()
        {
            VkFramebufferAttachmentImageInfo ret = new VkFramebufferAttachmentImageInfo();
            ret.sType = VkStructureType.FramebufferAttachmentImageInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferAttachmentImageInfoKHR
    {
    }

    public unsafe partial struct VkRenderPassAttachmentBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        public static VkRenderPassAttachmentBeginInfo New()
        {
            VkRenderPassAttachmentBeginInfo ret = new VkRenderPassAttachmentBeginInfo();
            ret.sType = VkStructureType.RenderPassAttachmentBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassAttachmentBeginInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureCompressionASTC_HDR;
        public static VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT New()
        {
            VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT ret = new VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cooperativeMatrix;
        public VkBool32 cooperativeMatrixRobustBufferAccess;
        public static VkPhysicalDeviceCooperativeMatrixFeaturesNV New()
        {
            VkPhysicalDeviceCooperativeMatrixFeaturesNV ret = new VkPhysicalDeviceCooperativeMatrixFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags cooperativeMatrixSupportedStages;
        public static VkPhysicalDeviceCooperativeMatrixPropertiesNV New()
        {
            VkPhysicalDeviceCooperativeMatrixPropertiesNV ret = new VkPhysicalDeviceCooperativeMatrixPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeNV AType;
        public VkComponentTypeNV BType;
        public VkComponentTypeNV CType;
        public VkComponentTypeNV DType;
        public VkScopeNV scope;
        public static VkCooperativeMatrixPropertiesNV New()
        {
            VkCooperativeMatrixPropertiesNV ret = new VkCooperativeMatrixPropertiesNV();
            ret.sType = VkStructureType.CooperativeMatrixPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 ycbcrImageArrays;
        public static VkPhysicalDeviceYcbcrImageArraysFeaturesEXT New()
        {
            VkPhysicalDeviceYcbcrImageArraysFeaturesEXT ret = new VkPhysicalDeviceYcbcrImageArraysFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceYcbcrImageArraysFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewHandleInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkDescriptorType descriptorType;
        public VkSampler sampler;
        public static VkImageViewHandleInfoNVX New()
        {
            VkImageViewHandleInfoNVX ret = new VkImageViewHandleInfoNVX();
            ret.sType = VkStructureType.ImageViewHandleInfoNVX;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        public static VkImageViewAddressPropertiesNVX New()
        {
            VkImageViewAddressPropertiesNVX ret = new VkImageViewAddressPropertiesNVX();
            ret.sType = VkStructureType.ImageViewAddressPropertiesNVX;
            return ret;
        }
    }

    public unsafe partial struct VkPresentFrameTokenGGP
    {
        public VkStructureType sType;
        public void* pNext;
        public GgpFrameToken frameToken;
        public static VkPresentFrameTokenGGP New()
        {
            VkPresentFrameTokenGGP ret = new VkPresentFrameTokenGGP();
            ret.sType = VkStructureType.PresentFrameTokenGgp;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCreationFeedbackEXT
    {
        public VkPipelineCreationFeedbackFlagsEXT flags;
        public ulong duration;
    }

    public unsafe partial struct VkPipelineCreationFeedbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreationFeedbackEXT* pPipelineCreationFeedback;
        public uint pipelineStageCreationFeedbackCount;
        public VkPipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks;
        public static VkPipelineCreationFeedbackCreateInfoEXT New()
        {
            VkPipelineCreationFeedbackCreateInfoEXT ret = new VkPipelineCreationFeedbackCreateInfoEXT();
            ret.sType = VkStructureType.PipelineCreationFeedbackCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFullScreenExclusiveEXT fullScreenExclusive;
        public static VkSurfaceFullScreenExclusiveInfoEXT New()
        {
            VkSurfaceFullScreenExclusiveInfoEXT ret = new VkSurfaceFullScreenExclusiveInfoEXT();
            ret.sType = VkStructureType.SurfaceFullScreenExclusiveInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public HMONITOR hmonitor;
        public static VkSurfaceFullScreenExclusiveWin32InfoEXT New()
        {
            VkSurfaceFullScreenExclusiveWin32InfoEXT ret = new VkSurfaceFullScreenExclusiveWin32InfoEXT();
            ret.sType = VkStructureType.SurfaceFullScreenExclusiveWin32InfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fullScreenExclusiveSupported;
        public static VkSurfaceCapabilitiesFullScreenExclusiveEXT New()
        {
            VkSurfaceCapabilitiesFullScreenExclusiveEXT ret = new VkSurfaceCapabilitiesFullScreenExclusiveEXT();
            ret.sType = VkStructureType.SurfaceCapabilitiesFullScreenExclusiveEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePerformanceQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 performanceCounterQueryPools;
        public VkBool32 performanceCounterMultipleQueryPools;
        public static VkPhysicalDevicePerformanceQueryFeaturesKHR New()
        {
            VkPhysicalDevicePerformanceQueryFeaturesKHR ret = new VkPhysicalDevicePerformanceQueryFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePerformanceQueryFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePerformanceQueryPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 allowCommandBufferQueryCopies;
        public static VkPhysicalDevicePerformanceQueryPropertiesKHR New()
        {
            VkPhysicalDevicePerformanceQueryPropertiesKHR ret = new VkPhysicalDevicePerformanceQueryPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDevicePerformanceQueryPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceCounterKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterUnitKHR unit;
        public VkPerformanceCounterScopeKHR scope;
        public VkPerformanceCounterStorageKHR storage;
        public fixed byte uuid[(int)VulkanNative.UuidSize];
        public static VkPerformanceCounterKHR New()
        {
            VkPerformanceCounterKHR ret = new VkPerformanceCounterKHR();
            ret.sType = VkStructureType.PerformanceCounterKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterDescriptionFlagsKHR flags;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte category[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public static VkPerformanceCounterDescriptionKHR New()
        {
            VkPerformanceCounterDescriptionKHR ret = new VkPerformanceCounterDescriptionKHR();
            ret.sType = VkStructureType.PerformanceCounterDescriptionKHR;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolPerformanceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint queueFamilyIndex;
        public uint counterIndexCount;
        public uint* pCounterIndices;
        public static VkQueryPoolPerformanceCreateInfoKHR New()
        {
            VkQueryPoolPerformanceCreateInfoKHR ret = new VkQueryPoolPerformanceCreateInfoKHR();
            ret.sType = VkStructureType.QueryPoolPerformanceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAcquireProfilingLockInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAcquireProfilingLockFlagsKHR flags;
        public ulong timeout;
        public static VkAcquireProfilingLockInfoKHR New()
        {
            VkAcquireProfilingLockInfoKHR ret = new VkAcquireProfilingLockInfoKHR();
            ret.sType = VkStructureType.AcquireProfilingLockInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceQuerySubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint counterPassIndex;
        public static VkPerformanceQuerySubmitInfoKHR New()
        {
            VkPerformanceQuerySubmitInfoKHR ret = new VkPerformanceQuerySubmitInfoKHR();
            ret.sType = VkStructureType.PerformanceQuerySubmitInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkHeadlessSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkHeadlessSurfaceCreateInfoEXT New()
        {
            VkHeadlessSurfaceCreateInfoEXT ret = new VkHeadlessSurfaceCreateInfoEXT();
            ret.sType = VkStructureType.HeadlessSurfaceCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 coverageReductionMode;
        public static VkPhysicalDeviceCoverageReductionModeFeaturesNV New()
        {
            VkPhysicalDeviceCoverageReductionModeFeaturesNV ret = new VkPhysicalDeviceCoverageReductionModeFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCoverageReductionModeFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCoverageReductionStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkCoverageReductionModeNV coverageReductionMode;
        public static VkPipelineCoverageReductionStateCreateInfoNV New()
        {
            VkPipelineCoverageReductionStateCreateInfoNV ret = new VkPipelineCoverageReductionStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineCoverageReductionStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferMixedSamplesCombinationNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCoverageReductionModeNV coverageReductionMode;
        public VkSampleCountFlags rasterizationSamples;
        public VkSampleCountFlags depthStencilSamples;
        public VkSampleCountFlags colorSamples;
        public static VkFramebufferMixedSamplesCombinationNV New()
        {
            VkFramebufferMixedSamplesCombinationNV ret = new VkFramebufferMixedSamplesCombinationNV();
            ret.sType = VkStructureType.FramebufferMixedSamplesCombinationNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderIntegerFunctions2;
        public static VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL New()
        {
            VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL ret = new VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL();
            ret.sType = VkStructureType.PhysicalDeviceShaderIntegerFunctions2FeaturesIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceValueINTEL
    {
        public VkPerformanceValueTypeINTEL type;
        public VkPerformanceValueDataINTEL data;
    }

    public unsafe partial struct VkInitializePerformanceApiInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pUserData;
        public static VkInitializePerformanceApiInfoINTEL New()
        {
            VkInitializePerformanceApiInfoINTEL ret = new VkInitializePerformanceApiInfoINTEL();
            ret.sType = VkStructureType.InitializePerformanceApiInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
        public static VkQueryPoolPerformanceQueryCreateInfoINTEL New()
        {
            VkQueryPoolPerformanceQueryCreateInfoINTEL ret = new VkQueryPoolPerformanceQueryCreateInfoINTEL();
            ret.sType = VkStructureType.QueryPoolPerformanceQueryCreateInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolCreateInfoINTEL
    {
    }

    public unsafe partial struct VkPerformanceMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong marker;
        public static VkPerformanceMarkerInfoINTEL New()
        {
            VkPerformanceMarkerInfoINTEL ret = new VkPerformanceMarkerInfoINTEL();
            ret.sType = VkStructureType.PerformanceMarkerInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceStreamMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public uint marker;
        public static VkPerformanceStreamMarkerInfoINTEL New()
        {
            VkPerformanceStreamMarkerInfoINTEL ret = new VkPerformanceStreamMarkerInfoINTEL();
            ret.sType = VkStructureType.PerformanceStreamMarkerInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceOverrideTypeINTEL type;
        public VkBool32 enable;
        public ulong parameter;
        public static VkPerformanceOverrideInfoINTEL New()
        {
            VkPerformanceOverrideInfoINTEL ret = new VkPerformanceOverrideInfoINTEL();
            ret.sType = VkStructureType.PerformanceOverrideInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceConfigurationAcquireInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceConfigurationTypeINTEL type;
        public static VkPerformanceConfigurationAcquireInfoINTEL New()
        {
            VkPerformanceConfigurationAcquireInfoINTEL ret = new VkPerformanceConfigurationAcquireInfoINTEL();
            ret.sType = VkStructureType.PerformanceConfigurationAcquireInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderClockFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupClock;
        public VkBool32 shaderDeviceClock;
        public static VkPhysicalDeviceShaderClockFeaturesKHR New()
        {
            VkPhysicalDeviceShaderClockFeaturesKHR ret = new VkPhysicalDeviceShaderClockFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderClockFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 indexTypeUint8;
        public static VkPhysicalDeviceIndexTypeUint8FeaturesEXT New()
        {
            VkPhysicalDeviceIndexTypeUint8FeaturesEXT ret = new VkPhysicalDeviceIndexTypeUint8FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceIndexTypeUint8FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderSMCount;
        public uint shaderWarpsPerSM;
        public static VkPhysicalDeviceShaderSMBuiltinsPropertiesNV New()
        {
            VkPhysicalDeviceShaderSMBuiltinsPropertiesNV ret = new VkPhysicalDeviceShaderSMBuiltinsPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceShaderSmBuiltinsPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSMBuiltins;
        public static VkPhysicalDeviceShaderSMBuiltinsFeaturesNV New()
        {
            VkPhysicalDeviceShaderSMBuiltinsFeaturesNV ret = new VkPhysicalDeviceShaderSMBuiltinsFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceShaderSmBuiltinsFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentShaderSampleInterlock;
        public VkBool32 fragmentShaderPixelInterlock;
        public VkBool32 fragmentShaderShadingRateInterlock;
        public static VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT New()
        {
            VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT ret = new VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShaderInterlockFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 separateDepthStencilLayouts;
        public static VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures New()
        {
            VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures ret = new VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures();
            ret.sType = VkStructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
    {
    }

    public unsafe partial struct VkAttachmentReferenceStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilLayout;
        public static VkAttachmentReferenceStencilLayout New()
        {
            VkAttachmentReferenceStencilLayout ret = new VkAttachmentReferenceStencilLayout();
            ret.sType = VkStructureType.AttachmentReferenceStencilLayout;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentReferenceStencilLayoutKHR
    {
    }

    public unsafe partial struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilInitialLayout;
        public VkImageLayout stencilFinalLayout;
        public static VkAttachmentDescriptionStencilLayout New()
        {
            VkAttachmentDescriptionStencilLayout ret = new VkAttachmentDescriptionStencilLayout();
            ret.sType = VkStructureType.AttachmentDescriptionStencilLayout;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentDescriptionStencilLayoutKHR
    {
    }

    public unsafe partial struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineExecutableInfo;
        public static VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR New()
        {
            VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR ret = new VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePipelineExecutablePropertiesFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public static VkPipelineInfoKHR New()
        {
            VkPipelineInfoKHR ret = new VkPipelineInfoKHR();
            ret.sType = VkStructureType.PipelineInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineExecutablePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stages;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public uint subgroupSize;
        public static VkPipelineExecutablePropertiesKHR New()
        {
            VkPipelineExecutablePropertiesKHR ret = new VkPipelineExecutablePropertiesKHR();
            ret.sType = VkStructureType.PipelineExecutablePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineExecutableInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public uint executableIndex;
        public static VkPipelineExecutableInfoKHR New()
        {
            VkPipelineExecutableInfoKHR ret = new VkPipelineExecutableInfoKHR();
            ret.sType = VkStructureType.PipelineExecutableInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineExecutableStatisticKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public VkPipelineExecutableStatisticFormatKHR format;
        public VkPipelineExecutableStatisticValueKHR value;
        public static VkPipelineExecutableStatisticKHR New()
        {
            VkPipelineExecutableStatisticKHR ret = new VkPipelineExecutableStatisticKHR();
            ret.sType = VkStructureType.PipelineExecutableStatisticKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public VkBool32 isText;
        public UIntPtr dataSize;
        public void* pData;
        public static VkPipelineExecutableInternalRepresentationKHR New()
        {
            VkPipelineExecutableInternalRepresentationKHR ret = new VkPipelineExecutableInternalRepresentationKHR();
            ret.sType = VkStructureType.PipelineExecutableInternalRepresentationKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderDemoteToHelperInvocation;
        public static VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT New()
        {
            VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT ret = new VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 texelBufferAlignment;
        public static VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT New()
        {
            VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT ret = new VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTexelBufferAlignmentFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
        public static VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT New()
        {
            VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT ret = new VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTexelBufferAlignmentPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subgroupSizeControl;
        public VkBool32 computeFullSubgroups;
        public static VkPhysicalDeviceSubgroupSizeControlFeaturesEXT New()
        {
            VkPhysicalDeviceSubgroupSizeControlFeaturesEXT ret = new VkPhysicalDeviceSubgroupSizeControlFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceSubgroupSizeControlFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlags requiredSubgroupSizeStages;
        public static VkPhysicalDeviceSubgroupSizeControlPropertiesEXT New()
        {
            VkPhysicalDeviceSubgroupSizeControlPropertiesEXT ret = new VkPhysicalDeviceSubgroupSizeControlPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceSubgroupSizeControlPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint requiredSubgroupSize;
        public static VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT New()
        {
            VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT ret = new VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT();
            ret.sType = VkStructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong opaqueCaptureAddress;
        public static VkMemoryOpaqueCaptureAddressAllocateInfo New()
        {
            VkMemoryOpaqueCaptureAddressAllocateInfo ret = new VkMemoryOpaqueCaptureAddressAllocateInfo();
            ret.sType = VkStructureType.MemoryOpaqueCaptureAddressAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
    {
    }

    public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public static VkDeviceMemoryOpaqueCaptureAddressInfo New()
        {
            VkDeviceMemoryOpaqueCaptureAddressInfo ret = new VkDeviceMemoryOpaqueCaptureAddressInfo();
            ret.sType = VkStructureType.DeviceMemoryOpaqueCaptureAddressInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rectangularLines;
        public VkBool32 bresenhamLines;
        public VkBool32 smoothLines;
        public VkBool32 stippledRectangularLines;
        public VkBool32 stippledBresenhamLines;
        public VkBool32 stippledSmoothLines;
        public static VkPhysicalDeviceLineRasterizationFeaturesEXT New()
        {
            VkPhysicalDeviceLineRasterizationFeaturesEXT ret = new VkPhysicalDeviceLineRasterizationFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceLineRasterizationFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint lineSubPixelPrecisionBits;
        public static VkPhysicalDeviceLineRasterizationPropertiesEXT New()
        {
            VkPhysicalDeviceLineRasterizationPropertiesEXT ret = new VkPhysicalDeviceLineRasterizationPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceLineRasterizationPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkLineRasterizationModeEXT lineRasterizationMode;
        public VkBool32 stippledLineEnable;
        public uint lineStippleFactor;
        public uint16_t lineStipplePattern;
        public static VkPipelineRasterizationLineStateCreateInfoEXT New()
        {
            VkPipelineRasterizationLineStateCreateInfoEXT ret = new VkPipelineRasterizationLineStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationLineStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineCreationCacheControl;
        public static VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT New()
        {
            VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT ret = new VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePipelineCreationCacheControlFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 storageBuffer16BitAccess;
        public VkBool32 uniformAndStorageBuffer16BitAccess;
        public VkBool32 storagePushConstant16;
        public VkBool32 storageInputOutput16;
        public VkBool32 multiview;
        public VkBool32 multiviewGeometryShader;
        public VkBool32 multiviewTessellationShader;
        public VkBool32 variablePointersStorageBuffer;
        public VkBool32 variablePointers;
        public VkBool32 protectedMemory;
        public VkBool32 samplerYcbcrConversion;
        public VkBool32 shaderDrawParameters;
        public static VkPhysicalDeviceVulkan11Features New()
        {
            VkPhysicalDeviceVulkan11Features ret = new VkPhysicalDeviceVulkan11Features();
            ret.sType = VkStructureType.PhysicalDeviceVulkan11Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan11Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[(int)VulkanNative.UuidSize];
        public fixed byte driverUUID[(int)VulkanNative.UuidSize];
        public fixed byte deviceLUID[(int)VulkanNative.LuidSize];
        public uint deviceNodeMask;
        public VkBool32 deviceLUIDValid;
        public uint subgroupSize;
        public VkShaderStageFlags subgroupSupportedStages;
        public VkSubgroupFeatureFlags subgroupSupportedOperations;
        public VkBool32 subgroupQuadOperationsInAllStages;
        public VkPointClippingBehavior pointClippingBehavior;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public VkBool32 protectedNoFault;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        public static VkPhysicalDeviceVulkan11Properties New()
        {
            VkPhysicalDeviceVulkan11Properties ret = new VkPhysicalDeviceVulkan11Properties();
            ret.sType = VkStructureType.PhysicalDeviceVulkan11Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 samplerMirrorClampToEdge;
        public VkBool32 drawIndirectCount;
        public VkBool32 storageBuffer8BitAccess;
        public VkBool32 uniformAndStorageBuffer8BitAccess;
        public VkBool32 storagePushConstant8;
        public VkBool32 shaderBufferInt64Atomics;
        public VkBool32 shaderSharedInt64Atomics;
        public VkBool32 shaderFloat16;
        public VkBool32 shaderInt8;
        public VkBool32 descriptorIndexing;
        public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32 shaderSampledImageArrayNonUniformIndexing;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageImageArrayNonUniformIndexing;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUpdateUnusedWhilePending;
        public VkBool32 descriptorBindingPartiallyBound;
        public VkBool32 descriptorBindingVariableDescriptorCount;
        public VkBool32 runtimeDescriptorArray;
        public VkBool32 samplerFilterMinmax;
        public VkBool32 scalarBlockLayout;
        public VkBool32 imagelessFramebuffer;
        public VkBool32 uniformBufferStandardLayout;
        public VkBool32 shaderSubgroupExtendedTypes;
        public VkBool32 separateDepthStencilLayouts;
        public VkBool32 hostQueryReset;
        public VkBool32 timelineSemaphore;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
        public VkBool32 vulkanMemoryModel;
        public VkBool32 vulkanMemoryModelDeviceScope;
        public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
        public VkBool32 shaderOutputViewportIndex;
        public VkBool32 shaderOutputLayer;
        public VkBool32 subgroupBroadcastDynamicId;
        public static VkPhysicalDeviceVulkan12Features New()
        {
            VkPhysicalDeviceVulkan12Features ret = new VkPhysicalDeviceVulkan12Features();
            ret.sType = VkStructureType.PhysicalDeviceVulkan12Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan12Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDriverId driverID;
        public fixed byte driverName[(int)VulkanNative.MaxDriverNameSize];
        public fixed byte driverInfo[(int)VulkanNative.MaxDriverInfoSize];
        public VkConformanceVersion conformanceVersion;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
        public VkBool32 shaderDenormPreserveFloat16;
        public VkBool32 shaderDenormPreserveFloat32;
        public VkBool32 shaderDenormPreserveFloat64;
        public VkBool32 shaderDenormFlushToZeroFloat16;
        public VkBool32 shaderDenormFlushToZeroFloat32;
        public VkBool32 shaderDenormFlushToZeroFloat64;
        public VkBool32 shaderRoundingModeRTEFloat16;
        public VkBool32 shaderRoundingModeRTEFloat32;
        public VkBool32 shaderRoundingModeRTEFloat64;
        public VkBool32 shaderRoundingModeRTZFloat16;
        public VkBool32 shaderRoundingModeRTZFloat32;
        public VkBool32 shaderRoundingModeRTZFloat64;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
        public VkBool32 robustBufferAccessUpdateAfterBind;
        public VkBool32 quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public VkResolveModeFlags supportedDepthResolveModes;
        public VkResolveModeFlags supportedStencilResolveModes;
        public VkBool32 independentResolveNone;
        public VkBool32 independentResolve;
        public VkBool32 filterMinmaxSingleComponentFormats;
        public VkBool32 filterMinmaxImageComponentMapping;
        public ulong maxTimelineSemaphoreValueDifference;
        public VkSampleCountFlags framebufferIntegerColorSampleCounts;
        public static VkPhysicalDeviceVulkan12Properties New()
        {
            VkPhysicalDeviceVulkan12Properties ret = new VkPhysicalDeviceVulkan12Properties();
            ret.sType = VkStructureType.PhysicalDeviceVulkan12Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCompilerControlCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
        public static VkPipelineCompilerControlCreateInfoAMD New()
        {
            VkPipelineCompilerControlCreateInfoAMD ret = new VkPipelineCompilerControlCreateInfoAMD();
            ret.sType = VkStructureType.PipelineCompilerControlCreateInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceCoherentMemory;
        public static VkPhysicalDeviceCoherentMemoryFeaturesAMD New()
        {
            VkPhysicalDeviceCoherentMemoryFeaturesAMD ret = new VkPhysicalDeviceCoherentMemoryFeaturesAMD();
            ret.sType = VkStructureType.PhysicalDeviceCoherentMemoryFeaturesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceToolPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[(int)VulkanNative.MaxExtensionNameSize];
        public fixed byte version[(int)VulkanNative.MaxExtensionNameSize];
        public VkToolPurposeFlagsEXT purposes;
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte layer[(int)VulkanNative.MaxExtensionNameSize];
        public static VkPhysicalDeviceToolPropertiesEXT New()
        {
            VkPhysicalDeviceToolPropertiesEXT ret = new VkPhysicalDeviceToolPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceToolPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerCustomBorderColorCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkClearColorValue customBorderColor;
        public VkFormat format;
        public static VkSamplerCustomBorderColorCreateInfoEXT New()
        {
            VkSamplerCustomBorderColorCreateInfoEXT ret = new VkSamplerCustomBorderColorCreateInfoEXT();
            ret.sType = VkStructureType.SamplerCustomBorderColorCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxCustomBorderColorSamplers;
        public static VkPhysicalDeviceCustomBorderColorPropertiesEXT New()
        {
            VkPhysicalDeviceCustomBorderColorPropertiesEXT ret = new VkPhysicalDeviceCustomBorderColorPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceCustomBorderColorPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 customBorderColors;
        public VkBool32 customBorderColorWithoutFormat;
        public static VkPhysicalDeviceCustomBorderColorFeaturesEXT New()
        {
            VkPhysicalDeviceCustomBorderColorFeaturesEXT ret = new VkPhysicalDeviceCustomBorderColorFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceCustomBorderColorFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public uint maxVertex;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public VkDeviceOrHostAddressConstKHR transformData;
        public static VkAccelerationStructureGeometryTrianglesDataKHR New()
        {
            VkAccelerationStructureGeometryTrianglesDataKHR ret = new VkAccelerationStructureGeometryTrianglesDataKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryTrianglesDataKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryAabbsDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR data;
        public ulong stride;
        public static VkAccelerationStructureGeometryAabbsDataKHR New()
        {
            VkAccelerationStructureGeometryAabbsDataKHR ret = new VkAccelerationStructureGeometryAabbsDataKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryAabbsDataKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryInstancesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 arrayOfPointers;
        public VkDeviceOrHostAddressConstKHR data;
        public static VkAccelerationStructureGeometryInstancesDataKHR New()
        {
            VkAccelerationStructureGeometryInstancesDataKHR ret = new VkAccelerationStructureGeometryInstancesDataKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryInstancesDataKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkAccelerationStructureGeometryDataKHR geometry;
        public VkGeometryFlagsKHR flags;
        public static VkAccelerationStructureGeometryKHR New()
        {
            VkAccelerationStructureGeometryKHR ret = new VkAccelerationStructureGeometryKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagsKHR flags;
        public VkBuildAccelerationStructureModeKHR mode;
        public VkAccelerationStructureKHR srcAccelerationStructure;
        public VkAccelerationStructureKHR dstAccelerationStructure;
        public uint geometryCount;
        public VkAccelerationStructureGeometryKHR* pGeometries;
        public VkAccelerationStructureGeometryKHR** ppGeometries;
        public VkDeviceOrHostAddressKHR scratchData;
        public static VkAccelerationStructureBuildGeometryInfoKHR New()
        {
            VkAccelerationStructureBuildGeometryInfoKHR ret = new VkAccelerationStructureBuildGeometryInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureBuildGeometryInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureBuildRangeInfoKHR
    {
        public uint primitiveCount;
        public uint primitiveOffset;
        public uint firstVertex;
        public uint transformOffset;
    }

    public unsafe partial struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureCreateFlagsKHR createFlags;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkAccelerationStructureTypeKHR type;
        public ulong deviceAddress;
        public static VkAccelerationStructureCreateInfoKHR New()
        {
            VkAccelerationStructureCreateInfoKHR ret = new VkAccelerationStructureCreateInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAabbPositionsKHR
    {
        public float minX;
        public float minY;
        public float minZ;
        public float maxX;
        public float maxY;
        public float maxZ;
    }

    public unsafe partial struct VkAabbPositionsNV
    {
    }

    public unsafe partial struct VkTransformMatrixKHR
    {
        public float matrix_0;
        public float matrix_1;
        public float matrix_2;
    }

    public unsafe partial struct VkTransformMatrixNV
    {
    }

    public unsafe partial struct VkAccelerationStructureInstanceKHR
    {
        public VkTransformMatrixKHR transform;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagsKHR flags;
        public ulong accelerationStructureReference;
    }

    public unsafe partial struct VkAccelerationStructureInstanceNV
    {
    }

    public unsafe partial struct VkAccelerationStructureDeviceAddressInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        public static VkAccelerationStructureDeviceAddressInfoKHR New()
        {
            VkAccelerationStructureDeviceAddressInfoKHR ret = new VkAccelerationStructureDeviceAddressInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureDeviceAddressInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureVersionInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pVersionData;
        public static VkAccelerationStructureVersionInfoKHR New()
        {
            VkAccelerationStructureVersionInfoKHR ret = new VkAccelerationStructureVersionInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureVersionInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyAccelerationStructureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public static VkCopyAccelerationStructureInfoKHR New()
        {
            VkCopyAccelerationStructureInfoKHR ret = new VkCopyAccelerationStructureInfoKHR();
            ret.sType = VkStructureType.CopyAccelerationStructureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyAccelerationStructureToMemoryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public static VkCopyAccelerationStructureToMemoryInfoKHR New()
        {
            VkCopyAccelerationStructureToMemoryInfoKHR ret = new VkCopyAccelerationStructureToMemoryInfoKHR();
            ret.sType = VkStructureType.CopyAccelerationStructureToMemoryInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyMemoryToAccelerationStructureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public static VkCopyMemoryToAccelerationStructureInfoKHR New()
        {
            VkCopyMemoryToAccelerationStructureInfoKHR ret = new VkCopyMemoryToAccelerationStructureInfoKHR();
            ret.sType = VkStructureType.CopyMemoryToAccelerationStructureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingPipelineInterfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPipelineRayPayloadSize;
        public uint maxPipelineRayHitAttributeSize;
        public static VkRayTracingPipelineInterfaceCreateInfoKHR New()
        {
            VkRayTracingPipelineInterfaceCreateInfoKHR ret = new VkRayTracingPipelineInterfaceCreateInfoKHR();
            ret.sType = VkStructureType.RayTracingPipelineInterfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineLibraryCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint libraryCount;
        public VkPipeline* pLibraries;
        public static VkPipelineLibraryCreateInfoKHR New()
        {
            VkPipelineLibraryCreateInfoKHR ret = new VkPipelineLibraryCreateInfoKHR();
            ret.sType = VkStructureType.PipelineLibraryCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedDynamicState;
        public static VkPhysicalDeviceExtendedDynamicStateFeaturesEXT New()
        {
            VkPhysicalDeviceExtendedDynamicStateFeaturesEXT ret = new VkPhysicalDeviceExtendedDynamicStateFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceExtendedDynamicStateFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public static VkRenderPassTransformBeginInfoQCOM New()
        {
            VkRenderPassTransformBeginInfoQCOM ret = new VkRenderPassTransformBeginInfoQCOM();
            ret.sType = VkStructureType.RenderPassTransformBeginInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkCopyCommandTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public static VkCopyCommandTransformInfoQCOM New()
        {
            VkCopyCommandTransformInfoQCOM ret = new VkCopyCommandTransformInfoQCOM();
            ret.sType = VkStructureType.CopyCommandTransformInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public VkRect2D renderArea;
        public static VkCommandBufferInheritanceRenderPassTransformInfoQCOM New()
        {
            VkCommandBufferInheritanceRenderPassTransformInfoQCOM ret = new VkCommandBufferInheritanceRenderPassTransformInfoQCOM();
            ret.sType = VkStructureType.CommandBufferInheritanceRenderPassTransformInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 diagnosticsConfig;
        public static VkPhysicalDeviceDiagnosticsConfigFeaturesNV New()
        {
            VkPhysicalDeviceDiagnosticsConfigFeaturesNV ret = new VkPhysicalDeviceDiagnosticsConfigFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDiagnosticsConfigFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceDiagnosticsConfigFlagsNV flags;
        public static VkDeviceDiagnosticsConfigCreateInfoNV New()
        {
            VkDeviceDiagnosticsConfigCreateInfoNV ret = new VkDeviceDiagnosticsConfigCreateInfoNV();
            ret.sType = VkStructureType.DeviceDiagnosticsConfigCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustBufferAccess2;
        public VkBool32 robustImageAccess2;
        public VkBool32 nullDescriptor;
        public static VkPhysicalDeviceRobustness2FeaturesEXT New()
        {
            VkPhysicalDeviceRobustness2FeaturesEXT ret = new VkPhysicalDeviceRobustness2FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceRobustness2FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong robustStorageBufferAccessSizeAlignment;
        public ulong robustUniformBufferAccessSizeAlignment;
        public static VkPhysicalDeviceRobustness2PropertiesEXT New()
        {
            VkPhysicalDeviceRobustness2PropertiesEXT ret = new VkPhysicalDeviceRobustness2PropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceRobustness2PropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageRobustnessFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustImageAccess;
        public static VkPhysicalDeviceImageRobustnessFeaturesEXT New()
        {
            VkPhysicalDeviceImageRobustnessFeaturesEXT ret = new VkPhysicalDeviceImageRobustnessFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageRobustnessFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 constantAlphaColorBlendFactors;
        public VkBool32 events;
        public VkBool32 imageViewFormatReinterpretation;
        public VkBool32 imageViewFormatSwizzle;
        public VkBool32 imageView2DOn3DImage;
        public VkBool32 multisampleArrayImage;
        public VkBool32 mutableComparisonSamplers;
        public VkBool32 pointPolygons;
        public VkBool32 samplerMipLodBias;
        public VkBool32 separateStencilMaskRef;
        public VkBool32 shaderSampleRateInterpolationFunctions;
        public VkBool32 tessellationIsolines;
        public VkBool32 tessellationPointMode;
        public VkBool32 triangleFans;
        public VkBool32 vertexAttributeAccessBeyondStride;
        public static VkPhysicalDevicePortabilitySubsetFeaturesKHR New()
        {
            VkPhysicalDevicePortabilitySubsetFeaturesKHR ret = new VkPhysicalDevicePortabilitySubsetFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePortabilitySubsetFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePortabilitySubsetPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minVertexInputBindingStrideAlignment;
        public static VkPhysicalDevicePortabilitySubsetPropertiesKHR New()
        {
            VkPhysicalDevicePortabilitySubsetPropertiesKHR ret = new VkPhysicalDevicePortabilitySubsetPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDevicePortabilitySubsetPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 formatA4R4G4B4;
        public VkBool32 formatA4B4G4R4;
        public static VkPhysicalDevice4444FormatsFeaturesEXT New()
        {
            VkPhysicalDevice4444FormatsFeaturesEXT ret = new VkPhysicalDevice4444FormatsFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevice4444FormatsFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCopy2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
        public static VkBufferCopy2KHR New()
        {
            VkBufferCopy2KHR ret = new VkBufferCopy2KHR();
            ret.sType = VkStructureType.BufferCopy2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkImageCopy2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public static VkImageCopy2KHR New()
        {
            VkImageCopy2KHR ret = new VkImageCopy2KHR();
            ret.sType = VkStructureType.ImageCopy2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkImageBlit2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffsets_0;
        public VkOffset3D srcOffsets_1;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffsets_0;
        public VkOffset3D dstOffsets_1;
        public static VkImageBlit2KHR New()
        {
            VkImageBlit2KHR ret = new VkImageBlit2KHR();
            ret.sType = VkStructureType.ImageBlit2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkBufferImageCopy2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public static VkBufferImageCopy2KHR New()
        {
            VkBufferImageCopy2KHR ret = new VkBufferImageCopy2KHR();
            ret.sType = VkStructureType.BufferImageCopy2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkImageResolve2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public static VkImageResolve2KHR New()
        {
            VkImageResolve2KHR ret = new VkImageResolve2KHR();
            ret.sType = VkStructureType.ImageResolve2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyBufferInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferCopy2KHR* pRegions;
        public static VkCopyBufferInfo2KHR New()
        {
            VkCopyBufferInfo2KHR ret = new VkCopyBufferInfo2KHR();
            ret.sType = VkStructureType.CopyBufferInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyImageInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2KHR* pRegions;
        public static VkCopyImageInfo2KHR New()
        {
            VkCopyImageInfo2KHR ret = new VkCopyImageInfo2KHR();
            ret.sType = VkStructureType.CopyImageInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkBlitImageInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageBlit2KHR* pRegions;
        public VkFilter filter;
        public static VkBlitImageInfo2KHR New()
        {
            VkBlitImageInfo2KHR ret = new VkBlitImageInfo2KHR();
            ret.sType = VkStructureType.BlitImageInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyBufferToImageInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkBufferImageCopy2KHR* pRegions;
        public static VkCopyBufferToImageInfo2KHR New()
        {
            VkCopyBufferToImageInfo2KHR ret = new VkCopyBufferToImageInfo2KHR();
            ret.sType = VkStructureType.CopyBufferToImageInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyImageToBufferInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferImageCopy2KHR* pRegions;
        public static VkCopyImageToBufferInfo2KHR New()
        {
            VkCopyImageToBufferInfo2KHR ret = new VkCopyImageToBufferInfo2KHR();
            ret.sType = VkStructureType.CopyImageToBufferInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkResolveImageInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageResolve2KHR* pRegions;
        public static VkResolveImageInfo2KHR New()
        {
            VkResolveImageInfo2KHR ret = new VkResolveImageInfo2KHR();
            ret.sType = VkStructureType.ResolveImageInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderImageInt64Atomics;
        public VkBool32 sparseImageInt64Atomics;
        public static VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT New()
        {
            VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT ret = new VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderImageAtomicInt64FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentReference2* pFragmentShadingRateAttachment;
        public VkExtent2D shadingRateAttachmentTexelSize;
        public static VkFragmentShadingRateAttachmentInfoKHR New()
        {
            VkFragmentShadingRateAttachmentInfoKHR ret = new VkFragmentShadingRateAttachmentInfoKHR();
            ret.sType = VkStructureType.FragmentShadingRateAttachmentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D fragmentSize;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
        public static VkPipelineFragmentShadingRateStateCreateInfoKHR New()
        {
            VkPipelineFragmentShadingRateStateCreateInfoKHR ret = new VkPipelineFragmentShadingRateStateCreateInfoKHR();
            ret.sType = VkStructureType.PipelineFragmentShadingRateStateCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineFragmentShadingRate;
        public VkBool32 primitiveFragmentShadingRate;
        public VkBool32 attachmentFragmentShadingRate;
        public static VkPhysicalDeviceFragmentShadingRateFeaturesKHR New()
        {
            VkPhysicalDeviceFragmentShadingRateFeaturesKHR ret = new VkPhysicalDeviceFragmentShadingRateFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
        public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
        public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
        public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
        public VkBool32 layeredShadingRateAttachments;
        public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
        public VkExtent2D maxFragmentSize;
        public uint maxFragmentSizeAspectRatio;
        public uint maxFragmentShadingRateCoverageSamples;
        public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;
        public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
        public VkBool32 fragmentShadingRateWithSampleMask;
        public VkBool32 fragmentShadingRateWithShaderSampleMask;
        public VkBool32 fragmentShadingRateWithConservativeRasterization;
        public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
        public VkBool32 fragmentShadingRateWithCustomSampleLocations;
        public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
        public static VkPhysicalDeviceFragmentShadingRatePropertiesKHR New()
        {
            VkPhysicalDeviceFragmentShadingRatePropertiesKHR ret = new VkPhysicalDeviceFragmentShadingRatePropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRatePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleCounts;
        public VkExtent2D fragmentSize;
        public static VkPhysicalDeviceFragmentShadingRateKHR New()
        {
            VkPhysicalDeviceFragmentShadingRateKHR ret = new VkPhysicalDeviceFragmentShadingRateKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderTerminateInvocation;
        public static VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR New()
        {
            VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR ret = new VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderTerminateInvocationFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentShadingRateEnums;
        public VkBool32 supersampleFragmentShadingRates;
        public VkBool32 noInvocationFragmentShadingRates;
        public static VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV New()
        {
            VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV ret = new VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags maxFragmentShadingRateInvocationCount;
        public static VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV New()
        {
            VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV ret = new VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFragmentShadingRateTypeNV shadingRateType;
        public VkFragmentShadingRateNV shadingRate;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
        public static VkPipelineFragmentShadingRateEnumStateCreateInfoNV New()
        {
            VkPipelineFragmentShadingRateEnumStateCreateInfoNV ret = new VkPipelineFragmentShadingRateEnumStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineFragmentShadingRateEnumStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureBuildSizesInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong accelerationStructureSize;
        public ulong updateScratchSize;
        public ulong buildScratchSize;
        public static VkAccelerationStructureBuildSizesInfoKHR New()
        {
            VkAccelerationStructureBuildSizesInfoKHR ret = new VkAccelerationStructureBuildSizesInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureBuildSizesInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 mutableDescriptorType;
        public static VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE New()
        {
            VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE ret = new VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE();
            ret.sType = VkStructureType.PhysicalDeviceMutableDescriptorTypeFeaturesValve;
            return ret;
        }
    }

    public unsafe partial struct VkMutableDescriptorTypeListVALVE
    {
        public uint descriptorTypeCount;
        public VkDescriptorType* pDescriptorTypes;
    }

    public unsafe partial struct VkMutableDescriptorTypeCreateInfoVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint mutableDescriptorTypeListCount;
        public VkMutableDescriptorTypeListVALVE* pMutableDescriptorTypeLists;
        public static VkMutableDescriptorTypeCreateInfoVALVE New()
        {
            VkMutableDescriptorTypeCreateInfoVALVE ret = new VkMutableDescriptorTypeCreateInfoVALVE();
            ret.sType = VkStructureType.MutableDescriptorTypeCreateInfoValve;
            return ret;
        }
    }
}
