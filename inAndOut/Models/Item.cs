using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace inAndOut.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

    }
}
 