using System;

namespace DOTA2Test
{
    public abstract class AHero
    {
        public string Name { get; set; }
        public int  Moneys { get; set; }
        public AItem[] Item = new AItem[6];
        public double HP { get; set; }
        public double MP { get; set; }

        public string GetName_Hero()
        {
            return Name;
        }

        public double GetMP()
        {
            return MP;
        }

        public double GetHP()
        {
            return HP;
        }

        public abstract void BuyItem(AItem name);
        public abstract void SellItem();
        public abstract void SetMoneys(int number);
        public abstract void ShowItem();
    }
}