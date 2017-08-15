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
    /// BibleSearchView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BibleSearchView : UserControl
    {
        public BibleSearchView()
        {
            InitializeComponent();
        }

        private void bookTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                Console.WriteLine(bookTextBox.Text);
            }
        }

        private void chapterTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void verseTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
