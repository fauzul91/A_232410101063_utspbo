using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UTS.App.Models
{
    public class M_Inventaris
    {
        [Key]
        public int id_inventaris { get; set; }
        [Required]
        public string nama_inventaris { get; set; }
        [Required]
        public int id_category { get; set; }
        [Required]
        public int jumlah { get; set; }
        [Required]
        public int harga { get; set; }
    }
}
