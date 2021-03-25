using System;

namespace MSSA.Parking.Lot
{
    public class ParkingLot
    {
        // fields
        private int _smallSize;
        private int _mediumSize;
        private int _largeSize;

        // constructors
        public ParkingLot(int small, int medium, int large)
        {
            _smallSize = small;
            _mediumSize = medium;
            _largeSize = large;
        }

        // methods
        public bool AddCar(string carSize)
        {
            carSize.ToLower();
            if (carSize.ToLower() == "small")
            {
                if (_smallSize == 0)
                {
                    return false;
                }
                if (_smallSize < 0)
                {
                    _smallSize = -_smallSize;
                }
                _smallSize--;
            }
            if (carSize.ToLower() == "medium")
            {
                if (_mediumSize == 0)
                {
                    return false;
                }
                if (_mediumSize < 0)
                {
                    _mediumSize = -_mediumSize;
                }
                _mediumSize--;
            }
            if (carSize.ToLower() == "large")
            {
                if (_largeSize == 0)
                {
                    return false;
                }
                if (_largeSize < 0)
                {
                    _largeSize = -_largeSize;
                }
                _largeSize--;
            }
            return true;
        }
    }
}