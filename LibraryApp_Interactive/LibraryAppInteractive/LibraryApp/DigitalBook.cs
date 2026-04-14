using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class DigitalBook : Book
{
    private int maxBorrowDays;
    private float latePenaltyPerDay;
    public DigitalBook(string bookName, string bookISBN) : base(bookName, bookISBN)
    {
        
    }

    /// <summary>
    /// Based on python code, this is supposed to set maxborrowdays and latepenaltyperday but does not return anything.
    /// </summary>
    private void DetermineLoanLicense()
    {

    }

    public override LibraryAsset BorrowBook()
    {
                
    }

    public override (TimeSpan, int, decimal) ReturnBook(int libID)
    {

    }



}
