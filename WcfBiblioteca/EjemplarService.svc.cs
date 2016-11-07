using CapaLogica.BBLL;
using CapaLogica.BBLL.interfaces;
using CapaLogica.Models;
using System;
using System.Collections.Generic;

namespace WcfBiblioteca {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ejemplar" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ejemplar.svc o Ejemplar.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSEjemplarService: IEjemplarService {
        EjemplarService aS = new EjemplarServiceImp();

        public void delete(int idEjemplar) {
            Ejemplar ejemplar = aS.getEjemplarById(idEjemplar);
            if (ejemplar != null) {

                aS.delete(idEjemplar);
            }
        }

        public IList<WSEjemplar> getAll() {
            IList<Ejemplar> listaEjemplares = aS.getAll();
            IList<WSEjemplar> listaWSEjemplares = new List<WSEjemplar>();
            WSEjemplar wsEjemplar = new WSEjemplar();
            foreach (var ejemplar in listaEjemplares){
                ejemplar.CodEjemplar = wsEjemplar.Codigo;
                ejemplar.ISBN = wsEjemplar.ISBN;
                ejemplar.NumPaginas = wsEjemplar.NumPaginas;
                listaWSEjemplares.Add(wsEjemplar);
            }                        
            return listaWSEjemplares;
        }

        

        public WSEjemplar getEjemplarById(int idEjemplar) {

            WSEjemplar ejemplar = null;
            Ejemplar ejemAux = aS.getEjemplarById(idEjemplar);
            ejemplar = new WSEjemplar();
            if (ejemAux == null) {
                ejemplar.ErrorMessage = "El Ejemplar no existe";
                throw new Exception();
            }
            else
            {
                ejemplar.NumPaginas = ejemAux.NumPaginas;
                ejemplar.ISBN = ejemAux.ISBN;
                ejemplar.FPublicacion = ejemAux.FPublicacion;
            }


            return ejemplar;
        }
       
        public string create(WSEjemplar ejemplar) {
            string resultado = "";           
            if (aS.getEjemplarById(ejemplar.Codigo) == null) {
               
                aS.create(parseWSEjemplarToEjemplar(ejemplar));
                resultado = "Ejemplar Creado";
            } else {
                resultado = "No se ha podido crear el ejemplar";
            }

            return resultado;
        }

        private static Ejemplar parseWSEjemplarToEjemplar(WSEjemplar ejemplar) {
            Ejemplar aux = new Ejemplar();
            aux.NumPaginas = ejemplar.NumPaginas;
            aux.ISBN = ejemplar.ISBN;
            aux.FPublicacion = ejemplar.FPublicacion;
            return aux;
        }

        public string update(WSEjemplar ejemplar) {
            string resultado = "";           
            if (aS.getEjemplarById(ejemplar.Codigo) != null) {
                aS.update(parseWSEjemplarToEjemplar(ejemplar));
                resultado = "El ejemplar se ha actualizado";
            } else {
                resultado = "No se ha actualizado el ejemplar";
            }
            return resultado;
        }
    }
}
