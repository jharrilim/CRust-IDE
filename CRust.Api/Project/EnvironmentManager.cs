using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CRust.Api.Project
{
    class EnvironmentManager
    {
        private static string crustDirName = ".crust";
        private static string environmentFileName = "environment.json";
        private string projectPath;
        private Environment env;

        public EnvironmentManager(string path = "")
        {
            projectPath = path;
            env = Environment.Default;
        }

        /// <summary>
        /// Looks for the .crust directory in the project directory and creates an environment.json 
        /// if it does not already exist.
        /// </summary>
        /// <exception cref="Exception"
        /// <returns>
        /// 
        /// </returns>
        public async Task<bool> CreateEnvironmentIfDoesNotExist()
        {
            string envPath = Path.Combine(projectPath, crustDirName, environmentFileName);
            if (File.Exists(envPath))
            {
                return false;
            }
            using(StreamWriter writer = new StreamWriter(envPath))
            {
                string json = JsonConvert.SerializeObject(env);
                await writer.WriteAsync(json);
                return true;
            }
        }
    }
}
