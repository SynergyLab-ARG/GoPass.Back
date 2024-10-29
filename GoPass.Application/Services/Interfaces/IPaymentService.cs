using GoPass.Domain.DTOs.Request.PaymentRequestDTOs;

namespace GoPass.Application.Services.Interfaces;

public interface IPaymentService
{
    Task<string> GeneratePaymentAsync(PaymentRequestDto paymentRequest);
    Task<PaymentStatusDto> VerifyPaymentStatusAsync(string paymentId);
    Task<bool> ProcessRefundAsync(string paymentId);
}
