using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

class Program {

  public ArrayList selectionSort (ArrayList lista){

    int n = lista.Count;

    for (int i = 0; i < n - 1; i++){
            int min = i;
            for (int j = i + 1; j < n; j++){
                if ((int)lista[j] < (int)lista[min]){
                    min = j;
                }
            }
            int temp = (int)lista[min];
            lista[min] = lista[i];
            lista[i] = temp;
        }

          return lista;
  }

  public static void Main () {

    Program program = new Program();

    ArrayList miLista = new ArrayList {7,5,3,1,73,18,82};

    program.selectionSort(miLista);

    foreach(var item in miLista){
      Console.WriteLine(item);
    }


    
  }
}
