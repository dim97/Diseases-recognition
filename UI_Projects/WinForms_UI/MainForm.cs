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
using DictionaryUMLS;

namespace WinForms_UI
{
    public partial class MainForm : Form
    {
        DataManager dataManager = new DataManager();
        Dict dictUMLS;
        List<string> InputSymptoms;
        public MainForm()
        {
            InitializeComponent();
            dictUMLS = new Dict();
            InputSymptoms = new List<string>();

            List<Symptom> displaySymptoms = dataManager.GetAllSymptoms();
            foreach (var symp in displaySymptoms)
            {
                SymptomsListBox.Items.Add(symp);
            }
            SymptomsListBox.DisplayMember = "Eng";
            SymptomsListBox.ValueMember = "UMLS";
        }

        private void PredictBtn_Click(object sender, EventArgs e)
        {
            List<string> symptoms = InputSymptoms;
            InputSymptoms = new List<string>();
            List<(string, double)> resultToShow = dataManager.GetSortedPredictions(symptoms).Take(10).ToList();

            Disease1Text.Text = resultToShow[0].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[0].Item1);
            Disease2Text.Text = resultToShow[1].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[1].Item1);
            Disease3Text.Text = resultToShow[2].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[2].Item1);
            Disease4Text.Text = resultToShow[3].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[3].Item1);
            Disease5Text.Text = resultToShow[4].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[4].Item1);
            Disease6Text.Text = resultToShow[5].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[5].Item1);
            Disease7Text.Text = resultToShow[6].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[6].Item1);
            Disease8Text.Text = resultToShow[7].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[7].Item1);
            Disease9Text.Text = resultToShow[8].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[8].Item1);
            Disease10Text.Text = resultToShow[9].Item1 + " - " + dataManager.TranslateDiseasesUMLSToEng(resultToShow[9].Item1);

            double maxPrediction = resultToShow.Max(x => x.Item2);

            double proportion;
            int confBarMaxWidth = ConfidenceBar1.Width;
            proportion = resultToShow[0].Item2 / maxPrediction;
            ConfidenceBar1.Width = (int)Math.Ceiling(ConfidenceBarBackground1.Width * proportion);
            proportion = resultToShow[1].Item2 / maxPrediction;
            ConfidenceBar2.Width = (int)Math.Ceiling(ConfidenceBarBackground2.Width * proportion);
            proportion = resultToShow[2].Item2 / maxPrediction;
            ConfidenceBar3.Width = (int)Math.Ceiling(ConfidenceBarBackground3.Width * proportion);
            proportion = resultToShow[3].Item2 / maxPrediction;
            ConfidenceBar4.Width = (int)Math.Ceiling(ConfidenceBarBackground4.Width * proportion);
            proportion = resultToShow[4].Item2 / maxPrediction;
            ConfidenceBar5.Width = (int)Math.Ceiling(ConfidenceBarBackground5.Width * proportion);
            proportion = resultToShow[5].Item2 / maxPrediction;
            ConfidenceBar6.Width = (int)Math.Ceiling(ConfidenceBarBackground6.Width * proportion);
            proportion = resultToShow[6].Item2 / maxPrediction;
            ConfidenceBar7.Width = (int)Math.Ceiling(ConfidenceBarBackground7.Width * proportion);
            proportion = resultToShow[7].Item2 / maxPrediction;
            ConfidenceBar8.Width = (int)Math.Ceiling(ConfidenceBarBackground8.Width * proportion);
            proportion = resultToShow[8].Item2 / maxPrediction;
            ConfidenceBar9.Width = (int)Math.Ceiling(ConfidenceBarBackground9.Width * proportion);
            proportion = resultToShow[9].Item2 / maxPrediction;
            ConfidenceBar10.Width = (int)Math.Ceiling(ConfidenceBarBackground10.Width * proportion);

            MakeResultsVisible();
            InputTextBox.Clear();
        }

        private void SymptomsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var inputSymptom = (Symptom)SymptomsListBox.SelectedItem;
            if (!InputSymptoms.Contains(inputSymptom.UMLS))
            {
                InputSymptoms.Add(inputSymptom.UMLS);
            }
            string strToShow = "";
            foreach (var symptom in InputSymptoms)
            {
                strToShow += symptom + " - " + dataManager.TranslateSymptomEngToUMLS(symptom) + Environment.NewLine;

            }
            InputTextBox.Text = strToShow;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var a = SymptomsListBox.FindString(SearchTextBox.Text);

            SymptomsListBox.Items.Clear();

            foreach (var symp in dataManager.GetAllSymptoms())
            {
                if (symp.Eng.Contains(SearchTextBox.Text))
                {
                    SymptomsListBox.Items.Add(symp);
                }
            }
        }

        private void MakeResultsVisible()
        {
            label1.Visible = true;
            pictureBox1.Visible = false;

            ConfidenceBar1.Visible = true;
            ConfidenceBar2.Visible = true;
            ConfidenceBar3.Visible = true;
            ConfidenceBar4.Visible = true;
            ConfidenceBar5.Visible = true;
            ConfidenceBar6.Visible = true;
            ConfidenceBar7.Visible = true;
            ConfidenceBar8.Visible = true;
            ConfidenceBar9.Visible = true;
            ConfidenceBar10.Visible = true;

            ConfidenceBarBackground1.Visible = true;
            ConfidenceBarBackground2.Visible = true;
            ConfidenceBarBackground3.Visible = true;
            ConfidenceBarBackground4.Visible = true;
            ConfidenceBarBackground5.Visible = true;
            ConfidenceBarBackground6.Visible = true;
            ConfidenceBarBackground7.Visible = true;
            ConfidenceBarBackground8.Visible = true;
            ConfidenceBarBackground9.Visible = true;
            ConfidenceBarBackground10.Visible = true;

            Disease1Text.Visible = true;
            Disease2Text.Visible = true;
            Disease3Text.Visible = true;
            Disease4Text.Visible = true;
            Disease5Text.Visible = true;
            Disease6Text.Visible = true;
            Disease7Text.Visible = true;
            Disease8Text.Visible = true;
            Disease9Text.Visible = true;
            Disease10Text.Visible = true;
        }
    }
}
