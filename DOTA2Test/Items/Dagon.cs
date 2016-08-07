using System;

namespace DOTA2Test.Items
{
    public class Dagon : AItem
    {
        /*private string Name = "Dagon";
        private int PriceItem = 2700;
        private double MPCostItem = 100;
        private double DistanceItem = 100;
        private double DamageItem = 400;*/


        public Dagon()
        {
            Name = "Dagon";
            PriceItem = 2700;
            MPCostItem = 100;
            DistanceItem = 100;
            DamageItem = 400;
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