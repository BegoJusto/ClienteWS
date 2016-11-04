using CapaLogica.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfBiblioteca {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEjemplar" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEjemplarService {

        WSEjemplar getEjemplarById(int idEjemplar);

        IList<WSEjemplar> getAll();

        void delete(int id);

        string create(WSEjemplar ejemplar);

        string update(WSEjemplar ejemplar);
       

    }
    [DataContract]
    public class WSEjemplar {
        int codigo = -1;
        DateTime fPublicacion = new DateTime();
        int numPaginas = 0;
        string isbn = "";
        string errorMessage = "";
        Editorial editorial;        

        [DataMember]
        public int Codigo {
            get {
                return codigo;
            }
            set {
                codigo = value;
            }
        }
        [DataMember]
        public DateTime FPublicacion {
            get {return fPublicacion;}
            set {fPublicacion = value;}
        }
        [DataMember]
        public int NumPaginas {
            get {
                return numPaginas;
            }
            set {
                numPaginas = value;
            }
        }
        [DataMember]
        public string ISBN {
            get {
                return isbn;
            }
            set {
                isbn = value;
            }
        }
        [DataMember]
        public string ErrorMessage {
            get {
                return errorMessage;
            }
            set {
                errorMessage = value;
            }
        }

    }
}
