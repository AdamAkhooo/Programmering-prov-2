using System.Dynamic;

namespace Programmering_prov_2
{
    public class Enemy
    {
        protected int hp;
        
        

         public int Hp{
            get{return hp;}
            set{hp = value;}
         }
         public int Attack(Player player, int damage){
            return player.Hp -= damage;
         }
    }
}