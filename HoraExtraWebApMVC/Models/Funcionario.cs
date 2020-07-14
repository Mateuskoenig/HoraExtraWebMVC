using HoraExtraWebApMVC.Models.Departamento;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Rewrite.Internal.IISUrlRewrite;

namespace HoraExtraWebApMVC.Models 
{ 
   
    

    public class Funcionario
    {
        
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Decricao { get; set; }
            public DateTime DiaDaHoraExtra { get; set; }
            public Departamento.Departamento Departamento { get; set; }
            public ICollection<HorasExtra> HorasExtra { get; set; } = new List<HorasExtra>();

        public Funcionario() 
        {
        
        }

        public Funcionario(int id, string nome, string decricao, DateTime diaDaHoraExtra, Departamento.Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Decricao = decricao;
            DiaDaHoraExtra = diaDaHoraExtra;
            Departamento = departamento;
        }


        public void AddHoraExtra(HorasExtra hr)
        {
            HorasExtra.Add(hr);
        }

        public void RemoveHoraExtra(HorasExtra hr)
        {
            HorasExtra.Remove(hr);
        }

        public double TotalHorasExtra(DateTime Inicial, DateTime Final)
        {
            return HorasExtra.Where(hr => hr.DataDaHora >= Inicial && hr.DataDaHora <= Final).Sum(hr => hr.Amount);
        }
    }
}
