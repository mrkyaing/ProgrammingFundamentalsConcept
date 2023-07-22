using LibraryManagementSystem.DAO;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI {
    public partial class LoginUI : Form {
        
        private readonly IUserDAO _userDAO;
       
        public LoginUI() {
            InitializeComponent();
            _userDAO=new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string userName=txtUserName.Text;
            string password=txtPassword.Text;
            
            bool loginSuccess=_userDAO.CheckUserExists(userName,password);
            if (loginSuccess) {
                MessageBox.Show("login succesfully");
                DashboardUI dashboard=new DashboardUI();
                dashboard.Show();
            }
            else {
                MessageBox.Show("user email or password is incorrect.");
            }
        }
    }
}
