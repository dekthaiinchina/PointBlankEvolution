﻿using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BATTLE_NOTIFY_BE_KICKED_BY_KICKVOTE_ACK : SendPacket
  {
    public override void write()
    {
      this.writeH((short) 3409);
    }
  }
}
