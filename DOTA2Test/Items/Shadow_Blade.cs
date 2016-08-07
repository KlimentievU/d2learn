using System;

namespace DOTA2Test.Items
{
    public class Shadow_Blade : AItem
    {

        public Shadow_Blade()
        {
            Name = "Shadow_Blade";
            PriceItem = 2400;
            MPCostItem = 90;
            DistanceItem = 0;
            DamageItem = 120;
        }

        public override void ShowName()
        {
            Console.Write(Name + " ");
        }

        public override void ShowPropertyItem()
        {
            Console.WriteLine("Название: {0} Цена: {1} MP: {2} Дистанция: {3} Дамаг: {4}", Name, PriceItem, MPCostItem, DistanceItem, DamageItem);
        }
    }
}