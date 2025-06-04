using Nethermind.Libp2p.Core;

namespace Velocium.Network.Protocols;

public class VelociumConsensusProtocol : ISessionProtocol
{
    public string Id { get; }
    public Task ListenAsync(IChannel downChannel, ISessionContext context)
    {
        throw new NotImplementedException();
    }

    public Task DialAsync(IChannel downChannel, ISessionContext context)
    {
        throw new NotImplementedException();
    }
}