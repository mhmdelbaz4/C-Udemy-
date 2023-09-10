namespace GameSystem
{
    public class Warrior : Character
    {

        public Warrior(string name, int health, int attack, int defense) :
                base(name, health, attack, defense)
            {    }


        public  void Charge(Character target)
        {
            int damage = this.attack * 2 - target.defense;

            if(damage > 0)
            {
                target.health -= damage;
                System.Console.WriteLine($"{this.name} charges {target.name} for {damage} damage!");
            }
            else
            {
                System.Console.WriteLine($"{this.name}'s charge has no effect on {target.name}.");
            }
        }
        public  override void Defend()
        {
            base.Defend();
            defense += 5;
        }
    }
}