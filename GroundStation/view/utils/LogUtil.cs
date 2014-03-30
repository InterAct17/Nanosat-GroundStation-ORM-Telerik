using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Appender;
using log4net;
using log4net.Config;
using log4net.Core;
using System.Windows.Forms;
using System.Drawing;

namespace GroundStation.view
{    
    class LogEventAppender : AppenderSkeleton
    {
        //Объект, который хранит информацию о контроле (окошко с логом)
        private RichTextBox formEvent;
        public bool isDebugMode = false;
        public bool isThreadStart = false;

        //свой конструктор, здесь вы можете сконфигурировать аппендер как вам угодно
        public LogEventAppender(RichTextBox formEvent_)
        {
            this.formEvent = formEvent_;
        }

        private void UpdateControl(log4net.Core.LoggingEvent loggingEvent)
        {
            if (formEvent.Lines.Count() > 200)
                formEvent.Clear();

            switch (loggingEvent.Level.ToString())
            {
                case "INFO": formEvent.SelectionColor = Color.Green; break;
                case "ERROR": formEvent.SelectionColor = Color.Red; break;
                default: formEvent.SelectionColor = Color.Blue; break;
            }            
            formEvent.AppendText("\n" + loggingEvent.TimeStamp.TimeOfDay.ToString(@"hh\:mm\:ss\.fff") + " [" + loggingEvent.Level + "] " + loggingEvent.MessageObject);

            formEvent.SelectionStart = formEvent.Text.Length;
            formEvent.ScrollToCaret();
        }

        private delegate void UpdateControlDelegate(log4net.Core.LoggingEvent loggingEvent);

        protected override void Append(LoggingEvent loggingEvent)
        {
            if ((!isDebugMode && !loggingEvent.Level.Equals(Level.Info)) || (!isDebugMode && isThreadStart)) return;
            
            // prevent exceptions 
            if (formEvent != null)
            {
                // make thread safe 
                if (formEvent.InvokeRequired)
                {
                    formEvent.Invoke(new UpdateControlDelegate(UpdateControl), new object[] { loggingEvent });
                }
                else
                {
                    UpdateControl(loggingEvent);
                }
            }
        }
    }

}

