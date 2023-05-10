

namespace ExercicioRetanguloQuadrado.Models;

public class RetanguloQuadrado{

    // Definindo Propriedades

    private int _altura;
    public int Altura
    {
        get { return _altura; }
        set { 
            if(value >= 0)
            {
                _altura = value; 
            }
            else {
                _altura = 0;
            }
            
         }
    }

    private int _base;
    public int Base
    {
        get { return _base; }
        set { // condição para se caso o usuario digitar um valor menor que zero, ou seja, negativo.

            if(value >= 0)
            {
                _base = value; 
            }
            else {
                _base = 0;
            }
            
        }
    }

    public int AreaRQ { // assim como o enunciado pediu, criei uma prop, apenas para retornar o calculo da area
                        // é uma propriedade que tem apenas o get, ou seja, ela não recebe nada, porem passa 
                        // um valor.
        get{
            return _altura * _base; 
        }
    }
    
    // Definindo Construtores

    public RetanguloQuadrado()
    {
        
    }

    // Definindo Metodos ou funções

    public void ExibirDados(){
        Console.WriteLine($" A sua base é: {Base}");
        Console.WriteLine($" A sua altura é: {Altura} ");
        Console.WriteLine($" E a sua Area é de: {AreaRQ}");
    }
    
}