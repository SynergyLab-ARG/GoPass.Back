namespace GoPass.Domain.DTOs.Request.PaymentRequestDTOs;

public class PaymentStatusDto
{
    public string PaymentId { get; set; }
    public string Status { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}
