using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace branchingExMVC.Models
{
    public class Emp
    {
        public int Empid { get; set; }
        public string EName { get; set; }
        public string EDesign { get; set; }
        public DateTime? EDoj { get; set; }
    }
}