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
            
            IHero hero = new Hero("Pudge",2000,2000,1000);
            hero.ShowAllInfo();

            IHero hero2 = new Hero("Pugna",1000,1000,1000);
            hero2.ShowAllInfo();

            hero.BuyItem(new BlinkDagger());
            hero2.BuyItem(new Dagon());

            hero.AddMoneys(100);
            hero2.AddMoneys(1700);

            hero.ShowAllInfo();
            hero2.ShowAllInfo();

            hero.BuyItem(new BlinkDagger());
            hero2.BuyItem(new Dagon());

            hero.ShowAllInfo();
            hero2.ShowAllInfo();

            ISkills huk = new Skills("Huck", 1400,200,400,0,0);
            ISkills huk2 = new Skills("Huck2", 1400, 300, 200, 0, 0);


            hero.AddSkill(huk);
            hero.AddSkill(huk2);
            
            hero.UseSkill(hero.GetSkils()[0],hero2);

            hero.ShowAllInfo();
            hero2.ShowAllInfo();

            hero.UseSkill(hero.GetSkils()[1], hero2);

            hero.ShowAllInfo();
            hero2.ShowAllInfo();
        }
    }
}
