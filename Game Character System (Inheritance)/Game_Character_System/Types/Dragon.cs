namespace GameSystem
{
    public class Dragon :Character
    {
        public Dragon(string name, int health, int attack, int defense) :
                base(name, health, attack, defense)
        {  }

        public  void BreatheFire(Character target)
        {
            int damage = this.attack * 4 - target.defense;

            if(damage > 0)
            {
                target.health -= damage;
                System.Console.WriteLine($"{this.name} breathes fire {target.name} for {damage} damage!");
            }
            else
            {
                System.Console.WriteLine($"{this.name}'s fire has no effect on {target.name}.");
            }
        }

        public override void Attack(Character target)
        {
            this.attack *= 2; 
            base.Attack(target);
        }
    }
}