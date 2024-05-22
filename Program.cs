using System; 
using System.IO;
using Programmering_prov_2;
 class Program{

    static void Main(string[]args)
    {
        string scoreFilePath = "player_score.txt";
        Random random = new Random();
        
        while(true)
        {
            Console.WriteLine("❚█══Välkommen till Adams Batalj!══█❚");
            Console.WriteLine("1. Starta Spelet");
            Console.WriteLine("2. Avsluta Spelet");
            
            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "1":
                StartGame(random, scoreFilePath);
                break;

                case "2":
                Console.WriteLine("Spelet Avslutas!");
                return;

                default:
                Console.WriteLine("Ogiltigt val, Vänligen välj utskrivna alternativen");
                break;

            }
        }
    }
        
    
        
        static void StartGame(Random random, string scoreFilePath)
        {
            while(true){
            Player player = new Player();
            Enemy enemy = GetRandomEnemy(random);
            int playerScore = 0;

            Console.WriteLine($"Du möter en {enemy.GetType().Name}!");
        
        



        while (true)
        {
            Console.WriteLine("Välj ett alternativ: ");
            Console.WriteLine("1. Attackera fienden ");
            Console.WriteLine("2. Skriva ut din hälsa");
            Console.WriteLine("3. Avsluta spelet");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                int playerDamage = random.Next(10, 36);
                int newEnemyHp = player.Attack(enemy, playerDamage);
                playerScore += playerDamage;
                Console.WriteLine("Player attackerar fienden");
                Console.WriteLine("Fiendens nya hp: " + newEnemyHp);

                if(enemy.Hp <= 0)
                {
                    Console.WriteLine("Fienden har dött. Du vann!");
                    
                    SaveScore(scoreFilePath, playerScore);
                    PrintScore(scoreFilePath);
                    break;
                }

                
                    int enemyDamage = random.Next(10, 28);
                    int newPlayerHp = enemy.Attack(player, enemyDamage);
                    Console.WriteLine("Fienden attackerar tillbaka");
                    Console.WriteLine("Spelarens nya hp: " + newPlayerHp);

                    if(player.Hp <= 0)
                    {
                        Console.WriteLine("Du förlorar!");
                        SaveScore(scoreFilePath, playerScore);
                        PrintScore(scoreFilePath);
                        break;
                    }
                
                
                break;

                case "2":
                Console.WriteLine("Spelarens HP: " + player.Hp);
                break;

                case "3":
                Console.WriteLine("Spelet avslutas. Tack för att du spelade!");
                return;

                default:
                Console.WriteLine("Ogiltigt val. Vänligen välj ett av alternativen");
                break;

                

            }
            
            
            
            
        }
    }
        }
        
        

    

    static void SaveScore(string filePath, int score)
    {
        if (File.Exists(filePath))
        {
            string existingScore = File.ReadAllText(filePath);
            int totalScore = int.Parse(existingScore) + score;
            File.WriteAllText(filePath, totalScore.ToString());
        }
        else
        {
            File.WriteAllText(filePath, score.ToString());
        }
    }

    static void PrintScore(string filePath)
    {
        if(File.Exists(filePath))
        {
            string score = File.ReadAllText(filePath);
            Console.WriteLine("Din totala poäng är: " + score);

        }
        else
        {
            Console.WriteLine("Ingen poäng hittades.");
        }
    }

    static Enemy GetRandomEnemy(Random random)
    {
        int enemyType = random.Next(1,3);
        return enemyType == 1 ? new Creeper() : new Zombie();
    }

 }