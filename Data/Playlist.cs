using SimplySignage.Components.Pages;

namespace SimplySignage.Data {
    public class Playlist {
        public Int64 ID {get; set;}
        public string DisplayName {get;set;}
        public string Description {get;set;}
        public ContentSchedule Schedule {get;set;}
        public ICollection<PlaylistItem> Items {get;set;}
    }
}