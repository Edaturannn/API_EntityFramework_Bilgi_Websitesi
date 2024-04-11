using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AllUsers
    {
        [Key]
        public int allusersid { get; set; }

        [Required]
        [StringLength(300)]
        public string namesurname { get; set; }


        [Required]
        [StringLength(200)]
        public string password { get; set; }


        public DateTime createdate { get; set; } = DateTime.Now;

        public bool locked { get; set; } = true;


        [StringLength(10)]
        public string role { get; set; } = "user";
    }
}
