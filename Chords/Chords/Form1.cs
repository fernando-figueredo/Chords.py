﻿using Chords.Profiling;
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

namespace Chords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 30; i++)
            //{
            //    var label = new Label
            //    {
            //        Text = "Em",
            //        Width = 100,
            //            Height = 50,
            //            //AutoSize = true,
            //            Font = new Font(this.Font.FontFamily, 15),
            //            BorderStyle = BorderStyle.FixedSingle,

            //    };

            //    this.flowLayoutPanel1.Controls.Add(label);
            //}
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Audio files (*.wav)|*.wav";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            var progress = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                progressBar1.Value = v;
            });

            var fileContent = await Task.Run(() => LongAudioProfiling.GetPredictionWithProgressReport(openFileDialog.FileName, progress));

            this.flowLayoutPanel1.Controls.Clear();
            foreach (string chord in fileContent)
            {
                var label = new Label
                {
                    Text = chord,
                    Width = 100,
                    Height = 50,
                    Font = new Font(this.Font.FontFamily, 15),
                    BorderStyle = BorderStyle.FixedSingle,
                };

                this.flowLayoutPanel1.Controls.Add(label);
            }
        }
    }
}
