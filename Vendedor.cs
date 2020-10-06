using System;

class vendedor_de_veiculos{
private double salário;
public double comissão;

public receber_salario(double salário, double comissão, double valor_das_vendas){
return salário+comissão*valor_das_vendas;

}
}