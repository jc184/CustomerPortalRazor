using System.ComponentModel;

namespace CustomerPortalRazor.Data.Models
{
    public enum Status
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }
}
