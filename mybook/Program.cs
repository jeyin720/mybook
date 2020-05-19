using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Book
        {
            public String name;
            public String date;
            public String writer;
            public String publishing;
            public String publisher;
            public String firstEditer;
            public String plan;
            public String editer;
            public String designer;

        }
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                name = "PHP 프로그래밍 입문",
                date = "2013년 5월 20일",
                writer = "황재호",
                publishing = "김태헌",
                publisher = "한빛아카데미(주)",
                firstEditer = "김현용",
                plan = "김이화",
                editer = "김이화",
                designer = "여동일"
            } ;
            }

        }
    }
}
