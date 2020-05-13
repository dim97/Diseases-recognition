using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpRequestManager;
using System.Windows.Forms;

namespace WinForms_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PredictBtn_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;

            input = input.Replace("\n",String.Empty);
            input = input.Replace("\r", String.Empty);
            input = input.Replace("\"", String.Empty);
            input = input.Replace(" ", String.Empty);
            List<string> symptoms = input.Split(',').ToList();

            RequestManager manager = new RequestManager();
            List<(string, double)> result = manager.GetResponse(symptoms);

            var resultToShow = result.OrderByDescending(r => r.Item2).ToList();

            string strToShow = "";
            foreach (var disease in resultToShow.Take(5))
            {
                strToShow += disease.Item1 + Environment.NewLine;
            }

            OutputTextBox.Text = strToShow;
        }
    }
}
