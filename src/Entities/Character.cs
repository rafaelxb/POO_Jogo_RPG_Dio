namespace RPG_com_POO.src.Entities
{
    public abstract class Character
    {

        public Character(string name, int level, string heroType, string attackObject)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.AttackObject = attackObject;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public string AttackObject;


        public override string ToString()
        {
            return $"O nome do personagem é {Name}, seu level é o {Level} e seu tipo é {HeroType}.";
        }

        public virtual string Attack()
        {
            return $"{Name} atacou com {AttackObject}";
        }

        public virtual string Attack(int bonus)
        {
            return $"{Name} atacou com {AttackObject} e bonus de {bonus} pts.";
        }
    }
}