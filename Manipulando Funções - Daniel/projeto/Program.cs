using System;

class Program
{
  static void Main()
  {
    string nome = Console.ReadLine();
    double quilometrosPorDia = double.Parse(Console.ReadLine());
    int horasDeEletronicos = int.Parse(Console.ReadLine());
    int refeicoesComCarne = int.Parse(Console.ReadLine());

    double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
    Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");
    Console.ReadLine();
  }

  static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
  {
    const double fatorTransporte = 0.2;
    const double fatorEletronicos = 0.1;
    const double fatorCarne = 0.5;
    const int diasNoAno = 365;

    double pegadaTransporte = quilometrosPorDia * diasNoAno * fatorTransporte;
    double pegadaEletronicos = horasDeEletronicos * fatorEletronicos;
    double pegadaCarne = refeicoesComCarne * fatorCarne;

    double pegadaTotal = pegadaTransporte + pegadaEletronicos + pegadaCarne;
    return pegadaTotal;
  }
}