using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMM4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string logFilePath = "log1.txt";
        [Conditional("DEBUG")]
        public void Log(string logString)
        {
            File.AppendAllText(logFilePath, logString + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double time = Convert.ToDouble(timeNumeric.Value*24);
            Statistics statistics = new Statistics();

            Node node1 = new Node(statistics, Convert.ToDouble(defectNumeric.Value / 24), Convert.ToDouble(repairNumeric.Value / 24), 201743, 1323, 50021);
            Node node2 = new Node(statistics, Convert.ToDouble(defectNumeric.Value / 24), Convert.ToDouble(repairNumeric.Value / 24), 20143, 14252, 502212);
            Generator generator = new Generator(node1, node2);
            //interval = Math.Min(node1.processingTime, node2.processingTime);
            while (generator.currentTime < time)
            {

                string logString = "";
                
                logString += node1.state.ToString();
                logString += node2.state.ToString();
                Log(logString);
                generator.Time();
                if (logString == "RepairWork" || logString == "WorkRepair")
                {
                    statistics.oneRepairOneWork += generator.interval;
                }
                if (logString == "WorkWork")
                {
                    statistics.bothWork += generator.interval;
                }
                if (logString == "RepairRepair")
                {
                    statistics.bothRepair += generator.interval;
                }
                
            }
            textBox1.Text += "OneRepairOneWork" + (statistics.oneRepairOneWork / time).ToString() + "\n";
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "BothWork" + (statistics.bothWork / time).ToString()+ "\n";
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "BothRepair" + (statistics.bothRepair / time).ToString()+ "\n";
        }

    }
}
