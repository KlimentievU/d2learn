namespace DOTA2Test
{
    public abstract  class ASkils
    {
        protected string name;
        protected double range;
        protected double mpcost;
        protected double heal;
        protected double damage;
        protected double coldoun;

        public double GetHeal()
        {
            return heal;
        }

        public void SetHeal(double val)
        {
            heal = val;
        }

        public string GetName()
        {
            return name;
        }

        public double GetRange()
        {
            return range;
        }

        public double GetManaCost()
        {
            return mpcost;
        }

        public double GetDamage()
        {
            return damage;
        }

        public double GetCooldown()
        {
            return coldoun;
        }
    }
}