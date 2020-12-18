//0 1 1 2 3
using System;
public class fibonacci
{
    public static void Main(string[] args)
    {
        int num1=0, num2=1, N, next;
        Console.WriteLine("Enter a number (N) to print first N th numbers of fibonacci series");
        N=Convert.ToInt32( Console.ReadLine());//N=5
        System.Console.WriteLine(" Fibonacci series first "+ N + " numbers"); //5
        System.Console.Write(" "+ num1); //0
        System.Console.Write(" "+ num2);//1
        for(int i=2; i<N; i++)//4<5 true
        {
            next=num1+num2; // next=1+2=3
            System.Console.Write(" " + next); //3
            num1=num2; //1
            num2=next; //2
        }
    }
}