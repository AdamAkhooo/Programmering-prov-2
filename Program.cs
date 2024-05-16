using System; 
using Programmering_prov_2;
 class Program{

    static void Main(string[]args)
    {

        Player player = new Player();
        Enemy enemy = new Enemy();



        while (true)
        {
            Console.WriteLine("Välj ett alternativ: ");
            Console.WriteLine("1. Attackera fienden ");
            Console.WriteLine("2. Skriva ut din hälsa");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                int newEnemyHp = player.Attack(enemy);
                Console.WriteLine("Player attackerar fienden");
                Console.WriteLine("Fiendens nya hp: " + newEnemyHp);
                break;

                case "2":
                Console.WriteLine("Spelarens HP: " + player.Hp);
                break;

                default:
                Console.WriteLine("Ogiltigt val. Vänligen välj ett av alternativen");
                break;

            }
        }
        
        Console.WriteLine("Round 1");

        

        int newEnemyHp = player.Attack(enemy);
        Console.WriteLine("Player attacks Enemy");

        

        Console.WriteLine("Enemy new hp " + newEnemyHp);
        

        

        

        int newPlayerHp = enemy.Attack(player);
        Console.WriteLine("Enemy attacks Player");

        

        Console.WriteLine("Player new hp " + newPlayerHp);
        

        
    }

 }