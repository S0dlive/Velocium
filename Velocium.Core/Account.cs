using System.Security.Cryptography;
using System.Text;

namespace Velocium.Core;

public class Account
{
    public string Address { get; set; }
    public ECDsa KeyPair { get; set; }

    public Account()
    {
        KeyPair = ECDsa.Create(ECCurve.NamedCurves.nistP256);
        Address = GenerateAddress();
    }
    
    public byte[] SignData(string message)
    {
        var data = Encoding.UTF8.GetBytes(message);
        return KeyPair.SignData(data, HashAlgorithmName.SHA256);
    }
    
    public bool VerifySignature(string message, byte[] signature)
    {
        var data = Encoding.UTF8.GetBytes(message);
        return KeyPair.VerifyData(data, signature, HashAlgorithmName.SHA256);
    }

    public byte[] ExportPrivateKey()
    {
        return KeyPair.ExportECPrivateKey();
    }

    public byte[] ExportPublicKey()
    {
        return KeyPair.ExportSubjectPublicKeyInfo();
    }
    private string GenerateAddress()
    {
        byte[] pubKey = KeyPair.ExportSubjectPublicKeyInfo();
        using var sha = SHA256.Create();
        byte[] hash = sha.ComputeHash(pubKey);
        return Convert.ToHexString(hash[..20]); 
    }
    
    public override string ToString()
    {
        return $"Account: {Address}";
    }
}