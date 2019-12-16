using System;
using System.IO;
using System.Reflection;

namespace Mashkanta
{
    public static class EmbadedResources
    {
        private static string GetEmbeddedResource(Type type, string resourceName)
        {
            var assembly = type.Assembly;
            var result = GetEmbeddedResource(assembly, resourceName);
            return result;
        }

        private static string GetEmbeddedResource(Assembly assembly, string resourceName)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var result = reader.ReadToEnd();
                return result;
            }
        }

        public static string GetEmbeddedResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return GetEmbeddedResource(assembly, resourceName);
        }

        public static string GetEmbeddedResource(object parentInstance, string resourceName)
        {
            var type = parentInstance.GetType();
            return GetEmbeddedResource(type, resourceName);
        }

        public static string GetEmbeddedResource<T>(string resourceName)
        {
            var type = typeof(T);
            return GetEmbeddedResource(type, resourceName);
        }
    }
}