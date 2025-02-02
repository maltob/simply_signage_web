public class SignageIdentityOptions {
    public const string Identity = "Identity";

    public bool AllowLocalRegistration {get; set;} = false;

    public string MicrosoftClientID {get; set;} = String.Empty;
    public string MicrosoftClientSecret {get; set;} = String.Empty;

    
    public string GoogleClientID {get; set;} = String.Empty;
    public string GoogleClientSecret {get; set;} = String.Empty;
}