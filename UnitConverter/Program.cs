using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ------ MeasureUnitConvert ------
            /// This program can convert between the imperial system units. Thou, Inches, foot, Yards, Chains, Furlongs, Miles and Leagues.

            //Inputs string to with information. ex. "1 ft in inch".
            string testInput = "";

            while ((testInput = Console.ReadLine()) != null)
            {
                // Split the incoming string.
                string[] testSplit = testInput.Split(" ");

                // Get values and units from input.
                long inputAmount = Int64.Parse(testSplit[0]);
                string unitA = testSplit[1];
                string unitB = testSplit[3];
                decimal testAnswer = 0;

                // Remake units into one standard.
                unitA = GetMeasureUnit(unitA);
                unitB = GetMeasureUnit(unitB);

                // Convert the measure.
                testAnswer = ConvertMeasure(unitA, unitB, inputAmount);

                // Rounds up to 13 decimals and prints result.
                Console.WriteLine(Decimal.Round(testAnswer, 13));
            }
        }

        static string GetMeasureUnit(string s)
        {
            // Standardise the measure unit.
            switch (s)
            {
                case "foot":
                    s = "ft";
                    break;
                case "inch":
                    s = "in";
                    break;
                case "thou":
                    s = "th";
                    break;
                case "yard":
                    s = "yd";
                    break;
                case "chain":
                    s = "ch";
                    break;
                case "furlong":
                    s = "fur";
                    break;
                case "mile":
                    s = "mi";
                    break;
                case "league":
                    s = "lea";
                    break;
                default:
                    break;
            }

            return s;
        }

        static decimal ConvertMeasure(string unitA, string unitB, decimal inputAmount)
        {
            decimal outputAmount = 0;

            switch ((unitA, unitB))
            {
                case ("ft", "in"): // How much is amount of foot in inches.
                    outputAmount = inputAmount * 12;
                    break;
                case ("ft", "th"): // How much is amount of foot in thous.
                    outputAmount = inputAmount * 12000;
                    break;
                case ("ft", "yd"): // How much is amount of foot in yards.
                    outputAmount = inputAmount / 3;
                    break;
                case ("ft", "ch"): // How much is amount of foot in chains.
                    outputAmount = inputAmount / 66;
                    break;
                case ("ft", "fur"): // How much is amount of foot in furlongs.
                    outputAmount = inputAmount / 660;
                    break;
                case ("ft", "mi"): // How much is amount of foot in miles.
                    outputAmount = inputAmount / 5280;
                    break;
                case ("ft", "lea"): // How much is amount of foot in leagues.
                    outputAmount = inputAmount / 15840;
                    break;
                case ("th", "in"): // How much is amount of thou in inches.
                    outputAmount = inputAmount / 1000;
                    break;
                case ("th", "ft"): // How much is amount of thou in foot.
                    outputAmount = inputAmount / 12000;
                    break;
                case ("th", "yd"): // How much is amount of thou in yards.
                    outputAmount = inputAmount / 36000;
                    break;
                case ("th", "ch"): // How much is amount of thou in chains.
                    outputAmount = inputAmount / 792000;
                    break;
                case ("th", "fur"): // How much is amount of thou in furlongs.
                    outputAmount = inputAmount / 7920000;
                    break;
                case ("th", "mi"): // How much is amount of thou in miles.
                    outputAmount = inputAmount / 63360000;
                    break;
                case ("th", "lea"): // How much is amount of thou in leagues.
                    outputAmount = inputAmount / 190080000;
                    break;
                case ("in", "th"): // How much is amount of inches in thous.
                    outputAmount = inputAmount / 1000;
                    break;
                case ("in", "ft"): // How much is amount of inches in foot.
                    outputAmount = inputAmount / 12;
                    break;
                case ("in", "yd"): // How much is amount of inches in yards.
                    outputAmount = inputAmount / 36;
                    break;
                case ("in", "ch"): // How much is amount of inches in chains.
                    outputAmount = inputAmount / 792;
                    break;
                case ("in", "fur"): // How much is amount of inches in furlongs.
                    outputAmount = inputAmount / 7920;
                    break;
                case ("in", "mi"): // How much is amount of inches in miles.
                    outputAmount = inputAmount / 63360;
                    break;
                case ("in", "lea"): // How much is amount of inches in leagues.
                    outputAmount = inputAmount / 190080;
                    break;
                case ("yd", "th"): // How much is amount of yards in thous.
                    outputAmount = inputAmount * 360000;
                    break;
                case ("yd", "in"): // How much is amount of yards in inches.
                    outputAmount = inputAmount * 36;
                    break;
                case ("yd", "ft"): // How much is amount of yards in foot.
                    outputAmount = inputAmount * 3;
                    break;
                case ("yd", "ch"): // How much is amount of yards in chains.
                    outputAmount = inputAmount / 22;
                    break;
                case ("yd", "fur"): // How much is amount of yards in furlongs.
                    outputAmount = inputAmount / 220;
                    break;
                case ("yd", "mi"): // How much is amount of yards in miles.
                    outputAmount = inputAmount / 1760;
                    break;
                case ("yd", "lea"): // How much is amount of yards in leagues.
                    outputAmount = inputAmount / 5280;
                    break;
                case ("ch", "th"): // How much is amount of chains in thous.
                    outputAmount = inputAmount * 792000;
                    break;
                case ("ch", "in"): // How much is amount of chains in inches.
                    outputAmount = inputAmount * 792;
                    break;
                case ("ch", "ft"): // How much is amount of chains in foot.
                    outputAmount = inputAmount * 66;
                    break;
                case ("ch", "yd"): // How much is amount of chains in yards.
                    outputAmount = inputAmount * 3;
                    break;
                case ("ch", "fur"): // How much is amount of chains in furlongs.
                    outputAmount = inputAmount / 10;
                    break;
                case ("ch", "mi"): // How much is amount of chains in miles.
                    outputAmount = inputAmount / 80;
                    break;
                case ("ch", "lea"): // How much is amount of chains in leagues.
                    outputAmount = inputAmount / 240;
                    break;
                case ("fur", "th"): // How much is amount of furlongs in thous.
                    outputAmount = inputAmount * 7920000;
                    break;
                case ("fur", "in"): // How much is amount of furlongs in inches.
                    outputAmount = inputAmount * 7920;
                    break;
                case ("fur", "ft"): // How much is amount of furlongs in foot.
                    outputAmount = inputAmount * 660;
                    break;
                case ("fur", "yd"): // How much is amount of furlongs in yards.
                    outputAmount = inputAmount * 220;
                    break;
                case ("fur", "ch"): // How much is amount of furlongs in chains.
                    outputAmount = inputAmount * 10;
                    break;
                case ("fur", "mi"): // How much is amount of furlongs in miles.
                    outputAmount = inputAmount / 8;
                    break;
                case ("fur", "lea"): // How much is amount of furlongs in leagues.
                    outputAmount = inputAmount / 24;
                    break;
                case ("mi", "th"): // How much is amount of miles in thous.
                    outputAmount = inputAmount * 63360000;
                    break;
                case ("mi", "in"): // How much is amount of miles in inches.
                    outputAmount = inputAmount * 63360;
                    break;
                case ("mi", "ft"): // How much is amount of miles in foot.
                    outputAmount = inputAmount * 5280;
                    break;
                case ("mi", "yd"): // How much is amount of miles in yards.
                    outputAmount = inputAmount * 1760;
                    break;
                case ("mi", "ch"): // How much is amount of miles in chains.
                    outputAmount = inputAmount * 80;
                    break;
                case ("mi", "fur"): // How much is amount of miles in furlongs.
                    outputAmount = inputAmount * 8;
                    break;
                case ("mi", "lea"): // How much is amount of miles in leagues.
                    outputAmount = inputAmount / 3;
                    break;
                case ("lea", "th"): // How much is amount of leagues in thous.
                    outputAmount = inputAmount * 190080000;
                    break;
                case ("lea", "in"): // How much is amount of leagues in inches.
                    outputAmount = inputAmount * 190080;
                    break;
                case ("lea", "ft"): // How much is amount of leagues in foot.
                    outputAmount = inputAmount * 15840;
                    break;
                case ("lea", "yd"): // How much is amount of leagues in yards.
                    outputAmount = inputAmount * 5280;
                    break;
                case ("lea", "ch"): // How much is amount of leagues in chains.
                    outputAmount = inputAmount * 240;
                    break;
                case ("lea", "fur"): // How much is amount of leagues in furlongs.
                    outputAmount = inputAmount * 24;
                    break;
                case ("lea", "mi"): // How much is amount of leagues in miles.
                    outputAmount = inputAmount * 3;
                    break;
                default:
                    Console.WriteLine("Computer says no...");
                    break;
            }

            return outputAmount;
        }
    }
}
