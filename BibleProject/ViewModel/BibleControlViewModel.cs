using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BibleProject.ViewModel
{
    class BibleControlViewModel
    {
        private static BibleControlViewModel _instance = new BibleControlViewModel();
        public static BibleControlViewModel Instance { get { return _instance; } }

        public void SetFocusItem(int index)
        {
            View.BibleControlView.Instance.SelectBibleItem(index);
        }

    }
}
