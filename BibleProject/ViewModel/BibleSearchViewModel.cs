using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.ViewModel
{
    class BibleSearchViewModel
    {
        private static BibleSearchViewModel _instance = new BibleSearchViewModel();
        public static BibleSearchViewModel Instance { get { return _instance; } }

        public void searchBible(string book, int chapter, int verse)
        {

        }
    }
}
