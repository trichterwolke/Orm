using System.ComponentModel.DataAnnotations.Schema;

namespace Sisyphus.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
    }
}