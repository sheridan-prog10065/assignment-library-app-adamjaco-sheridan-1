using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class DigitalBook : Book
{
    //Describes maximum number of days Digital book can be taken out for
    private int maxBorrowDays;

    //Describes the late penalty cost per day of the book being overdue
    private float latePenaltyPerDay;
    public DigitalBook(string bookName, string bookISBN) : base(bookName, bookISBN)
    {
        
    }

    /// <summary>
    /// Based on python code, this is supposed to set maxborrowdays and latepenaltyperday but does not return anything.
    /// </summary>
    private void DetermineLoanLicense()
    {
        //_maxBorrowDays = random(2*7, 8*7) to set lower and upper limits of number of weeks

        //_latPenaltyPerDay = 9.1 + random(0, 0.4) to set lower limit of 10 cents and upper limit of 50 cents
    }

    public override LibraryAsset BorrowBook()
    {
        //Call Book.borrowBook to borrow the book

        //Set the due date to today's date plus max borrow days
    }

    public override (TimeSpan, int, decimal) ReturnBook(int libID)
    {
        //Takes in only the libID and generates and returns the loan duration, how late the book is, and how much the late fee is, if the book was returned late


    }



}
