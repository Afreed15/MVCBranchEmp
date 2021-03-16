using branchingExMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace branchingExMVC.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<Emp> list = new List<Emp>
            {
                new Emp{Empid=1,EName="sam",EDesign="hr",EDoj=DateTime.Parse("12/12/2021") },
                 new Emp{Empid=2,EName="sree",EDesign="tester",EDoj=DateTime.Parse("1/11/2020") },
                  new Emp{Empid=3,EName="prabhas",EDesign="developer",EDoj=DateTime.Parse("2/12/2021") },
                   new Emp{Empid=4,EName="naveen",EDesign="manager",EDoj=DateTime.Parse("7/4/2020") },
            };
            return View(list);
        }
    }
}