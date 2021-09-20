namespace Telegram.Bots.Types
{
  public sealed class MessageId
  {
    public int Id { get; set; }

    public MessageId()
    {
    }

    public MessageId(int id)
    {
      this.Id = id;
    }
  }
}
