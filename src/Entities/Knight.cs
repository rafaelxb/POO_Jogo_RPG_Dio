namespace RPG_com_POO.src.Entities
{
    public class Knight : Character
    {
        public Knight(string name, int level, string heroType, string attackObject) : base(name, level, heroType, attackObject)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.AttackObject = attackObject;
        }
    }
}