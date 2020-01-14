using System;
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
    public partial class SearchingForLight : Form
    {
        public SearchingForLight()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ExploringTogether().Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new theEnding().Show();
            this.Visible = false;
        }
    }
}
