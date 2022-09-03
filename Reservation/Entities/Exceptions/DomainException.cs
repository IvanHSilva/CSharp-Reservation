using System;

namespace Reservation.Entities.Exceptions {
    public class DomainException : ApplicationException {
        public DomainException(string message) : base(message) { }
    }
}
