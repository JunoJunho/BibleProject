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

        private void BookTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                chapterTextBox.Focus();
            }
        }

        private void ChapterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                verseTextBox.Focus();
            }
        }

        private void VerseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string bookText = bookTextBox.Text;
                int chapter = -1;
                int verse = -1;

                try
                {
                    Int32.TryParse(chapterTextBox.Text, out chapter);
                    Int32.TryParse(verseTextBox.Text, out verse);
                }catch(Exception ex)
                {
                    Console.WriteLine("DEBUG: " + ex.Message); // Do nothing
                }

                // 올바르게 입력을 하였을 때만 검색 수행
                if(bookText.Length > 0 && chapter != -1 && verse != -1)
                {

                }

                // 모든 작업을 마친 후 초기화
                bookTextBox.Clear();
                chapterTextBox.Clear();
                verseTextBox.Clear();

            }
        }
    }
}
