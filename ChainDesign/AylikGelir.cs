using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesign
{
    public class AylikGelir : IKrediBasvuru
    {
        public override void BilgiGonder(Customer customer)
        {
            if (customer.Maas < 1000)
            {
              
                KrediVerilsinMi = false;
            }
            else
            {
                if (krediBasvuru != null)
                {
                    krediBasvuru.BilgiGonder(customer);
                }
            }
        }
    }
}
