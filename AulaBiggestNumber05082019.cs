using System;
using System.Linq;

class MainClass {
  
  public void Metodo1(int a,int b, int c){
    Console.WriteLine("(M1) - Biggest Number: "+Math.Max(Math.Max(a,b),c));
  }

  public void Metodo2(int a, int b, int c){
    int[] numbers=new int[]{a,b,c};
    Console.WriteLine("(M2) - Biggerst Number: " +numbers.Max());
  }


  public int MetodoMaiorArray(int anArray[]){
      int m = anArray.Max();

      int p = Array.IndexOf(anArray, m);

      Console.WriteLine("Biggest Number {1} it's index:{2} ",m,p);
  }


  public static void Main (string[] args) {
    int a,b,c;

    Console.WriteLine ("Input 3 numbers and We'll calculate the biggest Number: ");
    a=Convert.ToInt32(Console.ReadLine());
    b=Convert.ToInt32(Console.ReadLine());
    c=Convert.ToInt32(Console.ReadLine());

    MetodoDoProf(a,b,c);

  }
}
