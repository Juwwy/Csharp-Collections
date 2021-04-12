using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ExhibitionTask
{
    public class Exhibition
    {
        public string ExhibitName { get; set; }
        public string ExhibitorName { get; set; }
        public string Subject { get; set; }
        public string Floor { get; set; }
        private string building;

        public Exhibition(string exhName, string exhibitor, string subject, string floor, string building)
        {
            ExhibitName = exhName;
            ExhibitorName = exhibitor;
            Subject = subject;
            Floor = floor;
            Building = building;
        }
        public string Building
        {
            get { return building; }
            set { 
                if(value == "Primary" || value == "Higher" || value == "Labs")
                {
                    building = value;
                } else{
                    throw new System.ArgumentOutOfRangeException();
                }
             }
        }

        public override string ToString()
        {
            return $"Exhibit Name: {ExhibitName}\nExhibitor Name: {ExhibitorName}\nSubject: {Subject}\nFloor: {Floor}\nBuilding: {Building}\n\n";
        }

        
    }
}