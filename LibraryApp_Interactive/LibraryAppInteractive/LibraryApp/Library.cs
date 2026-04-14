using Windows.Security.Cryptography.Core;

namespace LibraryAppInteractive;

/// <summary>
/// Defines the Library class used to manage the library books and assets.
///
/// NOTE: A single object/instance of this class (called a "singleton") is created and shared automatically
/// with the two pages in the application through the process of Dependency Injection handled and configured
/// in MauiProgram class.  
/// </summary>
public class Library
{
    #region fieldvars
    private List<Book>;
    private int _libIDGeneratorSeed;
    const int DEFAULT_LIBID_START = 100;
    #endregion
   
    #region constructors
    public Library()
    {

    }
    #endregion

    #region methods
    private void CreateDefaultBooks()
    {

    }

    private int DetermineLibID()
    {

    }

    public Book RegisterBook(string Name, string bookISBN, string[] authors, BookType booktype, int nCopies)
    {

    }

    public Book FindBookByName(string bookName)
    {

    }

    public Book FindBookByISBN(string bookISBN)
    {

    }

    #endregion


}