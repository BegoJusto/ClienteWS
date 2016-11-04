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
                
            }
        }

        public IList<WSEjemplar> getAll() {
            throw new NotImplementedException();
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
       
        string IEjemplarService.create(WSEjemplar ejemplar) {
            string resultado = "";           
            if (aS.getEjemplarById(ejemplar.Codigo) == null) {
                Ejemplar aux = parseEjemplar(ejemplar);
                aS.create(aux);
                resultado = "Ejemplar Creado";
            } else {
                resultado = "No se ha podido crear el ejemplar";
            }

            return resultado;
        }

        private static Ejemplar parseEjemplar(WSEjemplar ejemplar) {
            Ejemplar aux = new Ejemplar();
            aux.NumPaginas = ejemplar.NumPaginas;
            aux.ISBN = ejemplar.ISBN;
            aux.FPublicacion = ejemplar.FPublicacion;
            return aux;
        }

        string IEjemplarService.update(WSEjemplar ejemplar) {
            string resultado = "";
            EjemplarService aS = new EjemplarServiceImp();
            if (aS.getEjemplarById(ejemplar.Codigo) == null) {
                aS.update(ejemplar);
            } else {
                resultado = "No se ha actualizado el ejemplar";
            }
            return resultado;
        }
    }
}
