using System;

namespace DOTA2Test.Items
{
    public class Desolator : AItem
    {
        private string Name = "Desolator";
        private int PriceItem = 5400;
        private double MPCostItem;
        private double DistanceItem;
        private double DamageItem = 50;

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