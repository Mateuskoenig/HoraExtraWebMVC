using HoraExtraWebApMVC.Data;
using HoraExtraWebApMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HoraExtraWebApMVC.Services
{
    public class FuncionarioService
    {
        private readonly HoraExtraWebApMVCContext _context;

        public FuncionarioService(HoraExtraWebApMVCContext context)
        {
            _context = context;
        }
        public List<Funcionario> FindAll()
        {
            return _context.Funcionarios.ToList();
        }

        public void Insert (Funcionario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
