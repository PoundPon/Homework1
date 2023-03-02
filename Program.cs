using System;
namespace Homework1{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter your password: ");
            int password = int.Parse(Console.ReadLine());
            int hundredKs = password / 100000;
            int tenKs = (password - (hundredKs*100000))/10000;
            int thousands = (password - (hundredKs*100000) - (tenKs*10000))/1000 ;
            int hundreds = (password - (hundredKs*100000) - (tenKs*10000) - (thousands*1000))/100;
            int tens = (password - (hundredKs*100000) - (tenKs*10000) - (thousands*1000) - (hundreds*100))/10;
            int units = (password - (hundredKs*100000) - (tenKs*10000) - (thousands*1000) - (hundreds*100) - (tens*10));
            bool input = password <= 999999;
            Console.WriteLine(hundredKs);
            Console.Write("Enter your agency: ");
            string agency = Console.ReadLine();
            switch(agency){
                case "CIA":
                if (input = true && hundredKs > 0) {
                    if (units%3 == 0){
                        if (tens != 1 || tens != 3 || tens != 5) {
                            if (thousands >= 6 && thousands != 8) {
                                Console.WriteLine("True");
                            }
                            else {
                                Console.WriteLine("False");
                            }
                        }
                        else {
                            Console.WriteLine("False");
                        }
                    }
                    else {
                        Console.WriteLine("False");
                    }

                }
                else {
                    Console.WriteLine("False");
                }
                break;
                case "FBI":
                if (input = true && hundredKs > 0) {
                    if ( hundredKs >= 4 && hundredKs <= 7){
                        if ( hundreds % 2 == 0 && hundreds != 6) {
                            if ( tenKs % 2 != 0) {
                                Console.WriteLine("True");
                            }
                            else {
                                Console.WriteLine("False");
                            }
                        }
                        else {
                            Console.WriteLine("False");
                        }
                    }
                    else {
                        Console.WriteLine("False");
                    }

                }
                else {
                    Console.WriteLine("False");
                }
                break;
                case "NSA":
                if (input = true && hundredKs > 0) {
                    if (30 % units == 0){
                        if (hundreds % 3 == 0 && hundreds % 2 != 0) {
                            if ( hundredKs == 7 || tenKs == 7 || thousands == 7 || hundreds == 7 || tens == 7 || units == 7) {
                                Console.WriteLine("True");
                            }
                            else {
                                Console.WriteLine("False");
                            }
                        }
                        else {
                            Console.WriteLine("False");
                        }
                    }
                    else {
                        Console.WriteLine("False");
                    }

                }
                else {
                    Console.WriteLine("False");
                }
                break;
            }
            
        }

    }
}
