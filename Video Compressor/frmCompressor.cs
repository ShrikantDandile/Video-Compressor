using FFmpeg.NET;
using FFmpeg.NET.Events;
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

namespace Video_Compressor
{
   public partial class Compressor : Form
   {
      public Compressor()
      {
         InitializeComponent();
         if (!Directory.Exists(dicrectoryPath))
         {
            Directory.CreateDirectory(dicrectoryPath);
         }
      }

      readonly static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      readonly static string outputFolderName = "Compressor\\Output\\";
      readonly static string dicrectoryPath = Path.Combine(documentsPath, outputFolderName);
      private void Compressor_Load(object sender, EventArgs e)
      {

      }

      private void btnBrowse_Click(object sender, EventArgs e)
      {
         OpenFileDialog openFileDialog1 = new OpenFileDialog
         {
            InitialDirectory = Path.Combine(documentsPath, @"\Compressor\Input"),
            Title = "Browse Video Files",

            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "mp4",
            Filter = "mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*",
            FilterIndex = 2,
            RestoreDirectory = true,

            ReadOnlyChecked = true,
            ShowReadOnly = true
         };

         if (openFileDialog1.ShowDialog() == DialogResult.OK)
         {
            textBox1.Text = openFileDialog1.FileName;
         }
      }

      private void btnCompress_Click(object sender, EventArgs e)
      {
         var inputFile = textBox1.Text;
         if (string.IsNullOrEmpty(textBox1.Text))
         {
            textBox3.Text = "Please Browse Video!";
            return;
         }
         var outputFile = dicrectoryPath + Guid.NewGuid().ToString() + ".mp4";
         //  var mediaInfo = FFProbe.Analyse(inputFile);
         try
         {
            Task.Run(() => StartConverting(inputFile, outputFile));
         }
         catch (Exception ex)
         {
            textBox3.Text = ex.Message;
         }

      }
      public async Task StartConverting(string inputFileLocation, string outputFileLocation)
      {
         var inputFile = new MediaFile(inputFileLocation);
         var outputFile = new MediaFile(outputFileLocation);
         string directory = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg.exe";
         var ffmpeg = new Engine(directory);
         ffmpeg.Progress += OnProgress;
         ffmpeg.Data += OnData;
         ffmpeg.Error += OnError;
         ffmpeg.Complete += OnComplete;
         await ffmpeg.ConvertAsync(inputFile, outputFile);
      }
      delegate void SetTextCallback(string text);
      delegate void SetDataTextCallback(string text);
      delegate void SetCompetedTextCallback(string text);

      private void SetText(string text)
      {
         // InvokeRequired required compares the thread ID of the
         // calling thread to the thread ID of the creating thread.
         // If these threads are different, it returns true.
         if (this.textBox3.InvokeRequired)
         {
            SetTextCallback d = new SetTextCallback(SetText);
            this.Invoke(d, new object[] { text });
         }
         else
         {
            this.textBox3.Text = text + Environment.NewLine;
         }
      }
      private void SetDataText(string text)
      {
         // InvokeRequired required compares the thread ID of the
         // calling thread to the thread ID of the creating thread.
         // If these threads are different, it returns true.
         if (this.textBox4.InvokeRequired)
         {
            SetDataTextCallback d = new SetDataTextCallback(SetDataText);
            this.Invoke(d, new object[] { text });
         }
         else
         {
            this.textBox4.Text = text + Environment.NewLine;
         }
      }


      private void OnProgress(object sender, ConversionProgressEventArgs e)
      {

         var finalString = string.Format("[{0} => {1}]"
              + Environment.NewLine + "Bitrate: {2}"
              + Environment.NewLine + "Fps: {3}"
              + Environment.NewLine + "Frame: {4}"
              + Environment.NewLine + "ProcessedDuration: {5}"
              + Environment.NewLine + "Size: {6} kb"
              + Environment.NewLine + "TotalDuration: {7} "
              + Environment.NewLine + "Percentage: {8}%",
              e.Input.FileInfo.Name,
              e.Output.FileInfo.Name,
              e.Bitrate,
              e.Fps,
              e.Frame,
              e.ProcessedDuration,
              e.SizeKb,
               e.TotalDuration,
               Math.Round((((double)e.ProcessedDuration.Ticks / (double)e.TotalDuration.Ticks)*100),2,MidpointRounding.ToZero)
              );
         SetText(finalString);
      }

      private void OnData(object sender, ConversionDataEventArgs e)
      {
         SetDataText(string.Format("[{0} => {1}]: {2}", e.Input.FileInfo.Name, e.Output.FileInfo.Name, e.Data));
      }

      private void OnComplete(object sender, ConversionCompleteEventArgs e)
      {
         SetCompetedText(string.Format("Completed conversion from {0} to {1}", e.Input.FileInfo.FullName, e.Output.FileInfo.FullName));
      }

      private void SetCompetedText(string text)
      {
         // InvokeRequired required compares the thread ID of the
         // calling thread to the thread ID of the creating thread.
         // If these threads are different, it returns true.
         if (this.textBox5.InvokeRequired)
         {
            SetCompetedTextCallback d = new SetCompetedTextCallback(SetCompetedText);
            this.Invoke(d, new object[] { text });
         }
         else
         {
            this.textBox5.Text = text + Environment.NewLine;
         }
      }

      private void OnError(object sender, ConversionErrorEventArgs e)
      {
         SetCompetedText(string.Format("[{0} => {1}]: Error: {2}\n{3}", e.Input.FileInfo.Name, e.Output.FileInfo.Name, e.Exception.ExitCode, e.Exception.InnerException));
      }

      private void btnBrowseOutputPath_Click(object sender, EventArgs e)
      {
         System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
         {
            FileName = dicrectoryPath,
            UseShellExecute = true,
            Verb = "open"
         });
      }
   }
}
