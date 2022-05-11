using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKBProductManagement.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public float Weight { get; set; }
        public DateTime DateR { get; set; }
    }
}
