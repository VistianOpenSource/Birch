using System.IO;
using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    public class JobReader
    {
        /// <summary>
        /// Read a <see cref="Job"/> json instance from a specified path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Job FromFile(string path)
        {
            var content = File.ReadAllText(path);

            var root = JsonConvert.DeserializeObject<Job>(content);

            return root;
        }
    }
}
