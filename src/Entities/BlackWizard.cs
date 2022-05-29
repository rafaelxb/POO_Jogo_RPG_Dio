namespace RPG_com_POO.src.Entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string name, int level, string heroType, string attackObject) : base(name, level, heroType, attackObject)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.AttackObject = attackObject;
        }

        public override string Attack(){
           
            return $"{this.Name} lançou Magia Negra.";
            
        }

        public override string Attack(int bonus){
           
            if(bonus > 6)
            {
                return $"{this.Name} lançou magia negra super efetiva com bonus de ataque de {bonus} pts";
            }else
            {
                return $"{this.Name} lançou magia negra fraca com bonus de ataque de {bonus} pts";
            }
            
        }
    }
}