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
            HP = hp;
            MP = mp;
        }

        public Hero()
        {
        }


         public int temp = 0;

        public override void BuyItem(AItem name)
        {
            Console.Write("При покупке итема ");
            name.ShowName();
        
            int i = name.GetPrice();
          if(i <= Moneys)
           {
                Item[temp] = name;
                temp++;
                Moneys = Moneys - i;
                Console.WriteLine("Итем куплен");
            }
          else Console.WriteLine("НЕдостаточно денег");

        }

        public override void SellItem()
        {
            /////////////////////////////////////////////////////////////
            if (temp != 0)
            {
                temp--;
                Item[temp] = null;
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
            for (int i = 0; i < temp; i++) Item[i].ShowName();
            Console.WriteLine();
        }

        public  void ShowALLInfo()
        {
            Console.WriteLine("Вся информация : {0}\t {1}\t xp: {2} mp: {3} ",Name,Moneys,HP,MP);
            Console.WriteLine("Итемы: ");
            for (int i = 0; i < temp; i++) Item[i].ShowName();
            Console.WriteLine();
        }

        public override void AddSkil(ASkils skil)
        {
            if (skils.Count < 5)
            {
                this.skils.Add((skil));
            }
            else
            {
                Console.WriteLine("Скилов уже 4!!!!");
            }
        }

        public void UseSkil(ASkils skil, AHero hero)
        {
            if (this.GetMP() > skil.GetManaCost())
            {

                if (skil.GetCooldown() == 0.0)
                {
                    hero.SetHP(hero.GetHP() - skil.GetDamage());
                    this.SetMP(this.GetMP() - skil.GetManaCost());
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




        public override List<ASkils> GetSkils()
        {
            return skils;
        }




        public void UseSkil(ASkils skil)
        {
            if (this.GetMP() > skil.GetManaCost())
            {

                if (skil.GetCooldown() == 0.0)
                {
                    this.SetHP(this.GetHP() + skil.GetHeal());
                    this.SetMP(this.GetMP() - skil.GetManaCost());
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