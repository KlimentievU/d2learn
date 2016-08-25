using System;
using System.Collections.Generic;

namespace DOTA2Test
{
    public abstract class AHero
    {
        public string Name { get; set; }
        protected int  Moneys { get; set; }
        protected AItem[] Item = new AItem[6];
        protected List<ASkills> Skils = new List<ASkills>();

        protected ASkills[] Skill = new ASkills[4];

        public double Hp { get; set; }

        public double Mp { get; set; }


        public abstract List<ASkills> GetSkils(); 
        public abstract void AddSkil(ASkills skils);
        public abstract void BuyItem(AItem name);
        public abstract void SellItem();
        public abstract void SetMoneys(int number);
        public abstract void ShowItem();
    }
}