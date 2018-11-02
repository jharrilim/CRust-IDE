using System.IO;
using System.Threading.Tasks;

namespace CRust.Api.Editor
{
    public static class FileLoader
    {
        public static async Task<string> GetFileAsStringAsync(string path)
        {
            string txt = "";
            using (StreamReader reader = new StreamReader(path))
            {
                txt = await reader.ReadToEndAsync();
            }
            return txt;
        }
    }
}
