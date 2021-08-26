using System;

class Program {
  public static void Main (string[] args) {
    Sistema sistema = new Sistema();
    Carro carro = new Carro();
    Pessoa p1 = new Pessoa("Nome da pessoa", sistema, null, carro, null); // string double sistema automovel
    
    p1.pagar();

    Pessoa p2 = new Pessoa(); // Pessoa com moto
    Pessoa p3 = new Pessoa(); // Pessoa com caminhão




  }
}