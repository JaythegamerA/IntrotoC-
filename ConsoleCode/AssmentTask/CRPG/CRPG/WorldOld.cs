using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class WorldOld
    {
        public static readonly string Worldname = "E.A. Earth";
        public static readonly List<Location> Locations = new List<Location>();

        //Start providing IDs for locations
        public const int LOCATION_ID_TEMPLE = 1;
        public const int LOCATION_ID_FOREST_CLEARING = 2;
        public const int LOCATION_ID_VILLAGE = 3;

        //World constructor
        static WorldOld()
        {
            PopulateLocations();
        }

        private static void PopulateLocations()
        {
            //Location attributes
            Location temple = new Location(LOCATION_ID_TEMPLE, "The Temple of the Mages",
                "You've spent hours studying magic, but that seems to have been your downfall.");
            Location forestClearing = new Location(LOCATION_ID_FOREST_CLEARING, "A Forest Clearing",
                "It's calm here. A gentle breeze may flow through your hair, but now is not the time to relax.");
            Location village = new Location(LOCATION_ID_VILLAGE, "Your home village",
                "You've lived here all of your life, made many friends, spent time with people you thought were genuine." +
                "\n\tYou aren't welcome here anymore.");

            //Linking locations
            temple.LocationToNorth = forestClearing;
            forestClearing.LocationToWest = village;
            village.LocationToEast = forestClearing;
            forestClearing.LocationToSouth = temple;

            //Create list of locations
            Locations.Add(temple);
            Locations.Add(forestClearing);
            Locations.Add(village);

        }

        public static Location LocationByID(int id)
        {
            foreach (Location loc in Locations)
            {
                if (loc.ID == id) return loc;
            }
            return null;
        }

        public static void ListLocations()
        {
            Console.WriteLine("These are the locations in the world:");
            foreach (Location loc in Locations)
            {
                Console.WriteLine($"\t{loc.Name}");
            }
        }
    }
}
