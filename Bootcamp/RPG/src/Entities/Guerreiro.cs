namespace RPG.src.Entities
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string Name,int Level, string HeroType, int Vida, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Vida = Vida;
            this.Mana = Mana;
        }

         public override string Ataque(){
            return $"Lançou magia";
        }

        public string Ataque(int Bonus){
            if(Bonus>6){
                 return $"Você atacou com uma espada super efetiva com bonus de {Bonus}";   
            }else{
                return $"Você atacou com uma espada fraca com bonus de {Bonus}";
            }
        }

    }
}