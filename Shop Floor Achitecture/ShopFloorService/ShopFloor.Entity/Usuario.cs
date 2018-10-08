using System;
using System.Runtime.Serialization;

namespace ShopFloor.Entity
{
    [DataContract]
    public class Usuario : Entity
    {
        [DataMember]
        public string Nome { get; set; }
    }
}
