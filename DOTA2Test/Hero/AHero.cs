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
        protected List<ISkill> Skils = new List<ISkill>();
        //protected ISkill[] Skill = new ISkill[4];

        
        public abstract List<ISkill> GetSkils(); 
        public abstract void AddSkill(ISkill skils);
        public abstract void BuyItem(InterfaceItem name);
        public abstract void SellItem(int item);
        public abstract void AddMoneys(int number);
        public abstract void ShowItem();
        public abstract void UseSkill(ISkill skill, IHero hero);
        public abstract void UseSkill(ISkill skill);
        public abstract void ShowAllInfo();
    }
}