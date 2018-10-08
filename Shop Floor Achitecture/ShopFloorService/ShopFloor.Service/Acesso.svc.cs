using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopFloor.Business.Entity;
using ShopFloor.Business.Modules.Acesso;

namespace ShopFloor.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service3" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service3.svc ou Service3.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Acesso : IAcesso
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        public Usuario ObterUsuario()
        {
            return usuarioBLL.ObterUsuario("Matheus"); 
        }
    }
}
