using Rira_Project.Enum;

namespace Rira_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public uint Price { get; set; }
    }
}
