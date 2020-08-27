using System.Collections.Generic;
using System;
using System.Linq;


namespace HoraExtraWebApMVC.Models.Departamento
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Gestor { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();


        public Departamento()
        { 
        
        }

        public Departamento(int id, string nome, string gestor  )
        {
            Id = id;
            Nome = nome;
            Gestor = gestor;
        }
   
        public void AddFuncionario(Funcionario func)
        {
            Funcionarios.Add(func);

        }

  
    }

}



