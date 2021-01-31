using System.Diagnostics;
using System.Xml.Linq;

namespace vk.registry.model
{
    [DebuggerDisplay("Name: {Name}, Protect: {Protect}, Comment: {Comment}")]
    public class Platform : IElementReader
    {
        public string Name { get; private set; }
        public string Protect { get; private set; }
        public string Comment { get; private set; }

        public void ReadFrom(XElement element)
        {
            Name = element.StringAttribute("name");
            Protect = element.StringAttribute("protect");
            Comment = element.StringAttribute("comment");
        }
    }
}
