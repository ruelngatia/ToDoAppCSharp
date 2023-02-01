

namespace ToDoApp.Functionality
{
    public class DateHandler
    {
        public static Dictionary<int, string> month = new Dictionary<int, string>
        {
            {1,"January"},
            {2,"February"},
            {3,"March "},
            {4,"April"},
            {5,"May"},
            {6,"June"},
            {7,"July"},
            {8,"Agust"},
            {9,"September"},
            {10,"October"},
            {11,"November"},
            {12,"December"},
        };

    

        public static CustomDate GetCustomDate()
        {
            DateTime currentTime = DateTime.Now;
            CustomDate customDate = new CustomDate(currentTime.Day, GetSup(currentTime.Day),month[currentTime.Month],currentTime.Year);

            return customDate;
        }

        private static string GetSup(int date)
        {
            char last = Convert.ToString(date).Last();
            switch (last){
                case '1':
                    return "st";
                
                case '2':
                    return "nd";
                  
                case '3':
                    return "rd";
                    
                default:
                    return "th";
            }

            
        }

    }

    public class CustomDate
    {
        public int Date { get; set; }
        public string sup { get; set; }
        public string month { get; set; }
        public int year { get; set; }

        public CustomDate(int date,string sup,string month,int year) 
        {
            this.Date = date;
            this.sup = sup;
            this.year = year;
            this.month = month;
        }
    }

}
