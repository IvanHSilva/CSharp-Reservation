using System;

namespace Reservation.Entities {
    public class ReservationRoom {
        // Attributes
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        // Constructors
        public ReservationRoom() { }

        public ReservationRoom(int roomNumber, DateTime checkin, DateTime checkout) {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        // Methods
        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout) {
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString() {
            return $"Quarto {RoomNumber}, CheckIn em {CheckIn.ToString("dd/MM/yyyy")}, " +
                $"CheckOut em {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} noites";
        }
    }
}
