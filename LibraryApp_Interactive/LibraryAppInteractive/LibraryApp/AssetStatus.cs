using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

/// <summary>
/// Assigns a number starting at 1 to each of the possible statuses a book can be
/// </summary>
public enum AssetStatus
{
    NotAvailable,
    Available,
    Loaned,
    Reserved
}
