namespace GameCore.Cards
{
    public class Card
    {
        public readonly string Name;

        public readonly int AttackDamage;

        public readonly int Health;

        public Card(string name, int attackDamage, int health)
        {
            Name = name;
            AttackDamage = attackDamage;
            Health = health;
        }
    }
}