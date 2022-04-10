using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { KBB = 1500, KrediKart = true, Kefil = true, Maas = 1500, Kurumsal = true };
            IKrediBasvuru krediBasvuru = new KBB();
            IKrediBasvuru krediBasvuru2 = new KrediKart();
            IKrediBasvuru krediBasvuru3 = new Kefil();
            IKrediBasvuru krediBasvuru4 = new AylikGelir();
            IKrediBasvuru krediBasvuru5 = new Firma();

            krediBasvuru._krediBasvuru = krediBasvuru2;
            krediBasvuru2._krediBasvuru = krediBasvuru3;
            krediBasvuru3._krediBasvuru = krediBasvuru4;
            krediBasvuru4._krediBasvuru = krediBasvuru5;

            krediBasvuru.BilgiGonder(customer);
        

            if (IKrediBasvuru.KrediVerilsinMi == true)
            {
                Console.WriteLine("kredi ver");
            }
            else
            {
                Console.WriteLine("kredi verme");
            }

            Console.ReadLine();
        }
    }
}
