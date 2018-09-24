﻿using QQ.Framework.Events;
using QQ.Framework.Packets.Receive.Data;

namespace QQ.Framework.Domains.Commands.ReceiveCommands.Data
{
    [ReceivePacketCommand(QQCommand.Data0X019B)]
    public class _019BCommand : ReceiveCommand<Receive_0x019B>
    {
        public _019BCommand(byte[] data, ISocketService service, IServerMessageSubject transponder, QQUser user) :
            base(data, service, transponder, user)
        {
            _packet = new Receive_0x019B(data, _user);
            _eventArgs = new QQEventArgs<Receive_0x019B>(_service, _user, _packet);
        }

        public override void Process()
        {
            Response();
        }
    }
}