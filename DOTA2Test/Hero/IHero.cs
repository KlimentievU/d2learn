using System.Collections.Generic;

namespace DOTA2Test
{
    public interface IHero
    {
         string Name { get; set; }
         int Moneys { get; set; }
         double Hp { get; set; }
         double Mp { get; set; }


        List<ISkill> GetSkils();
         void AddSkill(ISkill skils);
         void BuyItem(InterfaceItem name);
         void SellItem(int item);
         void AddMoneys(int number);
         void ShowItem();
         void UseSkill(ISkill skil, IHero hero);
        void UseSkill(ISkill skill);
        void ShowAllInfo();

    }
}