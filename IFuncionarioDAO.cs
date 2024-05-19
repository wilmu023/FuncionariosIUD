using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosIUD
{
    internal interface IFuncionarioDAO
    {
        void Add(Funcionario funcionario);
        Funcionario Get(int id);
        List<Funcionario> GetAll();
        void Update(Funcionario funcionario);
        void Delete(int id);
    }
}
