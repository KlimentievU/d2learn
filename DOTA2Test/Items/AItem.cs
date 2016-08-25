using System;

namespace DOTA2Test
{
    public abstract class AItem
    {
        public string Name { get; set; }
        public int PriceItem { get; set; }
        public double MpCostItem { get; set; }
        public double DistanceItem { get; set; }
        public double DamageItem { get; set; }
//хуй пизда джигурда
        public  void ShowPropertyItem()
        {

            Console.WriteLine("Название: {0} Цена: {1} MP: {2} Дистанция: {3} Дамаг: {4}", Name, PriceItem,
                                                                        MpCostItem, DistanceItem, DamageItem);
        }

        public  void ShowName()
        {
            Console.Write(Name + " ");
        }

    }
}
