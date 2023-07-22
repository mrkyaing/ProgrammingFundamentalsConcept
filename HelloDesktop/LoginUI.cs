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
    public partial class LoginUI : Form {
        public LoginUI() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
           
            string username=txtUserName.Text;// get the user's keyboard input
            string passwod=txtPassword.Text;
            
            if(username.Equals("admin") &&  passwod.Equals("admin123") ) {
                MessageBox.Show("Welcome admin", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else {
                MessageBox.Show("user name or password is incorrect", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
