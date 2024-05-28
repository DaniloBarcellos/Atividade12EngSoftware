using System;
public static class OperacoresSimples
{
    public static int Soma(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
    
    public static int Subtracao(int numero1, int numero2)
    {
        return numero1 - numero2;
    }
    
    public static int Multiplicacao(int numero1, int numero2)
    {
        return numero1 * numero2;
    }

    public static float Divisao(int numero1, int numero2)
    {
        if (numero2 == 0)
        {
            return -1;
        }
        return numero1/numero2;
    }

    public static class Tratamentos
{
    public static int TratamentoGeral(string numero1)
    {
        int numero;
        try
        {
            numero = int.Parse(numero1);
        }catch(Exception e)
        {
            return 1;
        }
        return numero;
    }
}
}

class HelloWorld {
  static void Main() 
  {


  }

}