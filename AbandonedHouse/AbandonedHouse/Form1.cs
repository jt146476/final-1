﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbandonedHouse
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void btn_Escaping_Click(object sender, EventArgs e)
        {
            new EscapingHome().Show();
            this.Visible = false;
        }
    }
}
