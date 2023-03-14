using MyApp.Models;

namespace MyApp.Services;

public class Paytm : IPaymentService
{
    public PaymentViewModel Pay()
    {
        var vm = new PaymentViewModel()
        {
            VendorName = "Paytm"
        };
        return vm;
    }
}
