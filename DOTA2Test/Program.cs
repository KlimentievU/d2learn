using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTA2Test.Items;

namespace DOTA2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("ПАДЖ", 2000,100,100);
            hero.ShowALLInfo();

            Hero hero2 = new Hero("ПУГНА",1000,100,100);
            hero2.ShowALLInfo();

            hero.BuyItem(new Blink_Dagger());
            hero2.BuyItem(new Dagon());

            hero.SetMoneys(100);
            hero2.SetMoneys(1700);

            hero.ShowALLInfo();
            hero2.ShowALLInfo();

            hero.BuyItem(new Blink_Dagger());
            hero2.BuyItem(new Dagon());

            hero.ShowALLInfo();
            hero2.ShowALLInfo();

        }
    }
}
