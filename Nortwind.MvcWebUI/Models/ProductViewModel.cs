using System.Collections.Generic;
using Nortwind.Entities;

namespace Nortwind.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; internal set; }
        public PagingInfo PagingInfo { get; internal set; }
    }
}