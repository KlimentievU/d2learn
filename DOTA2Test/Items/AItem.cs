namespace DOTA2Test
{
    public abstract class AItem
    {
        protected string Name;
        protected int PriceItem;
        protected double MPCostItem;
        protected double DistanceItem;
        protected double DamageItem;

        public abstract void ShowPropertyItem();
        public abstract void ShowName();

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