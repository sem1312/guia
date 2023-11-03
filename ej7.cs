using System;
using System.Collections;
using System.Collections.Generic;

class Program {

  public bool linearSearch (ArrayList lista, int num){

    for(int i = 0; i < lista.Count - 1; i++){
      if((int)lista[i] == num){
        return true;
      }
    }
    return false;
  }

  public static void Main () {

    Program program = new Program();

    ArrayList miLista = new ArrayList {7,5,3,1,73,18,82};
    miLista.Sort();

    int num = 7;

    if(program.linearSearch(miLista, num)){
      Console.WriteLine("si esta chango");
    } else {
      Console.WriteLine("no esta:(");
    }
  }
}
