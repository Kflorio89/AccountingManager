using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingManager
{
    public partial class MainPage : Form
    {
        private List<BillData> _bills;
        private List<BillData> Bills
        {
            get
            {
                return _bills;
            }
            set
            {
                _bills = value;
                UpdateWindow();
            }
        }
        
        public MainPage()
        {
            InitializeComponent();
            Bills = new List<BillData>();
            LoadDataFromFile();
            UpdateWindow();
        }

        private void UpdateWindow()
        {
            PopulateOverview();
            PopulateSummary();
        }

        private void PopulateOverview()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bill Name \t\t Amount");
            sb.AppendLine("-----------------------------------------------");
            foreach (BillData data in _bills)
            {
                sb.AppendLine($"{data.Name} \t\t ${data.Amount}");
            }
            _txtBillOverview.Text = sb.ToString();
        }

        private void PopulateSummary()
        {
            StringBuilder sb = new StringBuilder();
            double total = 0.0;
            double mostExpensive = 0.0;
            double secondMostExpensive = 0.0;
            for (int i = 0; i < _bills.Count; ++i)
            {
                total += _bills[i].Amount;
                if (_bills[i].Amount > mostExpensive)
                {
                    secondMostExpensive = mostExpensive;
                    mostExpensive = _bills[i].Amount;
                }
            }
            sb.AppendLine($"Total: ${total}");
            sb.AppendLine($"Most Expensive Bill: ${mostExpensive}");
            sb.AppendLine($"Second Most Expensive Bill ${secondMostExpensive}");
            _txtSummary.Text = sb.ToString();
        }

        private void BtnAddBill_Click(object sender, EventArgs e)
        {
            string[] billInfo = _txtNewBill.Text.Trim().Split(':');
            if (billInfo.Length < 2)
            {
                //error on input
                MessageBox.Show("Input Error", $"Invalid format for {_txtNewBill.Text.Trim()}\nUse \':\' to separate, ex. name:value.");
                return;
            }
            if (!double.TryParse(billInfo[1], out double amount))
            {
                MessageBox.Show("Input Error", $"Amount: {billInfo[1]} is not recognized as a number");
                return;
            }
            Bills.Add(new BillData(billInfo[0], amount));
            _txtNewBill.Text = "";
            UpdateWindow();
        }

        private void LoadDataFromFile()
        {
            string mainFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            List<string> txtFiles = GetFiles(mainFolder, "*.txt");

            foreach (string file in txtFiles)
            {
                
                if (!Path.GetFileName(file).Contains("Data"))
                {
                    continue;
                }

                string[] lines = File.ReadAllLines(file, Encoding.UTF8);
                
                foreach (string line in lines)
                {
                    string[] data = line.Split(':');
                    if (data.Length < 2)
                    {
                        continue;
                    }
                    if (!double.TryParse(data[1], out double amount))
                    {
                        continue;
                    }
                    Bills.Add(new BillData(data[0], amount));
                }
            }
        }

        private static List<string> GetFiles(string path, string searchPattern)
        {
            try
            {
                return Directory.GetFiles(path, searchPattern).ToList();
            }
            catch (UnauthorizedAccessException ex)
            {
                CreateTextFileLog($"Exception thrown while in GetFiles(), Exception: {ex.Message}");
                return new List<string>();
            }
        }

        private static void CreateTextFileLog(string Message)
        {
            StreamWriter SW;
            string dateTime = DateTime.Now.ToString("yyyyMMdd");
            if (!File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "txt_" + dateTime + ".txt")))
            {
                SW = File.CreateText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "txt_" + dateTime + ".txt"));
                SW.Close();
            }
            using (SW = File.AppendText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "txt_" + dateTime + ".txt")))
            {
                SW.WriteLine(DateTime.Now.ToString("yyyy:MM:dd:hh:mm:ss") + ": " + Message);
                SW.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<string> dataLines = new List<string>();
            foreach (BillData bill in _bills)
            {
                dataLines.Add($"{bill.Name}:{bill.Amount}");
            }
            string masterFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MasterData.txt");

            File.WriteAllLines(masterFile, dataLines);
            MessageBox.Show($"Saved contents to: {masterFile}");
        }
    }
}
