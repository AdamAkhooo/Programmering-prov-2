namespace Programmering_prov_2
{
    public class Player
    {
        private int hp =  100;
        private int damage = 25;

       
        public void Attack(Enemy enemy){
            enemy.Hp -= damage;
        }
    }
}