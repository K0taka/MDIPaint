using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace MDIPaint
{
    public class PluginConfig
    {
        private const string ConfigFileName = "plugins.config";
        public bool AutoMode { get; set; } = true;
        public Dictionary<string, bool> Plugins { get; } = new Dictionary<string, bool>();

        public static PluginConfig Load()
        {
            var config = new PluginConfig();

            if (!File.Exists(ConfigFileName))
            {
                return config;
            }

            try
            {
                var doc = XDocument.Load(ConfigFileName);
                var root = doc.Root;

                if (root.Element("AutoMode") != null)
                {
                    config.AutoMode = bool.Parse(root.Element("AutoMode").Value);
                }

                foreach (var pluginElement in root.Elements("Plugin"))
                {
                    var name = pluginElement.Attribute("Name").Value;
                    var enabled = bool.Parse(pluginElement.Attribute("Enabled").Value);
                    config.Plugins[name] = enabled;
                }
            }
            catch
            {
                // Если файл поврежден, используем настройки по умолчанию
                config.AutoMode = true;
                config.Plugins.Clear();
            }

            return config;
        }

        public void Save()
        {
            var doc = new XDocument(
                new XElement("Configuration",
                    new XElement("AutoMode", AutoMode),
                    Plugins.Select(p =>
                        new XElement("Plugin",
                            new XAttribute("Name", p.Key),
                            new XAttribute("Enabled", p.Value))
                )));

            doc.Save(ConfigFileName);
        }

        public void UpdatePluginsList(IEnumerable<string> availablePlugins)
        {
            // Добавляем новые плагины, которых нет в конфиге
            foreach (var plugin in availablePlugins)
            {
                if (!Plugins.ContainsKey(plugin))
                {
                    Plugins[plugin] = true; // По умолчанию включаем новые плагины
                }
            }

            // Удаляем плагины, которых больше нет
            var toRemove = Plugins.Keys.Where(k => !availablePlugins.Contains(k)).ToList();
            foreach (var key in toRemove)
            {
                Plugins.Remove(key);
            }
        }
    }
}
