using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using NetOffice.WordApi;
namespace Word2XML_2
{
    public partial class MainForm : Form
    {
        private string _openFile;
        private string _saveFile;
        private string _outputFileType = "";
        private List<FieldXML> _fieldsXML = new List<FieldXML>();
        private List<MyTupleXML<string, string>> _fieldsXML2 = new List<MyTupleXML<string, string>>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                extractButtonXML.Enabled = true;
                extractButtonXML2.Enabled = true;
                _openFile = ofd.FileName;
                fileSelectedTextBox.Text = Path.GetFileName(_openFile);
            }
            else { MessageBox.Show("Error, please select a file"); }
        }

        private void extractButtonXML_Click(object sender, EventArgs e)
        {
            switch (Path.GetExtension(_openFile))
            {
                case ".txt":
                    extractTextFileXML(_fieldsXML, _openFile);
                    break;
                case ".docx":
                    extractWordFileXML(_fieldsXML, _openFile);
                    break;
            }
            saveFileButton.Enabled = true;
            _outputFileType = "xml_version1";
            toggleExtractButtons(false);
        }
        private void extractButtonXML2_Click(object sender, EventArgs e)
        {
            switch (Path.GetExtension(_openFile))
            {
                case ".txt":
                    extractTextFileXML2(_fieldsXML2, _openFile);
                    break;
                case ".docx":
                    extractWordFileXML2(_fieldsXML2, _openFile);
                    break;
            }
            saveFileButton.Enabled = true;
            _outputFileType = "xml_version2";
            toggleExtractButtons(false);
        }
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            switch (_outputFileType)
            {
                case "xml_version1":
                    saveFileXML();
                    break;
                case "xml_version2":
                    saveFileXML2();
                    break;
            }
            
        }
        // Gui manipulation
 
        /// <summary>
        /// Toggles the extract buttons with a boolean value.
        /// </summary>
        /// <param name="t"></param>
        private void toggleExtractButtons(bool t)
        {
            extractButtonXML.Enabled = t;
            extractButtonXML2.Enabled = t;
        }
        // Extraction Functions
        private void extractTextFileXML(List<FieldXML> list, string file)
        {
            using (FileStream s = File.OpenRead(file))
            using (TextReader reader = new StreamReader(s))
            {
                while (reader.Peek() > -1)
                {
                    string line = reader.ReadLine();
                    string[] fieldArray = line.Split('=');
                    fieldCleanUp(fieldArray);
                    FieldXML field = new FieldXML(fieldArray[0], fieldArray[1]);
                    list.Add(field);
                }
            }
        }
        private void extractTextFileXML2(List<MyTupleXML<string, string>> list, string file)
        {
            using (FileStream s = File.OpenRead(file))
            using (TextReader reader = new StreamReader(s))
            {
                while (reader.Peek() > -1)
                {
                    string line = reader.ReadLine();
                    string[] fieldArray = line.Split('=');
                    fieldCleanUp(fieldArray);
                    MyTupleXML<string, string> tuple = new Tuple<string, string>(fieldArray[0], fieldArray[1]);
                    list.Add(tuple);
                }
            }
        }
        private void extractWordFileXML(List<FieldXML> list, string file)
        {
            string text = extractWordDocument(file);
            string[] lines = text.Split(';');
            for (int i = 0; i < lines.Length - 1; i++)
            {
                string[] fieldArray = lines[i].Split('=');
                fieldCleanUp(fieldArray);
                FieldXML field = new FieldXML(fieldArray[0], fieldArray[1]);
                list.Add(field);
            }
        }
        private void extractWordFileXML2(List<MyTupleXML<string, string>> list, string file)
        {
            string text = extractWordDocument(file);
            string[] lines = text.Split(';');
            for (int i = 0; i < lines.Length - 1; i++)
            {
                string[] fieldArray = lines[i].Split('=');
                fieldCleanUp(fieldArray);
                MyTupleXML<string, string> tuple = new Tuple<string, string>(fieldArray[0], fieldArray[1]);
                list.Add(tuple);
            }
        }
        
        //Serialization Functions
        private void outputSerializedFieldsXML(List<FieldXML> list, string file)
        {
            FieldSerializerXML.SerializeObject(list, file);
        }
        private void outputSerializedFieldsXML2(List<MyTupleXML<string, string>> list, string file)
        {
            FieldSerializerXML2.SerializeObject(list, file);
        }
        // Save File Functions
        private void saveFileXML()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".xml";
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _saveFile = sfd.FileName;
                outputSerializedFieldsXML(_fieldsXML, _saveFile);
                fileSavedTextBox.Text = Path.GetFileName(_saveFile);
                saveFileButton.Enabled = false;
            }
        }
        private void saveFileXML2()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".xml";
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _saveFile = sfd.FileName;
                outputSerializedFieldsXML2(_fieldsXML2, _saveFile);
                fileSavedTextBox.Text = Path.GetFileName(_saveFile);
                saveFileButton.Enabled = false;
            }
        }
        
        // Utility Functions
        /// <summary>
        /// Extracts the text from a word document and returns it as a string.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string extractWordDocument(string file)
        {
            NetOffice.WordApi.Application wordApplication = new NetOffice.WordApi.Application();
            NetOffice.WordApi.Document newDocument = wordApplication.Documents.Open(file);
            string txt = newDocument.Content.Text;
            wordApplication.Quit();
            wordApplication.Dispose();
            return txt;
        }
        /// <summary>
        ///  Cleans up whitespace at the beginning and ends of the strings in a string[].
        /// </summary>
        /// <param name="s"></param>
        private void fieldCleanUp(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = (s[i].Replace(";", "")).Trim();
            }
        }

    }
}
