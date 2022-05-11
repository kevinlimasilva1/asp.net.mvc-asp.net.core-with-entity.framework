using System;

namespace BKBProductManagement.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateR { get; set; }
    }
}
