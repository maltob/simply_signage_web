using SimplySignage.Components.Pages;

namespace SimplySignage.Data {
    public class Display {
        public int ID {get; set;}
        public string DisplayName {get;set;}
        public ICollection<Playlist> Playlists {get;set;}
    }
}