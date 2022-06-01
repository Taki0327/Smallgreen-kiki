using System;
using System.IO;
using System.Windows.Forms;

namespace 运行监测
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long sj;
        long a;
        long b;
        public void cqa()
        {
            #region 判断系统是否已启动
            System.Diagnostics.Process[] myProcesses1 = System.Diagnostics.Process.GetProcessesByName("CQA");//获取指定的进程名   
            System.Diagnostics.Process[] myProcesses2 = System.Diagnostics.Process.GetProcessesByName("Flexlive.CQP.CSharpProxy");
            if (myProcesses1.Length > 0) //如果可以获取到知道的进程名则说明已经启动
            {
                label2.Text = a.ToString();
            }
            else
            {
                if (File.Exists(".lnk"))
                {
                    a++;
                    label2.Text = a.ToString();
                    System.Diagnostics.Process.Start(".lnk");
                    label8.Text = DateTime.Now.ToString();
                }
                else
                {
                    label2.Text = "未发现基基快速登录程序";
                    MessageBox.Show("当前目录下未发现基基快速登录 请更换本程序目录后重试");
                    Application.Exit();
                }
            }
            if (myProcesses2.Length > 0) //如果可以获取到知道的进程名则说明已经启动
            {
                label4.Text = b.ToString();
            }
            else
            {
                if (File.Exists("Flexlive.CQP.CSharpProxy.exe"))
                {
                    b++;
                    label4.Text = b.ToString();
                    System.Diagnostics.Process.Start("Flexlive.CQP.CSharpProxy.exe");
                    label8.Text = DateTime.Now.ToString();
                }
                else
                {
                    label4.Text = "未发现代理程序";
                    MessageBox.Show("当前目录下未发现代理程序 请更换本程序目录后重试");
                    Application.Exit();
                }
            }
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {

            cqa();
            if (timer1.Enabled == false)
            {
                sj = 0;
                label6.Text = sj.ToString();
                timer1.Enabled = true;
            }
            MessageBox.Show("监测程序正常运行 PS：卡住几秒是正常现象");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cqa();
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cqa();
            sj = sj + 10;
            label6.Text = sj.ToString();
        }
    }
}
