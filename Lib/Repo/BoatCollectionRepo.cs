using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public class BoatCollectionRepo : IBoatRepo
    {
        protected List<Boat> _boats = new List<Boat>();
        public virtual void Add(Boat boat)
        {
            _boats.Add(boat);
        }

        public BoatCollectionRepo() // Adds mockup boats from chatgpt to the list
        {
            _boats.Add(new Boat(8, "Sea Breeze", 1, "Sailboat", "Beneteau Oceanis 45", 12345, "Volvo Penta D2-55", "13.85m x 4.49m", 2019, "Spacious family cruiser with good performance."));
            _boats.Add(new Boat(4, "Wave Rider", 2, "Motorboat", "Yamaha 242X", 0, "Twin 1.8L Yamaha marine engines", "7.32m x 2.59m", 2021, "Sporty and agile, perfect for weekend getaways."));
            _boats.Add(new Boat(12, "Ocean Queen", 3, "Catamaran", "Lagoon 42", 54321, "2x Yanmar 57 HP", "12.80m x 7.70m", 2020, "Luxurious and stable catamaran for charter use."));
            _boats.Add(new Boat(6, "Silver Arrow", 4, "Speedboat", "Cigarette Racing 515", 0, "Mercury Racing twin engines", "15.6m x 2.6m", 2018, "High-speed performance with aggressive design."));
            _boats.Add(new Boat(10, "Blue Marlin", 5, "Fishing Boat", "Boston Whaler 370 Outrage", 0, "Triple Mercury Verado 350", "11.28m x 3.5m", 2017, "Fully equipped for deep sea fishing."));
            _boats.Add(new Boat(2, "Tiny Wave", 6, "Dinghy", "Zodiac Cadet 270", 0, "Portable 4HP outboard", "2.7m x 1.5m", 2022, "Lightweight and portable tender."));
            _boats.Add(new Boat(14, "Grand Voyager", 7, "Yacht", "Princess F70", 67890, "Twin MAN V12", "21.25m x 5.38m", 2019, "Luxury yacht with expansive living space."));
            _boats.Add(new Boat(3, "Eco Sail", 8, "Sailboat", "Jeanneau Sun Odyssey 349", 23456, "Yanmar 21 HP", "10.34m x 3.44m", 2023, "Easy-to-handle sailboat with modern features."));
            _boats.Add(new Boat(5, "Wind Whisper", 9, "Sailboat", "Hallberg-Rassy 44", 34567, "Volvo Penta D2-75", "13.71m x 4.20m", 2020, "Bluewater cruiser built for comfort and endurance."));
            _boats.Add(new Boat(7, "Aqua Runner", 10, "Jet Boat", "Scarab 255 ID", 0, "Twin Rotax 300 HP", "7.01m x 2.54m", 2021, "Jet-powered fun boat with wake sports features."));
            _boats.Add(new Boat(11, "Sun Chaser", 11, "Pontoon", "Sun Tracker Party Barge 22", 0, "Mercury 115 ELPT", "7.01m x 2.59m", 2020, "Ideal for family leisure and inland cruising."));
            _boats.Add(new Boat(9, "Storm Breaker", 12, "Trawler", "Nordhavn 52", 99887, "Lugger L1066T", "16.0m x 5.0m", 2016, "Long-range cruiser with robust construction."));
            _boats.Add(new Boat(15, "Liberty Belle", 13, "Houseboat", "Horizon 500", 0, "Twin outboard engines", "15.24m x 4.5m", 2022, "Floating home with modern amenities."));
            _boats.Add(new Boat(4, "Coral Cut", 14, "Motorboat", "Bayliner Element E18", 0, "Mercury 115 HP", "5.49m x 2.29m", 2021, "Simple, fun boat for beginners."));
            _boats.Add(new Boat(2, "Splashy", 15, "Jet Ski", "Sea-Doo Spark Trixx", 0, "Rotax 900 HO ACE", "2.8m x 1.2m", 2023, "Compact and playful watercraft."));
            _boats.Add(new Boat(6, "Freedom Glide", 16, "Sailboat", "Dufour 390 Grand Large", 11223, "Volvo D1-30", "11.94m x 3.99m", 2022, "Spacious cruiser with modern design."));
            _boats.Add(new Boat(3, "Blue Tide", 17, "Fishing Boat", "Grady-White Canyon 336", 0, "Yamaha F300", "10.21m x 3.6m", 2020, "Offshore fishing beast with seating."));
            _boats.Add(new Boat(13, "White Pearl", 18, "Yacht", "Azimut 60 Flybridge", 78901, "2x Volvo D13", "18.25m x 5.02m", 2021, "Luxury yacht with sleek Italian design."));
            _boats.Add(new Boat(5, "Echo Bay", 19, "Sailboat", "Catalina 355", 11112, "Yanmar 29 HP", "10.82m x 3.63m", 2019, "Balance of comfort and performance."));
            _boats.Add(new Boat(6, "Falcon Rise", 20, "Speedboat", "Formula 310 Bowrider", 0, "Twin MerCruiser 6.2L", "9.45m x 2.9m", 2021, "Elegant boat for fast coastal rides."));
            _boats.Add(new Boat(4, "Serenity Now", 21, "Motorboat", "Quicksilver Activ 755", 0, "Mercury 225 V6", "7.55m x 2.55m", 2020, "Family day cruiser with cabin."));
            _boats.Add(new Boat(8, "Mystic Tide", 22, "Catamaran", "Fountaine Pajot Lucia 40", 45678, "2x Volvo 30 HP", "11.73m x 6.63m", 2018, "Spacious catamaran ideal for charters."));
            _boats.Add(new Boat(1, "Mini Mako", 23, "Dinghy", "Walker Bay 10", 0, "Oars", "3.05m x 1.4m", 2022, "Simple rowboat for short trips."));
            _boats.Add(new Boat(10, "Thunder Reef", 24, "Fishing Boat", "Regulator 34", 0, "Triple Yamaha 300", "10.36m x 3.4m", 2021, "Ultimate offshore fishing machine."));
            _boats.Add(new Boat(6, "Wave Crest", 25, "Sailboat", "Island Packet 349", 33344, "Yanmar 45 HP", "11.58m x 3.66m", 2019, "Classic bluewater cruiser."));

        }
        public List<Boat> GetAll()
        {
            return _boats;
        }
    }
}
