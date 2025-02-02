using SimplySignage.Components.Pages;

namespace SimplySignage.Data {
    public class ContentSchedule {
        public Int64 ID {get; set;}
        public string DisplayName {get;set;}
        public string Description {get;set;}
        public string DaysOfWeek {get;set;}
        public string TimeOfDay {get;set;}
        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}

    }
}