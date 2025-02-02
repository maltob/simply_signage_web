using SimplySignage.Components.Pages;

namespace SimplySignage.Data {
    public class Content {
        public Int64 ID {get; set;}
        public string DisplayName {get;set;}
        public string Description {get;set;}
        public ContentTemplate Template {get;set;}
        public ICollection<ContentTemplateParameter> TemplateParameters {get;set;}
        public DateTime Expires {get;set;}
        public bool Deleted {get;set;}
    }
}