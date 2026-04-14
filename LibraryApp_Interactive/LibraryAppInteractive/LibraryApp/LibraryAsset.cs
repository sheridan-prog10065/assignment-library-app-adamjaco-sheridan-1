using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class LibraryAsset
{
    #region FieldVars
    private Book _book;
    private int _libID;
    private AssetStatus _status;
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
        get { return _status == 1; }
        set { _status = value; }
    }
    #endregion
}