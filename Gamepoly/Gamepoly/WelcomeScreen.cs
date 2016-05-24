using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamepoly
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void bttPlayVersus_Click(object sender, EventArgs e)
        {
            Interface i = new Interface();
            i.ShowDialog();
            Close();
        }
    }
}
