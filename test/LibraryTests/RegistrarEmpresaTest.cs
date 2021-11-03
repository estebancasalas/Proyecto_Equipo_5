using NUnit.Framework;
using Library;
using System.Collections.Generic;

namespace LibraryTests
{

    [TestFixture]
    public class RegistrarEmpresaTests
    {
        Mensaje mensaje;
        RegistrarEmpresarioHandler registrarEmpresario;
       
        [SetUp]
        public void Setup()
        {
            ListaEmpresa lista1 = new ListaEmpresa();
            Dictionary<string, string> diccionario = new Dictionary<string, string>();

        }

        /// <summary>
        /// En este test verificamos que, cuando la invitación es válida, el id del usuario se añade correctamente a la lista de 
        /// ids de la empresa.
        /// </summary>
        [Test]
        public void InvitacionValidaTest()
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
            diccionario.Add("Ingrese su código de invitación: ", "ValidToken");

            ListaEmpresa lista1 = new ListaEmpresa();
            Mensaje mensaje = new Mensaje(1234,"/empresa");
            RegistrarEmpresarioHandler registrarEmpresario = new RegistrarEmpresarioHandler();
            Administrador admin = new Administrador(456, "admin");
            admin.CrearInvitacion("Empresa1", "Montevideo", "textil", "ValidToken");
            LectorTest lector = new LectorTest(diccionario);
            registrarEmpresario.Input = lector;
            registrarEmpresario.Handle(mensaje);
            Assert.That(ListaEmpresa.Empresas[1].ListaIdEmpresarios.Contains(1234),Is.True);
        }
        [Test]
        public void InvitacionInvalidaTest()
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
            diccionario.Add("Ingrese su código de invitación: ", "InvalidToken");
            ListaEmpresa lista1 = new ListaEmpresa();
            Mensaje mensaje = new Mensaje(1234,"/empresa");
            RegistrarEmpresarioHandler registrarEmpresario = new RegistrarEmpresarioHandler();
            Administrador admin = new Administrador(456, "admin");
            admin.CrearInvitacion("Empresa1", "Montevideo", "textil", "ValidToken");
            LectorTest lector = new LectorTest(diccionario);
            registrarEmpresario.Handle(mensaje);
            BuscarEmpresa buscarempresa = new BuscarEmpresa();
            Empresa empresa = buscarempresa.Buscar("Empresa1");
            Assert.That(empresa.ListaIdEmpresarios.Contains(1234),Is.False);   
        }
    }
}