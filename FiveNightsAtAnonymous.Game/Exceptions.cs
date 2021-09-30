using System;

namespace TerraCore.Game
{
    public class InvalidModException : Exception { public InvalidModException(string message) : base(message) { } }
    public class ContentException : Exception { public ContentException(string message) : base(message) { } }
}