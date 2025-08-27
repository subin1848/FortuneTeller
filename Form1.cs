using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class Form1 : Form
    {
        List<string> results;

        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string filename = "results.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 존재하지 않습니다. \n{ex.Message}", "파일이 없는 오류!");
            }
            
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없습니다. \n{ex.Message}", "파일 권한 오류!");
            }
            
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다. \n{ex.Message}", "알 수 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 상단내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory();
                form.Show();
            }
        }
        
        private string GetFortune()
        {
            Random random = new Random();
            int index = random.Next(0, results.Count);
            return results[index];
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 포춘텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string birthday = tbBirthday.Text;
            string birthtime = tbBirthtime.Text;
            string result = GetFortune();
            string saju = result.Split('|')[0];
            string message = result.Split('|')[1];
            tbResult.Text = birthday + " " + birthtime + Environment.NewLine 
                + saju + Environment.NewLine
                + message;
            SaveHistory($"{birthday} {birthtime}|{result}");
        }

        private void SaveHistory(string history)
        {
            try
            {
                string filename = "history.csv";
                File.AppendAllText(filename, history + Environment.NewLine);
            } 
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없습니다. \n{ex.Message}", "권한 오류!");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다. \n{ex.Message}", "알 수 없는 오류!");
            }
        }
    }
}
