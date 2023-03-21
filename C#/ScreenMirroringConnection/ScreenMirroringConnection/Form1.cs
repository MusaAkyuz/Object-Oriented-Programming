using System.Diagnostics.Metrics;
using System.IO;
using System.Text;

namespace ScreenMirroringConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfigureButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(NameTextBox.Text))
            {
                var ps1File = @"./display.ps1";
                var fileName = "./final.ps1";
                string battxt = String.Empty;

                if (File.Exists(ps1File))
                {
                    using (var reader = new StreamReader(ps1File))
                    {
                        string config = "";
                        foreach (string line in System.IO.File.ReadLines(ps1File))
                        {
                            if(line.Trim() == "$networkName=\"XXXXXXXX\"")
                            {
                                config += "$networkName=\"" + NameTextBox.Text.ToString() + "\"\n"; 
                            }
                            else if(line.Trim() == "$wshell.SendKeys(\"XXXXXXXXX\")")
                            {
                                config += "$wshell.SendKeys(\"" + NameTextBox.Text.ToString() + "\")\n";
                            }
                            else
                            {
                                config += line + "\n";
                            }
                        }

                        try
                        {
                            // Check if file already exists. If yes, delete it.     
                            if (File.Exists(fileName))
                            {
                                File.Delete(fileName);
                            }

                            // Create a new file     
                            using (FileStream fs = File.Create(fileName))
                            {
                                // Add some text to file    
                                Byte[] title = new UTF8Encoding(true).GetBytes(config);
                                fs.Write(title, 0, title.Length);
                            }
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.ToString());
                        }
                    }

                }
            }
        }
    }
}