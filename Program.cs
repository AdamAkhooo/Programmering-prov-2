using System; //Importerar funktioner
using System.IO;//Importerar filhantering
using Programmering_prov_2;//namn för projektet
 class Program{

    static void Main(string[]args)
    {
        string scoreFilePath = "player_score.txt"; //Anger filen för att spara poäng
        Random random = new Random(); //Instans av random-klassen för att generera random
        
        while(true) //Startar huvudloopen för spelet
        {
            Console.WriteLine("❚█══Välkommen till Adams Batalj!══█❚");
            Console.WriteLine("1. Starta Spelet");
            Console.WriteLine("2. Avsluta Spelet");
            
            string mainChoice = Console.ReadLine(); //Läser in användarens val i övre alternativ

            switch (mainChoice) //Hanterar användarens val
            {
                case "1": // Använder "1" i alternativet
                StartGame(random, scoreFilePath); // Startar spelet
                break;

                case "2": // Använder "2" i alternativet
                Console.WriteLine("Spelet Avslutas!"); // Medelar att spelet har avslutats
                return;

                default: // Om inget av alternativet används
                Console.WriteLine("Ogiltigt val, Vänligen välj utskrivna alternativen"); // Medelar ett ogiltigt svar
                break;

            }
        }
    }
        
    
        
        static void StartGame(Random random, string scoreFilePath)
        {
            while(true){ // En loop för att starta om spelet
            Player player = new Player(); // Skapar player
            Enemy enemy = GetRandomEnemy(random); // Skapar en random enemy
            int playerScore = 0; //Sätter spelarens start poäng

            Console.WriteLine($"Du möter en {enemy.GetType().Name}!"); //Medelar vad du möter för enemy
        
        



        while (true) // En loop för sjävla striden
        {
            Console.WriteLine("Välj ett alternativ: ");
            Console.WriteLine("1. Attackera fienden ");
            Console.WriteLine("2. Skriva ut din hälsa");
            Console.WriteLine("3. Avsluta spelet");

            string choice = Console.ReadLine(); //Läser spelarens val

            switch (choice) //Hanterar spelarens val i övre alternativen
            {
                case "1":
                int playerDamage = random.Next(10, 36); //Genererar random skada för player
                int newEnemyHp = player.Attack(enemy, playerDamage); //Player attackerar enemy
                playerScore += playerDamage; // Uppdaterar players poäng
                Console.WriteLine("Player attackerar fienden");
                Console.WriteLine("Fiendens nya hp: " + newEnemyHp);

                if(enemy.Hp <= 0) // Kontrollerar om enemy har dött
                {
                    Console.WriteLine("Fienden har dött. Du vann!"); //Medelar att Enemy har dött
                    
                    SaveScore(scoreFilePath, playerScore); // Sprarar players poäng
                    PrintScore(scoreFilePath); // Skriver ut sparade poäng
                    break; //bryter loopen
                }

                
                    int enemyDamage = random.Next(10, 28); // Genererar random skada för enemy
                    int newPlayerHp = enemy.Attack(player, enemyDamage); // Enemy attackerar player
                    Console.WriteLine("Fienden attackerar tillbaka");
                    Console.WriteLine("Spelarens nya hp: " + newPlayerHp);

                    if(player.Hp <= 0) // Kontrollerar om player har dött
                    {
                        Console.WriteLine("Du förlorar!");
                        SaveScore(scoreFilePath, playerScore); //Sparar players poäng
                        PrintScore(scoreFilePath); // Skriver ut sparade poäng
                        break; //bryter loopen
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
        using (StreamWriter sw = new StreamWriter(filePath, true)) //Skapar en möjlighet att skriva till filen. Using ser till så att streamwriter frigörs och och stängs korrekt när det avslutas
        {
            sw.WriteLine(score.ToString()); // Skriver poängen till filen
        }
    }

    static void PrintScore(string filePath)
    {
        if(File.Exists(filePath)) //Kontrollerar om filen finns
        {
            string[] scores = File.ReadAllLines(filePath); // Läser alla poäng från filen
            foreach (string score in scores)
            {
                Console.WriteLine("Din poäng blev: " + score); // skriver ut varje poäng
            }

        }
        
    }

    static Enemy GetRandomEnemy(Random random)
    {
        int enemyType = random.Next(1,3); // Gör så att fienden man möter är random
        return enemyType == 1 ? new Creeper() : new Zombie(); // Returnerar en creeper om talet är 1 annars zombie
    }

 }