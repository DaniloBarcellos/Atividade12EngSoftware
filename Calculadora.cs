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

public class EntradaSaida
{
    private int _numero1;
    private int _numero2;
    
    public static void Menu()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("---------------------------");
        Console.WriteLine();
        Console.WriteLine("*Caso a entrada seja incorreta, o número será 1");
    }
    
    public void Entrada()
    {
        Console.WriteLine("Insira o primeiro número");
        _numero1 = Tratamentos.TratamentoGeral(Console.ReadLine());
        Console.WriteLine("Insira o segundo número");
        _numero2 = Tratamentos.TratamentoGeral(Console.ReadLine());
    }
    
    public void Conta()
    {
        Console.Clear();
        MenuTipoConta();
        if (TipoConta() == 1)
        {
            OperacoesIntermediarias();
        }
        else
        {
            OperacoesBasicas();
            EscolhaOperacaoBasica();
        }
    }
    
    private void MenuTipoConta()
    {
        Console.WriteLine("Escolha o tipo operação:");
        Console.WriteLine("0: soma, subtração, multiplicação ou divisão");
        Console.WriteLine("1: expoente, divisão inteira ou subtração absoluta");
        Console.WriteLine("*Se a entrada for inválida, a opção 0 será considerada");
    }
    
    private void OperacoesBasicas()
    {
        Console.WriteLine("0: soma");
        Console.WriteLine("1: subtração");
        Console.WriteLine("2: multiplicação");
        Console.WriteLine("3: divisão");
        
    }
    
    private void OperacoesIntermediarias()
    {
        Console.WriteLine("0: expoente");
        Console.WriteLine("1: divisão inteira");
        Console.WriteLine("2: subtração absoluta");
    }
    
    private int TipoConta()
    {
        string entrada = Console.ReadLine();
        if (entrada == "1")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    
    private void EscolhaOperacaoBasica()
    {
        string escolha = Console.ReadLine();
        
        if (escolha == "0") //soma
        {
            Console.WriteLine(_numero1 + "+" + _numero2 + "=" + OperacoresSimples.Soma(_numero1, _numero2));
        }
        else
        {
            if (escolha == "1") //subtração
            {
                Console.WriteLine(_numero1 + "-" + _numero2 + "=" + OperacoresSimples.Subtracao(_numero1, _numero2));
            }
            else
            {
                if (escolha == "2") //multiplicão
                {
                    Console.WriteLine(_numero1 + "*" + _numero2 + "=" + OperacoresSimples.Multiplicacao(_numero1, _numero2));
                }
                else
                {
                    if (escolha == "3") //divisão
                    {
                        Console.WriteLine(_numero1 + "/" + _numero2 + "=" + OperacoresSimples.Divisao(_numero1, _numero2));
                    }
                    else
                    {
                         Console.WriteLine(_numero1 + "/" + _numero2 + "=" + OperacoresSimples.Divisao(_numero1, _numero2));
                    }
                }
            }
        }
    }
    
}



class HelloWorld {
  static void Main() 
  {
    EntradaSaida calculos = new EntradaSaida();
    EntradaSaida.Menu();
    calculos.Entrada();
    calculos.Conta();
  }


  /////Comentário aleatório
}
