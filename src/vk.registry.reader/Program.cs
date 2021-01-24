using System;
using System.Net.Http;
using System.Threading.Tasks;
using vk.registry.model;

namespace vk.registry.reader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string RegistryUrl = @"https://raw.githubusercontent.com/KhronosGroup/Vulkan-Headers/master/registry/vk.xml";

            string registryXml;

            using (var client = new HttpClient())
            {
                registryXml = await client.GetStringAsync(RegistryUrl);
            }

            var registry = Registry.ReadFrom(registryXml);
        }
    }
}
