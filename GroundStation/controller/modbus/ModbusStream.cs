using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Modbus.Device;
using Modbus.IO;
using Modbus;
using log4net;

namespace controller
{
    class MBStream : IStreamResource, IDisposable
    {
        SerialPort sp = null;
        public static readonly ILog log = LogManager.GetLogger(typeof(MBStream));

        public int InfiniteTimeout
        {
            get { return SerialPort.InfiniteTimeout; }
        }
        public int ReadTimeout { get; set; }
        public int WriteTimeout { get; set; }

        public MBStream()
        {

        }

        public MBStream(SerialPort sp)
        {
            this.sp = sp;
            this.ReadTimeout = sp.ReadTimeout;
            this.WriteTimeout = sp.WriteTimeout;
        }   

        void IStreamResource.DiscardInBuffer()
        {
            sp.DiscardInBuffer();
        }

        int IStreamResource.Read(byte[] buffer, int offset, int count) 
        {            
                                
            try
            {
            //if (!IsOpen())
            //    throw new InvalidOperationException("Port not open.");
            //if (buffer == null)
            //    throw new ArgumentNullException("buffer", "Argument buffer cannot be null.");
            //if (offset < 0)
            //    throw new ArgumentOutOfRangeException("offset", "Argument offset cannot be less than 0.");
            //if (count < 0)
            //    throw new ArgumentOutOfRangeException("count", "Argument count cannot be less than 0."); 

                return sp.Read(buffer, offset, count);
            }
            catch(Exception e)
            {
             log.Error(e.Message);   
             //  throw;
            }
            return -1;
            
        }

        void IStreamResource.Write(byte[] buffer, int offset, int count)
        {
            //throw new NotImplementedException();
            if (!IsOpen())
                throw new InvalidOperationException("Port not open.");
            if (buffer == null)
                throw new ArgumentNullException("buffer", "Argument buffer cannot be null.");
            if (offset < 0)
                throw new ArgumentOutOfRangeException("offset", "Argument offset must be greater than 0.");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count", "Argument count must be greater than 0.");
            if ((buffer.Length - offset) < count)
                throw new ArgumentException("Invalid buffer size.");
            
            sp.Write(buffer, offset,count);
        }

        void IDisposable.Dispose()
        {            
            throw new NotImplementedException();
        }
        
        public void Open()
        {          
            sp.Open();
        }

        public void Close()
        {
            sp.Close();

        }

        public bool IsOpen()
        {

            return sp.IsOpen;
           
        }
    }
}
