using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int aboutid { get; set; }

        [StringLength(500)]
        public string text {  get; set; }

        [StringLength(500)]
        public string img {  get; set; }
    }
}
