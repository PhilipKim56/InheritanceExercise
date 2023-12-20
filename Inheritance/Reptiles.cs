using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptiles : Animals
    {
        public Reptiles() { }

        public string NameInType { get; set; }
        public string WalksOrSlithers { get; set; }
        public bool HasVenom { get; set; }
        public string MostKnownFor {  get; set; }
    }

   
}
