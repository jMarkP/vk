using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace vk.registry.model
{
    [DebuggerDisplay("Name: {Name}, Category: {Category}")]
    public class VulkanType : IElementReader
    {
        public string Requires { get; private set; }
        public string Name { get; private set; }
        public string Alias { get; private set; }
        public string SpecializedForApi { get; private set; }
        public VulkanTypeCategory? Category { get; private set; }
        public string Comment { get; private set; }
        public string Parent { get; private set; }
        public bool ReturnedOnly { get; private set; }
        public string StructExtends { get; private set; }
        public bool AllowDuplicate { get; private set; }
        public string CorrespondingObjectTypeEnum { get; private set; }

        public virtual void ReadFrom(XElement element)
        {
            var descendants = element.DescendantNodes().ToArray();
            Category = element.OptionalEnumAttribute<VulkanTypeCategory>("category");
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

        public static VulkanTypeCategory? GetCategory(XElement element)
        {
            return element.OptionalEnumAttribute<VulkanTypeCategory>("category");
        }
    }

    public class VulkanTypeEnum : VulkanType
    {
        // Contains a name that matches an 'enum' tag later on
    }

    public class VulkanTypeStructOrUnion : VulkanType
    {
        public Member[] Members { get; private set; }

        public override void ReadFrom(XElement element)
        {
            base.ReadFrom(element);
            Members = element
                .XPathSelectElements("member")
                .Select(e => new Member(e))
                .ToArray();
        }

        public class Member
        {
            public string[] Values { get; private set; }
            public string Len { get; private set; }
            public string AltLen { get; private set; }
            public bool ExternSync { get; private set; }
            public bool Optional { get; private set; }
            public string Selector { get; private set; }
            public string Selection { get; private set; }
            public bool NoAutoValidity { get; private set; }

            public string TypeName { get; private set; }
            public string Name { get; private set; }
            public string Enum { get; private set; }
            public string Comment { get; private set; }

            public Member(XElement element)
            {
                Values = (element.StringAttribute("values") ?? "").Split(",", StringSplitOptions.RemoveEmptyEntries);
                Len = element.StringAttribute("len");
                AltLen = element.StringAttribute("altlen");
            }
        }
    }
}
