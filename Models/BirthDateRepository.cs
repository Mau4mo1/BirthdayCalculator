using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayCalculator.Models
{
    public static class BirthDateRepository
    {
        public static List<BirthDateModel> BirthDates = new List<BirthDateModel>();

        public static void AddBirthDate(BirthDateModel birthDateModel)
        {
            int highestId = 0;
            try
            {
                highestId = (from BirthDateModel birthdates in BirthDates
                             select birthdates.Id)
                             .Max();
                // highest Id we could find plus increment
                birthDateModel.Id = highestId + 1;
                BirthDates.Add(birthDateModel);
            } catch(Exception ex)
            {
                BirthDates.Add(birthDateModel);
            }
            
            
        }

        public static BirthDateModel GetBirthDate(int id)
        {
            BirthDateModel birthDate = (from BirthDateModel birthDates in BirthDates
                                        where birthDates.Id == id
                                        select birthDates).First();
            return birthDate;
        }
    }
}
