using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Job
    {
        [Key]
        public int Job_Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string img_Url { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string FilterName { get; set; }
        public ICollection<Employee>? Employees { get; set; }//Navigation properties 
    }
}
