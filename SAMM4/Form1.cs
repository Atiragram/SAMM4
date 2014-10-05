﻿using System;
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
            node1.processingTime = node1.defectGenerator();
            node2.processingTime = node2.defectGenerator();
            //interval = Math.Min(node1.processingTime, node2.processingTime);
            while (generator.currentTime < time)
            {
                string logString = "";
                logString += node1.state.ToString();
                logString += node2.state.ToString();
                Log(logString);
                generator.Time();
            }
        }

    }
}
