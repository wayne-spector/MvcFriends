namespace MvcFriends.Models; // 確保這裡的 namespace 跟您的專案一致

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}