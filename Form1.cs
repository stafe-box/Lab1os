using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Environment;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string MilsToText (long Mils)
        {
            long Secondns = Mils/1000;
            long RMils = Mils - Secondns * 1000;
            long Minutes = Secondns/60;
            long RSeconds = Secondns - Minutes * 60;
            long Hours = Minutes/60;
            long RMinutes = Minutes - Hours * 60;
            string Time = $"{Hours}:{RMinutes}:{RSeconds}.{RMils:D3}";
            return Time;
        }

        private void Click_Click(object sender, EventArgs e)
        {
            int CoreCount = System.Environment.ProcessorCount;
            label1.Text = $"Количество потоков процессора: {CoreCount}";
            string Name = System.Environment.MachineName;
            label2.Text = $"Название компьютера: {Name}";
            int TimeWork = System.Environment.TickCount;
            label3.Text = $"Время работы компьютера: {MilsToText(TimeWork)}";
            long Memory = System.Environment.WorkingSet;
            label4.Text = $"Колличество памяти, выделенной для процесса: {Memory / 1000000} МБ";
            string Directory = System.Environment.CurrentDirectory;
            label5.Text = $"Активная директория: {Directory}";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
