using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Estapar.Domain;
using Estapar.Application;
using AutoMapper;

namespace Estapar.Presentation.Web.Controllers
{
    public class CarroController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICarroAppService _carroAppService;

        public CarroController(ICarroAppService carroAppService, IMapper mapper)
        {
            _mapper = mapper;
            _carroAppService = carroAppService;
        }

        // GET: Carro
        public IActionResult Index()
        {
            var carro = _carroAppService.Get();

            var carroDTO = _mapper.Map<List<CarroDTO>>(carro);

            return View(carroDTO);
        }

        // GET: Carro/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = _carroAppService.GetById(id);

            if (carro == null)
            {
                return NotFound();
            }

            var carroDTO = _mapper.Map<CarroDTO>(carro);

            return View(carroDTO);
        }

        // GET: Carro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carro/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarroDTO carroDTO)
        {
            if (ModelState.IsValid)
            {
                var carro = _mapper.Map<Carro>(carroDTO);

                var verificarPlaca = _carroAppService.VerificarPlacaCreate(carro.Placa);

                if (verificarPlaca != null)
                {
                    TempData["Message"] = "Placa já Cadastrada";

                    return View(carroDTO);
                }

                _carroAppService.Insert(carro);
                _carroAppService.Commit();

                return RedirectToAction(nameof(Index));
            }

            return View(carroDTO);
        }

        // GET: Carro/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = _carroAppService.GetById(id);

            if (carro == null)
            {
                return NotFound();
            }

            var carroDTO = _mapper.Map<CarroDTO>(carro);

            return View(carroDTO);
        }

        // POST: Carro/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CarroDTO carroDTO)
        {
            if (id != carroDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var carro = _mapper.Map<Carro>(carroDTO);

                    var verificarPlaca = _carroAppService.VerificarPlacaEdit(id, carro.Placa);

                    if (verificarPlaca != null)
                    {
                        TempData["Message"] = "Placa já Cadastrada";

                        return View(carroDTO);
                    }

                    _carroAppService.Update(carro);
                    _carroAppService.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarroExists(carroDTO.Id))
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

            return View(carroDTO);
        }

        // GET: Carro/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = _carroAppService.GetById(id);

            if (carro == null)
            {
                return NotFound();
            }          

            var carroDTO = _mapper.Map<CarroDTO>(carro);

            return View(carroDTO);
        }

        // POST: Carro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var carro = _carroAppService.GetById(id);

            _carroAppService.Delete(carro);
            _carroAppService.Commit();

            return RedirectToAction(nameof(Index));
        }

        private bool CarroExists(int id)
        {
            return _carroAppService.VerificarCarro(id);
        }
    }
}
