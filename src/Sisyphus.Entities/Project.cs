using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sisyphus.Entities
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Column("customer_id")]
        public int? CustomerID { get; set; }

        public Customer Customer { get; set; }

        [NotMapped, JsonIgnore]
        public string FullName => $"{ID}: {Name}";
    }
}
