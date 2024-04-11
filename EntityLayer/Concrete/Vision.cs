using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Vision
    {
        [Key]
        public int visionid { get; set; }

        [StringLength(100)]
        public string title { get; set; }

        [StringLength(500)]
        public string text { get; set; }

        [StringLength(50)]
        public string icon {  get; set; }
    }
}
