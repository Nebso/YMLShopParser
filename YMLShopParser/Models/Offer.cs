using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YMLShopParser.Models
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }    


        public string? ShopName { get; set; }

        [ForeignKey("ShopName")]
        public Shop? Shop { get; set; }  
    }
}
