﻿namespace DOTA2Test
{
    public interface ISkill
    {
         string Name { get; set; }
         double Range { get; set; }
         double Mpcost { get; set; }
         double Heal { get; set; }
         double Damage { get; set; }
         double Coldoun { get; set; }
    }
}