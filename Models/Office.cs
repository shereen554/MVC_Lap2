using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Lap2.Models
{
    [PrimaryKey ("id")]
    public class Office
    {
        public int? id { get; set; }
        public string? Name { get; set; }
        public string? location { get; set; }
        //navigation property
        List<Employee>? employees { get; set; }

    }
}
