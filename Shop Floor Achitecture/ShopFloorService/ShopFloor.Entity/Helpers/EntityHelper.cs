using System.Runtime.Serialization;

namespace ShopFloor.Entity.Helpers
{
    public class EntityHelper
    {
        bool? inativo { get; set; }

        [DataMember]
        public bool? Inativo
        {
            get
            {
                if (inativo == null)
                    return false;
                return inativo;
            }
            set
            {
                inativo = value;
            }
        }
    }
}
