using System.Collections.Generic;

class mostruario {
  //TAD
  private vendedor_de_veiculos Representante;
        //EST  <TAD>    VARIAVEL 
  public List<Veiculo> carros;

  public mostruario(){
    carros = new List<Veiculo>();
    

  }

  public void setRepresentante(vendedor_de_veiculos v){
    Representante = v;
  }


}