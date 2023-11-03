using System;
using System.Collections.Generic;

class Program {
  public bool IsPalindrome(string word) {
    bool isPalindrome = true;

    Queue<char> myQueue = new Queue<char>();

    foreach (char c in word) {
      myQueue.Enqueue(c);
    }

    string invertedWord = new string(word.ToCharArray().Reverse().ToArray());

    foreach (char c in invertedWord) {
      if (c != myQueue.Dequeue()) {
        isPalindrome = false;
        break;
      }
    }

    return isPalindrome;
  }

  public static void Main() {

    Program program = new Program();

    string input = Console.ReadLine();
    
    if (program.IsPalindrome(input)) {
      Console.WriteLine("si");
    } else {
      Console.WriteLine("no");
    }
  }
}

