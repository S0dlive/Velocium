using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace Velocium.Core;

public class Transaction
{
    public string TransactionHash { get; set; }
    public DateTime Timestamp { get; set; }
    public string FromAdress { get; set; }
    public string ToAdress { get; set; }
    public decimal Amount { get; set; }

    public Transaction(string fromAdress, string toAdress, decimal amount)
    {
        TransactionHash = CalculateHash();
        Timestamp = DateTime.Now;
    }
    
    private string CalculateHash()
    {
        using SHA256 sha = SHA256.Create();
        string raw = $"{Timestamp}-{ToAdress}-{Amount}-{FromAdress}";
        byte[] bytes = Encoding.UTF8.GetBytes(raw);
        byte[] hashBytes = sha.ComputeHash(bytes);
        return Convert.ToHexString(hashBytes);
    }
    
}