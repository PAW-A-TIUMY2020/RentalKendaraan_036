using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_036.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        [Required(ErrorMessage = "Tanggal Tidak Boleh Kosong")]
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "Denda Tidak Boleh Kosong")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
