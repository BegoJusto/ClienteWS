using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CapaLogica.Models {
    public class Usuario {
        private int _codUsuario;
        private string _nombre;
        private string _apellidos;
        private string _alias;
        private string _pass;
        private DateTime? _fNacimiento;
        private string _dni;
        private string _email;
       


        public Usuario() {
            this._codUsuario = -1;
            this._nombre = "";
            this._apellidos = "";
            this._alias = "";
            this._pass = "";
            _fNacimiento = null;
            this._dni = "";
            this._email = "";
            this.Prestamos = null;
        }

        public int CodUsuario {
            get {
                return _codUsuario;
            }

            set {
                _codUsuario = value;
            }
       
        public string Nombre {
            get {
                return _nombre;
            }

            set {
                _nombre = value;
            }
        }
        
        public string Apellidos {
            get {
                return _apellidos;
            }

            set {
                _apellidos = value;
            }
        }
      
        public string Alias {
            get {
                return _alias;
            }

            set {
                _alias = value;
            }
        }
       
        public string Pass {
            get {
                return _pass;
            }

            set {
                _pass = value;
            }
        }
       
        public DateTime? FNacimiento
        {
            get
            {
                return _fNacimiento;
            }

            set
            {
                _fNacimiento = value;
            }
        }
       
        public string Dni
        {
            get
            {
                return _dni;
            }

            set
            {
                _dni = value;
            }
        }
       
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

    }
}