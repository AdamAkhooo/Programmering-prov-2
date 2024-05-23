using System.Dynamic;

namespace Programmering_prov_2
{
    public class Enemy
    {
        protected int hp; // Enemy hp som är protected för att kunna ärvas
        
        

         public int Hp{
            get{return hp;} // Returnerar enemy hp
            set{hp = value;} // Sätter ennemy hp
         }
         public int Attack(Player player, int damage){
            return player.Hp -= damage; // Minskar players hp och returnerar enemys hälsa
         }
    }
}