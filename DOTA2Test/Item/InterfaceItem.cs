namespace DOTA2Test
{
    public interface InterfaceItem
    {

         string Name { get; set; }
         int PriceItem { get; set; }
         double MpCostItem { get; set; }
         double DistanceItem { get; set; }
         double DamageItem { get; set; }

        void ShowPropertyItem();
         void ShowName();

    }
}