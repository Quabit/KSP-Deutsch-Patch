using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSP_Deutsch_Patch
{
    public partial class Splash : Form
    {
        public int i;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }
    }
}
