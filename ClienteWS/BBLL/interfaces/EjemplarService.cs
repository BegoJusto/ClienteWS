﻿using ClienteWS.Models;
using System.Collections.Generic;

namespace ClienteWS.BBLL.interfaces {
    public interface EjemplarService
    {

        IList<Ejemplar> getAll();
        Ejemplar getEjemplarById(int codigoEjemplar);
        Ejemplar create(Ejemplar ejemplar);
        Ejemplar update(Ejemplar ejemplar);
        void delete(int codigoEjemplar);
        IList<Ejemplar> getByIdDeLibro(int codLibro);
    }
}
