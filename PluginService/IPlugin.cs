using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginService
{
    public interface IPlugin
    {
        string PluginName { get; } // имя плагина
        string DisplayPluginName { get; } // имя плагина, которое отображается
        string PluginDescription { get; } // описание плагина
        string Author { get; } // имя автора
        int Version { get; } // версия
        object Host { get; set; } // ссылка на владельца

        void Show(); // отображает форму
        string Activate<T>(List<T> input);
    }
}
