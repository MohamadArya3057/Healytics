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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.ShowDialog();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
