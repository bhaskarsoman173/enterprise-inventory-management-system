namespace EIMS.Application.Exceptions;

public sealed class ProductAlreadyExistsException(string message) : Exception(message) { }
