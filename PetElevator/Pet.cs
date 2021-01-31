using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator
{
    public class Pet
    {
        public Pet(string petName, string species)
        {
            PetName = petName;
            Species = species;
        }
        public string PetName
        {
            get;
            set;
        }
        public string Species
        {
            get;
            set;
        }
        public List<string> Vaccinations
        {
            get;
            set;
        } = new List<string>();
        public string ListVaccinations()
        {
            string vaccinationsCSV = "";
            int i = 0;
            while (i < Vaccinations.Count)
            {
                if (i > 0)
                {
                    vaccinationsCSV += ", ";
                }
                vaccinationsCSV += Vaccinations[i];
                i++;
            }
            return vaccinationsCSV;
        }
    }
}
