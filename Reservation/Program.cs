using Reservation.Entities;
using Reservation.Entities.Exceptions;
using System;

namespace Reservation {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Quarto nº: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Checkin (Entrada): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout (Saída): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());
                ReservationRoom reservation = new ReservationRoom(room, checkin, checkout);
                Console.WriteLine(reservation);
                Console.WriteLine("");

                Console.WriteLine("Dados atualizados:");
                Console.Write("Checkin (Entrada): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout (Saída): ");
                checkout = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(reservation);
                Console.WriteLine();
            } catch (DomainException e) {
                Console.WriteLine(e.Message);
            } catch (FormatException e) {
                Console.WriteLine($"Erro: {e.Message}");
            } catch (Exception e) {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
