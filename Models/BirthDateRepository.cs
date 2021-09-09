using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayCalculator.Models
{
    public static class BirthDateRepository
    {
        private static List<BirthDateModel> BirthDates = new List<BirthDateModel>();

        public static void AddBirthDate(BirthDateModel birthDateModel)
        {
            BirthDates.Add(birthDateModel);
        }
    }
}
