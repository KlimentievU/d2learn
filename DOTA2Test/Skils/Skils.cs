namespace DOTA2Test
{
    public class Skils : ASkils
    {
        public Skils(double range, int mpcost, int damage, int coldoun)
        {
            range = range;
            mpcost = mpcost;
            damage = damage;
            coldoun = coldoun;
        }

        public void UseSkil(AHero hero)
        {
            if(hero.GetMP() > mpcost)
                if(coldoun == 0)

        }

    }
}