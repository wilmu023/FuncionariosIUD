using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FuncionariosIUD 
{
    internal class FuncionarioDAOImpl : IFuncionarioDAO
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();

    public void Add(Funcionario funcionario)
    {
        funcionario.Id = funcionarios.Count > 0 ? funcionarios.Max(f => f.Id) + 1 : 1;
        funcionarios.Add(funcionario);
    }

    public Funcionario Get(int id)
    {
        return funcionarios.FirstOrDefault(f => f.Id == id);
    }

    public List<Funcionario> GetAll()
    {
        return funcionarios;
    }

    public void Update(Funcionario funcionario)
    {
        var existingFuncionario = Get(funcionario.Id);
        if (existingFuncionario != null)
        {
            existingFuncionario.TipoIdentificacion = funcionario.TipoIdentificacion;
            existingFuncionario.NumeroIdentificacion = funcionario.NumeroIdentificacion;
            existingFuncionario.Nombres = funcionario.Nombres;
            existingFuncionario.Apellidos = funcionario.Apellidos;
            existingFuncionario.EstadoCivil = funcionario.EstadoCivil;
            existingFuncionario.Sexo = funcionario.Sexo;
            existingFuncionario.Direccion = funcionario.Direccion;
            existingFuncionario.Telefono = funcionario.Telefono;
            existingFuncionario.FechaNacimiento = funcionario.FechaNacimiento;
        }
    }

    public void Delete(int id)
    {
        var funcionario = Get(id);
        if (funcionario != null)
        {
            funcionarios.Remove(funcionario);
        }
    }
}
}
