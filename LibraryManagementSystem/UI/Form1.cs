using LibraryManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem {
    public partial class frmWelcome : Form {
        public frmWelcome() {
            InitializeComponent();
        }

        private void btngotologin_Click(object sender, EventArgs e) {
            LoginUI ui = new LoginUI();
            ui.ShowDialog();
        }
    }
}
