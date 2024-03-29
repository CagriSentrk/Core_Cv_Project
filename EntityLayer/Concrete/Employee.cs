﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Content { get; set; }
        public string Cv { get; set; }
        [ForeignKey("Job")]
        public int Job_Id { get; set; }
        public Job Job { get; set; }

    }
}
