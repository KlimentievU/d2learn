﻿namespace DOTA2Test
{
    public class Skills : ASkills
    {
        public Skills(string name,double range, double mpcost, double damage, double heal, double coldoun)
        {
            this.Name = name;
            this.Range = range;
            this.Mpcost = mpcost;
            this.Damage = damage;
            this.Heal = heal;
            this.Coldoun = coldoun;
        }



    }
}