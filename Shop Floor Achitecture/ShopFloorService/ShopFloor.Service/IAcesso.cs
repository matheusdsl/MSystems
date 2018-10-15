using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopFloor.Entity;

namespace ShopFloor.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService3" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IAcesso
    {
        [OperationContract]
        Usuario ObterUsuario();
    }
}
