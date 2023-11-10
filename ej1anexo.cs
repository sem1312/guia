using System;
using System.Collections;
using System.Collections.Generic;

class Program {

  public string Atbash (string cadena){

    List<char> abcList = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    List<char> abcInvertidoList = new List<char> {'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a'};
    List<char> cifrado0 = new List<char>{};

    foreach(var item in cadena){
      int i = abcList.IndexOf(item);
      cifrado0.Add(abcInvertidoList[i]);
    }

    string cifrado = new string(cifrado0.ToArray());
     
    return cifrado;

  }

  public static void Main () {

    Program program = new Program();


    string frase = "test test";
    frase = frase.Replace(" ", "");

    string cifrado = program.Atbash(frase);

    Console.WriteLine(cifrado);
  }
}
