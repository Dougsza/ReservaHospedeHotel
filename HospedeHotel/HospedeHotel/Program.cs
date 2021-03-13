using System;
using HospedeHotel.Entities;
using HospedeHotel.Entities.Exceptions;

namespace HospedeHotel {
    class Program {
        static void Main(string[] args) {
            //Inserindo dados
            try { 
            Console.WriteLine("Digite o número do quarto que irá hosperar!");
            int rnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data do check-in (DD/AA/AA)");
            DateTime dateIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data do check-out");
            DateTime dateOut = DateTime.Parse(Console.ReadLine());

              
                Reservation reservation = new Reservation(rnumber,dateIn,dateOut);
                Console.WriteLine(reservation);
                Console.WriteLine("");
            }
            catch(DomainException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
