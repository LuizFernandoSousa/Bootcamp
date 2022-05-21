namespace RPG.src.Entities
{
    public class Mago : Personagem
    {
        public Mago(string Name,int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Mago(){

        }

        public override string Ataque(){
            return $"Lançou magia";
        }
        public string Ataque(int Bonus){
            if(Bonus>6){
                 return $"Lançou magia super efetiva com bonus de {Bonus}";   
            }else{
                return $"Lançou magia fraca com bonus de {Bonus}";
            }
            
        }

    }
}