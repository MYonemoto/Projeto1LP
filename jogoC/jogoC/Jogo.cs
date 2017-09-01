using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Jogo
    {
        Dictionary<Sala, List<Opcao>> map;

        public Jogo()
        {
            this.map =  new Dictionary<Sala, List<Opcao>>();
        }


        public Dictionary<Sala, List<Opcao>> Map
        {
            get { return map; }
            set { map = value; }
        }



    }
}
