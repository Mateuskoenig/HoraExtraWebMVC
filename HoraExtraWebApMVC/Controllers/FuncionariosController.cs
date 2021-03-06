﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HoraExtraWebApMVC.Services;
using HoraExtraWebApMVC.Models;

namespace HoraExtraWebApMVC.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        public FuncionariosController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
        public IActionResult Index()
        {
            var list = _funcionarioService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Funcionario funcionario)
        {
            _funcionarioService.Insert(funcionario);
            return RedirectToAction(nameof(Index));
            
        }

    }
}
