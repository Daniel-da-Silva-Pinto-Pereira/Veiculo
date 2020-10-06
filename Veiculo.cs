using System;

class Atributos_do_Veiculo{
 private string marca;
 private int ano;
 private double valor;
 public int km;
 
 public void Setmarca(string m){
    marca = m;
  }
  public void Setano(int a){
    ano = a;
  }
  public void Setvalor(double v){
    valor= v;
  }

public void relatório(string marca, int ano, double valor, int km){
  Console.WriteLine("Marca Escolhida> {0} - Ano >> {1} - Valor >> {2} Reais - Kilometragem >> {3}", marca, ano, valor, km);

}
}