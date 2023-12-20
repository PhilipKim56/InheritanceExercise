using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds : Animals
    {
        public Birds() 
        {
        
        }

        public string NameInType { get; set; }
        public string ColorOfFeathers {  get; set; }        
        public bool CanFly { get; set; }
        public string MostKnownFor {  get; set; }

    }
}
