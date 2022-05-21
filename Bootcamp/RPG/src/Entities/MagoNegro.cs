namespace RPG.src.Entities
{
    public class MagoNegro : Mago
    {
        public MagoNegro(string Name,int Level, string HeroType)
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
                 return $"Lançou magia uma magia negra super efetiva com bonus de {Bonus}";   
            }else{
                return $"Lançou magia negra fraca com bonus de {Bonus}";
            }
        }
    }
}