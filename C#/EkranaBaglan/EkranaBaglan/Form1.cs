using System.Diagnostics;

namespace EkranaBaglan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            WarningLabel.Text = "Bağlanılıyor...\nBir aksiyon yapmayınız!!";

            await PowerShellExecute();

            WarningLabel.Text = "Bağlandı";
            Application.Exit();
        }

        public async static Task PowerShellExecute()
        {
            var ps1File = @".\final.ps1";

            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy ByPass -File \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }
    }
}