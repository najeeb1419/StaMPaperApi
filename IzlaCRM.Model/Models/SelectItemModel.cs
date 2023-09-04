using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Models
{
    public class SelectItemModel
    {
        public int Value { get; set; }
        public string Label { get; set; }
    }
    public class SelectItemModelWithForenkey
    {
        public int Value { get; set; }
        public string Label { get; set; }
        public int CountryId { get; set; }
    }
}
