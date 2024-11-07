using System;
//digunakan kelas dari system namespace

namespace Tugas // digunakan untuk mengatur kode 
{
  class PBO //wadah data dan metode yang memberikan fungsionalitas pada program 
  {
    static void Main(string[] args) //static yaitu metode tersebut milik kelas program
    {
      string name = "Rodifa";
      Console.WriteLine(name); 
       int myInt = 29;
      double myDouble = 2.900;
      bool myBool = false;

      Console.WriteLine(Convert.ToString(myInt));    
      Console.WriteLine(Convert.ToDouble(myInt));    
      Console.WriteLine(Convert.ToInt32(myDouble));  
      Console.WriteLine(Convert.ToString(myBool)); 
      {
     string[] food = {"Bakmi", "Mie ayam", "Nasi Goreng",};
      foreach (string i in food) 
      {
        Console.WriteLine(i);
      }  
      } 
      Console.WriteLine("Your age is: " + age); 
      Console.WriteLine(Math.Sqrt(100));  
     }
  }

}
