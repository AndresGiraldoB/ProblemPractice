/*
Problem
Most programmers will tell you that one of the ways to improve your performance in competitive
programming is to practice a lot of problems.

Our Chef took the above advice very seriously and decided to set a target for himself.

Chef decides to solve at least 10 problems every week for 4 weeks.Given the number of problems 
he actually solved in each week over  4 weeks as P1,P2,P3 , and P4, output the number of weeks 
in which Chef met his target.


Input Format
There is a single line of input, with 4 integers P1,P2,P3, and P4. These are the number of problems
solved by Chef in each of the 4 weeks.

Sample 1:
Input
Output
12 15 8 10
3
Explanation:
Chef solved at least 
10 problems in the first, second and fourth weeks. He failed to solve at least 
10 problems in the third week. Hence, the number of weeks in which Chef met his target is 3.


*/
//AndresGiraldoB
using System;

public class Test
{
	public static void Main()
	{
       int P, result = 0;
        
        string[] problems = Console.ReadLine().Split();
        for(int i = 0; i < problems.Length;i++)
        {
           P = int.Parse(problems[i]);
           if(P >= 10)
               result ++;
        }
        Console.WriteLine(result);
	}
	
}
