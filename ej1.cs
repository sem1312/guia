using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    List<int> myList = new List<int>();
    myList.Add(2);
    myList.Add(3);
    myList.Add(9);
    
    Stack<int> myStack = new Stack<int>();

    foreach(var item in myList)
      myStack.Push(item);
      
    foreach(var item in myStack)
      Console.WriteLine(item + "");
    
    
  }
}