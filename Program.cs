using System;

namespace P1
{
    class Program
    {
        public decimal fee(double gpa){
            var semFee=0.0;
            if(gpa>=3.3 && gpa <=4.0){
                semFee = 4321.12*0.4;
               
            }
            if(gpa >0.0 && gpa < 3.3){
                semFee=4321.12;
            }
            return Convert.ToDecimal(semFee);

        }
        static void Main(string[] args)
        {
            var gpa = 0.0;
            var s=0;
            var grade = 'q';
            var gradeChar = String.Empty;
            var name = String.Empty;
            Console.WriteLine("Welcome To Student Gpa Calculator App!\n");
            while(true){
            
            while(name == ""){
            Console.WriteLine($"Enter your name: ");
            name = Console.ReadLine();
            }

                Console.WriteLine($"Enter your gpa between 0 and 4: ");
                var ans = Console.ReadLine();
                gpa = Convert.ToDouble(ans);
                Program l = new Program();
            if(gpa>=3.3 && gpa <=4.0){
                Console.WriteLine($"You are eligible for scolorship of: {l.fee(gpa)}.");
            }
            else if(gpa >0.0 && gpa < 3.3){
                     Console.WriteLine($"You need to pay fee of: {l.fee(gpa)}.");    
            }
            Console.WriteLine($"Enter your grade: ");
            gradeChar = Console.ReadLine();
            var g1 = gradeChar.ToLower();
            grade = Convert.ToChar(g1);
            switch(grade){
                case 'a' : Console.WriteLine($"Your percentage is more than 90, Good Job!!.");
                break;
                case 'b': Console.WriteLine($"Your percentage is more than 80, Good!.");
                break;
                case 'c':  Console.WriteLine($"Your percentage is more than 70, Try Hard :).");
                break;
                default:  Console.WriteLine($"Your percentage is very low, Best of Luck!!!.");
                break;
            }
            
            Console.WriteLine("Enter 1 to quit: ");
                var p = Console.ReadLine();
                    s=Convert.ToInt16(p);
                if(s == 1){
                    Console.WriteLine("Good Bye!!");
                    break;
                }
                name = "";
                }
            }
            
        }
    }

