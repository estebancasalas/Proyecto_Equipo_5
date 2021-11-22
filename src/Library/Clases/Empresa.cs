// -----------------------------------------------------------------------
// <copyright file="Empresa.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Library
{
    /// <summary>
    /// Clase que modela un usario del tipo empresa.
    /// Implementa la interfaz IUsuario, para lograr facilitar la extensión en caso de que
    /// surjan nuevos tipos de usuario.
    /// </summary>
    public class Empresa
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Empresa"/> class.
        /// Es el constructor que se encarga de crear a la empresa en su totalidad.
        /// </summary>
        /// <param name="nombre">Se encarga de guardar el nombre de la empresa dentro del objeto empresa.</param>
        /// <param name="ubicacion">Se encarga de guardar la ubicación de la empresa dentro del objeto empresa.</param>
        /// <param name="rubro">Se encarga de guardar el rubro de la empresa dentro del objeto empresa.</param>
        /// <param name="invitacion">Se encarga de guardar la invitación de la empresa dentro del objeto empresa.</param>
        public Empresa(string nombre, string ubicacion, string rubro, string invitacion)
        {
            this.Invitacion = invitacion;
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
            this.Rubro = rubro;
            Singleton<ListaEmpresa>.Instance.Add(this);
        }

        /// <summary>
        /// La ListaEmpresarios se encarga de registrar todos los usuarios que
        /// puede tener una misma empresa.
        /// </summary>
        /// <value></value>
        [JsonInclude]
        private List<Empresario> listaEmpresarios = new List<Empresario>();

        /// <summary>
        /// Gets or sets guarda la invitación de la empresa.
        /// </summary>
        /// <value>Guarda la invitacion que la empresa le brinda a los empresarios para unirse.</value>
        public string Invitacion { get; set; }

        /// <summary>
        /// Gets or sets guarda el nombre de la empresa.
        /// </summary>
        /// <value>Guarda el nombre de la empresa.</value>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets guarda la ubicación de la empresa.
        /// </summary>
        /// <value>Guarda la ubicacion de la empresa.</value>
        public string Ubicacion { get; set; }

        /// <summary>
        /// Gets or sets guarda el rubro de la empresa.
        /// </summary>
        /// <value>Guarda el rubro de la empresa.</value>
        public string Rubro { get; set; }

        public List<Empresario> ListaEmpresarios { get; set; }
    }
}
