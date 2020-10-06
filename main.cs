using System;

class MainClass {
  public static void Main () {
    vendedor_de_veiculos carlos = new vendedor_de_veiculos();
    Veiculo uno = new Veiculo();

    mostruario secaoA = new mostruario();
    secaoA.setRepresentante(carlos);

    secaoA.carros.Add(uno);

  }
}