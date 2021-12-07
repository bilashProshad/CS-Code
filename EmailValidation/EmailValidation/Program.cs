using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;           

            Console.Write("Enter your email address : ");
            email = Console.ReadLine();

            CheckEmail(email);

            Console.ReadKey();
        }


        public static void CheckEmail(string email)
        {
            bool isValid = true;
            int indexAt = 0;
            int indexDot = 0;
            int countAt = 0;
            int dotBeforeAt = 0;
            int hypnBeforeAt = 0;
            int usBeforeAt = 0;
            int dotAfterAt = 0;
            int symble = 0;

            while (true)
            {
                if (email[0] >= 'a' && email[0] <= 'z' || email[0] >= 'A' && email[0] <= 'Z') { }
                else
                {
                    Console.WriteLine("Invalid email address");
                    break;
                }

                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] >= 'a' && email[i] <= 'z' || email[i] >= 'A' && email[i] <= 'Z' || email[i] >= '0' && email[i] <= '9'
                        || email[i] == '@' || email[i] == '.' || email[i] == '-' || email[i] == '_')
                    {
                        if (email[i] == '@')
                        {
                            indexAt = i;
                            countAt++;
                        }
                            
                        else if (email[i] == '.')
                            indexDot = i;

                        continue;
                    }
                    else
                    {
                        isValid = false;
                        Console.WriteLine("Invalid email address");
                        break;
                    }
                }
                if (isValid == false)
                {
                    break;
                }

                for (int i = 0; i < indexAt; i++)
                {
                    if (email[i] == '.')
                        dotBeforeAt++;
                    else if (email[i] == '-')
                        hypnBeforeAt++;
                    else if (email[i] == '_')
                        usBeforeAt++;
                }

                for (int i = indexAt+1; i < indexDot; i++)
                {
                    if (email[i] == '.' || email[i] == '@' || email[i] == '.' || email[i] == '-' || email[i] == '_')
                    {
                        if (email[i] == '.')
                            dotAfterAt++;
                        else
                            symble++;
                    }
                }

                if (indexDot == email.Length-1)
                {
                    Console.WriteLine("Invalid email address");
                    break;
                }

                else if (countAt != 1)
                {
                    Console.WriteLine("Invalid email address");
                    break;
                }

                else if ((indexAt + 1) == indexDot)
                {
                    Console.WriteLine("Invalid email address");
                    break;
                }                              

                else if(usBeforeAt>1 || hypnBeforeAt > 1 || dotBeforeAt > 1)
                {
                    Console.WriteLine("Invalid email address");
                    break;
                }

                else if(dotAfterAt > 0 || symble > 0)
                {
                    Console.WriteLine("Invalid email address");
                    break;
                }

                else if (indexAt < indexDot)
                {
                    Console.WriteLine("Valid email address");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid email address");
                    break;
                }
            }
        }


    }
}
