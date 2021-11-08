﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppSchool.Models;

namespace AppSchool.Controllers
{
    public class AlunosController : Controller
    {

        // GET: AlunosController
        public ActionResult Index()
        {
            return View(AlunoRepository.GetAlunoList);
        }


        // GET: AlunosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlunosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlunosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            Aluno aluno = (Aluno) collection;
            AlunoRepository.Create(aluno);

            return RedirectToAction(nameof(Index));
            
        }

        // GET: AlunosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlunosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlunosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}