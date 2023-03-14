using MyApp.Models;

namespace MyApp.Services;

public class GPay : IPaymentService
{
    public PaymentViewModel Pay()
    {
        var vm = new PaymentViewModel()
        {
            VendorName = "GPay"
        };
        return vm;
    }
}
