using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class LibraryAsset
{
    #region FieldVars
    //Holds the object of the book
    private Book _book;

    //Holds the ID of the book determined by the library
    private int _libID;

    //Holds the status of the book (ie available, not available, loaned etc)
    private AssetStatus _status;

    //How long the book can be loaned out for
    private LoanPeriod _loanPeriod;
    #endregion

    #region Constructors
    public LibraryAsset(int libID, Book book)
    {
        _libID = libID;
        _book = book;
    }
    #endregion

    #region properties

    public int LibID
    {
        get { return _libID; }
        set { _libID = value; }
    }

    public AssetStatus Status
    {
        get { return _status; }
        set { _status = value;  }
    }

    public LoanPeriod Loan
    {
        get { return _loanPeriod; }
        set { _loanPeriod = value; }
    }

    public bool IsAvailable
    {
        get { return _status == AssetStatus.Available; }
    }
    #endregion
}