using System.Xml.Linq;
using System.Xml.XPath;

namespace vk.registry.model
{
    public class Registry
    {
        private Registry(Platforms platforms, Tags tags, Types types)
        {
            Platforms = platforms;
            Tags = tags;
            Types = types;
        }

        public Platforms Platforms { get; }
        public Tags Tags { get; }
        public Types Types { get; }

        public static Registry ReadFrom(string xmlString)
        {
            var xDocument = XDocument.Parse(xmlString);
            var registryElement = xDocument.XPathSelectElement("registry");
            return new Registry(
                registryElement.Read<Platforms>("platforms"),
                registryElement.Read<Tags>("tags"),
                registryElement.Read<Types>("types")
            );
        }
    }
}
