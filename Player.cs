namespace Programmering_prov_2
{
    public class Player
    {
        private int hp =  160; // Spelarens hälsa
        

       
        public int Attack(Enemy enemy, int damage){
            return enemy.Hp -= damage; // Minskar enemys hp med damage och returnerar nya hp
        }

        public int Hp{
            get{return hp;} // Returnerar players hp
            set{hp = value;} // Sätter players hp
         }
    }
}