using System.Diagnostics;
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
}
