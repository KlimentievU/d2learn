using System;

namespace DOTA2Test
{
    public abstract class AItem
    {
        protected string Name;
        protected int PriceItem;
        protected double MPCostItem;
        protected double DistanceItem;
        protected double DamageItem;
//хуй пизда джигурда
        public  void ShowPropertyItem()
        {

            Console.WriteLine("Название: {0} Цена: {1} MP: {2} Дистанция: {3} Дамаг: {4}", Name, PriceItem, MPCostItem, DistanceItem, DamageItem);
        }

        public  void ShowName()
        {
            Console.Write(Name + " ");
        }

        public int GetPrice()
        {
            return PriceItem;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetMPCost()
        {
            return MPCostItem;
        }
        public double GetDistanceItem()
        {
            return DistanceItem;
        }

        public double GetDamageItem()
        {
            return DamageItem;
        }

    }
}
