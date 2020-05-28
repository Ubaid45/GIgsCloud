﻿using GigCloud.Models;
using GigCloud.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GigCloud.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }


    }
}
