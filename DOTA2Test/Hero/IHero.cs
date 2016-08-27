using System.Collections.Generic;

namespace DOTA2Test
{
    public interface IHero
    {
         string Name { get; set; }
         int Moneys { get; set; }
         double Hp { get; set; }
         double Mp { get; set; }


        List<ISkills> GetSkils();
         void AddSkill(ISkills skils);
         void BuyItem(InterfaceItem name);
         void SellItem();
         void AddMoneys(int number);
         void ShowItem();
         void UseSkill(ISkills skil, IHero hero);
        void UseSkill(ISkills skill);
        void ShowAllInfo();

    }
}