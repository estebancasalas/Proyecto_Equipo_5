// -----------------------------------------------------------------------
// <copyright file="Emprendedor.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que modela un usario del tipo emprendedor.
    /// Implementa la interfaz IUsuario, para lograr facilitar la extensión en caso de que
    /// surjan nuevos tipos de usuario.
    /// </summary>
    public class Emprendedor : IUsuario, IStringbuilder
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Emprendedor"/>.
        /// Constructor de la clase emprendedor.
        /// </summary>
        /// <param name="id">Id del emprendedor.</param>
        /// <param name="nombre">Nombre del emprendedor.</param>
        /// <param name="ubicacion">Ubicación del emprendedor.</param>
        /// <param name="rubro">Rubro del emprendedor.</param>
        /// <param name="habilitaciones">Habilitaciones que tiene el emprendedor.</param>
        /// <param name="especializaciones">Especializaciones que tiene el emprendedor.</param>
        public Emprendedor(long id, string nombre, string ubicacion, string rubro, string habilitaciones, string especializaciones)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
            this.Rubro = rubro;
            this.Habilitaciones = habilitaciones;
            this.Especializaciones = especializaciones;
        }

        /// <summary>
        /// Obtiene o establece id del Emprendedor.
        /// </summary>
        /// <value>Se guarda el Id de el usuario.</value>
        public long Id { get; set; }

        /// <summary>
        /// Obtiene o establece atributo para ver el estado en el que se encuentra este usuario dentro de los handlers.
        /// </summary>
        /// <value>Se guarda el Estado de la conversación del usuario.</value>
        public EstadoUsuario Estado { get; set; }

        /// <summary>
        /// Obtiene o establece nombre del emprendedor.
        /// </summary>
        /// <value>Se guarda el nombre del emprendedor.</value>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece ubicación del emprendedor.
        /// </summary>
        /// <value>Se guarda la dirección del emprendedor.</value>
        public string Ubicacion { get; set; }

        /// <summary>
        /// Obtiene o establece rubro del emprendedor.
        /// </summary>
        /// <value>Se guarda el rubro del emprendedor.</value>
        public string Rubro { get; set; }

        /// <summary>
        /// Obtiene habilitaciones del emprendedor(Link al documento).
        /// </summary>
        /// <value>Se guarda las habilitaciones que contiene el emprendedor.</value>
        public string Habilitaciones { get; }

        /// <summary>
        /// Obtiene especializaciones del emprendedor.
        /// </summary>
        /// <value>Se guardan las especializaciones del emprendedor.</value>
        public string Especializaciones { get; }

        public string ConvertToString()
        {
            StringBuilder resultado = new StringBuilder();
            resultado.Append($"Nombre: {this.Nombre}\n");
            resultado.Append($"Ubicación: {this.Ubicacion}\n");
            resultado.Append($"Rubro: {this.Rubro}\n");
            resultado.Append($"Habilitaciones: {this.Habilitaciones}\n");
            resultado.Append($"Especializaciones: {this.Especializaciones}\n");
            return resultado.ToString();
        }
    }
}