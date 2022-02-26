using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace FindText
{
    public partial class FormMain : Form
    {
        bool stop;
        AutoCompleteStringCollection inputHistory = new AutoCompleteStringCollection();
        public FormMain()
        {
            InitializeComponent();
            buttonFolder.Click += ButtonFolder_Click;
            buttonStart.Click += ButtonStart_Click;
            buttonCopy.Click += ButtonCopy_Click;
            checkBoxWrap.CheckedChanged += CheckBoxWrap_CheckedChanged;
            FormClosing += FormMain_FormClosing;
            textBoxKeyWord.AutoCompleteCustomSource = inputHistory;
            KeyPreview = true;
            KeyDown += FormMain_KeyDown;
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !textBoxResult.Focused)
            {
                ButtonStart_Click(null, null);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
            Environment.Exit(0);
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxResult.Text))
            {
                return;
            }
            Clipboard.SetText(textBoxResult.Text);
        }

        private void CheckBoxWrap_CheckedChanged(object sender, EventArgs e)
        {
            textBoxResult.WordWrap = checkBoxWrap.Checked;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(textBoxFolder.Text) || (string.IsNullOrWhiteSpace(textBoxKeyWord.Text) && !checkBoxNoResult.Checked))
            {
                return;
            }
            inputHistory.Add(textBoxKeyWord.Text);
            if (comboBoxFilter.Items.Contains(comboBoxFilter.Text))
            {
                string s = comboBoxFilter.Text;
                comboBoxFilter.Items.Remove(comboBoxFilter.Text);
                comboBoxFilter.Text = s;
            }
            comboBoxFilter.Items.Insert(0, comboBoxFilter.Text);
            CheckForIllegalCrossThreadCalls = false;
            if (buttonStart.Text == "停止")
            {
                stop = true;
                return;
            }
            stop = false;
            buttonStart.Text = "停止";
            textBoxResult.Clear();
            Thread t = new Thread(ThMain);
            t.Start();
            toolStripStatusLabelResult.Text = "正在檢索……";
        }

        private void ButtonFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ThMain()
        {
            string pattern;
            pattern = comboBoxFilter.Text.Trim();
            if (pattern.StartsWith("."))
            {
                pattern = "*" + pattern;
            }
            //else if (!pattern.StartsWith( "*"))
            //{
            //    pattern = "*." + pattern;
            //}
            try
            {
                GetResult(textBoxFolder.Text, pattern, textBoxKeyWord.Text, (int)numericUpDownLenth.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            buttonStart.Text = "開始";
        }

        private void GetResult(string path, string pattern, string keyWord, int charNum)
        {
            string[] allFiles = checkBoxSonParh.Checked ? Directory.GetFiles(path, pattern, SearchOption.AllDirectories) : Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly);
            int filenum = 0;
            int resultnum = 0;
            int truefile = 0;
            bool onlyfile = string.IsNullOrWhiteSpace(textBoxKeyWord.Text) && checkBoxNoResult.Checked;
            foreach (string file in allFiles)
            {
                filenum++;
                if (stop)
                {
                    toolStripStatusLabelResult.Text = "操作中斷。";
                    return;
                }
                if (onlyfile)
                {
                    textBoxResult.AppendText(file + "\r\n");
                    continue;
                }
                try
                {
                    string[] textLines = GetTextLines(file);
                    int totle = 0;
                    string result = "";
                    for (int line = 0; line < textLines.Length; line++)
                    {
                        Regex regex = checkBoxCaps.Checked ? new Regex(keyWord) : new Regex(keyWord.ToLower());
                        Match match = checkBoxCaps.Checked ? regex.Match(textLines[line]) : regex.Match(textLines[line].ToLower());
                        while (match.Success)
                        {
                            if (stop)
                            {
                                toolStripStatusLabelResult.Text = "操作中斷。";
                                return;
                            }
                            int bindex;
                            int eindex;
                            bindex = charNum > match.Index + 1 ? 0 : match.Index + 1 - charNum;
                            eindex = match.Index + charNum >= textLines[line].Length ? textLines[line].Length : match.Index + charNum;
                            if (checkBoxShowWord.Checked)
                                result += "\t第" + (line + 1) + "行\t......" + textLines[line].Substring(bindex, eindex - bindex) + "\r\n";
                            totle++;
                            match = regex.Match(textLines[line], match.Index + match.Length);
                            //Application.DoEvents();
                            resultnum++;
                        }
                    }
                    if (checkBoxNoResult.Checked || totle > 0)
                    {
                        textBoxResult.AppendText(file + "\t" + totle + "\r\n");
                        if (checkBoxShowWord.Checked)
                            textBoxResult.AppendText(result);
                        textBoxResult.AppendText("\r\n");
                        truefile++;
                    }
                }
                catch { }
            }
            toolStripStatusLabelResult.Text = onlyfile ? $"搜索完畢，共找到{filenum}個文件。" : $"搜索完畢，共找到{truefile}個文件，{resultnum}個匹配項。";
        }

        private string[] GetTextLines(string file)
        {
            TextEncodingDetect textDetect = new TextEncodingDetect();
            byte[] buffer = File.ReadAllBytes(file);
            TextEncodingDetect.Encoding encoding = textDetect.DetectEncoding(buffer);
            Encoding fEnc;
            switch (encoding)
            {
                case TextEncodingDetect.Encoding.None:
                    fEnc = Encoding.Default;
                    break;
                case TextEncodingDetect.Encoding.Ansi:
                    fEnc = Encoding.Default;
                    break;
                case TextEncodingDetect.Encoding.Ascii:
                    fEnc = Encoding.ASCII;
                    break;
                case TextEncodingDetect.Encoding.Utf8Bom:
                case TextEncodingDetect.Encoding.Utf8Nobom:
                    fEnc = Encoding.UTF8;
                    break;
                case TextEncodingDetect.Encoding.Utf16LeBom:
                case TextEncodingDetect.Encoding.Utf16LeNoBom:
                    fEnc = Encoding.Unicode;
                    break;
                case TextEncodingDetect.Encoding.Utf16BeBom:
                case TextEncodingDetect.Encoding.Utf16BeNoBom:
                    fEnc = Encoding.BigEndianUnicode;
                    break;
                default:
                    fEnc = Encoding.Default;
                    break;
            }
            string str = fEnc.GetString(buffer);
            return str.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n');
        }
    }
}
