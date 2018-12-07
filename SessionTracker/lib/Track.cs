using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionTracker.lib
{
    [Serializable]
    public class Track
    {
        public TimeSpan Duration { get { return calc(); } }
        public DateTime start { get; set; }
        public DateTime stop { get; set; }
        public String description { get; set; }

        public Track()
        {
            this.start = DateTime.Now;
            this.stop = this.start;
        }

        TimeSpan calc() {
            return stop - start;
        }

        
    }
}
