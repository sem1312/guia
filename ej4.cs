using System;
using System.Collections.Generic;

class Program {

  public static bool IsPalindromo(string word) {
    bool isPalindromo = true;

    Queue<char> myQueue = new Queue<char>();
    Queue<char> myQueueInvertida = new Queue<char>();

    for(int i = 0; i < word.Length; i++){
      myQueue.Enqueue(word[i]);
    }

    for(int i = word.Length - 1; i < 0; i--){
      myQueueInvertida.Enqueue(word[i]);
    }

    if(myQueue == myQueueInvertida){
      return isPalindromo;
    }else{
      isPalindromo = false;
    }

    return isPalindromo;
  }

  public static void Main() {
    string word = Console.ReadLine().ToLower(); 
    if (IsPalindromo(word)) {
      Console.WriteLine("si");
    } else {
      Console.WriteLine("no");
    }
  }
}
