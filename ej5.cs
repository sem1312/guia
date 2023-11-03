using System;
using System.Collections.Generic;

class Program {

  public Queue<int> filterEven (Queue<int> cola, string num){

    foreach(var i in cola){

    }
    
    

    return resultado;
  }

  public static void Main () {

    Program program = new Program();

    Queue<int> myQueue = new Queue<int>();

    Console.WriteLine("ingrese el tamaño de su cola");

    string tamaño0 = Console.ReadLine();
    int.TryParse(tamaño0, out int tamaño);

    Console.WriteLine("ingrese lo que quiere adentro de su cola");

    for(int i = 0; i < tamaño; i++){                 
      string num0 = Console.ReadLine();
      int.TryParse(num0, out int num);
      myQueue.Enqueue(num);
    }

    Console.WriteLine("ingrese ascendente (1) o -1 si no quiere hacer nada con su cola");

    string option = Console.ReadLine();

    if (option == "1"){
      Queue<int> resultado = program.filterEven(myQueue, option);

      foreach (var item in resultado) {
        Console.WriteLine(item);
      }
    } else if (option == "-1"){
      Console.WriteLine("-1");
    } else {
      Console.WriteLine("pero ingrese 1 o -1 changooooo");
    }
    
  }
}
