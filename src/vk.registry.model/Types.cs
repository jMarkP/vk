using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace vk.registry.model
{
    [DebuggerDisplay("{_elements.Length} types. {Comment}")]
    public class Types : WrappedEnumerable<VulkanType>, IElementReader
    {
        public string Comment { get; private set; }

        public void ReadFrom(XElement element)
        {
            _elements = ReadTypes(element);
            Comment = element.StringAttribute("comment");
        }

        private VulkanType[] ReadTypes(XElement parent)
        {
            return parent
                .XPathSelectElements("type")
                .Select(e =>
                {
                    var category = VulkanType.GetCategory(e);
                    switch (category)
                    {
                        case VulkanTypeCategory.Struct:
                        case VulkanTypeCategory.Union:
                            var result = new VulkanTypeStructOrUnion();
                            result.ReadFrom(e);
                            return result;
                        default:
                            return null;
                    }
                })
                .ToArray();
       
        }
    }
}
