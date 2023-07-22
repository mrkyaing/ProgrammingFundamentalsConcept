using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI {
    public partial class BookEntryUI : Form {
        private readonly IBookDAO bookDAO;
        public BookModel bookModel { get; set; }// your selected book will be here .
        public BookEntryUI() {
            InitializeComponent();
            bookDAO=new BookService();
        }

        private void btnsave_Click(object sender, EventArgs e) {
            if (btnsave.Text.Equals("Update")) {
                BookModel book = new BookModel(){
                    Id =bookModel.Id,//selected Id >> for update a existing book 
                    ISBN = txtisbn.Text,
                    Name = txtname.Text,
                    AuthorName = txtauthornane.Text,
                    Category = txtcategory.Text,
                    UnitPrice = Convert.ToDecimal(txtunitprice.Text),
                    PublishedAt = Convert.ToDateTime(dtppublishedat.Text),
                    PublisherName = txtpublishername.Text,
                    Volume = txtvolume.Text,
                };
                if (bookDAO.Update(book)) {
                    MessageBox.Show("1 record is updated successfully.");
                }else {
                    MessageBox.Show("error occur when 1 record is updated.");
                }
            }else {
                BookModel book = new BookModel()
                {
                    Id = Guid.NewGuid().ToString(),// for create a book 
                    ISBN = txtisbn.Text,
                    Name = txtname.Text,
                    AuthorName = txtauthornane.Text,
                    Category = txtcategory.Text,
                    UnitPrice = Convert.ToDecimal(txtunitprice.Text),
                    PublishedAt = Convert.ToDateTime(dtppublishedat.Text),
                    PublisherName = txtpublishername.Text,
                    Volume = txtvolume.Text,
                };
                if (bookDAO.Create(book)) {
                    MessageBox.Show("1 record is created successfully.");
                }
                else {
                    MessageBox.Show("error occur when 1 record is created.");
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e) {
            txtname.Clear();
            txtauthornane.Clear();
            txtisbn.Clear();
            txtcategory.Clear();
            txtpublishername.Clear();
            txtunitprice.Clear();
            txtvolume.Clear();
            dtppublishedat.Text = DateTime.Now.ToString();
        }

        private void BookEntryUI_Load(object sender, EventArgs e) {
            if(bookModel != null) {
                txtname.Text = bookModel.Name;
                txtisbn.Text = bookModel.ISBN;
                txtcategory.Text = bookModel.Category;
                txtpublishername.Text = bookModel.PublisherName;
                txtunitprice.Text = bookModel.UnitPrice.ToString();
                txtauthornane.Text = bookModel.AuthorName;
                txtvolume.Text = bookModel.Volume;
                dtppublishedat.Text = bookModel.PublishedAt.ToString();
                btnsave.Text = "Update";
            }
        }
    }
}
