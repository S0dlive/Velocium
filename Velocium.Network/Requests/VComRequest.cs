namespace Velocium.Network.Requests;

public class VComRequest
{
    public string RequestId { get; }
    public string Command { get; }
    public List<string> Parameters { get; }
}