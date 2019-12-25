﻿using PluginService;
using StoreDAL.Is;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoryChange
{
    public class Plugin : IPlugin
    {
        public string Name => "CategoryChange";

        public string Description => "CategoryChange";

        public string Author => "zwaren";

        public string Version => "1.0.0";

        public bool Exec(IProductService pService, ICategoryService cService)
        {
            var form = new Form1(pService, cService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
