using System.Collections.Generic;

namespace Telegram.Bots.Types
{
  public sealed class VoiceChatParticipantsInvited
  {
    public IReadOnlyList<User>? Users { get; set; }
  }
}
