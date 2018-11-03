using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Editor.Extensibility
{
    /// <summary>
    /// Manages plugins for the Editor. All of the extra Editor features
    /// should be added throughthe plugin manager.
    /// </summary>
    public class PluginManager
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
