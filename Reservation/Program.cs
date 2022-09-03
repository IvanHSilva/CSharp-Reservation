using System;
using Reservation.Entities;

namespace Reservation {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quarto nº: ");
            int room = int.Parse(Console.ReadLine());
            Console.Write("Checkin (Entrada): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Checkout (Saída): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());
            if (checkout <= checkin) {
                Console.WriteLine("Erro: Chekout deve sair maior que Checkin!");
                return;
            }
            ReservationRoom reservation = new ReservationRoom(room, checkin, checkout);
            Console.WriteLine(reservation);
            Console.WriteLine("");

            Console.WriteLine("Dados atualizados:");
            Console.Write("Checkin (Entrada): ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Checkout (Saída): ");
            checkout = DateTime.Parse(Console.ReadLine());
           
            string error = reservation.UpdateDates(checkin, checkout);
            if (error != null) {
                Console.WriteLine(error);
                return;
            }
            Console.WriteLine(reservation);
            Console.WriteLine();
        }
    }
}
