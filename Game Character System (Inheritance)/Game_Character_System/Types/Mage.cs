namespace GameSystem
{
    public class Mage :Character
    {
        public Mage(string name, int health, int attack, int defense) :
                base(name, health, attack, defense)
        {  }

        public  void Charge(Character target)
        {
            int damage = this.attack * 3 - target.defense;

            if(damage > 0)
            {
                target.health -= damage;
                System.Console.WriteLine($"{this.name} casts a spell {target.name} for {damage} damage!");
            }
            else
            {
                System.Console.WriteLine($"{this.name}'s spell has no effect on {target.name}.");
            }
        }

        public override sealed void Defend()
        {
            System.Console.WriteLine($"{this.name} cannot defend!");
        }
    }
}