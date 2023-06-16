namespace TestDevco.Exercises.F06
{
    public class History
    {
        public string LastMsg { get; set; }
        //private string LastMsg { get; set; }

        public event EventHandler<Guid> IdMsgRegistered;

        public void AddMsg(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastMsg = error;

            // logic
            var guid = Guid.NewGuid();

            RaiseMsgEvent(guid);
            //IdMsgRegistered?.Invoke(this, Guid.NewGuid());
        }

        private void RaiseMsgEvent(Guid guid)
        {
            IdMsgRegistered?.Invoke(this, guid);
        }
    }
}
