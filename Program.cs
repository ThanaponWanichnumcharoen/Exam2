class Program
{
    static void Main(string[] args)
    {
         CircularLinkedList<char> T = new CircularLinkedList<char>(); 
        while(true)
        {
            Console.Write("Input ( Or ) : ");
            char input = char.Parse(Console.ReadLine());

        if (input != '(' && input != ')' )
        {
            Console.WriteLine("");
            Console.WriteLine("Valid");
            Console.WriteLine("");
             break;      
        }
       
        else 
        {
            int Length = T.GetLength();
            if(Length == 0)
            {
                if(input == '(' || input == ')')
                {
                    T.Add (input);
                }
                else
                {
                    Console.WriteLine("");
                }               
            }  
            
            else if (Length >= 1)
            {
                if(Length <= 2)
                {
                    if (input == '(' && T.Get(0) == T.Get(-1))
                    {
                        Console.WriteLine("Invalid pattern 1");
                    } 
                    else if (T.Get (-2) == '(' && input == T.Get(-3))
                    {
                        Console.WriteLine("Invalid pattern 2");
                    }
                    else
                    {
                        T.Add(input);
                    }
                }
                else if(Length >= 2)
                {
                    if (input == ')' && T.Get(0) == T.Get(-1))
                   { 
                        Console.WriteLine("Invalid 2");
                   }

                    else if(input == ')')
                   { 

                     if(input == T.Get(-1) && input == T.Get(-2)&& input == T.Get(-3))
                   {
                        Console.WriteLine("Invalid pattern 3");
                   }

                     else if(T.Get(1) == '(' && T.Get(2) == ')')
                   { 
                        Console.WriteLine("Invalid pattern 4");
                   }
                
                     else
                   {
                        T.Add(input);
                   }

                   }

                    else 
                    {
                        T.Add(input);
                    }

                    }

                }
            }
            Console.WriteLine("------------------------------------------------------------------");
            
             for(int i = 0 ; i < T.GetLength() ; i++)
            {
                Console.WriteLine(T.Get(i));
            }

                Console.WriteLine("");

        }
    } 
 }