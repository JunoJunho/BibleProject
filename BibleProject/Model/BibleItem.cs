using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BibleProject.Model
{

    public class BibleItem
    {
        private int bookNum;
        private int chapter;
        private int verse;
        private string content;

        public int BookNum { get { return bookNum; } }
        public int Chapter { get { return chapter; } }
        public int Verse { get { return verse; } }
        public string Content { get { return content; } }

        public BibleItem(int bookNum, int chapter, int verse, string content)
        {
            this.bookNum = bookNum;
            this.chapter = chapter;
            this.verse = verse;
            this.content = content;
        }
    }
}
