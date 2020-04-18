using DictionaryUMLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictUi
{
    public partial class Dictoinary : Form
    {
        private Dict _dict;
        public Dictoinary()
        {
            InitializeComponent();
            _dict = new Dict();
            DiseasesUmlsComboBox.DataSource = _dict.AllDiseasesUMLS;
            SymptomsUmlsComboBox.DataSource = _dict.AllSymptomsUMLS;
            DiseasesEngComboBox.DataSource = _dict.AllDiseasesEng;
            SymptomsEngComboBox.DataSource = _dict.AllSymptomsEng;
        }

        private void DiseasesUmlsComboBox_TextChanged(object sender, EventArgs e)
        {
            EngResult.Text = _dict.UMLSToEng(DiseasesUmlsComboBox.Text);
        }

        private void SymptomsUmlsComboBox_TextChanged(object sender, EventArgs e)
        {
            EngResult.Text = _dict.UMLSToEng(SymptomsUmlsComboBox.Text);
        }

        private void DiseasesEngComboBox_TextChanged(object sender, EventArgs e)
        {
            UMLSResult.Text = _dict.EngToUMLS(DiseasesEngComboBox.Text);
        }

        private void SymptomsEngComboBox_TextChanged(object sender, EventArgs e)
        {
            UMLSResult.Text = _dict.EngToUMLS(SymptomsEngComboBox.Text);
        }
    }
}
