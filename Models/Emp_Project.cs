using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;


namespace MVC_Lap2.Models
{
    [PrimaryKey("emp_id", "prj_id")]
    public class Emp_Project
    {
        
        [ForeignKey("Employee")]
        public int? emp_id { get; set; }
        [ForeignKey("project")]
        public int? prj_id { get; set; }
        public int? workinghours { get; set; }
        //nevigation property

        public Employee? Employee { get; set; }
        public Project? project { get; set; }

    }
}
