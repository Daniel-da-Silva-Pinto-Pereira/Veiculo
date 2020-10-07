using System;

class Veiculo{
 private string marca;
 private int ano;
 private double valor;
 private int km;
 
 
public void relatório(string marca, int ano, double valor, int km){
  Console.WriteLine("Marca Escolhida> {0} /n Ano >> {1} /n Valor >> {2} Reais /n Kilometragem >> {3}", marca, ano, valor, km);}

private double atualizar_valor(double valor, int ano_base){
 return valor = valor - (ano_base-ano)*2.05;
}
 public Veiculo (string m, int a, int k, double v){
    marca = m;
    ano = a;
    km = k;
    valor = v;
}

}