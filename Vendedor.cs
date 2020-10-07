using System;

class vendedor_de_veiculos{
private double salário;
public double comissão;

string nome;
  public void setNome(string n){
    nome = n;
  }
  public string getNome(){
    return nome;
  }

public double receber_salario(double comissão, double valor_das_vendas){
return  salário+comissão*valor_das_vendas;
}

public  vendedor_de_veiculos (string n, double s, double c){
 nome = n;
 salário = s;
 comissão = c;
}

}