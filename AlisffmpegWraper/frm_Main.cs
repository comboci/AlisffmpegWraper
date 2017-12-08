using AlisAlisffmpegWraper;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisffmpegWraper
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_FileAdress.Text = openFileDialog1.FileName;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteAsync();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        Process process = null;
        void ExecuteAsync()
        {
            try
            {
                string result = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                process = new Process();

                process.StartInfo.FileName = "ffmpeg";
                if (rbtn_mp4.Checked)
                {
                   
                    process.StartInfo.Arguments = @"-i  " + ((char)34) + openFileDialog1.FileName + ((char)34) + " ";
                    if (chk_Override.Checked)
                        process.StartInfo.Arguments += " -y ";
                    if (rbtn_ac_Copy.Checked)
                        process.StartInfo.Arguments += " -acodec copy ";
                    if (rbtn_vc_copy.Checked)
                        process.StartInfo.Arguments += " -vcodec copy ";
                    if (rbtn_vc_libx264.Checked)
                        process.StartInfo.Arguments += " -vcodec libx264 ";
                    if (rbtn_vs_640480.Checked)
                        process.StartInfo.Arguments += " -s 640x480 ";
                    if (rbtn_vs_800600.Checked)
                        process.StartInfo.Arguments += " -s 800x600 ";
                    if (rbtn_vs_960720.Checked)
                        process.StartInfo.Arguments += " -s 960x720 ";
                    process.StartInfo.Arguments += ((char)34) + Path.GetDirectoryName(openFileDialog1.FileName) + "\\" + result + ".mp4" + ((char)34);

                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;

                    process.Start();
                }
            }
            catch
            {
                if (process != null) process.Dispose();
            }
        }

        void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            //richTextBox1.Text+=("Input line: {0} ({1:m:s:fff})", lineCount++,
            //    DateTime.Now);
            //Console.WriteLine(e.Data);
            //Console.WriteLine();
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            //richTextBox1.Text += e.Data;
            Console.WriteLine("Output Data Received.");
        }

        void process_Exited(object sender, EventArgs e)
        {
            process.Dispose();
            Console.WriteLine("Bye bye!");
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            process.Suspend();
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            process.Resume();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public static class ProcessExtensions
    {
        #region Methods

        public static void Suspend(this Process process)
        {
            Action<ProcessThread> suspend = pt =>
            {
                var threadHandle = NativeMethods.OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pt.Id);

                if (threadHandle != IntPtr.Zero)
                {
                    try
                    {
                        NativeMethods.SuspendThread(threadHandle);
                    }
                    finally
                    {
                        NativeMethods.CloseHandle(threadHandle);
                    }
                };
            };

            var threads = process.Threads.ToArray<ProcessThread>();

            if (threads.Length > 1)
            {
                Parallel.ForEach(threads, new ParallelOptions { MaxDegreeOfParallelism = threads.Length }, pt =>
                {
                    suspend(pt);
                });
            }
            else
            {
                suspend(threads[0]);
            }
        }

        public static void Resume(this Process process)
        {
            Action<ProcessThread> resume = pt =>
            {
                var threadHandle = NativeMethods.OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pt.Id);

                if (threadHandle != IntPtr.Zero)
                {
                    try
                    {
                        NativeMethods.ResumeThread(threadHandle);
                    }
                    finally
                    {
                        NativeMethods.CloseHandle(threadHandle);
                    }
                }
            };

            var threads = process.Threads.ToArray<ProcessThread>();

            if (threads.Length > 1)
            {
                Parallel.ForEach(threads, new ParallelOptions { MaxDegreeOfParallelism = threads.Length }, pt =>
                {
                    resume(pt);
                });
            }
            else
            {
                resume(threads[0]);
            }
        }

        #endregion

        #region Interop

        static class NativeMethods
        {
            [DllImport("kernel32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool CloseHandle(IntPtr hObject);

            [DllImport("kernel32.dll")]
            public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

            [DllImport("kernel32.dll")]
            public static extern uint SuspendThread(IntPtr hThread);

            [DllImport("kernel32.dll")]
            public static extern uint ResumeThread(IntPtr hThread);
        }

        [Flags]
        enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        #endregion
    }
}

