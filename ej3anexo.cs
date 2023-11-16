using System;
using System.Runtime.CompilerServices;

class Program {
  public int compa(string cadena, int num){
    
    Queue<int> Cola = new Queue<int>();

    for(int i = 0; i+2 < cadena.Length; i++){
      int.TryParse(cadena[i].ToString(), out int num0);
      int.TryParse(cadena[i+1].ToString(), out int num1);
      int.TryParse(cadena[i+2].ToString(), out int num2);
      Cola.Enqueue(num0*num1*num2);
    }

    int maximo = int.MinValue;

    foreach(var item in Cola){
       if (item > maximo){
                maximo = item;
      }
    }

    return maximo;
  }
  
  public static void Main () {
    
    Program program = new Program();
    
    string cadena = "1027839564";
    int num = 3;
    
    int res = program.compa(cadena, num); 
    Console.WriteLine(res);
  }
}
