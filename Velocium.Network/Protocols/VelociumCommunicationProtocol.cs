using Nethermind.Libp2p.Core;
using Velocium.Network.Requests;
using Velocium.Network.Responses;

namespace Velocium.Network.Protocols;

public class VelociumCommunicationProtocol : ISessionProtocol<VComRequest, VComResponse>
{
    public Task<VComResponse> DialAsync(IChannel downChannel, ISessionContext context, VComRequest request)
    {
        // todo : implementation of the protocol
        throw new NotImplementedException();
    }

    public string Id { get; }
    public Task ListenAsync(IChannel downChannel, ISessionContext context)
    {
        throw new NotImplementedException();
    }
}