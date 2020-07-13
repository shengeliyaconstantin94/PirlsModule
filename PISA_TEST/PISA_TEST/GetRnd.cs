using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISA_TEST
{
    public class GetRnd
    {
        public  int GetRndNum() {

            Random rnd = new Random();
            int l = rnd.Next(3, 10);
            return l;

                }
    }
}
