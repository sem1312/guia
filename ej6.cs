using System;
using System.Collections;
using System.Collections.Generic;

class Program {
  public ArrayList SliceArrayList(ArrayList arrayList, int startIndex, int length) {
        ArrayList result = new ArrayList();
        for (int i = startIndex; i < startIndex + length; i++) {
            result.Add(arrayList[i]);
        }
        return result;
    }
  public bool binarySearch (ArrayList lista, int num){

    Program program = new Program();

    int mid = lista.Count / 2;

    if((int)lista[mid] == num){
      return true;
    }else if(lista.Count == 1){
      return false;
    }else if ((int)lista[mid] > num){
      ArrayList listaNuevaIzq = program.SliceArrayList(lista, 0, mid);
      return binarySearch(listaNuevaIzq, num);
    }else{
      ArrayList listaNuevaDer = program.SliceArrayList(lista, mid, lista.Count);
      return binarySearch(listaNuevaDer, num);
    }
  }

  public static void Main () {

    Program program = new Program();

    ArrayList miLista = new ArrayList {7,5,3,1,73,18,82};
    miLista.Sort();

    int num = 2;

    if(program.binarySearch(miLista, num)){
      Console.WriteLine("si esta chango");
    } else {
      Console.WriteLine("no esta:(");
    }
  }
}
