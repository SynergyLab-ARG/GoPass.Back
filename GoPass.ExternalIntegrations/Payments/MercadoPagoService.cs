using GoPass.Application.Services.Interfaces;
using GoPass.Domain.DTOs.Request.PaymentRequestDTOs;
using MercadoPago.Client.Payment;
using MercadoPago.Config;

namespace GoPass.ExternalIntegrations.Payments;

public class MercadoPagoService : IPaymentService
{
    public MercadoPagoService()
    {
        MercadoPagoConfig.AccessToken = "TEST-8033823159015286-102915-889e71800a4faf4fce4e96078969ae83-141687656"; // cargar desde la configuración
    }

    public async Task<string> GeneratePaymentAsync(PaymentRequestDto paymentRequestDto)
    {
        // Configurar y enviar solicitud de pago
        var client = new PaymentClient();
        var paymentRequestDtoValues = new PaymentCreateRequest
        {
            TransactionAmount = paymentRequestDto.Amount,
            Description = paymentRequestDto.Description,
            // Otras configuraciones como Return URL
        };

        var result = await client.CreateAsync(paymentRequestDtoValues);

        return result.ToString()!;
    }

    public async Task<PaymentStatusDto> VerifyPaymentStatusAsync(string paymentId)
    {
        // Lógica para consultar el estado del pago con MercadoPago
        PaymentStatusDto paymentTest = new PaymentStatusDto()
        {
            Amount = 100
        };
        return paymentTest;
    }

    public async Task<bool> ProcessRefundAsync(string paymentId)
    {
        // Lógica para procesar un reembolso con MercadoPago
        return false;
    }

 }
