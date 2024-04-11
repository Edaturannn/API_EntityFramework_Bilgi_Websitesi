using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int contactid {  get; set; }

        [StringLength(100)]
        public string yourname {  get; set; }

        [StringLength(100)]
        public string youremail {  get; set; }

        [StringLength(150)]
        public string subject {  get; set; }

        [StringLength(500)]
        public string message {  get; set; }

        public bool status { get; set; } = false;
    }
}
