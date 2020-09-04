using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Estapar.Domain;
using Estapar.Infrastructure.Data;
using AutoMapper;
using Estapar.Application;

namespace Estapar.Presentation.Web.Controllers
{
    public class CarroManobristaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICarroManobristaAppService _carroManobristaAppService;
        private readonly ICarroAppService _carroAppService;
        private readonly IManobristaAppService _manobristaAppService;

        public CarroManobristaController(IMapper mapper,
            ICarroManobristaAppService carroManobristaAppService,
            ICarroAppService carroAppService,
            IManobristaAppService manobristaAppService)
        {
            _mapper = mapper;
            _carroManobristaAppService = carroManobristaAppService;
            _carroAppService = carroAppService;
            _manobristaAppService = manobristaAppService;
        }

        // GET: CarroManobrista
        public IActionResult Index()
        {
            var listaCarroManobrista = _carroManobristaAppService.ListarCarrosManobrista();

            var carroManobristaDTO = _mapper.Map<List<CarroManobristaDTO>>(listaCarroManobrista);

            return View(carroManobristaDTO);
        }

        // GET: CarroManobrista/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carroManobrista = _carroManobristaAppService.CarrosManobrista((int)id);

            var carroManobristaDTO = _mapper.Map<List<CarroManobristaDTO>>(carroManobrista);

            if (carroManobristaDTO == null)
            {
                return NotFound();
            }

            return View(carroManobristaDTO);
        }

        // GET: CarroManobrista/Create
        public IActionResult Create()
        {
            ViewData["IdCarro"] = new SelectList(_carroAppService.Get(), "Id", "Placa");
            ViewData["IdManobrista"] = new SelectList(_manobristaAppService.Get(), "Id", "Cpf");

            return View();
        }

        // POST: CarroManobrista/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarroManobristaDTO carroManobristaDTO)
        {
            if (ModelState.IsValid)
            {
                var carroManobrista = _mapper.Map<CarroManobrista>(carroManobristaDTO);

                var vericiarCarro = _carroManobristaAppService.VericiarCarro(carroManobrista.IdCarro);

                if (vericiarCarro != null)
                {
                    return Content("Carro já Manobrado");
                }

                _carroManobristaAppService.Insert(carroManobrista);
                _carroManobristaAppService.Commit();

                return RedirectToAction(nameof(Index));
            }

            ViewData["IdCarro"] = new SelectList(_carroAppService.Get(), "Id", "Placa");
            ViewData["IdManobrista"] = new SelectList(_manobristaAppService.Get(), "Id", "Cpf");

            return View(carroManobristaDTO);
        }

        // GET: CarroManobrista/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carroManobrista = _carroManobristaAppService.GetById(id);

            if (carroManobrista == null)
            {
                return NotFound();
            }

            ViewData["IdCarro"] = new SelectList(_carroAppService.Get(), "Id", "Placa", carroManobrista.IdCarro);
            ViewData["IdManobrista"] = new SelectList(_manobristaAppService.Get(), "Id", "Cpf", carroManobrista.IdManobrista);

            var carroManobristaDTO = _mapper.Map<CarroManobristaDTO>(carroManobrista);

            return View(carroManobristaDTO);
        }

        // POST: CarroManobrista/Edit/5        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CarroManobristaDTO carroManobristaDTO)
        {
            if (id != carroManobristaDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var carroManobrista = _mapper.Map<CarroManobrista>(carroManobristaDTO);

                    _carroManobristaAppService.Update(carroManobrista);
                    _carroManobristaAppService.Commit();

                    ViewData["IdCarro"] = new SelectList(_carroAppService.Get(), "Id", "Placa", carroManobrista.IdCarro);
                    ViewData["IdManobrista"] = new SelectList(_manobristaAppService.Get(), "Id", "Cpf", carroManobrista.IdManobrista);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarroManobristaExists(carroManobristaDTO.Id))
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

            return View(carroManobristaDTO);
        }

        // GET: CarroManobrista/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carroManobrista = _carroManobristaAppService.CarrosManobrista((int)id);

            var carroManobristaDTO = _mapper.Map<List<CarroManobristaDTO>>(carroManobrista);

            if (carroManobristaDTO == null)
            {
                return NotFound();
            }

            return View(carroManobristaDTO);
        }

        // POST: CarroManobrista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var carroManbrista = _carroManobristaAppService.GetById(id);

            _carroManobristaAppService.Delete(carroManbrista);
            _carroManobristaAppService.Commit();

            return RedirectToAction(nameof(Index));
        }

        private bool CarroManobristaExists(int id)
        {
            return _carroManobristaAppService.Get().Any(e => e.Id == id);
        }
    }
}
