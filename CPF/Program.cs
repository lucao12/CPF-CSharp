using System;
class program
{
    static long ContaCPF(long cpf)
    {
        long primeiro, conta = 100000000, soma = 0, num1;
        int contador = 1;
        do
        {
            primeiro = cpf / conta;
            Math.Floor((double)primeiro);
            cpf = cpf - primeiro * conta;
            primeiro *= contador;
            contador++;
            soma = soma + primeiro;
            conta = conta / 10;
        } while (contador < 10);
        num1 = soma % 11;
        if (num1 >= 10)
        {
            num1 = 0;
        }
        return num1;
    }
    static long ContaCPFd(long cpf, long num1)
    {
        long primeiro, conta = 1000000000, soma = 0, num2;
        int contador = 0;
        cpf = (cpf * 10) + num1;
        do
        {
            primeiro = cpf / conta;
            Math.Floor((double)primeiro);
            cpf = cpf - primeiro * conta;
            primeiro *= contador;
            contador++;
            soma = soma + primeiro;
            conta = conta / 10;
        } while (contador < 10);
        num2 = soma % 11;
        if (num2 >= 10)
        {
            num2 = 0;
        }
        return num2;
    }
    static void Main(string[] args)
    {
        long cpf;
        do
        {
            Console.Write("Digite os 9 primeiros digitos do CPF: ");
            cpf = long.Parse(Console.ReadLine());
        }while (cpf < 99999999 || cpf > 1000000000);
        long num1 = ContaCPF(cpf);
        long num2 = ContaCPFd(cpf, num1);
        Console.WriteLine("O seu cpf final é: {0}-{1}{2}",cpf, num1, num2);
    }
}
