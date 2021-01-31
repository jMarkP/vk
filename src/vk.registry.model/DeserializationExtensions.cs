using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace vk.registry.model
{
    public static class DeserializationExtensions
    {
        public static string StringAttribute(this XElement element, XName name)
        {
            return element.Attribute(name)?.Value;
        }

        public static TEnum EnumAttribute<TEnum>(this XElement element, XName name)
            where TEnum : struct
        {
            string value = element.StringAttribute(name);
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException($"Required attribute {name} not found");
            }
            return Enum.Parse<TEnum>(value, true);
        }

        public static TEnum? OptionalEnumAttribute<TEnum>(this XElement element, XName name)
            where TEnum : struct
        {
            string value = element.StringAttribute(name);
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            return Enum.Parse<TEnum>(value, true);
        }

        internal static T[] ReadArray<T>(this XElement element, string xPath)
            where T: IElementReader, new()
        {
            return element
                .XPathSelectElements(xPath)
                .Select(e =>
                {
                    var r = new T();
                    r.ReadFrom(e);
                    return r;
                })
                .ToArray();
        }

        internal static T Read<T>(this XElement parent, string name)
            where T: IElementReader, new()
        {
            var element = parent.XPathSelectElement(name);
            if (element == null) return default;
            var result = new T();
            result.ReadFrom(element);
            return result;
        }
    }
}
