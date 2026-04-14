using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class PaperBook : Book
{
    private const int MAX_BORROW_DAYS = 30;
    private const float LATE_PENALTY_PER_DAY = 0.25f;

    public PaperBook(string bookName, string bookISBN) : base(bookName, bookISBN)
    {

    }

    public override LibraryAsset BorrowBook()
    {

    }

    public override (TimeSpan, int, decimal) ReturnBook(int libID)
    {

    }

}
