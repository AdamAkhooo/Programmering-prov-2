namespace Programmering_prov_2
{
    public class Player
    {
        private int hp =  100;
        private int damage = 25;

       
        public int Attack(Enemy enemy){
            return enemy.Hp -= damage;
        }

        public int Hp{
            get{return hp;}
            set{hp = value;}
         }
    }
}