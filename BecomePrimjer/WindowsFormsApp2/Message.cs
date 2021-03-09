namespace WindowsFormsApp2
{
    public class Message
    {
        public string Sadrzaj { get; }
        public Message(string sadrzaj)
        {
            Sadrzaj = sadrzaj;
        }
    }

    public class Start { }
    public class Logout { }
}
