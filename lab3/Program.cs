﻿using System.Security.Cryptography.X509Certificates;

public class catch1{

    class YesException : Exception
    {
        public YesException() { }
        public YesException(string message) : base(message) { }
        public YesException(string message, Exception inner) : base(message,
        inner) { }
    }

    public static void Main(String[] agrs)
    {   
        Console.WriteLine("--------------Exercise2--------------");
        Console.WriteLine("Starting Number: ");
        int start= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ending Number: ");
        int end= Convert.ToInt32(Console.ReadLine());

        if (start >= end ){
            throw new  ArgumentOutOfRangeException("Out of range");
        }
        Readnumber(start,end);
    }
    

    
    
    
    public static void Readnumber(int start,int end)
    {
        try{
            Console.WriteLine(" ");
            Console.WriteLine("--------------Numbers--------------");
            Console.WriteLine($"Number must be greater than {start} and less than {end}");
           
            for(int x=start;x<end+1;x++)
            {
            int num1=Convert.ToInt32(Console.ReadLine());
            if(num1<=start || num1>=end){
                throw new YesException($"Number must be greater than {start} and less than {end}");
            }
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }

    }
}