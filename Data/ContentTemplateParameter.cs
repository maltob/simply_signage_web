using SimplySignage.Components.Pages;

namespace SimplySignage.Data {
    public class ContentTemplateParameter {
        public Int64 ID {get; set;}
        public string DisplayName {get;set;}
        public string Description {get;set;}
        public string Body {get;set;}
        public string Validation {get;set;}
        public ContentTemplateParameterType Type {get;set;}
    }

    public enum ContentTemplateParameterType {
        String,
        URL,
        Number,
        Color,
        Image
    }
}