using System;
using System.Collections.Generic;
using HospedeHotel.Entities.Exceptions;

namespace HospedeHotel.Entities {
    class Reservation {
        //Propriedades (Properties)
        public int roomNumber { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }

        //Construtores (Constructors)
        public Reservation() {

        }
        public Reservation(int roomnumber,DateTime checkin,DateTime checkout) {
            if(checkout <= checkin) {

                throw new DomainException("A data do check-out não pode ser menor ou igual ao check-in");

            }
            roomNumber = roomnumber;
            checkIn = checkin;
            checkOut = checkout;
        }

        //Métodos (Methods)
        public int Duration() {     
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin,DateTime checkout) {
            DateTime now = DateTime.Now;
            if(checkin < now || checkout < now) {
                //enviando uma excessão para classe DomainException
                throw new DomainException("As datas devem ser futuras!");
            }
            if(checkout <= checkin) {
                throw new DomainException("A data atualizada do check-out não pode ser menor ou igual ao check-in");
            }
            checkIn = checkin;
            checkOut = checkout;
        }
        public override string ToString() {
            return "Quarto  "
                       + roomNumber +
                       "\nCheck-in: "
                       + checkIn.ToString("dd/mm/yyyy") +
                       "\nCheck-out: "
                       + checkOut.ToString("dd/mm/yyyy") +
                       "\nNoites que o hospede ficou: "
                       + Duration();
        }
    }
}
