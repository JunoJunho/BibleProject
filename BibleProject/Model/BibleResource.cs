using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Model
{
    public sealed class BibleResource
    {
        // Singleton Object
        private static volatile BibleResource _instance = null;
        private static readonly object _synclock = new object();

        // Attribute
        Dictionary<String, BIbleChapterItem> bible = null; 

        public static BibleResource Instance
        {
            get {
                if (_instance != null) return _instance;
                lock (_synclock)
                {
                    if(_instance == null)
                    {
                        _instance = new BibleResource();
                    }
                }
                return _instance;
            }
        }

        // Constructor
        private BibleResource()
        {
            this.bible = new Dictionary<string, BIbleChapterItem>();
        }
    }
}
