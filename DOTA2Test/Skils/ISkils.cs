using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace DOTA2Test
{
    public interface ISkils
    {
        double GetRange();
        int GetManaCost();
        int GetDamage();
        int GetColdaun();
    }
}