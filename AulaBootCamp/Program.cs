using static System.Console;
public class Program
{
    static int EncontrarNumero(int[] numeros, int numero){
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i]==numero){
                return i;
            }else{
                return -1;  
            }
            
        }

    }
    
    public static void Main(){
     int[] numeros = new int[] {0,2,4,6,8};

    WriteLine("Digite o numero de desejado procurar: ");
    var numero = int.Parse(ReadLine());
    var idxEncontrado = EncontrarNumero(numeros, numero);


    if(idxEncontrado >= 0){

        WriteLine($"O numero digitado esta na posição: {idxEncontrado}");

    }else{
        WriteLine("O numero não foi encontrado");
    }

    }
}