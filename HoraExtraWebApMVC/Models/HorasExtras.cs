using System;
using System.ComponentModel.DataAnnotations;
using HoraExtraWebApMVC.Models.Enums;

namespace HoraExtraWebApMVC.Models
{
    public class HorasExtras
    {
            public int Id { get; set; }
            
            public String Departamento { get; set; }
            [Display(Name = "Descrição")]
            public String Descricao { get; set; }
            public int Matricula { get; set; }

            [DataType(DataType.Date)]
            public DateTime Data { get; set; }

            public String Periodo { get; set; }

            public String Transporte { get; set; }

            public int Horas { get; set; }

        public HorasExtras()
            {

            }

        public HorasExtras(int id, string departamento, string descricao, int matricula, DateTime data, string periodo, string transporte, int horas)
        {
            id = Id;
            departamento = Departamento;
            descricao = Descricao;
            matricula = Matricula;
            data = Data;
            periodo = Periodo;
            transporte = Transporte;
            horas = Horas;


        }
    }
}
