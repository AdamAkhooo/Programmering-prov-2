using System.Dynamic;

namespace Programmering_prov_2
{
    public class Enemy
    {
        private int hp = 100;
        
        private int damage = 25;

         public int Hp{
            get{return hp;}
            set{hp = value;}
         }
         public int Attack(Player player){
            return player.Hp -= damage;
         }
    }
}