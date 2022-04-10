using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesign
{
    public abstract class IKrediBasvuru
    {
        public static bool KrediVerilsinMi { get; set; }
        
        protected IKrediBasvuru krediBasvuru;
        public IKrediBasvuru _krediBasvuru
        {
            set
            {
                krediBasvuru = value;
            }
        }
       public abstract void BilgiGonder(Customer customer);
    } 
}
