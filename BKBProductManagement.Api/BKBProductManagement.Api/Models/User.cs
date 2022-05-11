using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKBProductManagement.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateR { get; set; }
    }
}
