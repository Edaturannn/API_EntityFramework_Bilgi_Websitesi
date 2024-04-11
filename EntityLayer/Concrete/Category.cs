using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int categoryid {  get; set; }
        [StringLength(500)]
        public string title {  get; set; }
        public string text {  get; set; }
        public string img {  get; set; }
    }
}
