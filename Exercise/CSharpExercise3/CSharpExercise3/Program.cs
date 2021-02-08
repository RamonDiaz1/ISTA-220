using System;

namespace CSharpExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                try
                {
                    Console.WriteLine("\nPart 1, circumference and area of a circle.");
                    Console.WriteLine("Enter an interger for the radius: ");
                    string strradius = Console.ReadLine();
                    int radius = int.Parse(strradius);
                    if (radius < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (radius == 0)
                        throw new DivideByZeroException();
                    double circumference = 2 * Math.PI * radius;
                    Console.WriteLine($"The circumference is {circumference}");
                    double area = Math.PI * (radius * radius);
                    Console.WriteLine($"The area is {area}");
                 

                }
                catch (ArgumentOutOfRangeException Aex)
                {
                    Console.WriteLine(Aex.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (InvalidOperationException ioEx)
                {
                    Console.WriteLine(ioEx.Message);
                }
                catch (DivideByZeroException ixc)
                {
                    Console.WriteLine(ixc.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("okay");

                }
            }
     

            {
                try
                {
                    Console.WriteLine("\nPart 2, volume of a hemisphere.");
                    Console.Write("Enter an integer for the radius: ");
                    String strradius2 = Console.ReadLine();
                    int radius2 = int.Parse(strradius2);
                    if (radius2 < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (radius2 == 0)
                        throw new DivideByZeroException();
                    double volume = ((4 * (Math.PI * (radius2 * radius2 * radius2))) / 3) / 2;
                    Console.WriteLine($"The volume is {volume}");
                    

                   
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (ArgumentOutOfRangeException Aorex)
                {
                    Console.WriteLine(Aorex.Message);
                }
                catch (InvalidOperationException ioEx)
                {
                    Console.WriteLine(ioEx.Message);
                }
                catch (DivideByZeroException zEx)
                {
                    Console.WriteLine(zEx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("okay");
                }
            }



            {
                try
                {


                    Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
                    double Area = 0;
                    Console.Write("please enter an integer for side a: ");
                    string sidea = Console.ReadLine();
                    int a = int.Parse(sidea);
                    Console.Write("please enter an integer for side b: ");
                    string sideb = Console.ReadLine();
                    int b = int.Parse(sideb);
                    Console.Write("please enter an integer for side c: ");
                    string sidec = Console.ReadLine();
                    int c = int.Parse(sidec);
                    double p = (a + b + c) / 2;
                    Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"The area is {Area}");



                    if (a < 0)
                        throw new Exception("Your number must be a positive number");
                    if (b < 0)
                        throw new Exception("Your number must be a positive number");
                    if (b < 0)
                        throw new Exception("Your number must be a positive number");

                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (InvalidOperationException ioEx)
                {
                    Console.WriteLine(ioEx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("okay");
                }

            }



            try
            {

                Console.WriteLine("\nPart 4, solving a quadratic equation.");
                Console.Write("enter a number for coefficient a: ");
                string coefa = Console.ReadLine();
                int a1 = int.Parse(coefa);
                Console.Write("enter a number for coefficient b: ");
                string coefb = Console.ReadLine();
                int b1 = int.Parse(coefb);
                Console.Write("enter a number for coefficient c: ");
                string coefc = Console.ReadLine();
                int c1 = int.Parse(coefc);
                double denominator = 2 * a1;
                double positive_num = -b1 + Math.Sqrt(b1 * b1 - (4 * a1 * c1));
                double negative_num = -b1 - Math.Sqrt(b1 * b1 - (4 * a1 * c1));
                Console.WriteLine($"The positive solution is {positive_num / denominator}");
                Console.WriteLine($"The negative solution is {negative_num / denominator}");
                bool D = int.TryParse(coefa, out a1);


                if (a1 < 0)
                    throw new Exception();

                Console.WriteLine("Enter a possitive number: ");
                if (b1 < 0)
                    throw new Exception();
                Console.WriteLine("Enter a possitive number: ");
                if (c1 < 0)
                    throw new Exception();
                Console.WriteLine("Enter a possitive number: ");
            }
            catch (FormatException fEx)

            {
                Console.WriteLine(fEx.Message);
            }
            catch (ArgumentOutOfRangeException aEx)
            {
                Console.WriteLine(aEx.Message);
            }
            catch (DivideByZeroException zEx)
            {
                Console.WriteLine(zEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Okay");

            }


        }

    }

}