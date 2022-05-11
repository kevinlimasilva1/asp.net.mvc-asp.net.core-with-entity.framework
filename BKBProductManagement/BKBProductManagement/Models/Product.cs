using System;

namespace BKBProductManagement.Models
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
