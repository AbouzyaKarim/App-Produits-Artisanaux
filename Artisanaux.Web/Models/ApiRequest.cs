using static Artisanaux.Web.SD;

namespace Artisanaux.Web.Models
{
    public class ApiRequest
    {
        public APIType apitype { get; set; }
        public string URL { get; set; }
        public Object DATA { get; set; }
        public string AccessToken { get; set; }
    }
}
