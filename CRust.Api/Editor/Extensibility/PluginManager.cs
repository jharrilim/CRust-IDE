using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Editor.Extensibility
{
    class PluginManager
    {
        private Dictionary<string, IPlugin> plugins;

        public PluginManager()
        {
            plugins = new Dictionary<string, IPlugin>();
        }

        public void Register(string name, IPlugin plugin)
        {
            plugins.Add(name, plugin);
        }
    }
}
