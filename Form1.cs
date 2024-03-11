using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_OS
{
    public partial class Form1 : Form
    {
        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            backgroundWorker.Execute(); 
            StartMainWork(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartMainWork()
        {
            new Thread(() =>
            {
                while (true)
                {
                    this.Invoke(new Action(() =>
                    {
                        Text = $"Основной поток: {DateTime.Now}";
                    }));
                    Thread.Sleep(1000); 
                }
            })
            { IsBackground = true }.Start(); 
        }
    }
}
