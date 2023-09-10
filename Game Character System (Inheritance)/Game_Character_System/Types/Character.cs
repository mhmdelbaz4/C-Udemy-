namespace  GameSystem
{
    public class Character
    {

        public Character(string name, int health, int attack, int defense)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
        }
        public string name;
        public int health;
        public int attack; 
        public int defense;

        public virtual void Attack(Character target)
        {
            int damage = this.attack - target.defense;

            if(damage > 0)
            {
                target.health -= damage;
                System.Console.WriteLine($"{this.name} attacks {target.name} for {damage} damage!");
            }
            else
            {
                System.Console.WriteLine($"{this.name}'s attack has no effect on {target.name}.");
            }
        }
        public virtual void Defend()
        {
            defense += 5;
            System.Console.WriteLine($"{this.name} defends and gains 5 defense.");
        }
    }
}