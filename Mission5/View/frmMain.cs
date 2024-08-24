using Mission5Lib.Model;
using System;
using System.Windows.Forms;

namespace Mission5
{
    public partial class frmMain : Form
    {
        public Librarian Librarian { get; set; }
        private Member searchedMember;
        private BookCopy searchedBookCopy;

        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            RefreshMemberInfo();
        }

        private void RefreshMemberInfo()
        {
            var member = MemberDAO.GetInstance().Get(lblMemberId.Text);

            if (member == null)
            {
                ClearMemberFields();
                member = null;

                MessageBox.Show("Tidak ada anggota yang cocok dengan ID yang dimasukkan.", "Kesalahan dalam pencarian anggota.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            
            searchedMember = member;

            var memberCheckOutDAO = MemberCheckOutDAO.GetInstance();
            var checkoutInfo = memberCheckOutDAO.GetCheckOutSummary(member.Id);

            lblMemberName.Text = member.Name;
            lblPhoneNo.Text = member.PhoneNo;
            lblDaysOfOverdue.Text = checkoutInfo.DaysOfOverdue.ToString();
            lblNumOfAvailable.Text = checkoutInfo.NumOfBookAvailable.ToString();
            lblNumOfCheckOut.Text = checkoutInfo.NumOfBookCheckOut.ToString();
            lblOverdueFee.Text = checkoutInfo.OverdueFee.ToString();
            lblNumOfOverdue.Text = checkoutInfo.NumOfBookOverdue.ToString();

            var bookCopyList = memberCheckOutDAO.GetCheckOutBookInfoList(member.Id);
            dgvBookList.AutoGenerateColumns = false;
            dgvBookList.DataSource = bookCopyList;
            //MessageBox.Show(bookCopyList.ToString());

            btnReturn.Enabled = false;


            if (IsMemberCheckOutAvailable())
            {
                if (searchedMember != null)
                    btnCheckOut.Enabled = true;
            }

            if (bookCopyList.Count == 0)
                btnReturn.Enabled = false;
            else
                btnReturn.Enabled = true;

        }

        private bool IsMemberCheckOutAvailable()
        {
            if (searchedMember == null)
                return false;

            var memberCheckOutDAO = MemberCheckOutDAO.GetInstance();

            //TODO
            //Menggunakan metode GetCheckOutSummary() dari objek MemberCheckOutDAO
            var checkoutInfo = memberCheckOutDAO.GetCheckOutSummary(searchedMember.Id);
            //Peminjaman tambahan tidak dapat dilakukan karena jumlah buku yang dapat dipinjam sudah melebihi batas (periksa nilai NumOfBookAvailable)
            //Jika ada lebih dari 1 buku yang lewat jatuh tempo (periksa nilai NumOfBookOverdue), kembalikan false;
            //Dan mengembalikan nilai true jika pinjaman tambahan dimungkinkan
            if (checkoutInfo.NumOfBookAvailable <= 0)
                return false;

            // Check if the member has overdue books
            if (checkoutInfo.NumOfBookOverdue > 0)
                return false;

            return true;
        }

        private void ClearMemberFields()
        {
            lblMemberName.Text = "";
            lblPhoneNo.Text = "";
            lblDaysOfOverdue.Text = "";
            lblNumOfAvailable.Text = "";
            lblNumOfCheckOut.Text = "";
            lblOverdueFee.Text = "";
            lblNumOfOverdue.Text = "";

            dgvBookList.DataSource = null;

            btnCheckOut.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            var bookCopy = BookCopyDAO.GetInstance().Get(txtBookCopyCode.Text);

            if (bookCopy == null)
            {
                ClearBookCopyInfo();
                MessageBox.Show("Tidak ada buku yang cocok dengan nomor registrasi buku yang dimasukkan.", "Kesalahan dalam pencarian buku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var book = BookDAO.GetInstance().Get(bookCopy.BookId);
            lblTitle.Text = book.Title;
            lblPublisher.Text = book.Publisher;

            searchedBookCopy = bookCopy;

            btnCheckOut.Enabled = false;

            if (bookCopy.BookStatus == (int)BookCopyStatusEnum.CheckedOut)
            {
                MessageBox.Show("Buku sedang dipinjam sehingga tidak dapat dipinjam lagi.", "Kesalahan dalam peminjaman buku.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (bookCopy.BookStatus == (int)BookCopyStatusEnum.Lost)
            {
                MessageBox.Show("Buku ini telah hilang dan tidak dapat dipinjam.", "Kesalahan dalam peminjaman buku.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (searchedMember != null && searchedMember != null)
                btnCheckOut.Enabled = true;
            else
                btnCheckOut.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClearMemberFields();
           
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            
                //TODO
                //1. Membuat dan menginisialisasi objek buku untuk dipinjam (CheckOut)
                //2. Tambahkan CheckOut ke DB menggunakan objek CheckOutDAO
                //3. Ubah properti BookStatus dari objek BookCopy yang direferensikan oleh searchedBookCopy menjadi BookCopyStatusEnum.CheckedOut
                //4. Ubah BookCopy di DB dengan metode Update() objek BookCopyDAO

                if (searchedMember != null && searchedBookCopy != null)
                {
                    // 1. Membuat dan menginisialisasi objek buku untuk dipinjam (CheckOut)
                    var checkOut = new CheckOut
                    {
                        MemberId = searchedMember.Id,
                        BookCopyId = searchedBookCopy.Id,
                        CheckOutDate = DateTime.Now,
                        DueDate = DateTime.Now.AddDays(14), // Assuming a 2-week loan period
                        LibrarianId = Librarian.Id
                    };

                    // 2. Tambahkan CheckOut ke DB menggunakan objek CheckOutDAO
                    var checkOutDAO = CheckOutDAO.GetInstance();
                    checkOutDAO.Add(checkOut);

                    // 3. Ubah properti BookStatus dari objek BookCopy yang direferensikan oleh searchedBookCopy menjadi BookCopyStatusEnum.CheckedOut
                    searchedBookCopy.BookStatus = (int)BookCopyStatusEnum.CheckedOut;

                    // 4. Ubah BookCopy di DB dengan metode Update() objek BookCopyDAO
                    var bookCopyDAO = BookCopyDAO.GetInstance();
                    bookCopyDAO.Update(searchedBookCopy);

                    ClearBookCopyInfo();
                    RefreshMemberInfo();
                }
        }

        private void ClearBookCopyInfo()
        {
            txtBookCopyCode.Text = "";
            lblTitle.Text = "";
            lblPublisher.Text = "";
            searchedBookCopy = null;
            btnCheckOut.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBookList.CurrentRow == null)
            {
                return;
            }

            int checkOutId = Convert.ToInt32(dgvBookList.CurrentRow.Cells[0].Value);
            int overdueDays = Convert.ToInt32(dgvBookList.CurrentRow.Cells[5].Value);
            int overdueFee = Convert.ToInt32(dgvBookList.CurrentRow.Cells[6].Value);

            //TODO
            //1. Dapatkan objek CheckOut dengan metode Get() dari objek CheckOutDAO.
            //2. Ubah properti ReturnDate, OverdueCharge, dan OverdueDays dari objek CheckOut ke nilai yang dibaca dari baris Grid yang dipilih.
            //3. CheckOut yang dimodifikasi oleh metode Update() dari objek CheckOutDAO tercermin dalam DB.
            //4. Ambil objek BookCopy menggunakan metode Get() dari objek BookCopyDAO dan ubah properti BookStatus menjadi BookCopyStatusEnum.Available.
            //5. BookCopy yang dimodifikasi dengan metode Update() dari objek BookCopyDAO tercermin dalam DB.
            
            // 1. Dapatkan objek CheckOut dengan metode Get() dari objek CheckOutDAO.
            var checkOutDAO = CheckOutDAO.GetInstance();
            var checkOut = checkOutDAO.Get(checkOutId);

            // 2. Ubah properti ReturnDate, OverdueCharge, dan OverdueDays dari objek CheckOut ke nilai yang dibaca dari baris Grid yang dipilih.
            checkOut.ReturnDate = DateTime.Now;
            checkOut.OverdueCharge = overdueFee;
            checkOut.OverdueDays = overdueDays;

            // 3. CheckOut yang dimodifikasi oleh metode Update() dari objek CheckOutDAO tercermin dalam DB.
            checkOutDAO.Update(checkOut);

            // 4. Ambil objek BookCopy menggunakan metode Get() dari objek BookCopyDAO dan ubah properti BookStatus menjadi BookCopyStatusEnum.Available.
            var bookCopyDAO = BookCopyDAO.GetInstance();
            var bookCopy = bookCopyDAO.Get(checkOut.BookCopyId);
            bookCopy.BookStatus = (int)BookCopyStatusEnum.Available;

            // 5. BookCopy yang dimodifikasi dengan metode Update() dari objek BookCopyDAO tercermin dalam DB.
            bookCopyDAO.Update(bookCopy);
            RefreshMemberInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin keluar dari program?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblDaysOfOverdue_Click(object sender, EventArgs e)
        {

        }

        private void lblNumOfOverdue_Click(object sender, EventArgs e)
        {

        }
    }
}
