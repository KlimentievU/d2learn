using System;

namespace DOTA2Test.Items
{
    public class Blink_Dagger : AItem
    {
        private string Name = "Blink_Dagger";
        private int PriceItem = 2100;
        private double MPCostItem;
        private double DistanceItem = 900;
        private double DamageItem ;


        public override int GetPrice()
        {
            int pr = PriceItem;

            return pr;
        }

        public override void ShowName()
        {
            Console.Write(Name + " ");
        }

        public override void ShowPropertyItem()
        {
            
            Console.WriteLine("Название: {0} Цена: {1} MP: {2} Дистанция: {3} Дамаг: {4}",Name,PriceItem,MPCostItem,DistanceItem,DamageItem);
        }
    }
}