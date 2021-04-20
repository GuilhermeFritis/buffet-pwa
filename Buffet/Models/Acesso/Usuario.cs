using System;
using Microsoft.AspNetCore.Identity;

namespace Buffet.Models.Acesso
{
    public class Usuario : IdentityUser<Guid>
    {
        public string Nome { get; set; }

        public Usuario()
        {
        }
    }
}