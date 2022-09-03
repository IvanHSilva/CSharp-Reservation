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
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now) {
                Console.WriteLine("Erro: Checkin e Checkout devem ser datas futuras!");
                return;
            } else if (checkout <= checkin) {
                Console.WriteLine("Erro: Chekout deve sair maior que Checkin!");
                return;
            }
            reservation.UpdateDates(checkin, checkout);
            Console.WriteLine(reservation);
            Console.WriteLine();
        }
    }
}
