using System;
using System.IO;  

//Filename: Slotkin_P1

namespace Slotkin_P1
{
    class Program
    {
        //***MAIN*****************************************************************************

        static void Main(string[] args)
        {
            const double R = 8.3145;  //measured in m3   
            string[] gasNames = new string[200];
            double[] molecularWeights = new double[200];
            int countGases = 0;  //to keep track of the # of gases in the array
            double pascals = 0;
            double moles = 0;
            double gasPSI = 0;
            double molecularWeight = 0;
            
            //DisplayHeader()
            Program.DisplayHeader();

            //call GetMolecularWeights()
            Program.GetMolecularWeights(ref gasNames, ref molecularWeights, ref countGases);

            //call DisplayGasNames()
            Program.DisplayGasNames(gasNames, countGases);

            //use a do while loop
            string answer = "y";
            do
            {
                //ask the user the name of the gas
                Console.WriteLine("\n\nSelect the gas you would like to calculate the pressure it exerts in");
                Console.WriteLine("a given container under certain conditions: ");
                string gasName = Console.ReadLine();

                //if gas not found, display an error message and break out of the loop
                //for (int i = 1; i < countGases; i++)
                //{
                //    if (String.Equals(gasName, gasNames[i]) == false)
                //    {
                //        Console.WriteLine("ERROR! You have made an invalid selection.");
                //    }
                //    break;
                //}

                //call GetMolecularWeightFromName()
                //Program.GetMolecularWeightFromName(gasName, gasNames, molecularWeights, countGases);

                //ask the user for the volume of the gas in cubic meters
                Console.WriteLine("Please enter the volume in cubic meters: ");
                string volTemp = Console.ReadLine();
                double vol = Convert.ToDouble(volTemp); 

                //ask the user for the mass of the gas in grams
                Console.WriteLine("Please enter the mass in grams: ");
                string massTemp = Console.ReadLine();
                double mass = Convert.ToDouble(massTemp);

                //ask the user for the temperature in celsius
                Console.WriteLine("Please enter the temperature in celsius: ");
                string tempTemp = Console.ReadLine();
                double temp = Convert.ToDouble(tempTemp);

                //call Pressure()
                Program.Pressure(mass, vol, temp, molecularWeight, moles, R);   

                //call DisplayPressure()
                Program.DisplayPressure(ref pascals, gasName, ref gasPSI);      

                //ask the user if they want to do another
                Console.WriteLine("Would you like to do another? y/n");
                answer = Console.ReadLine();
            } while (answer == "y");

            //say goodbye
            Console.WriteLine("\nPhwew, I was getting tired of doing all of those calculations!");
            Console.WriteLine("Goodbye, enjoy the rest of your day.\n\n\n");

            Console.ReadLine(); //so the program waits for an entry before quitting
        }

        //***METHODS***************************************************************************

        static void DisplayHeader()
        {
            Console.WriteLine("Program Title: The Ideal Gas Calculator");
            Console.WriteLine("Program Objective: To calculate the pressure of a given gas in a given container");
            Console.WriteLine("                   with a given weight and a given temperature.\n");
        }

        static void GetMolecularWeights(ref string[] gasNames, ref double[] molecularWeights, ref int countGases)
        {
            //read in gas names and molecular weights from csv file:
            //Open the file and read contents
            string[] linesInFile = File.ReadAllLines("MolecularWeightsGasesAndVapors.csv");
            for (int i = 1; i < linesInFile.Length; i++)
            {
                //all the lines with both gas and weight
                string line = linesInFile[i]; 
                //split the line on the comma
                string[] lineSplit = line.Split(',');
                //names of the gases as an array of strings
                gasNames[i] = lineSplit[0];
                //molecularWeights changed into an array of doubles 
                molecularWeights[i] = Convert.ToDouble(lineSplit[1]);

                //get count of elements in the array 
                countGases = linesInFile.Length - 1;
            }
        }

        private static void DisplayGasNames(string[] gasNames, int countGases)
        {
            //display the gasNames[] to the user in 3 columns
            for (int i = 1; i < countGases; i++)
            {
                Console.Write("{0, -20}", gasNames[i]);

                if (i % 3 == 0 || i == countGases)
                {
                    Console.Write("\n");
                }
            }
        }

        //private static double GetMolecularWeightFromName(string gasName, string[] gasNames, double[] molecularWeights, int countGases)
        //{
        //    double molecularWeight; 
        //    //gets and returns the molecular weight of the gas selected by the user
        //    for (int i = 1; i < countGases; i++)
        //    {
        //        if (String.Equals(gasName, gasNames[i]) == true)
        //        {
        //            //return molecularWeights[i] parallel/= to gasNames[i]
        //            molecularWeight = molecularWeights[i];
        //            return molecularWeight; 
        //        }   
        //    }
        //}
          
        static double Pressure(double mass, double vol, double temp, double molecularWeight, double moles, double R)
        {
            //calculate and return pressure in pascals using (P = nRT/V):
            //call NumberOfMoles() to get n
            Program.NumberOfMoles(mass, molecularWeight);
            //call CelsiusToKelvin() to get T
            Program.CelsiusToKelvin(temp);
            double pascals = (moles * R * temp)/vol;   
            return pascals;  
        }

        static double NumberOfMoles(double mass, double molecularWeight)
        {
            //calculate and return moles(n) using (n = mass / molecular weight of gas)
            double moles = mass / molecularWeight;
            return moles;
        }

        static double CelsiusToKelvin(double temp)
        {
            double kelvin = temp + 273.15;
            return kelvin;
        }

        private static void DisplayPressure(ref double pascals, string gasName, ref double gasPSI)  
        {
            //call PaToPSI()
            Program.PaToPSI(pascals);  
            //display pressure in both pascals and PSI
            Console.WriteLine("For the gas {0}, it has a pressure of {1} pascals and a PSI of {2}.", gasName, pascals, gasPSI);  
        }

        static double PaToPSI(double pascals)
        {
            //calculate and return pascals to PSI
            const double PSI = 0.00014503773;
            double gasPSI = pascals * PSI;
            return gasPSI;
        }
    }
};

