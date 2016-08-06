namespace DOTA2Test
{
    public abstract  class ASkils : ISkils
    {
        protected double range;
        protected int mpcost;
        protected int damage;
        protected int coldoun;

        public double GetRange()
        {
            return range;
        }

        public int GetManaCost()
        {
            return mpcost;
        }

        public int GetDamage()
        {
            return damage;
        }

        public int GetColdaun()
        {
            return coldoun;
        }
    }
}