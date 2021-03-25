using System;

namespace MSSA.Parking.Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            int parkingLot1 = 5; // type    variable name   =   value

            ParkingLot parkingLot2 = new ParkingLot(1, 2, 3);

            ParkingLot parkingLot3 = new ParkingLot(100, 200, 300);

            Console.WriteLine("Done"); // this is a dummy statement
        }
    }
}