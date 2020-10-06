using System;

class vendedor_de_veiculos{
private double salário;
public double comissão;

public void Setsalário(double s){
    salário = s;
  }
public double receber_salario(double comissão, double valor_das_vendas){
return  salário+comissão*valor_das_vendas;

}
}