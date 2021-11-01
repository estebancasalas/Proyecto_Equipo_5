using System;
using System.Collections.Generic;

namespace Library
{
    public class CrearEmpresaHandler : IHandler
    {
        public IHandler Next {get; set;}
        private string nombreDeLaEmpresa;
        private string ubicacion;
        private string rubro;

        public void Handle(Mensaje mensaje)
        {
            Console.WriteLine("Indique nombre: ");
            nombreDeLaEmpresa = Console.ReadLine();
            Console.WriteLine("Indique ubicacion: ");
            ubicacion = Console.ReadLine();
            Console.WriteLine("Indique rubro: ");
            rubro = Console.ReadLine();
            Empresa empresa = new Empresa(this.nombreDeLaEmpresa, this.ubicacion, this.rubro);
            ListaEmpresa.Empresas.Add(empresa);
            empresa.ListaIdEmpresarios.Add(mensaje.Id);
            mensaje.Text = Console.ReadLine();
            this.Next.Handle(mensaje);
        }
    }
}