using ShopFloor.Entity.Helpers;
using System.Runtime.Serialization;


namespace ShopFloor.Entity
{
    [DataContract]
    public class Usuario : EntityHelper
    {
        [DataMember]
        public string Nome { get; set; }
    }
}
