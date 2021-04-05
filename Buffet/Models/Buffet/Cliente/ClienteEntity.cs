using System;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public ClienteEntity()
        {
            Id = new Guid();
        }
    }
}