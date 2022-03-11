using System;

namespace GardenPlannerClasses
{
    public class Plant
    {
        public string Name { get; set; }
        public DateTime Planted { get; set; }
        public DateTime Harvest { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Season { get; set; }

        public double SunlightHours { get; set; }
        public double AmountOfWater { get; set; }
        public int PruningDays { get; set; }

        public Plant()
        {

        }

        public Plant(string _name, DateTime _planted, DateTime _harvest, int _height, int _width, string _season, double _sunlighthours, double _amountofwater, int _pruningdays)

        {
            Name = _name;
            Planted = _planted;
            Harvest = _harvest;
            Height = _height;
            Width = _width;
            Season = _season;
            SunlightHours = _sunlighthours;
            AmountOfWater = _amountofwater;
            PruningDays = _pruningdays;
        }

        
    }
    public class Garden
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public Garden()
        {

        }
        public Garden(string _name, int _length, int _width)
        {
            Name = _name;
            Length = _length;
            Width = _width;
        }
    }
}
