namespace Programmering_prov_2
{
    public class Player
    {
        private int hp =  160;
        

       
        public int Attack(Enemy enemy, int damage){
            return enemy.Hp -= damage;
        }

        public int Hp{
            get{return hp;}
            set{hp = value;}
         }
    }
}