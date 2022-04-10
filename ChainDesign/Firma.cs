using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesign
{
    public class Firma : IKrediBasvuru
    {
        public override void BilgiGonder(Customer customer)
        {
            if (customer.Kurumsal == false)
            {
               
                KrediVerilsinMi = false;
            }
           
        }
    }
}
