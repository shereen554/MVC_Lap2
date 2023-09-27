using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace MVC_Lap2.Models
{
    [PrimaryKey("Id")]
    
    public class Project
    {
        
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
       
        //nevigation property
        List<Employee>? Employees { get; set; }
    }
}
