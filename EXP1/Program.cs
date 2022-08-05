using System;  
class ifdemo  
{  
  public static void Main()  
  {  
  int a,b;  
  Console.WriteLine("enter 2 no ");  
   a=int.Parse (Console.ReadLine());  
  b=int.Parse(Console.ReadLine());  
  if(a>b)  
     {  
       Console.WriteLine("a is greather");  
      }  
  else if(a< b)  
      {  
      Console.WriteLine("b is greather");  
      }  
  else   
     {  
    Console.WriteLine("both are Equals");  
     }  
Console.ReadLine();  
}  
