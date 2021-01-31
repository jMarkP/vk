using System.Diagnostics;
using System.Xml.Linq;

namespace vk.registry.model
{
    [DebuggerDisplay("Name: {Name}, Author: {Author}, Contact: {Contact}")]
    public class Tag : IElementReader
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Contact { get; private set; }

        public void ReadFrom(XElement element)
        {
            Name = element.StringAttribute("name");
            Author = element.StringAttribute("author");
            Contact = element.StringAttribute("contact");
        }
    }
}
