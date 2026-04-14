using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class Book
{
    #region FieldVars
    //Name of the book
    private string _bookName;

    //ISBN number of book
    private string _bookISBN;

    //List of all authors that wrote book
    private List<string> _bookAuthorList;

    //List of all copies of the book
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
        set { _libAssetList = (List<LibraryAsset>)value; }
    }
    #endregion

    #region methods
    public (bool,LibraryAsset) CheckAvailability()
    {
        //Get the libraryAsset

        //Get the Status of the book grabbed from LibraryAsset

        //If it is available, return true with the library asset.
    }

    /// <summary>
    /// Made virtual so can be overridden in PaperBook and VirtualBook as needed
    /// </summary>
    /// <returns></returns>
    public virtual LibraryAsset BorrowBook()
    {
        //Check to see if book is available

        //If available, mark the book as unavailable by setting borrowedDate to today, and status as loaned, as well as a default due date (which is changed in derived classes)


    }

    public (TimeSpan, int, decimal) ReturnBook(int libID)
    {
        //Find the book that was loaned

        //Check to see how long the book was loaned for

        //Check the number of days late

        //Check the late fees that apply if book was late
    }

    public LibraryAsset ReserveBook()
    {
        //Reserves a book so that it can be borrowed once it has been returned by checking closest due date to current date

        //Setting status of that book to reserve so the person can take it out once returned
    }

    private LibraryAsset findLibraryAsset(int libID)
    {
        //Goes through list of all assets and returns said asset if foundm if not then null
    }

    private LibraryAsset findNextAvailableAsset()
    {
        //Checks to see if any of the assets are available, and if it is then the asset is returned

        //If not available, stores each asset and compares each of the due dates to get the once being returned soonest

        //Returns next available book/book to be reserved
    }
    #endregion


}
