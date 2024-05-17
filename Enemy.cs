using System.Dynamic;

namespace Programmering_prov_2
{
    public class Enemy
    {
        private int hp = 100;
        
        

         public int Hp{
            get{return hp;}
            set{hp = value;}
         }
         public int Attack(Player player, int damage){
            return player.Hp -= damage;
         }
    }
}