using System; 
using System.IO;
using Programmering_prov_2;
 class Program{

    static void Main(string[]args)
    {
        string scoreFilePath = "player_score.txt";
        Random random = new Random();
        while(true){
            Player player = new Player();
            Enemy enemy = new Enemy();
            int playerScore = 0;
        
        



        while (true)
        {
            Console.WriteLine("Välj ett alternativ: ");
            Console.WriteLine("1. Attackera fienden ");
            Console.WriteLine("2. Skriva ut din hälsa");

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

 }