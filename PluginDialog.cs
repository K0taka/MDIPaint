using PlaaginInterface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class PluginDialog : Form
    {
        private PluginConfig config;
        private Dictionary<string, IPlagin> plugins;

        public PluginDialog(PluginConfig config, Dictionary<string, IPlagin> plugins)
        {
            InitializeComponent();
            this.config = config;
            this.plugins = plugins;
            InitializeControls();
        }

        private void InitializeControls()
        {
            chkAutoMode.Checked = config.AutoMode;
            chkAutoMode.CheckedChanged += (s, e) =>
            {
                config.AutoMode = chkAutoMode.Checked;
                pluginsList.Enabled = !config.AutoMode;
            };

            pluginsList.Enabled = !config.AutoMode;

            // Заполняем список плагинов
            foreach (var plugin in plugins)
            {
                var versionAttr = plugin.Value.GetType().GetCustomAttribute<VersionAttribute>();
                var version = versionAttr != null ? $"{versionAttr.Major}.{versionAttr.Minor}" : "1.0";

                var item = new ListViewItem(new[] {
                    plugin.Value.Name,
                    plugin.Value.Author,
                    version
                });

                item.Checked = config.AutoMode || (config.Plugins.ContainsKey(plugin.Key) && config.Plugins[plugin.Key]);
                item.Tag = plugin.Key;

                pluginsList.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!config.AutoMode)
            {
                foreach (ListViewItem item in pluginsList.Items)
                {
                    var pluginName = (string)item.Tag;
                    config.Plugins[pluginName] = item.Checked;
                }
            }

            config.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
