using System;
using System.IO; // A Streamwriter miatt.
using System.Text; // Az Encoding.Default miatt.

class Program {
  public static void Main (string[] args) {
    
    StreamWriter f_iras =  new StreamWriter("hello.txt"); 
        f_iras.WriteLine("árvíztűrő ikerfúrógép");
    f_iras.Close();
  
    StreamReader f_olvas =  new StreamReader("hello.txt", Encoding.Default); 
        string elsosor = f_olvas.ReadLine();
        Console.WriteLine(elsosor);
    f_olvas.Close();
   
  }
}