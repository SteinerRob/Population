using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population
{
    public class FilterDocument
    {
        public int SearchedGender { get; set; }
        public int SearchedMonth { get; set; }
        public List<Day> FilteredList { get; set; }


        public FilterDocument(Document document, int searchedGender, int searchedMonth)
        {
            SearchedGender = searchedGender;
            SearchedMonth = searchedMonth;
            FilteredList = new List<Day>();
            GetFilteredList(document);
            
        }

        public void GetFilteredList(Document document)
        {

            foreach (var day in document._days)
            {
               if (day.Gender == SearchedGender && IntMonthFromDateTime(day.Date) == SearchedMonth +1)
               {
                    FilteredList.Add(day);
               }
            }
        }

        private int IntMonthFromDateTime(DateTime date)
        {
            int result = date.Month;
            return result;
        }
    }
}
