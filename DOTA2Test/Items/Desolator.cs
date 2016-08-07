using System;

namespace DOTA2Test.Items
{
    public class Desolator : AItem
    {
        public Desolator()
        {
            Name = "Desolator";
            PriceItem = 5400;
            MPCostItem = 0;
            DistanceItem = 0;
            DamageItem = 50;
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