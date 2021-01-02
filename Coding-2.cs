using System;

  class Program2
  {
     static char[] compute(char[] str, int d){
       int len = str.Length;
       int k = d%len;
       rotate(str,0,len-1);
       rotate(str,0,k-1);
       rotate(str,k,len-1);
      return str;
    }

    static void rotate(char[] str, int low, int high){
      char temp;

       //swap the characters
       while(low<high){
       temp = str[low];
       str[low]=str[high];
       str[high]=temp;
       low++;
       high--;
       }
    }

    
    static void Main(string[] args)
    {
      //Accept a string from the user
      Console.WriteLine("Enter the String:");   
      char[] input = Console.ReadLine().ToCharArray();

      //Accept by how many places the rotation should happen
      Console.WriteLine("Enter rotation:"); 
      int d = Convert.ToInt32(Console.ReadLine());
      
      //Compute the output
      char[] output = compute(input,d);

      Console.WriteLine(output); 
    }
  }