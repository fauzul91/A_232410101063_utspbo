using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UTS.App.Models
{
    public class M_Category
    {
        [Key]
        public int id_category { get; set; }
        [Required]
        public string nama_category { get; set; }
    }
}
