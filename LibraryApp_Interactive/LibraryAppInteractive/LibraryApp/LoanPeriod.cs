using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public struct LoanPeriod
{
    #region FieldVars
    //Date the book was borrowed
    private DateTime _borrowedOn;

    //Date the book was returned
    private DateTime _returnedOn;

    //Date the book is due back
    private DateTime _dueDate;
    #endregion

    #region Constructors
    public LoanPeriod(DateTime borrowedOn, DateTime returnedOn)
    {
        _borrowedOn = borrowedOn;
        _returnedOn = returnedOn;
    }
    #endregion

    #region Properties
    public DateTime BorrowedOn
    {
        get { return _borrowedOn; }
        set { _borrowedOn = value; }
    }

    public DateTime ReturnedOn
    {
        get { return _returnedOn; }
        set { _returnedOn = value; }
    }

    public DateTime DueDate
    {
        get { return _dueDate; }
        set { _dueDate = value; }
    }

    public TimeSpan LoanDuration
    {
        get { return _dueDate - BorrowedOn; }
    }

    public TimeSpan LatePeriod
    {
        get { return _returnedOn - _dueDate; }
    }

    #endregion

}
