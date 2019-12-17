using PluginService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryChange
{
	public class Plugin : IPlugin
	{
		public string PluginName => throw new NotImplementedException();

		public string DisplayPluginName => throw new NotImplementedException();

		public string PluginDescription => throw new NotImplementedException();

		public string Author => throw new NotImplementedException();

		public int Version => throw new NotImplementedException();

		public object Host { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string Activate<T>(List<T> input)
		{
			throw new NotImplementedException();
		}

		public void Show()
		{
			throw new NotImplementedException();
		}
	}
}
