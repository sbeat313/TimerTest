using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1 : Form
    {
        private int LoopCount;
        private int CurrentCount = 0;
        private int Interval;
        private Stopwatch MyStopwatch = new Stopwatch();
        private System.Timers.Timer MyTimer = new System.Timers.Timer();

        // 高精 Timer
        [DllImport("winmm.dll")]
        private static extern int timeGetDevCaps(ref TimerCaps caps, int sizeOfTimerCaps);

        [DllImport("winmm.dll")]
        private static extern int timeSetEvent(int delay, int resolution, TimeProc proc, int user, int mode);

        [DllImport("winmm.dll")]
        private static extern int timeKillEvent(int id);

        delegate void TimeProc(int id, int msg, int user, int param1, int param2);

        public Form1()
        {
            InitLog();
            InitializeComponent();
            MyTimer.Elapsed += MyTimer_OnTick;
        }

        #region Timer 1
        private void BtnTimer1_Click(object sender, EventArgs e)
        {
            LoopCount = Convert.ToInt32(TbxLoopCount.Text);
            Interval = Convert.ToInt32(TbxInterval.Text);

            MyTimer.Interval = Interval;
            MyTimer.Enabled = true;
        }

        private void MyTimer_OnTick(object sender, EventArgs e)
        {
            if (CurrentCount < LoopCount)
            {
                MyStopwatch.Start();
                CurrentCount++;
            }
            else
            {
                MyStopwatch.Stop();
                MyTimer.Enabled = false;
                Log.InfoFormat("一般Timer - 耗時 : {0}", MyStopwatch.ElapsedMilliseconds.ToString());
                Reset();
            }
        }
        #endregion

        #region Timer 2
        private void BtnTimer2_Click(object sender, EventArgs e)
        {
            LoopCount = Convert.ToInt32(TbxLoopCount.Text);
            Interval = Convert.ToInt32(TbxInterval.Text);

            TimerCaps caps = new TimerCaps();
            // provides min and max period 
            timeGetDevCaps(ref caps, Marshal.SizeOf(caps));
            int period = Interval; // 可能不是調這個
            int resolution = 1;
            int mode = 1; // 0 for periodic, 1 for single event
            timeSetEvent(period, resolution, new TimeProc(TimerCallback), 0, mode);
        }

        void TimerCallback(int id, int msg, int user, int param1, int param2)
        {
            if (CurrentCount < LoopCount)
            {
                MyStopwatch.Start();
                CurrentCount++;
            }
            else
            {
                MyStopwatch.Stop();
                timeKillEvent(id);
                Log.InfoFormat("高精Timer - 耗時 : {0}", MyStopwatch.ElapsedMilliseconds.ToString());

                Reset();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TimerCaps
        {
            public int periodMin;
            public int periodMax;
        }
        #endregion

        private void Reset()
        {
            MyStopwatch.Reset();
            CurrentCount = 0;
        }
    }
} // Ref https://stackoverflow.com/questions/13521521/system-timers-timer-only-gives-maximum-64-frames-per-second
// Ref https://docs.microsoft.com/zh-tw/windows/desktop/Multimedia/about-multimedia-timers