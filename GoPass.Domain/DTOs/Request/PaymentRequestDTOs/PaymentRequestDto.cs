namespace GoPass.Domain.DTOs.Request.PaymentRequestDTOs;

public class PaymentRequestDto
{
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public string ReturnUrl { get; set; }
}
