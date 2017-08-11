using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Model
{
    public sealed class BibleResource
    {
        static readonly BibleResource _instance = new BibleResource();

        public static BibleResource Instance
        {
            get { return _instance};
        }

        // Constructor
        private BibleResource()
        {

        }
    }
}
