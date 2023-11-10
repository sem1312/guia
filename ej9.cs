using System;
using System.Collections;
using System.Collections.Generic;

class Program {

  public ArrayList Ordenacion (ArrayList lista){

    int n = lista.Count;
    int temp;
    bool swapped;

    for(int i = 0; i < n - 1; i++){
      swapped = false;
      for(int j = 0; j < n - 1; j++){
        if((int)lista[j] > (int)lista[j + 1]){
          temp = (int)lista[j];
          lista[j] = lista[j + 1];
          lista[j + 1] = temp;
          swapped = true;
        }
      }
      if(swapped == false){
        break;
      }
    }
    return lista;
  }

  public static void Main () {

    Program program = new Program();

    ArrayList miLista = new ArrayList {7,5,3,1};

    program.Ordenacion(miLista);

    foreach(var item in miLista){
      Console.WriteLine(item);
    }
  }
}
