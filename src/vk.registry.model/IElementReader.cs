using System.Xml.Linq;

namespace vk.registry.model
{
    internal interface IElementReader
    {
        void ReadFrom(XElement element);
    }
}
