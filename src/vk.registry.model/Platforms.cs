using System.Diagnostics;
using System.Xml.Linq;

namespace vk.registry.model
{
    [DebuggerDisplay("{_elements.Length} platforms. {Comment}")]
    public class Platforms : WrappedEnumerable<Platform>, IElementReader
    {
        public string Comment { get; private set; }

        public void ReadFrom(XElement element)
        {
            _elements = element.ReadArray<Platform>("tag");
            Comment = element.StringAttribute("comment");
        }
    }
}
