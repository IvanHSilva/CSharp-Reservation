using Reservation.Entities.Exceptions;
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
            if (checkout <= checkin) throw new DomainException("Erro: Chekout deve sair maior que Checkin!");
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
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now) {
                throw new DomainException("Erro: Checkin e Checkout devem ser datas futuras!");
            } else if (checkout <= checkin) {
                throw new DomainException("Erro: Chekout deve sair maior que Checkin!");
            }
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString() {
            return $"Quarto {RoomNumber}, CheckIn em {CheckIn.ToString("dd/MM/yyyy")}, " +
                $"CheckOut em {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} noites";
        }
    }
}
