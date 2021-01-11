using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop2.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        public int BeanVarietyId { get; set; }
        public BeanVariety BeanVariety { get; set; }
    }
}
