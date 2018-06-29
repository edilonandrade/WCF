using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WCFService
{
    //https://nelsonborges.wordpress.com/2009/07/26/10-passos-para-criar-um-servico-wcf-e-publicar-no-iis-1%C2%B0-parte/
    [DataContract]
    public class Pessoa
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string SobreNome { get; set; }
        [DataMember]
        public int Idade { get; set; }
    }
}
