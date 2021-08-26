public class Pessoa {
  private string    Nome {get; set;}
  private double    qntDinheiro {get; set ;}
  private Sistema   sistema {get; set;}

  private Caminhao caminhao {get; set;}
  private Carro carro {get; set;}
  private Moto moto {get; set;}

  public Pessoa(string   _Nome, double  _qntDinheiro, Sistema  _sistema, Caminhao _caminhao, Carro _carro, Moto _moto) {
    this.Nome = _Nome;
    this.qntDinheiro = _qntDinheiro;
    this.sistema = _sistema;
    this.Caminhao = _caminhao;
    this.Carro = _carro;
    this.Moto = _moto;
  }

  public bool pagar() {
	  
    double quantidadePagar = sistema.verificarPagamento(automovel);

  }
}