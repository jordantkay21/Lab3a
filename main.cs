using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");
    int celsius=Convert.ToInt32(Console.ReadLine());
  
    double stepOne=celsius*9/5;
    double farenheit=stepOne + 32;
    
    Console.WriteLine("Farenheit equivalent for " + celsius + " degree celsius is " + farenheit);


  if(farenheit<32)
  {
    Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
  }
  else if (farenheit>212)
  {
    Console.WriteLine("This temperature is above boiling temperature of 212 degrees Farenheit");
  }
  else
  {
    Console.WriteLine("");
 
  }

  }
}