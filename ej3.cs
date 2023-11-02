using System;
using System.Collections.Generic;

class Program {

  public static void evaluateRpn (){

    string tamaño0 = Console.ReadLine();
    int.TryParse(tamaño0, out int tamaño);

    Queue<int> myQueue = new Queue<int>();

    for(int i = 0; i < tamaño; i++){                 
      string num0 = Console.ReadLine();
      int.TryParse(num0, out int num);
      myQueue.Enqueue(num);
    }

    foreach(var item in myQueue){
      if(item % 2 != 0){
        Console.WriteLine(item);
      }
    }
  }

  public static void Main (string[] args) {
    evaluateRpn();
  }
}
