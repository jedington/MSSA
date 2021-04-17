using System.Collections.Generic;
using System.IO;

namespace Titanic
{
    public static class Titanic
    {
        //   fields and properties


        //   constructors


        //   methods

        public static List<Passenger> GetPassengers(string fileName)
        {
            List<Passenger> passengers = new List<Passenger>();
            
            using (var reader = new StreamReader(fileName))
            {
                reader.ReadLine(); // Heading Line
                while (reader.EndOfStream == false)
                {
                   passengers.Add(new Passenger(reader.ReadLine()));
                }
            }
            
            return passengers;
        } // end GetPassengers( )
    }
}
