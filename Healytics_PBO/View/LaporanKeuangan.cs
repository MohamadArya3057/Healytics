using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healytics_PBO.View
{
    public partial class LaporanKeuangan : Form
    {
        public LaporanKeuangan()
        {
            InitializeComponent();
        }

        private void LaporanKeuangan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
