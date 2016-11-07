
using CapaLogica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.BBLL
{
    public interface EditorialService
    {
        Editorial getById(int codigoEditorial);

        Editorial create(Editorial editorial);

        Editorial update(Editorial editorial);

        void delete(int codigoEditorial);

        IList<Editorial> getAll();
    }
}
