namespace DOTA2Test
{
    public abstract class AItem
    {
        private int PriceItem;
        private double MPCostItem;
        private double DistanceItem;
        private double DamageItem;

        public abstract void ShowPropertyItem();
        public abstract void ShowName();
        public abstract int GetPrice();

    }
}