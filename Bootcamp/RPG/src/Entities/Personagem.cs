namespace RPG.src.Entities
{
    public class Personagem
    {

        public Personagem(string Name,int Level, string HeroType, int Vida, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Vida = Vida;
            this.Mana = Mana;
        }

        public Personagem(){

        }
    
        public string Name;
        public int Level;
        public string HeroType;
        public int Vida;
        public int VidaTotal;
        public int Mana;
        public int ManaTotal;
        

        public override string ToString()
        {
            return $"{Name} {Level} {HeroType}";
        }

        public virtual string Ataque(){
            return $"Você atacou com a espada";
        }



    }
}