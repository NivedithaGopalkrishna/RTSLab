using System;

  class Program1
  {
     static void compute(int[] nums, int n){
         int a=0 , b =0;

        //'b' stores the count of numbers < given number & 'a' stores the count of numbers > given number 
        for (int i=0;i<nums.Length ; i++){
             if(nums[i]<n){
                b++;
             }
             else{
                 a++;
             }
      
         }

        //Output a and b
         Console.WriteLine("Above:" + a + "Below:" + b);
    }
    
    static void Main(string[] args)
    {
      //Accepts Size of the array
      Console.WriteLine("Enter array size:");   
      int size = Convert.ToInt32(Console.ReadLine());

      //Create an array with the size indicated by the user  
      int[] input = new int[size];

      //Accept array input  
      Console.WriteLine("Enter array inputs:");   
      for(int i=0;i<size ; i++){
        input[i]= Convert.ToInt32(Console.ReadLine());
      }

      //Accept a number from the user
      Console.WriteLine("Enter a number");  
      int n = Convert.ToInt32(Console.ReadLine());

      //function to compute the required output
      compute(input,n);
    }
  }