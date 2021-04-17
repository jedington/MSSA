using System;
using System.Collections.Generic;
using System.Linq;

namespace Titanic
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Passenger> passengers = Titanic.GetPassengers("Titanic.Tsv");

            //- foreach (Passenger p in passengers)
            //- {
            //-     Console.WriteLine(p);
            //- }

            // Intro: The line of code above reads in a file that contains all of
            //        the passengers who were on the Titanic. Feel free to look at
            //        the Passenger class to see which fields each Passenger
            //        contains. The file is read into a List of Passengers.

            // ToDo: Write code using LInQ in order to find the answers to the following questions.

            // 1) Find out whether a "Miss. Alice Cleaver" survived the accident.
            Passenger alice = passengers.Where(p => p.Name
                                        .Contains("Alice") && p.Name.Contains("Cleaver")).First();
            Console.WriteLine($"1. {alice.Survived} // Yes, she survived \n{alice}\n");

            // 2) There were six 52-year-olds on board, however, only one embarked
            //    from Cherbourg (C). What was his or her name? Did he or she survive?
            List<Passenger> fiftyTwos = passengers.FindAll(p => p.Age == 52);
            //- Console.WriteLine(fiftyTwos.Count);
            Passenger c52 = fiftyTwos.Find(p => p.Embarked == 'C' && p.Survived == true);
            Console.WriteLine($"2. {c52.Survived} // Yes, she survived \n{c52.Name}\n");

            // 3a) How many men were on board?
            // 3b) How many men survived?
            // 3c) What was the survival rate of men?
            List<Passenger> menTotal = passengers.FindAll(p => p.Gender == 'M' && p.Age >= 18);
            Console.WriteLine($"3a: {menTotal.Count()} total men");
            (List<Passenger> menSurvived, double menSurvivalRate) = getSurvivalRate(menTotal);
            Console.WriteLine($"3b: {menSurvived.Count()} men that survived");
            Console.WriteLine($"3c: {menSurvivalRate}% men survival rate\n");

            // 4a) How many women were on board?
            // 4b) How many women survived?
            // 4c) What was the survival rate of women?
            List<Passenger> womenTotal = passengers.FindAll(p => p.Gender == 'F' && p.Age >= 18);
            Console.WriteLine($"4a: {womenTotal.Count()} total women");
            (List<Passenger> womenSurvived, double womenSurvivalRate) = getSurvivalRate(womenTotal);
            Console.WriteLine($"4b: {womenSurvived.Count()} women that survived");
            Console.WriteLine($"4c: {womenSurvivalRate}% women survival rate\n");

            // 5a) How many children were on board?
            // 5b) How many children survived?
            // 5c) What was the survival rate of children?
            List<Passenger> childrenTotal = passengers.FindAll(p => p.Age < 18);
            Console.WriteLine($"5a: {childrenTotal.Count()} total children");
            (List<Passenger> childrenSurvived, double childrenSurvivalRate) = getSurvivalRate(childrenTotal);
            Console.WriteLine($"5b: {childrenSurvived.Count()} children that survived");
            Console.WriteLine($"5c: {childrenSurvivalRate}% children survival rate\n");

            // 6a) Who was the youngest survivor? (name)
            // 6b) Who was the oldest casualty? (name)
            Passenger youngest = passengers.FindAll(p => p.Age != null).OrderBy(p => p.Age).First();
            Passenger oldest = passengers.FindAll(p => p.Survived == false).OrderByDescending(p => p.Age).First();
            Console.WriteLine($"6a: {youngest.Name}");
            Console.WriteLine($"6b: {oldest.Name}\n");

            // 7a) Who had the cheapest ticket? (name) Did they survive?
            // 7b) Who had the most expensive ticket? (name) Did they survive?
            Passenger cheapest = passengers.FindAll(p => p.Fare != null).OrderBy(p => p.Fare).First();
            Passenger expensive = passengers.OrderByDescending(p => p.Fare).First();

            Console.WriteLine($"7a: {cheapest.Name}\n{cheapest.Survived} // yes, they survived");
            Console.WriteLine($"7b: {expensive.Name}\n{expensive.Survived} // yes, they survived\n");

            // 8a) What was the survival rate for all first class passengers?
            // 8b) What was the survival rate for all second class passengers?
            // 8c) What was the survival rate for all third class passengers?
            List<Passenger> firstClassTotal = passengers.FindAll(p => p.Class == 1);
            (List<Passenger> fCSurvived, double fCSurvivalRate) = getSurvivalRate(firstClassTotal);
            Console.WriteLine($"8a: {fCSurvivalRate}% First Class passengers survival rate\n");
            
            List<Passenger> secondClassTotal = passengers.FindAll(p => p.Class == 2);
            (List<Passenger> sCSurvived, double sCSurvivalRate) = getSurvivalRate(secondClassTotal);
            Console.WriteLine($"8b: {sCSurvivalRate}% Second Class passengers survival rate\n");
            
            List<Passenger> thirdClassTotal = passengers.FindAll(p => p.Class == 3);
            (List<Passenger> tCSurvived, double tCSurvivalRate) = getSurvivalRate(thirdClassTotal);
            Console.WriteLine($"8c: {tCSurvivalRate}% Third Class passengers survival rate\n");
            
            // 9) What was the survival rate of girls in first class with 2 or more of any relative?
            List<Passenger> female2PlusRelatives = passengers
                .FindAll(p => p.Class == 1 && p.Gender == 'F' && p.ParentsChildren + p.SiblingsSpouse >= 2);
            (List<Passenger> femaleSurvived, double femaleSurvivalRate) = getSurvivalRate(female2PlusRelatives);
            Console.WriteLine($"9: {femaleSurvivalRate}% Female passengers--with 2+ relatives--survival rate\n");

            // 10) What was the survival rate of men in third class with no relatives onboard?
            List<Passenger> male0Relatives = passengers
                .FindAll(p => p.Class == 3 && p.Gender == 'M' && p.ParentsChildren + p.SiblingsSpouse == 0);
            (List<Passenger> maleSurvived, double maleSurvivalRate) = getSurvivalRate(male0Relatives);
            Console.WriteLine($"10: {maleSurvivalRate}% Male passengers--with 0 relatives--survival rate\n");
            
            // 11) What was the survival rate of passengers who embarked from Southampton (S) and whose fare was over 10 pounds?
            List<Passenger> southamptonPassengers = passengers.FindAll(p => p.Fare > 10 && p.Embarked == 'S');
            (List<Passenger> southamptonSurvived, double southamptonSurvivalRate) = getSurvivalRate(southamptonPassengers);
            Console.WriteLine($"11: {southamptonSurvivalRate}% Southampton passengers--with more than 10 pounds' fare--survival rate\n");


            // 12) What was the survival rate of passengers with the word "sink" in their name? (case insensitive)
            List<Passenger> sinkPassengers = passengers.FindAll(p => p.Name.Contains("sink"));
            (List<Passenger> sinkSurvived, double sinkSurvivalRate) = getSurvivalRate(sinkPassengers);
            Console.WriteLine($"12: {sinkSurvivalRate}% Passengers--with 'sink' in their name--survival rate\n");


            // 13) What was the survival rate of passengers whose ticket number included the substring "13"?
            List<Passenger> thirteenPassengers = passengers.FindAll(p => p.Ticket.Contains("13"));
            (List<Passenger> thirteenSurvived, double thirteenSurvivalRate) = getSurvivalRate(thirteenPassengers);
            Console.WriteLine($"13: {thirteenSurvivalRate}% Passengers--a '13' contained within ticket--survival rate\n");


        } // end Main( )

        private static (List<Passenger> pSurvived, double sRate) getSurvivalRate(IEnumerable<Passenger> passengers)
        {
            List<Passenger> pSurvived = passengers.Where(p => p.Survived == true).ToList();
            double sRate = Math.Round((double) pSurvived.Count() / passengers.Count() * 100, 2);

            // ToDo: Implement this method.

            return (pSurvived, sRate);
        } // end getSurvivalRate( )
    } // class ends
} // namespace ends