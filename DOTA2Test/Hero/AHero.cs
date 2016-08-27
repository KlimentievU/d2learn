using System;
using System.Collections.Generic;

namespace DOTA2Test
{
    public abstract class AHero : IHero
    {
        public string Name { get; set; }
        public int  Moneys { get; set; }
        public double Hp { get; set; }
        public double Mp { get; set; }

        protected InterfaceItem[] Item = new InterfaceItem[6];
        protected List<ISkills> Skils = new List<ISkills>();
        protected ISkills[] Skill = new ISkills[4];

        
        public abstract List<ISkills> GetSkils(); 
        public abstract void AddSkill(ISkills skils);
        public abstract void BuyItem(InterfaceItem name);
        public abstract void SellItem();
        public abstract void AddMoneys(int number);
        public abstract void ShowItem();
        public abstract void UseSkill(ISkills skill, IHero hero);
        public abstract void UseSkill(ISkills skill);
        public abstract void ShowAllInfo();
    }
}