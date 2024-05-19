using NUnit.Framework;

namespace FuncionariosIUD.Tests
{
    [TestFixture]
    public class UnitTest1Base1
    {
        private FuncionarioDAOImpl funcionarioDAO;

        [SetUp]
        public void Setup()
        {
            funcionarioDAO = new FuncionarioDAOImpl();
        }

        [Test]
        public void TestAddFuncionario()
        {
            var funcionario = new Funcionario
            {
                TipoIdentificacion = "CC",
                NumeroIdentificacion = "123456789",
                Nombres = "Juan",
                Apellidos = "Perez",
                EstadoCivil = "Soltero",
                Sexo = "Masculino",
                Direccion = "Calle 123",
                Telefono = "555-1234",
                FechaNacimiento = new DateTime(1990, 1, 1)
            };
            funcionarioDAO.Add(funcionario);
            var funcionarios = funcionarioDAO.GetAll();
            Assert.AreEqual(1, funcionarios.Count);
            Assert.AreEqual("Juan", funcionarios[0].Nombres);
        }

        [Test]
        public void TestDeleteFuncionario()
        {
            var funcionario = new Funcionario
            {
                TipoIdentificacion = "CC",
                NumeroIdentificacion = "123456789",
                Nombres = "Juan",
                Apellidos = "Perez",
                EstadoCivil = "Soltero",
                Sexo = "Masculino",
                Direccion = "Calle 123",
                Telefono = "555-1234",
                FechaNacimiento = new DateTime(1990, 1, 1)
            };
            funcionarioDAO.Add(funcionario);
            funcionarioDAO.Delete(1);
            var funcionarios = funcionarioDAO.GetAll();
            Assert.AreEqual(0, funcionarios.Count);
        }

        [Test]
        public void TestUpdateFuncionario()
        {
            var funcionario = new Funcionario
            {
                TipoIdentificacion = "CC",
                NumeroIdentificacion = "123456789",
                Nombres = "Juan",
                Apellidos = "Perez",
                EstadoCivil = "Soltero",
                Sexo = "Masculino",
                Direccion = "Calle 123",
                Telefono = "555-1234",
                FechaNacimiento = new DateTime(1990, 1, 1)
            };
            funcionarioDAO.Add(funcionario);

            var updatedFuncionario = new Funcionario
            {
                Id = 1,
                TipoIdentificacion = "CC",
                NumeroIdentificacion = "123456789",
                Nombres = "Juan Pablo",
                Apellidos = "Perez",
                EstadoCivil = "Soltero",
                Sexo = "Masculino",
                Direccion = "Calle 123",
                Telefono = "555-1234",
                FechaNacimiento = new DateTime(1990, 1, 1)
            };
            funcionarioDAO.Update(updatedFuncionario);

            var retrievedFuncionario = funcionarioDAO.Get(1);
            Assert.AreEqual("Juan Pablo", retrievedFuncionario.Nombres);
        }
    }
}