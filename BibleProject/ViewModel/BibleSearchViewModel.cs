using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.ViewModel
{
    class BibleSearchViewModel
    {
        private static BibleSearchViewModel _instance = new BibleSearchViewModel();
        public static BibleSearchViewModel Instance { get { return _instance; } }

        /// <summary>
        /// 입력받은 책, 장, 절을 바탕으로 성경을 검색한다. 검색한 내용은 ControlViewModel로 값을 highlighting 한다
        /// </summary>
        /// <param name="book">책 e.g., 창, 출, 레</param>
        /// <param name="chapter">장 e.g., 1, 2, 3</param>
        /// <param name="verse">절 e.g., 1, 2, 3</param>
        public void SearchBible(string book, int chapter, int verse)
        {
            ObservableCollection<Model.BibleItem> BibleList = BibleViewModel.Instance.BibleList;
            var q = BibleList.IndexOf(
                BibleList.Where(p => p.BookNum.Equals(book) && p.Chapter == chapter && p.Verse == verse).FirstOrDefault()
                );
            if (q != -1)
            {// 장 절이 모두 맞아야함
                BibleControlViewModel controlViewModel = BibleControlViewModel.Instance;
                controlViewModel.SetFocusItem(q);
            }
        }
    }
}
