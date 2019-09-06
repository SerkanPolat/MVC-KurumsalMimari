using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Entities
{
    public class ShippingDetails
    {
        //Data Annocationlar
        [Required(ErrorMessage ="Isim Girilmesi Zorunludur.")]
        public string Name { get; set; }
        [Required()]
        [MinLength(10)]
        [MaxLength(50)]
        public string Adress1 { get; set; }
        [MaxLength(50)]
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string Country{ get; set; }
        public bool IsGift { get; set; }


    }
}
