using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Vk.Generator
{
    public class EnumDefinition
    {
        public string Name { get; }
        public EnumType Type { get; }
        public EnumValue[] Values { get; set;  }

        public EnumDefinition(string name, EnumType type, EnumValue[] values)
        {
            Require.NotNullOrEmpty(name);
            Require.NotNull(values);

            Name = name;
            Type = type;
            Values = values;
        }

        public static EnumDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            EnumType type;
            var typeAttr = xe.Attribute("type");
            if (typeAttr != null)
            {
                string typeString = xe.Attribute("type").Value;
                type = (EnumType)Enum.Parse(typeof(EnumType), typeString, true);
            }
            else
            {
                type = EnumType.Constants;
            }

            string name = xe.Attribute("name").Value;
            EnumValue[] values = xe.Elements("enum").Select(valuesx => EnumValue.CreateFromXml(valuesx, type == EnumType.Bitmask)).ToArray();
            values = ResolveAliases(values).ToArray();
            return new EnumDefinition(name, type, values);
        }

        public override string ToString()
        {
            return $"Enum: {Name} ({Type})[{Values.Length}]";
        }

        private static IEnumerable<EnumValue> ResolveAliases(EnumValue[] raw)
        {
            var lookup = raw.ToDictionary(x => x.Name, StringComparer.OrdinalIgnoreCase);
            foreach (var input in raw)
            {
                if (string.IsNullOrEmpty(input.Alias))
                {
                    yield return input;
                }
                else
                {
                    var original = lookup[input.Alias];
                    yield return new EnumValue(input.Name, original.ValueOrBitPosition, input.Comment);
                }
            }
        }
    }

    public enum EnumType
    {
        Bitmask,
        Enum,
        Constants,
    }

    public class EnumValue
    {
        public string Name { get; }
        public string Alias { get; }
        public int ValueOrBitPosition { get; }
        public string Comment { get; }

        public EnumValue(string name, string alias, string comment)
        {
            Name = name;
            Alias = alias;
            Comment = comment;
        }

        public EnumValue(string name, int value, string comment)
        {
            Name = name;
            ValueOrBitPosition = value;
            Comment = comment;
        }

        public static EnumValue CreateFromXml(XElement xe, bool isBitmask)
        {
            Require.NotNull(xe);

            string name = xe.Attribute("name").Value;
            string alias = xe.Attribute("alias")?.Value;
            string comment = xe.Attribute("comment")?.Value ?? string.Empty;
            if (!string.IsNullOrEmpty(alias))
            {
                return new EnumValue(name, alias, comment);
            }

            int value;
            string valueStr = xe.Attribute("value")?.Value;
            if (valueStr != null)
            {
                if (valueStr.StartsWith("0x"))
                {
                    valueStr = valueStr.Substring(2);
                    value = int.Parse(valueStr, System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    value = int.Parse(valueStr);
                }
            }
            else
            {
                string bitposStr = xe.Attribute("bitpos").Value;
                value = 1 << int.Parse(bitposStr);
            }

            return new EnumValue(name, value, comment);
        }
    }
}