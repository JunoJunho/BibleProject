using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BibleProject.View
{
    /// <summary>
    /// BibleControlView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BibleControlView : UserControl
    {

        private static BibleControlView _instance = new BibleControlView();
        public static BibleControlView Instance { get { return _instance; } }

        public BibleControlView()
        {
            InitializeComponent();
        }

        public void SelectBibleItem(int index)
        {
            ListViewItem item = BibleListView.ItemContainerGenerator.ContainerFromIndex(index) as ListViewItem;
            if(item != null)
            {
                BibleListView.ScrollIntoView(item);
                item.IsSelected = true;
                Keyboard.Focus(item);
            }
        }
    }
}
