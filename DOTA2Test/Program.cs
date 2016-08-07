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
            Hero hero = new Hero("ПАДЖ",2000,2000,1000);
            hero.ShowALLInfo();

            Hero hero2 = new Hero("ПУГНА",1000,1000,1000);
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

            Skils Huk = new Skils("Хук", 1400,200,400,0,0);
            Skils Huk2 = new Skils("Хук2", 1400, 300, 200, 0, 0);


            hero.AddSkil(Huk);
            hero.AddSkil(Huk2);
            
            hero.UseSkil(hero.GetSkils()[0],hero2);

            hero.ShowALLInfo();
            hero2.ShowALLInfo();

            hero.UseSkil(hero.GetSkils()[1], hero2);

            hero.ShowALLInfo();
            hero2.ShowALLInfo();
        }
    }
}
