using System.Security.Cryptography;
using System.Text;

namespace Velocium.Core;

public class Block
{
    public string BlockHash { get; set; }
    public long BlockIndex { get; set; }
    public List<Transaction> Transactions { get; set; }
    public string PreviousBlockHash { get; set; }
    public DateTime TimeStamp { get; set; }
    public int Nonce { get; set; }
    
    public static string CalculateHash(int index, DateTime timestamp, List<Transaction> transactions, string prevHash, int nonce)
    {
        string data = "";
        foreach (var transaction in transactions)
        {
            data += transaction.TransactionHash;
        }
        string raw = $"{index}-{timestamp:o}-{data}-{prevHash}-{nonce}";
        using var sha = SHA256.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(raw);
        byte[] hashBytes = sha.ComputeHash(bytes);
        return Convert.ToHexString(hashBytes);
    }
}