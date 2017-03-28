using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace TesterSample
{
    public partial class Deploy : Form
    {
        private static Deploy _instance = null;

        private Deploy()
        {
            InitializeComponent();

            this.Version_Box.Text = Properties.Settings.Default.ProjectVersion;
            this.SDL_Box.Text = Properties.Settings.Default.SDL_Number;
        }

        //シングルトンパターンを使う
        public static Deploy getInstance()
        {
            if( _instance == null )
            {
                _instance = new Deploy();
            }

            return _instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProjectVersion = this.Version_Box.Text;
            Properties.Settings.Default.SDL_Number = this.SDL_Box.Text;
            Properties.Settings.Default.Save();
        }

        private void loadWeather_Button_Click(object sender, EventArgs e)
        {
            CompileSW.reflash();
            XML_View.loadWeather();
        }

        public void addCompileSW_ListBox(string str)
        {
            CompileSW_ListBox.Items.Add(str);
        }
    }

    public class XML_View
    {
        public static void loadWeather()
        {

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("http://www.drk7.jp/weather/xml/11.xml");

            XmlNodeList nodeList = xmlDocument.SelectNodes("/weatherforecast/pref/area");

            string xml_string = "";
            for (int i = 0; i < nodeList.Count; i++)
            {
                xml_string += "NodeType: " + nodeList[i].NodeType + "\r\n";
                xml_string += "Name: " + nodeList[i].Name + "\r\n";
                xml_string += "LocalName: " + nodeList[i].LocalName + "\r\n";
                xml_string += "Value: " + nodeList[i].Value + "\r\n";
                xml_string += "InnerText: " + nodeList[i].InnerText + "\r\n";
                xml_string += "\r\n";
            }
        }
    }

    public class CompileSW
    {
        public static void reflash()
        {
            Regex reg = new Regex("^-D ");
            OpenFileDialog ofd =  new OpenFileDialog();

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader cReader = null;
                    cReader = new StreamReader(ofd.FileName, System.Text.Encoding.Default);

                    while ((cReader.EndOfStream == false) || (cReader == null))
                    {
                        string str = cReader.ReadLine();

                        if (reg.IsMatch(str) == true)
                        {
                            Deploy.getInstance().addCompileSW_ListBox(str); /* 正規表現にマッチしたときにリストボックスに追加する */
                        }
                    }

                    cReader.Close();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("正しい値を入力してください。", "エラー");
            }   

        }
    }
}
