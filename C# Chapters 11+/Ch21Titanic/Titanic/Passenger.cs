using System;

namespace Titanic
{
    public class Passenger
    {
        //   F i e l d s   &   P r o p e r t i e s

        public string Name            { get; }
        public bool   Survived        { get; }
        public char?  Gender          { get; }
        public float? Age             { get; }
        public int    SiblingsSpouse  { get; }
        public int    ParentsChildren { get; }
        public string Ticket          { get; }
        public float? Fare            { get; }
        public string Cabin           { get; }
        public int    Class           { get; }
        public char?  Embarked        { get; }
        public string Boat            { get; }
        public string HomeDestination { get; }
        
        
        //   C o n s t r u c t o r s
        
        public Passenger(string tsvLine)
        {
            string[] fields = tsvLine.Split('\t');
            
            Name            = fields[0];
            Survived        = fields[1] == "1";
            Gender          = getFirstChar(fields[2], null);
            Age             = parseFloat(fields[3], null);
            SiblingsSpouse  = parseInt(fields[4]);
            ParentsChildren = parseInt(fields[5]);
            Ticket          = fields[6];
            Fare            = parseFloat(fields[7], null);
            Cabin           = fields[8];
            Class           = parseInt(fields[9]);
            Embarked        = getFirstChar(fields[10], null);
            Boat            = fields[11];
            HomeDestination = fields[13];
        } // end Passenger( )
        
        
        //   M e t h o d s
        
        public override string ToString()
        {
            return "Passenger: ["
                + $"Name: {Name}"
                + $", Survived: {Survived}"
                + $", Gender: {Gender}"
                + $", Age: {Age}"
                + $", SiblingsSpouse: {SiblingsSpouse}"
                + $", ParentsChildren: {ParentsChildren}"
                + $", Ticket: {Ticket}"
                + $", Fare: {Fare}"
                + $", Cabin: {Cabin}"
                + $", Class: {Class}"
                + $", Embarked: {Embarked}"
                + $", Boat: {Boat}"
                + $", HomeDestination: {HomeDestination}"
                + "]";
        } // end ToString( )
        
        private static char? getFirstChar(string s, char? defaultValue = '\0')
        {
            if (s == null || s.Length == 0)
            {
               return defaultValue;
            }
            return s[0];
        } // end getFirstChar( )
        
        private static float? parseFloat(string s, float? defaultValue = 0.0f)
        {
            try
            {
               return float.Parse(s);
            }
            catch (Exception)
            {
            }
            return defaultValue;
        } // end parseFloat( )
        
        private static int parseInt(string s, int defaultValue = 0)
        {
            try
            {
               return int.Parse(s);
            }
            catch (Exception)
            {
            }
            return defaultValue;
        } // end parseInt( )
   }
}
