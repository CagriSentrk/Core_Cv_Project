using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Highliht
    {
        [Key]
        public int Highlihts_Id { get; set; }
        public string Title { get; set; }
        public string image_Url { get; set; }
        public string Content { get; set; }
    }
}
