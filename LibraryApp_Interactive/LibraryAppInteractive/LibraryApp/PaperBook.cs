using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class PaperBook : Book
{
    //Immeditely sets max borrow day of every paperback book to 30
    private const int MAX_BORROW_DAYS = 30;

    //And sets the late penalty per day to 25 cents
    private const float LATE_PENALTY_PER_DAY = 0.25f;

    public PaperBook(string bookName, string bookISBN) : base(bookName, bookISBN)
    {

    }

    public override LibraryAsset BorrowBook()
    {
        //Does same as book but overrides to add new maximum borrow days and ser new due date.
    }

    public override (TimeSpan, int, decimal) ReturnBook(int libID)
    {
        //returns the borrowed book back to the library, throwing proper errors if the book is incorrect.

        //Returns all relevant details
    }

}
