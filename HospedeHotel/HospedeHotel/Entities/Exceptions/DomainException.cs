using System;


namespace HospedeHotel.Entities.Exceptions {
    class DomainException : ApplicationException {
        //constructor que recebe uma mensagem e repassa para o ApplicationException
        public DomainException(string message) : base(message){

        }
    }
}
