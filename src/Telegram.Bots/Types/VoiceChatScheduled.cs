using System;

namespace Telegram.Bots.Types
{
  public sealed class VoiceChatScheduled
  {
    public DateTime StartDate { get; set; } = DateTime.UnixEpoch;
  }
}
