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
            _elements = element.ReadArray<VulkanType>("type");
            Comment = element.StringAttribute("comment");
        }

        private VulkanType[] ReadTypes(XElement parent)
        {
            return parent
                .XPathSelectElements("type")
                .Select(e =>
                {
                    var r = new T();
                    r.ReadFrom(e);
                    return r;
                })
                .ToArray();
       
        }
    }
}
