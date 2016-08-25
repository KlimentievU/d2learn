using System;
using System.Collections.Generic;

namespace DOTA2Test
{
    public class Hero : AHero
    {
        public Hero(string name, int moneys, double hp, double mp)
        {
            Name = name;
            Moneys = moneys;
            Hp = hp;
            Mp = mp;
        }

        public Hero()
        {
        }


        public int Temp = 0;

        public override void BuyItem(AItem name)
        {
            Console.Write("При покупке итема ");
            name.ShowName();
        
            int i = name.PriceItem;
          if(i <= Moneys)
           {
                Item[Temp] = name;
                Temp++;
                Moneys = Moneys - i;
                Console.WriteLine("Итем куплен");
            }
          else Console.WriteLine("НЕдостаточно денег");

        }

        public override void SellItem()
        {
            if (Temp != 0)
            {
                Temp--;
                Item[Temp] = null;
            }
            else
            {
                Console.WriteLine("У Героя нету итемов");
                Console.WriteLine();
            }
        }

        public override void SetMoneys(int number)
        {
            Moneys = Moneys + number;
        }


        public override void ShowItem()
        {
            Console.WriteLine("У перса {0} такие итемы: ",Name);
            for (int i = 0; i < Temp; i++) Item[i].ShowName();
            Console.WriteLine();
        }

        public  void ShowAllInfo()
        {
            Console.WriteLine("Вся информация : {0}\t {1}\t xp: {2} mp: {3} ",Name,Moneys,Hp,Mp);
            Console.WriteLine("Итемы: ");
            for (int i = 0; i < Temp; i++) Item[i].ShowName();
            Console.WriteLine();
        }

        public override void AddSkil(ASkills skil)
        {
            if (Skils.Count < 5)
            {
                this.Skils.Add((skil));
            }
            else
            {
                Console.WriteLine("Скилов уже 4!!!!");
            }
        }

        public void UseSkil(ASkills skil, AHero hero)
        {
            if (this.Mp > skil.Mpcost)
            {

                if (skil.Coldoun == 0.0)
                {
                    hero.Hp =(hero.Hp - skil.Damage);
                    this.Mp = (this.Mp - skil.Mpcost);
                }
                else
                {
                    Console.WriteLine("Скилл на колдауне");
                }

            }
            else
            {
                Console.WriteLine("Не хватает МП");
            }
        }




        public override List<ASkills> GetSkils()
        {
            return Skils;
        }




        public void UseSkil(ASkills skil)
        {
            if (this.Mp > skil.Mpcost)
            {

                if (skil.Coldoun == 0.0)
                {
                    this.Hp = (this.Hp + skil.Heal);
                    this.Mp = (this.Mp - skil.Mpcost);
                }
                else
                {
                    Console.WriteLine("Скилл на колдауне");
                }

            }
            else
            {
                Console.WriteLine("Не хватает МП");
            }

        }

    }
}