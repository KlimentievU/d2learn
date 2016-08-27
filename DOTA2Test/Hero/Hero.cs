using System;
using System.Collections.Generic;

namespace DOTA2Test
{
    public class Hero : AHero
    {
        public int ItemsInHero = 0;

        public Hero(string name, int moneys, double hp, double mp)
        {
            Name = name;
            Moneys = moneys;
            Hp = hp;
            Mp = mp;
        }

        public override void BuyItem(InterfaceItem name)
        {
            Console.Write("При покупке итема ");
            name.ShowName();
        
            int price = name.PriceItem;
          if(price <= Moneys)
           {
                Item[ItemsInHero] = name;
                ItemsInHero++;
                Moneys = Moneys - price;
                Console.WriteLine("Итем куплен");
            }
          else Console.WriteLine("НЕдостаточно денег");

        }

        public override void SellItem(int numberItem)
        {
            if (ItemsInHero != 0 && Item[numberItem] != null) //от 0 до 6
            {
                ItemsInHero--;
                Item[numberItem] = null;
            }
            else
            {
                Console.WriteLine("У Героя нету итемов");
                Console.WriteLine();
            }
        }

        public override void AddMoneys(int number)
        {
            Moneys += number;
        }


        public override void ShowItem()
        {
            Console.WriteLine("У перса {0} такие итемы: ",Name);
            for (int i = 0; i < ItemsInHero; i++)
            {
                Item[i].ShowName();
            }
            Console.WriteLine();
        }

        public override  void ShowAllInfo()
        {
            Console.WriteLine("Вся информация : {0}\t {1}\t xp: {2} mp: {3} ",Name,Moneys,Hp,Mp);
            Console.WriteLine("Итемы: ");
            for (int i = 0; i < ItemsInHero; i++) Item[i].ShowName();
            Console.WriteLine();
        }

        public override void AddSkill(ISkill skil)
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

        public override void UseSkill(ISkill skil, IHero hero)
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

        public override List<ISkill> GetSkils()
        {
            return Skils;
        }


        public override void UseSkill(ISkill skill)
        {
            if (this.Mp > skill.Mpcost)
            {

                if (skill.Coldoun == 0.0)
                {
                    this.Hp = (this.Hp + skill.Heal);
                    this.Mp = (this.Mp - skill.Mpcost);
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