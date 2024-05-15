using System; 
using Programmering_prov_2;
 class Program{

    static void Main(string[]args)
    {

        Player player = new Player();
        Enemy enemy = new Enemy();
        player.Attack(enemy);
        Console.WriteLine(enemy.Hp);
        
    }

 }