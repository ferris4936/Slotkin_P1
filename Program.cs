using System;  

namespace Slotkin_P1
{
    class Program
    {
        //***MAIN*****************************************************************************

        static void Main(string[] args)
        {
            //declare an array for gas names
            string[] nameOfGases = { "", "", "" };  

            //declare an array for molecular weights
            double[] gasMolecularWeights = { 0.0, 0.0, 0.0 };

            //declare an int to keep track of the # of elements in the array
            int numOfElementsinArray = 0;

            //call DisplayHeader()
            Program.DisplayHeader();

            //call GetMolecularWeights()

            //call DisplayGasNames()

            //use a do while loop
            string gasName = "";
            string answer = "y";  
            do
            {
                //ask the user the name of the gas
                Console.WriteLine("\nSelect the gas you would like to calculate the pressure it");
                Console.WriteLine("exerts in a given container under certain conditions: ");
                gasName = Console.ReadLine();

                //if gas not found, display an error message and break out of the loop
                //if(!gasName) 
                //{
                //    Console.WriteLine("ERROR! You have made an invalid selection.");
                //    break;
                //}

                //call GetMolecularWeightFromName()

                //ask the user for the volume of the gas in cubic meters

                //ask the user for the mass of the gas in grams

                //ask the user for the temperature in celsius

                //call Pressure()

                //call DisplayPressure(pressure)

                //ask the user if they want to do another
                Console.WriteLine("Would you like to do another? y/n");
                answer = Console.ReadLine(); 
            } while (answer == "y");

            //say goodbye
            Console.WriteLine("\nPhwew, I was getting tired of doing all of those calculations!");
            Console.WriteLine("Goodbye, I'm off to take a nap.\n\n\n");

        }

        //***METHODS***************************************************************************

        static void DisplayHeader()
        {
            Console.WriteLine("Programmer: Erica S.");
            Console.WriteLine("Program Title: The Ideal Gas Calculator");
            Console.WriteLine("Program Objective: To calculate the pressure of a given gas in a given container");
            Console.WriteLine("                   with a given weight and a given temperature.");
        }

        //static void GetMolecularWeights(ref string[] gasNames, ref double[] molecularWeights,
        //    out int count)
        //{
        //    //read in molecular weights from csv file
        //    //use StreamReader to open the file and read contents
        //    //use the string split function to split the data on the comma

        //    //fill molecularWeights[]

        //    //fill gasNames[]

        //    //get count of elements in the array from countGases[]
        //}

        //private static void DisplayGasNames(string[] gasNames, int countGases)
        //{
        //    //display the gasNames[] to the user in 3 columns

        //    //get countGases
        //}

        //private static double GetMolecularWeightFromName(string gasName, string[] gasNames,
        //    double[] molecularWeights, int countGases)
        //{
        //    //gets and returns the molecular weight of the gas selected by the user

        //    //update countGases
        //}

        //static double Pressure(double mass, double vol, double temp, double molecularWeight)
        //{
        //    //calculate and return pascals using (P = nRT/V)
        //    //call NumberOfMoles() to get n
        //    //call CelsiusToKelvin() to get T
        //}

        //static double NumberOfMoles(double mass, double molecularWeight)
        //{
        //    //calculate and return moles(n) using (n = mass / molecular weight of gas)
        //}

        //static double CelsiusToKelvin(double celsius)
        //{
        //    double kelvin = celsius + 273.15;
        //    return kelvin;
        //}

        //private static void DisplayPressure(double pressure)
        //{ 
        //    //call PaToPSI()

        //    //display pressure in both pascals and PSI
                
        //}

        //static double PaToPSI(double pascals)
        //{
        //    //calculate and return pascals to PSI

        //}
    }
};

