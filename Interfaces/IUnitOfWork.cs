using LoginPractica.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractica.Interfaces
{
    public interface IUnitOfWork
    {
        IUsuarios Usuarios { get; }
       
    }
}
