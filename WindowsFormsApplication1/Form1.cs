using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正しい値を入力してください。",
            "エラー");
        }

        private void selectModeButton_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rdoMode in DMM_ModeSelectBox.Controls )
            {
                if( rdoMode.Checked == true )
                {
                    //MessageBox.Show(rdoMode.Text);
                    break;
                }

            }
        }

        private void DMM_GetValueButton_Click(object sender, EventArgs e)
        {
            string read_value;
            read_value = WindowsFormsApplication1.Program.DMM.readValue();
            DMM_OutputBox.Text = read_value;
        }

        private void OpenXlsxFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd;
            string raw_file;

            ofd = new OpenFileDialog();

            ofd.Filter = "xlsxファイル(*.xlsx)|*.xlsx|すべてのファイル(*.*)|*.*";

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(ofd.FileName);

                XlsxFilePath.Text = ofd.FileName;
            }
        }

        private void DeployFormShow_Button_Click(object sender, EventArgs e)
        {
            TesterSample.Deploy new_form = TesterSample.Deploy.getInstance();

            new_form.Show();
        }
    }
}
