using ShopFloor.Entity;
using ShopFloor.Business.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopFloor.Business.Modules.Acesso
{
    public class UsuarioBLL : Helper<Usuario>
    {
        public Usuario ObterUsuario(string nome)
        {
            return new Usuario { Nome = nome, Inativo = false };
        }
    }
}
