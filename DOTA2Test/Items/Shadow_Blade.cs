using System;

namespace DOTA2Test.Items
{
    public class Shadow_Blade : AItem
    {
        private string Name = "Shadow_Blade";
        private int PriceItem = 2400;
        private double MPCostItem = 90;
        private double DistanceItem;
        private double DamageItem = 120;

        public override void ShowName()
        {
            Console.Write(Name + " ");
        }

        public override int GetPrice()
        {
            int pr = PriceItem;

            return pr;
        }

        public override void ShowPropertyItem()
        {
            Console.WriteLine("Название: {0} Цена: {1} MP: {2} Дистанция: {3} Дамаг: {4}", Name, PriceItem, MPCostItem, DistanceItem, DamageItem);
        }
    }
}