using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program {

  public int Compa(string arg, int base0){

    Queue<int> cola = new Queue<int>();
    
    for(int i = 0; i < arg.Length; i++){
      int.TryParse(arg[i].ToString(), out int num);
      int res = (int)(num * Math.Pow(base0, i));
      cola.Enqueue(res);
    }

    int sum = 0;

    foreach(var item in cola){
      sum += item;
    }

    return sum;
    
  }
  
  public static void Main () {
    
    Program program = new Program();
    
    string num ="42";
    int base0 = 2;

    int res = program.Compa(num, base0);
    Console.WriteLine(res);
  }
}
