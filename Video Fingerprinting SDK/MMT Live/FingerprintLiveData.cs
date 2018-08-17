using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.VideoFingerPrinting;

namespace VisioForge_MMT
{
    public class FingerprintLiveData : IDisposable
    {
        public VFPSearchData Data;

        public DateTime StartTime { get; private set; }

        public FingerprintLiveData(int duration, DateTime startTime)
        {
            Data = new VFPSearchData(duration);
            StartTime = startTime;
        }

        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        protected virtual void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();

            if (disposing)
            {
                Data?.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~FingerprintLiveData()
        {
            Dispose(false);
        }
    }
}
