﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public partial class HomeNavigation : UserControl
    {
        public HomeNavigation()
        {
            InitializeComponent();
            lblPromo.Text = Explorer.SuiteDescription;
            InitializeCategories();
        }

        private void InitializeCategories()
        {
            var cat1 = new CategoryControl("NEW CONTROLS\r\n&& FEATURES", "new", Color.FromArgb(242, 242, 243), Color.FromArgb(226, 226, 225), 26);
            cat1.Location = new Point(0, 0);
            cat1.Width = this.Width;

            var cat2 = new CategoryControl("TOP CONTROLS", "top", Color.FromArgb(242, 242, 243), Color.FromArgb(226, 226, 225), 26);
            cat2.Location = new Point(0, cat1.Height);
            cat2.Width = this.Width;

            this.pnlFeaturedTiles.Controls.Add(cat2);
            this.pnlFeaturedTiles.Controls.Add(cat1);
        }
    }
}
