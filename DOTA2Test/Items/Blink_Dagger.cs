using System;

namespace DOTA2Test.Items
{
    public class Blink_Dagger : AItem
    {
        public Blink_Dagger()
        {
          Name = "Blink_Dagger";
          PriceItem = 2100;
          MPCostItem = 0;
          DistanceItem = 1200;
          DamageItem = 0;
        }



        public string GetName()
        {
            return Name;
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