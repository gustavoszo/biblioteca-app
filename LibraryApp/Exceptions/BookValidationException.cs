using System;

namespace LibraryApp.Exceptions;

internal class BookValidationException : Exception
{
    public BookValidationException(string message) : base(message) { }
}
