namespace TestDevco.Exercises.F06;

public class History
{
    public string LastMessage { get; set;}

    public History(string lastMessage)
    {
        this.LastMessage = lastMessage;
    }

    public event EventHandler<Guid>? RegisteredMessageId;

    public void AddMessage(string newMessage)
    {
        if (String.IsNullOrWhiteSpace(newMessage))
            throw new ArgumentNullException(nameof(newMessage));

        LastMessage = newMessage;

        RegisteredMessageId?.Invoke(this, Guid.NewGuid());
    }
}
