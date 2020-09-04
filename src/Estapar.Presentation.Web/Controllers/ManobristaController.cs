using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Estapar.Domain;
using Estapar.Application;
using AutoMapper;

namespace Estapar.Presentation.Web.Controllers
{
    public class ManobristaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IManobristaAppService _manobristaAppService;

        public ManobristaController(IMapper mapper, IManobristaAppService manobristaAppService)
        {
            _mapper = mapper;
            _manobristaAppService = manobristaAppService;
        }

        // GET: Manobrista
        public IActionResult Index()
        {
            var manobrista = _manobristaAppService.Get();

            var manobristaDTO = _mapper.Map<List<ManobristaDTO>>(manobrista);

            return View(manobristaDTO);
        }

        // GET: Manobrista/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manobrista = _manobristaAppService.GetById(id);

            if (manobrista == null)
            {
                return NotFound();
            }

            var manobristaDTO = _mapper.Map<ManobristaDTO>(manobrista);

            return View(manobristaDTO);
        }

        // GET: Manobrista/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manobrista/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ManobristaDTO manobristaDTO)
        {
            if (ModelState.IsValid)
            {
                var manobrista = _mapper.Map<Manobrista>(manobristaDTO);

                var verificarCpf = _manobristaAppService.VerificarCpfCreate(manobrista.Cpf);

                if (verificarCpf != null)
                {
                    TempData["Message"] = "CPF já Cadastrado";

                    return View(manobristaDTO);
                }

                _manobristaAppService.Insert(manobrista);
                _manobristaAppService.Commit();

                return RedirectToAction(nameof(Index));
            }
            return View(manobristaDTO);
        }

        // GET: Manobrista/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manobrista = _manobristaAppService.GetById(id);

            if (manobrista == null)
            {
                return NotFound();
            }

            var manobristaDTO = _mapper.Map<ManobristaDTO>(manobrista);

            return View(manobristaDTO);
        }

        // POST: Manobrista/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ManobristaDTO manobristaDTO)
        {
            if (id != manobristaDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var manobrista = _mapper.Map<Manobrista>(manobristaDTO);

                    var verificarCpf = _manobristaAppService.VerificarCpfEdit(id, manobrista.Cpf);

                    if (verificarCpf != null)
                    {
                        TempData["Message"] = "CPF já Cadastrado";

                        return View(manobristaDTO);
                    }

                    _manobristaAppService.Update(manobrista);
                    _manobristaAppService.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManobristaExists(manobristaDTO.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(manobristaDTO);
        }

        // GET: Manobrista/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manobrista = _manobristaAppService.GetById(id);

            if (manobrista == null)
            {
                return NotFound();
            }

            var manobristaDTO = _mapper.Map<ManobristaDTO>(manobrista);

            return View(manobristaDTO);
        }

        // POST: Manobrista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var manobrista = _manobristaAppService.GetById(id);

            _manobristaAppService.Delete(manobrista);
            _manobristaAppService.Commit();

            return RedirectToAction(nameof(Index));
        }

        private bool ManobristaExists(int id)
        {
            return _manobristaAppService.VerificarManobrista(id);
        }
    }
}
