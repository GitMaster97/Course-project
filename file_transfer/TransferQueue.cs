using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_transfer
{
    public enum QueueType : byte
    {
        Download,
        Upload
    }

    class TransferQueue
    {
        private const int FILE_BUFFER_SIZE = 8175;
        private static byte[] file_buffer = new byte[FILE_BUFFER_SIZE];

        private ManualResetEvent pauseEvent;

        public int ID;
        public int Progress, LastProgress;

        public long Transferred;
        public long Index;
        public long Length;

        public bool Running;
        public bool Paused;

        public string Filename;

        public QueueType Type;

        public object Client;
        public Thread Thread;
        public FileStream FS;

        private TransferQueue()
        {
            pauseEvent = new ManualResetEvent(true);
            Running = true;
        }

        public void Start()
        {
            Running = true;
            Thread.Start(this);
        }

        public void Stop()
        {
            Running = false;
        }

        public void Pause()
        {
            if (!Paused)
            {
                pauseEvent.Reset();
            }
            else
            {
                pauseEvent.Set();
            }

            Paused = !Paused;
        }

        public void Close()
        {
            Running = false;
            FS.Close();
            pauseEvent.Dispose();

            Client = null;
        }

        public void Write(byte[] bytes, long index)
        {
            lock (this)
            {
                FS.Position = index;
                FS.Write(bytes, 0, bytes.Length);
                Transferred += bytes.Length;
            }
        }

        private static void transferProc(object o)
        {
            TransferQueue queue = (TransferQueue)o;
        }
    }
}
