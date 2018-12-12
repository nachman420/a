using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
     public class address
    {
        private string street;
        private int numofbilding;
        private string city;

        public override string ToString()
        {
            return "street"+street+"numofbilding"+numofbilding+"city"+city;
        }
       
    }
}
