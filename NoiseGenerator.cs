//This program will create a NoiseGen class that will getValues and addNoise
//and will finally print them to the console from the getValues class which is
//called from main.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseGenerator
{
    class NoiseGen
    {

        //initiating needed variables to store values with a clean and noisy array
        //as well as variables to hold the noiseFactor and random generated number
        //seeded with a value of 243.
        double[] carray = new double[100];
        double[] narray = new double[100];
        Random rnd = new Random(243);
        int noiseFactor = 7;






        //empty constructor for NoiseGen class.
        public NoiseGen()
        {

        }





        //Constructor that accepts a value that will modify the noiseFactor value
        public NoiseGen(int nf)
        {
            noiseFactor = nf;
        }





        //Start of the NoiseGen's getValues class method
        public double[] getValues()
        {

            //Using a for loop to generate values anad store them int he clean array.
            for(double i = 0; i < 100; i++)
            {
                double dec = i/10;
                double sine = Math.Sin(dec);
                carray[Convert.ToInt32(i)] = Convert.ToInt32(sine * 100);                
            }

            //calling other class methods to generate the noisy array and print all the values
            //to a table in the console.
            addNoise();
            printTable();
            return carray;
        }




        

        //NoiseGen's addNoise class method will generate our noisy array
        public double[] addNoise()
        {

            //Using a for loop statement to generate a random number based on the
            //noiseFactor and then copying and modifying the clean array's value 
            //and storing it within the noisy array.
            for (int i = 0; i < 100; i++)
            {

                int random = rnd.Next(-noiseFactor, noiseFactor + 1);
                narray[i] = carray[i] + random;

            }
            return narray;
        }






        //NoiseGen's printTable class Method that will print our values from the clean and
        //noisy array to the console
        void printTable()
        {
            //Printing the current element number, and each value for both the clean and
            //noisy arrays we generated using a for loop statement.

            Console.WriteLine("Element,Clean,Noisy");
            for (int i = 0; i <100; i++)
            {

                Console.WriteLine(i + "," + carray[i] + "," + narray[i]);

            }
        }
    }




    //Start of the Main class which contains the Main method.
    internal class Program
    {
        //Using the Main method to instantiate the NoiseGen class object and then
        //using it to call the getValues method from the NoiseGen class. 
        static void Main(string[] args)
        {
            NoiseGen noise = new NoiseGen();
            noise.getValues();
            


            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
