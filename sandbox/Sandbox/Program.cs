using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string stop = "";
        List<int> nums = new List<int>();
        nums.Add(2);
        int integer = 0;
        // Console.WriteLine(prime(nums, 7));
        while(stop != "quit"){
            integer++;
            if(prime(nums, integer) == true){
                Console.WriteLine(integer);
                nums.Add(integer);
            }
            stop = Console.ReadLine();
        }

        bool prime(List<int> n, int num){
            foreach(int nu in n){
                if(num%nu == 0){
                    return false;
                }
            }
            return true;
        }
    }
}