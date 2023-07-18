using Microsoft.VisualBasic;

namespace CopyWStash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baseText = "TestText";
            string prefix = textPrefix.Text;
            string suffix = textSuffix.Text;
            string replacerText = textRemove.Text;
            if (textRemove.Text != "")
            {
                baseText = baseText.Replace(replacerText, "");

            }
            System.Diagnostics.Debug.WriteLine($"{prefix}{baseText}{suffix}");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baseText = "TestText";
            string prefix = textPrefix.Text;
            string suffix = textSuffix.Text;
            string replacerText = textRemove.Text;
            if (textRemove.Text != "")
            {
                baseText = baseText.Replace(replacerText, "");

            }
            System.Diagnostics.Debug.WriteLine($"{prefix}{baseText}{suffix}");

        }
    }
}
