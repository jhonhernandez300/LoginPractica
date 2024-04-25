using LoginPractica.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractica
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUsuarios Usuarios { get; set; }

        public UnitOfWork(IUsuarios Usuarios)
        {
            this.Usuarios = Usuarios;
        }
    }
}
