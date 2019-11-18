using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
