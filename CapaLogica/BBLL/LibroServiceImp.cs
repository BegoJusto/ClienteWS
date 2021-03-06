﻿using CapaLogica.BBLL.interfaces;
using CapaLogica.DAL;
using CapaLogica.Models;
using System.Collections.Generic;

namespace CapaLogica.BBLL {
    public class LibroServiceImp : LibroService
    {
        private LibroRespository lr;

        public LibroServiceImp()
        {
            lr = new LibroRepositoryImp();
        }
        public Libro create(Libro libro)
        {
            return lr.create(libro);
        }

        public void delete(int codigoLibro)
        {
            lr.delete(codigoLibro);
        }

        public IList<Libro> getAll()
        {
            return lr.getAll();
        }

        public Libro getById(int codigoLibro)
        {
            return lr.getById(codigoLibro);
        }

        public Libro update(Libro libro)
        {
            return lr.update(libro);
        }
    }
}