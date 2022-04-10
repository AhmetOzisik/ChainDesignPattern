using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesign
{
    public class KBB : IKrediBasvuru
    {
        public override void BilgiGonder(Customer customer)
        {
            KrediVerilsinMi = true;
            if (customer.KBB <= 1000)
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
