//------------------------------------------------------------------------------
// <auto-generated>
//     Kode ini dihasilkan dari template.
//
//     Mengubah file ini secara manual dapat menyebabkan perilaku tidak terduga pada aplikasi.
//     Jika Anda mengubah file ini secara manual, perubahan Anda akan ditimpa saat kode dibuat ulang.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mission5Lib.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckOut
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BookCopyId { get; set; }
        public System.DateTime CheckOutDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<int> OverdueDays { get; set; }
        public Nullable<int> OverdueCharge { get; set; }
        public int LibrarianId { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
