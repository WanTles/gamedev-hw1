using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hero = 100;
            int health = 100;
            int damaged(int downHP)
            {
                return health - downHP;
            }
            int playerHP = damaged(20);
            Console.WriteLine("Damaged Health : " + playerHP);

            int boost(int boostHP)
            {
                return playerHP + boostHP;
            }
            int bsHP = boost(10);
            Console.WriteLine("Boosted Health : " + bsHP);

            int[] HealthArray = { playerHP, bsHP };
            {
                Console.WriteLine(HealthArray[1]);
            };

            if (playerHP > bsHP)
            {
                Console.WriteLine(playerHP + " is more than " + bsHP);
            }
            else if (playerHP < bsHP)
            {
                Console.WriteLine(playerHP + " is less than " + bsHP);
            }
            else
            {
                Console.WriteLine("Neither is more than the another");
            }


        }
    }
}
