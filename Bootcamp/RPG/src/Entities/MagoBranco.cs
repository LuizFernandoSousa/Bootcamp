namespace RPG.src.Entities
{
    public class MagoBranco : Mago
    {
        public MagoBranco(string Name,int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Ataque(){
            return $"Lançou magia";
        }

        public string Ataque(int Bonus){
            if(Bonus>6){
                 return $"Lançou magia de luz super efetiva com bonus de {Bonus}";   
            }else{
                return $"Lançou magia de luz fraca com bonus de {Bonus}";
            }
        }
    }
}