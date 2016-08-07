using System;
using System.Collections.Generic;

namespace DOTA2Test
{
    public abstract class AHero
    {
        protected string Name { get; set; }
        protected int  Moneys { get; set; }
        protected AItem[] Item = new AItem[6];
        protected List<ASkils> skils = new List<ASkils>();

        protected ASkils[] Skil = new ASkils[4];

        protected double HP;

        protected double MP { get; set; }

        public string GetName_Hero()
        {
            return Name;
        }

        public double GetMP()
        {
            return MP;
        }

        public void SetMP(double val)
        {
            MP = val;
        }

        public double GetHP()
        {
            return HP;
        }
        public void SetHP(double val)
        {
            HP = val;
        }

        public abstract List<ASkils> GetSkils(); 
        public abstract void AddSkil(ASkils skils);
        public abstract void BuyItem(AItem name);
        public abstract void SellItem();
        public abstract void SetMoneys(int number);
        public abstract void ShowItem();
    }
}