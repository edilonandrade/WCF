using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Pessoa> CriarListaPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>() {
                new Pessoa(){Nome="Claudia", SobreNome="Borges", Idade = 30},
                new Pessoa(){Nome="Nelson", SobreNome="Borges", Idade = 30},
                new Pessoa(){Nome="João", SobreNome="Ferreira", Idade = 10},
                new Pessoa(){Nome="Pedro", SobreNome="Henrique", Idade = 8}
            };

            return listaPessoas;
        }
        public List<Pessoa> BuscarPessoas()
        {
            return CriarListaPessoas();
        }

        #region IService1 Members
        public Pessoa BuscarPessoasPorIdade(int idade)
        {
            return CriarListaPessoas().Find(pResult => pResult.Idade == idade);
        }

        #endregion

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
