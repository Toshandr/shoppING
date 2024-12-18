using System.Runtime.InteropServices;

namespace shoppING;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many rubles in your wallet?");
        int wallet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        string[] assort = {"bread", "milk", "lemon"};
        int[] prices = {59, 100, 90};
        Console.WriteLine("Good afternoon! What do you want?");
        Console.WriteLine("Today we have: ");
        foreach(string i in assort){
            Console.Write(i + "  ");
        }
        Console.WriteLine(" ");
        string request = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("How many?");
        int col = Convert.ToInt32(Console.ReadLine());
        shopping(assort, prices, request, col, wallet);


    }

    static void shopping(string[] assort, int[] prices, string request, int col, int wallet){
        switch(request){
            case "bread":
                int coast = prices[0] * col;
                if(coast <= wallet){
                    Console.WriteLine($"Your change: {wallet - coast}");
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else{
                    while(coast > wallet){
                        coast -= prices[0];
                    }
                    int newCol = coast / prices[0];
                    Console.WriteLine(" ");
                    Console.WriteLine($"I'm sorry, but you only have enough for this amount of goods: {newCol}");
                    Console.WriteLine("Do you want to buy?(print num)");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int zapros = Convert.ToInt32(Console.ReadLine());
                    if (zapros == 1){
                        int endCoast = prices[0] * newCol;
                        Console.WriteLine($"Your change: {wallet - coast}");
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    if (zapros == 2){
                        Console.WriteLine("Okay, Goodbye!");
                        break;
                    }
                    else{
                        Console.WriteLine("Да емае я цифру а не слово прошу, вот теперь перезапускай");
                        break;
                    }
                    
                }
            case "milk":
                int coast2 = prices[1] * col;
                if(coast2 <= wallet){
                    Console.WriteLine($"Your change: {wallet - coast2}");
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else{
                    while(coast2 > wallet){
                        coast2 -= prices[1];
                    }
                    int newCol = coast2 / prices[1];
                    Console.WriteLine(" ");
                    Console.WriteLine($"I'm sorry, but you only have enough for this amount of goods: {newCol}");
                    Console.WriteLine("Do you want to buy?(print num)");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int zapros = Convert.ToInt32(Console.ReadLine());
                    if (zapros == 1){
                        int endCoast = prices[1] * newCol;
                        Console.WriteLine($"Your change: {wallet - coast2}");
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    if (zapros == 2){
                        Console.WriteLine("Okay, Goodbye!");
                        break;
                    }
                    else{
                        Console.WriteLine("Да емае я цифру а не слово прошу");
                        break;
                    }
                }
            case "lemon":
                int coast3 = prices[2] * col;
                if(coast3 <= wallet){
                    Console.WriteLine($"Your change: {wallet - coast3}");
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else{
                    while(coast3 > wallet){
                        coast3 -= prices[2];
                    }
                    int newCol = coast3 / prices[2];
                    Console.WriteLine(" ");
                    Console.WriteLine($"I'm sorry, but you only have enough for this amount of goods: {newCol}");
                    Console.WriteLine("Do you want to buy?(print num)");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int zapros = Convert.ToInt32(Console.ReadLine());
                    if (zapros == 1){
                        int endCoast = prices[2] * newCol;
                        Console.WriteLine($"Your change: {wallet - coast3}");
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    if (zapros == 2){
                        Console.WriteLine("Okay, Goodbye!");
                        break;
                    }
                    else{
                        Console.WriteLine("Да емае я цифру а не слово прошу");
                        break;
                    }
                }
            default:
                Console.WriteLine("There is no such good");
                Console.WriteLine("Goodbye!");
                break;  
        }
    }
}
        
    
