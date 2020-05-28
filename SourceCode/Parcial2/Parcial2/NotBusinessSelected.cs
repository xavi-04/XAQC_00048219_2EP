using System;

namespace Parcial2
{
    public class NotBusinessSelected : Exception
    {
        public NotBusinessSelected(string message) : base(message)
        {
        }
    }
}