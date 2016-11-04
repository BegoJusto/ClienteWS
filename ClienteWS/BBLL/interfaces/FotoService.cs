using ClienteWS.Models;
using System.Collections.Generic;
namespace ClienteWS.BBLL.interfaces {
    interface FotoService {

        Foto getByID(int idFoto);
        Foto create(Foto foto);
        Foto update(Foto foto);
        void delete(int idFoto);
        IList<Foto> getAll();

    }
}
