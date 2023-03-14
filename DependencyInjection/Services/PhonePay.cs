using MyApp.Models;

namespace MyApp.Services;

public class PhonePay : IPaymentService
{
    public PaymentViewModel Pay()
    {
        var vm = new PaymentViewModel()
        {
            VendorName = "Phone Pay"
        };
        return vm;
    }
}
