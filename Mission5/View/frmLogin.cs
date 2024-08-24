using Mission5Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission5
{
    public partial class frmLogin : Form
    {
        private ErrorProvider errEmpNo = new ErrorProvider();
        private ErrorProvider errPassword = new ErrorProvider();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;

            var librarianDAO = LibrarianDAO.GetInstance();
            var lib = librarianDAO.Get(txtEmpNo.Text);

            if (lib == null || lib.Password != txtPassword.Text)
            {
                MessageBox.Show("ID atau Password Anda salah.", "Login gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Hide();
            frmMain form = new frmMain();
            form.Librarian = lib;
          

            //Jika login berhasil, pindah ke layar utama
            
            form.ShowDialog();

            this.Close();
        }
        private bool ValidateEmpNo()
        {
            // Jika EmpNo tidak kosong, validasi berhasil
            if (!string.IsNullOrEmpty(txtEmpNo.Text))
            {
                errEmpNo.Clear();
                return true;
            }
            else
            {
                // Jika kosong, tampilkan pesan kesalahan
                errEmpNo.SetError(txtEmpNo, "Silakan masukkan ID login");
                return false;
            }
        }

        // Metode untuk validasi input password
        private bool ValidatePassword()
        {
            // Jika password tidak kosong, validasi berhasil
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                errPassword.Clear();
                return true;
            }
            else
            {
                // Jika kosong, tampilkan pesan kesalahan
                errPassword.SetError(txtPassword, "Silahkan masukkan password");
                return false;
            }
        }

        // Metode untuk validasi semua input (EmpNo dan password)
        private bool ValidateAll()
        {
            bool validated = true;
            if (!ValidateEmpNo())
                validated = false;
            if (!ValidatePassword())
                validated = false;
            return validated;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler untuk validasi saat pengguna berpindah dari input EmpNo
        private void txtEmpNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateEmpNo();
        }

        // Event handler untuk validasi saat pengguna berpindah dari input password
        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatePassword();
        }

    }
}
