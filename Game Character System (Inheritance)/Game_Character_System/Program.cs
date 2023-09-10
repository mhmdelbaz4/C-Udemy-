using GameSystem;

Warrior c1 = new Warrior("Arthur", 100, 20, 10);
Mage c2 = new Mage("Merlin", 80, 15, 5);
Dragon c3 = new Dragon("Smaug", 200, 30, 20);

c1.Attack(c2);
c2.Defend();
c3.BreatheFire(c1);
c3.Defend();
c1.Defend();

Game game = new Game();
game.Battle(c1, c2);
game.Battle(c3, c1);
game.Battle(c2, c3);

Console.ReadKey();
