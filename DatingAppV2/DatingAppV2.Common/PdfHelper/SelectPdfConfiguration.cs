
namespace DatingAppV2.Common.PdfHelper
{
    public interface ISelectPdfConfiguration
    {
        string LicenseKey { get; }
    }

    public class SelectPdfConfiguration : ISelectPdfConfiguration
    {
        public string LicenseKey { get; set; }
    }
}