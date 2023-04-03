using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace YMLShopParser.Models
{
    public class Shop
    {
        [Key] 
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }

        public List<Offer>? Offers { get; set; }
    }
}
