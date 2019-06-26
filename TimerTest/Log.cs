using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1
    {
        // Log
        private static readonly ILog Log = LogManager.GetLogger(typeof(Form1));
        private MemoryAppender appender;
        private Thread logWatcher;
        private bool logWatching = true;

        private void InitLog()
        {
            appender = new MemoryAppender();
            BasicConfigurator.Configure(appender);

            logWatcher = new Thread(LogerWatch);
            logWatcher.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            logWatching = false;
            // logWatcher.Join();
        }

        private void LogerWatch()
        {
            while (logWatching)
            {
                LoggingEvent[] events = appender.GetEvents();
                if (events != null && events.Length > 0)
                {

                    // if there are events, we clear them from the logger, 

                    // since we're done with them 
                    appender.Clear();
                    foreach (LoggingEvent ev in events)
                    {
                        //string line = ev.LoggerName + ": " + ev.RenderedMessage + "\r\n";
                        string line = ev.RenderedMessage + "\r\n";
                        AppendLog(line);
                    }
                }

                Thread.Sleep(500);
            }
        }

        private void AppendLog(string line)
        {
            if (textBox1.InvokeRequired)
            {
                BeginInvoke(new Action<string>(DoAppendLog), line);
            }
            else
            {
                DoAppendLog(line);
            }
        }

        private void DoAppendLog(string line)
        {
            if (textBox1.Lines.Length > 99)
            {
                var builder = new StringBuilder(textBox1.Text);

                // strip out a nice chunk from the beginning 
                builder.Remove(0, textBox1.Text.IndexOf('\r', 3000) + 2);
                builder.Append(line);
                textBox1.Clear();

                // using AppendText since that makes sure the TextBox stays 

                // scrolled at the bottom 
                textBox1.AppendText(builder.ToString());
            }
            else
            {
                textBox1.AppendText(line);
            }
        }
    }
}