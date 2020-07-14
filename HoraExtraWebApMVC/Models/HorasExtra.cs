using System;
using HoraExtraWebApMVC.Models.Enums;

namespace HoraExtraWebApMVC.Models
{
    public class HorasExtra
    {
            public int Id { get; set; }
            public DateTime DataDaHora { get; set; }
            public Double Amount  { get; set; }
            public HoraExtraStatus Status { get; set; }
            public Funcionario Funcionario{ get; set; }

            public HorasExtra()
            {

            }

        public HorasExtra(int id, DateTime dataDaHora, double amount, HoraExtraStatus status, Funcionario funcionario)
        {
            Id = id;
            DataDaHora = dataDaHora;
            Amount = amount;
            Status = status;
            Funcionario = funcionario;
        }
    }
}
