using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
                String Cmd = Console.ReadLine();
                char[] v = Cmd.ToCharArray();
                int i = 0;

                int _P = System.Convert.ToInt32(v[i]);
                int _E = System.Convert.ToInt32(v[v.Length - 1]);
                int _Cmd = System.Convert.ToInt32(v[i + 1]);
                int b = System.Convert.ToInt32(v[v.Length - 2]);
                int _d = System.Convert.ToInt32(v[i + 2]);
                if (_P == 80 && _E == 69)
                {

                    if (_Cmd == 84)
                    {
                        if (_d == 58 && b == 58)
                        {
                            Console.WriteLine("Ack");
                            Console.WriteLine("");
                            String _msg = Cmd.Substring(Cmd.IndexOf(":") + 1, Cmd.LastIndexOf(":") - Cmd.IndexOf(":") - 1);
                            Console.WriteLine(_msg);

                        }
                        else
                        {
                            Console.WriteLine("Nack");
                        }
                    }
                    else
                    {
                        if (_Cmd == 83)
                        {
                            if (_d == 58 && b == 58)
                            {
                                String f = Cmd.Substring(Cmd.IndexOf(":") + 1, Cmd.IndexOf(",") - Cmd.IndexOf(":") - 1);
                                String c = Cmd.Substring(Cmd.IndexOf(",") + 1, Cmd.LastIndexOf(":") - Cmd.IndexOf(",") - 1);

                                int _frequency = System.Convert.ToInt32(f);
                                int _duration = System.Convert.ToInt32(c);
                                Console.WriteLine("Ack");
                                Console.WriteLine("");
                                Console.Beep(_frequency, _duration);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nack");
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Nack");
                }

            
        }
    }
}

       


        

        
        
      
    

    

