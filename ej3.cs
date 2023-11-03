using System;
using System.Collections.Generic;

class Program {

  public Queue<int> filterEven (int tamaño){

    Queue<int> myQueue = new Queue<int>();
    Queue<int> myQueueFiltrado = new Queue<int>();

    for(int i = 0; i < tamaño; i++){                 
      string num0 = Console.ReadLine();
      int.TryParse(num0, out int num);
      myQueue.Enqueue(num);
    }

    foreach(var item in myQueue){
      if(item % 2 == 0){
        myQueueFiltrado.Enqueue(item);
      }
    }

    return myQueueFiltrado;
  }

  public static void Main () {

    Program program = new Program();

    string tamaño0 = Console.ReadLine();
    int.TryParse(tamaño0, out int tamaño);

    Queue<int> resultado = program.filterEven(tamaño);

    foreach (var item in resultado) {
      Console.WriteLine(item);
    }
    
  }
}
