
namespace ExercicioRetanguloQuadrado.Models{
    class Program{
        static void Main(string[] args){

            // Estanciação dos Objetos

            RetanguloQuadrado rq1 = new RetanguloQuadrado();

            // Entrada de Dados

            Console.Write("Por favor informa a base do Retangulo ou quadrado: ");
            rq1.Base = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor digite a altura do Retangulo ou Quadrado: ");
            rq1.Altura = Convert.ToInt32(Console.ReadLine());

            rq1.ExibirDados();
            
        }
    }
}