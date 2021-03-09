using System.Windows.Forms;

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

    public class Start 
    {
        public Label Label { get; }
        public Start(Label label)
        {
            Label = label;
        }
    }
    public class Logout { }
}
