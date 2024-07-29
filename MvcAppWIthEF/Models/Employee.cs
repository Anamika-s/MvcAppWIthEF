using System.ComponentModel.DataAnnotations;

namespace MvcAppWIthEF.Models
{
    public class Employee
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public int Exp { get; set; }
        public string Dept { get; set; }
    }

}
