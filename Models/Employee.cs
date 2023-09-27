using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Lap2.Models
{
    [PrimaryKey("id")]
    public class Employee
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int? age { get; set; }
        public string? address { get; set; }
        public int? salary { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        //foreignKey
        [ForeignKey("office")]
        public int? office_id { get; set; }
       
        //Navigation property
        public Office? office { get; set; }
        List<Project>? projects { get; set; }

    }
}
