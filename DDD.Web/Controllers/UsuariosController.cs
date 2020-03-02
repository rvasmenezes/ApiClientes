using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DDD.Web.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly IAppUsuario _appUsuario;

        public UsuariosController(IAppUsuario appUsuario)
        {
            _appUsuario = appUsuario;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(_appUsuario.List());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View(_appUsuario.GetEntity(id));
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View(new Usuario());
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                _appUsuario.Add(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appUsuario.GetEntity(id));
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuario usuario)
        {
            try
            {
                _appUsuario.Update(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appUsuario.GetEntity(id));
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Usuario usuario)
        {
            try
            {
                _appUsuario.Delete(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}