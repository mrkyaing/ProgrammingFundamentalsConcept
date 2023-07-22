using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI {
    public partial class BookListUI : Form {
       
        private readonly IBookDAO _bookDAO;
        
        public BookListUI() {
            InitializeComponent();
            _bookDAO = new BookService();
        }

        private void BookListUI_Load(object sender, EventArgs e) {
         dgvBooks.DataSource = _bookDAO.GetAll();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 0) {
                //edit action
                BookModel selectedBook = (BookModel)dgvBooks.CurrentRow.DataBoundItem;
                BookEntryUI bookEntryUI = new BookEntryUI();
                bookEntryUI.bookModel = selectedBook;//data carrying to book Entry UI 
                bookEntryUI.Show();
            }
            else if(e.ColumnIndex == 1) {
                //delete action
                DialogResult result=MessageBox.Show("are you sure to delete this record?","Confrim",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result.Equals(DialogResult.Yes)) {
                    BookModel selectedBook = (BookModel)dgvBooks.CurrentRow.DataBoundItem;
                    if (_bookDAO.Delete(selectedBook.Id)) {
                        MessageBox.Show("Delete successfully");
                        dgvBooks.DataSource = _bookDAO.GetAll();
                    }
                }
            }
        }
    }
}
