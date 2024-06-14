using Tulpep.NotificationWindow;

namespace NOTIFYIME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info;
            popup.TitleText = "Anshika's new work";
            popup.ContentText = " Thank you Slidely AI , for giving this opportunity , I enjoyed making this :). ";
            popup.Popup();
        }
    }
}
