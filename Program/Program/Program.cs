using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2:08:56 / 9:19:55
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerHealth = 100;
            int playerDamage = 10;
            int enemyHealth = 100;
            int enemyDamage = 15;


            while (playerHealth > 0 && enemyHealth >0 )
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;
                Console.WriteLine(playerHealth + "player.");
                Console.WriteLine(enemyHealth + "enemy.");
            }

             if (playerHealth <= 0 & enemyHealth <= 0)
            {
                Console.WriteLine("Draw");
            } 
                else if (playerHealth <= 0)
            {
                Console.WriteLine("Winner Player");
            }

             else if (enemyHealth <= 0)
            {
                Console.WriteLine("Winner Enemy");
            }

        }
    }
}