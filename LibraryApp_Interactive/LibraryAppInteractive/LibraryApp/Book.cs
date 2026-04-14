using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class Book
{
    #region FieldVars
    private string _bookName;
    private string _bookISBN;
    private List<string> _bookAuthorList;
    private List<LibraryAsset> _libAssetList;
    #endregion

    #region Constructors
    public Book(string bookName, string bookISBN)
    {
        _bookName = bookName;
        _bookISBN = bookISBN;
    }
    #endregion

    #region properties
    public string Name
    {
        get { return _bookName; }
        set { _bookName = value; }
    }

    public string ISBN
    {
        get { return _bookISBN; }
        set { _bookISBN = value; }
    }

    public List<string> Authors
    {
        get { return _bookAuthorList; }
        set { _bookAuthorList = value; }
    }

    public IEnumerable<LibraryAsset> Assets
    {
        get { return _libAssetList; }
        set { _libAssetList = value; }
    }
    #endregion

    #region methods
    public (bool,LibraryAsset) CheckAvailability()
    {

    }

    /// <summary>
    /// Made virtual so can be overridden in PaperBook and VirtualBook as needed
    /// </summary>
    /// <returns></returns>
    public virtual LibraryAsset BorrowBook()
    {

    }

    public (TimeSpan, int, decimal) ReturnBook(int libID)
    {

    }

    public LibraryAsset ReserveBook()
    {

    }

    private LibraryAsset findLibraryAsset(int libID)
    {

    }

    private LibraryAsset findNextAvailableAsset()
    {

    }
    #endregion


}
