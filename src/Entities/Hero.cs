namespace rpgGame.src.Entities
{
    public class Hero
    {
        public Hero(string name, int level, string heroType){
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return $"{this.Name} {this.Level} {this.HeroType}";
        }

        public virtual string Attack(){
            return $"{this.Name} Atacou com a sua espada."; 
        }

        public string Attack(int Bonus) {
            return this.Name + " lançou Magia com bônus de ataque de " + Bonus;
        }
    }
}