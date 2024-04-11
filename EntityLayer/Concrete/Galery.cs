using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Galery
    {
        [Key]
        public int galeryid {  get; set; }

        [StringLength(200)]
        public string title {  get; set; }

        [StringLength(500)]
        public string img {  get; set; }
    }
}
