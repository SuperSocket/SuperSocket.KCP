using System.Net;
using System.Net.Sockets;
using SuperSocket.Channel;
using SuperSocket.ProtoBase;
using SuperSocket.Udp;

namespace SuperSocket.KCP
{
    public class KCPPipeChannel<TPackageInfo> : UdpPipeChannel<TPackageInfo>
    {
        public KCPPipeChannel(Socket socket, IPipelineFilter<TPackageInfo> pipelineFilter, ChannelOptions options, IPEndPoint remoteEndPoint)
            : this(socket, pipelineFilter, options, remoteEndPoint, $"{remoteEndPoint.Address}:{remoteEndPoint.Port}")
        {

        }

        public KCPPipeChannel(Socket socket, IPipelineFilter<TPackageInfo> pipelineFilter, ChannelOptions options, IPEndPoint remoteEndPoint, string sessionIdentifier)
            : base(socket, pipelineFilter, options, remoteEndPoint, sessionIdentifier)
        {

        }
    }
}