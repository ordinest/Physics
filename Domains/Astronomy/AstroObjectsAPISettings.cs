namespace Physics.Domains.Astronomy
{
    public interface IAstroObjectsAPISettings
    {
        public string AstroObjectsBaseAddress { get; set; }
    }

    public class AstroObjectsAPISettings : IAstroObjectsAPISettings
    {
        public string AstroObjectsBaseAddress { get; set; }
    }
}
