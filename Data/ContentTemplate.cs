using SimplySignage.Components.Pages;

namespace SimplySignage.Data {
    public class ContentTemplate {
        public Int64 ID {get; set;}
        public string DisplayName {get;set;}
        public string Description {get;set;}
        public string TemplateBody {get;set;}
        public ICollection<ContentTemplateParameter> Parameters {get;set;}
    }
}