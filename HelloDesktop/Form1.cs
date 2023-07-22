using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloDesktop {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e) {
            MessageBox.Show("Hello,Nice to see you ","my app",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //caling the loginui form 
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
        }
    }
}
