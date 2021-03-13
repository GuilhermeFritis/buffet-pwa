using System;
using System.Collections.Generic;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        public List<ClienteEntity> ObterClientes()
        {
            var listaDeClientes = new List<ClienteEntity>();
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 1,
                Nome = "Leonardo",
                DataDeNascimento = new DateTime(1986, 12, 1)
            });
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 2,
                Nome = "José",
                DataDeNascimento = new DateTime(1977, 09,  25)
            });

            return listaDeClientes;
        }
    }
}