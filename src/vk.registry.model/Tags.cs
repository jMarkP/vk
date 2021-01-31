using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace vk.registry.model
{
    [DebuggerDisplay("{_elements.Length} tags. {Comment}")]
    public class Tags : WrappedEnumerable<Tag>, IElementReader
    {
        public string Comment { get; private set; }

        public void ReadFrom(XElement element)
        {
            _elements = element.ReadArray<Tag>("tag");
            Comment = element.StringAttribute("comment");
        }
    }

    [DebuggerDisplay("{_elements.Length} types. {Comment}")]
    public class Types : WrappedEnumerable<VulkanType>, IElementReader
    {
        public string Comment { get; private set; }

        public void ReadFrom(XElement element)
        {
            _elements = element.ReadArray<VulkanType>("type");
            Comment = element.StringAttribute("comment");
        }
    }

    [DebuggerDisplay("Name: {Name}, Category: {Category}")]
    public class VulkanType : IElementReader
    {
        public string Requires { get; private set; }
        public string Name { get; private set; }
        public string Alias { get; private set; }
        public string SpecializedForApi { get; private set; }
        public Category? Category { get; private set; }
        public string Comment { get; private set; }
        public string Parent { get; private set; }
        public bool ReturnedOnly { get; private set; }
        public string StructExtends { get; private set; }
        public bool AllowDuplicate { get; private set; }
        public string CorrespondingObjectTypeEnum { get; private set; }

        public void ReadFrom(XElement element)
        {
            var descendants = element.DescendantNodes().ToArray();
            Category = element.OptionalEnumAttribute<Category>("category");
            Name = element.StringAttribute("name")
                ?? descendants
                    .OfType<XElement>()
                    .Where(el => el.Name == "name")
                    .FirstOrDefault()?
                    .Value;


            // DescendantNodes()
            // #define XText
            // <name>VK_MAKE_VERSION</name> XElement
            // VK_MAKE_VERSION XText
            // {(major, minor, patch) \   ((((uint32_t)(major)) ... XText
        }
    }

    public enum Category
    {
        Basetype,
        BitMask,
        Define,
        Enum,
        FuncPointer,
        Group,
        Handle,
        Include,
        Struct,
        Union
    }
}
