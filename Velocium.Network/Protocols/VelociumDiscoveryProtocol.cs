using Multiformats.Address;
using Nethermind.Libp2p.Core.Discovery;

namespace Velocium.Network.Protocols;

public class VelociumDiscoveryProtocol : IDiscoveryProtocol
{
    public Task StartDiscoveryAsync(IReadOnlyList<Multiaddress> localPeerAddr, CancellationToken token = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}