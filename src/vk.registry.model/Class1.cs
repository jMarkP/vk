using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace vk.registry.model
{
    public class Registry
    {
        private Registry(Platforms platforms, Tags tags)
        {
            Platforms = platforms;
            Tags = tags;
        }

        public Platforms Platforms { get; }
        public Tags Tags { get; }

        public static Registry ReadFrom(string xmlString)
        {
            var xDocument = XDocument.Parse(xmlString);
            var registryElement = xDocument.XPathSelectElement("registry");
            return new Registry(
                Platforms.R.Read(registryElement, "platforms"),
                Tags.R.Read(registryElement, "tags")
            );
        }
    }

    public class RegistryElement
    {
        public Read(XElement element)
        {

        }

        protected RegistryElement() { }
    }

    [DebuggerDisplay("{_platforms.Length} platforms. {Comment}")]
    public class Platforms : RegistryElement, IEnumerable<Platforms.Platform>
    {
        private Platform[] _platforms;

        public string Comment { get; }

        public Platforms(XElement element)
            : this()
        {
            var platforms = Platform.R.ReadArray(element, "tag");
            var comment = element.StringAttribute("comment");
            return new Platforms(platforms, comment);
        }

        private Platforms(Platform[] platforms, string comment)
        {
            _platforms = platforms;
            Comment = comment;
        }

        public IEnumerator<Platform> GetEnumerator()
        {
            return ((IEnumerable<Platform>)_platforms).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _platforms.GetEnumerator();
        }

        public class Reader : IReader<Platforms>
        {
            public Platforms ReadFrom(XElement element)
            {
                
            }
        }
        public static Reader R { get; } = new Reader();


        [DebuggerDisplay("Name: {Name}, Protect: {Protect}, Comment: {Comment}")]
        public class Platform
        {
            public string Name { get; }
            public string Protect { get; }
            public string Comment { get; }

            public Platform(string name, string protect, string comment)
            {
                Name = name;
                Protect = protect;
                Comment = comment;
            }

            public class Reader : IReader<Platform>
            {
                public Platform ReadFrom(XElement element)
                {
                    return new Platform(
                        element.StringAttribute("name"),
                        element.StringAttribute("protect"),
                        element.StringAttribute("comment")
                        );
                }
            }
            public static Reader R { get; } = new Reader();
        }
    }

    [DebuggerDisplay("{_tags.Length} tags. {Comment}")]
    public class Tags : IEnumerable<Tags.Tag>
    {
        private Tag[] _tags;

        public string Comment { get; }

        private Tags(Tag[] tags, string comment)
        {
            _tags = tags;
            Comment = comment;
        }

        public IEnumerator<Tag> GetEnumerator()
        {
            return ((IEnumerable<Tag>)_tags).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _tags.GetEnumerator();
        }

        public class Reader : IReader<Tags>
        {
            public Tags ReadFrom(XElement element)
            {
                var tags = Tag.R.ReadArray(element, "platform");
                var comment = element.StringAttribute("comment");
                return new Tags(tags, comment);
            }
        }
        public static Reader R { get; } = new Reader();


        [DebuggerDisplay("Name: {Name}, Author: {Author}, Contact: {Contact}")]
        public class Tag
        {
            public string Name { get; }
            public string Author { get; }
            public string Contact { get; }

            public Tag(string name, string author, string contact)
            {
                Name = name;
                Author = author;
                Contact = contact;
            }

            public class Reader : IReader<Tag>
            {
                public Tag ReadFrom(XElement element)
                {
                    return new Tag(
                        element.StringAttribute("name"),
                        element.StringAttribute("author"),
                        element.StringAttribute("contact")
                        );
                }
            }
            public static Reader R { get; } = new Reader();
        }
    }

    internal static class ListReader
    {
        public static TList Read<TList, TElement>(XElement parent,
            string listName, string elementName)
            where TList : IEnumerable<TElement>
        {

        }
    }


    public interface IReader<out T>
    {
        T ReadFrom(XElement element);
    }

    public static class DeserializationExtensions
    {
        public static string StringAttribute(this XElement element, XName name)
        {
            return element.Attribute(name)?.Value;
        }

        public static T[] ReadArray<T>(this IReader<T> reader, XElement element, string xPath)
        {
            return element
                .XPathSelectElements(xPath)
                .Select(reader.ReadFrom)
                .ToArray();
        }

        public static T[] ReadArray<T>(this XElement element, string xPath)
            where T: RegistryElement, new()
        {
            return element
                .XPathSelectElements(xPath)
                .Select(e => new T(e))
                .ToArray();
        }

        public static T Read<T>(this IReader<T> reader, XElement parent, string name)
            where T: class
        {
            var element = parent.XPathSelectElement(name);
            if (element == null) return null;
            return reader.ReadFrom(element);
        }
    }
}
