using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ShopFloor.Entity
{
    [DataContract]
    public class CoreModulo : Helpers.EntityHelper
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public int? Id_ModuloPai { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Descricao { get; set; }


    }
}
