using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NeoTagger.Data;
using NeoTagger.Models;


namespace NeoTagger.Controllers;

public class MapController : Controller
{
    private readonly NeoTaggerContext _context;
    // private readonly ILogger<MapController> _logger;

    public MapController(NeoTaggerContext context)
    {
        _context = context;
    }

        public async Task<IActionResult> Index()
        {
            return _context.Tag != null ? 
                View(await _context.Tag.ToListAsync()) :
                Problem("Entity set 'NeoTaggerContext.Tag' is null.");
        }
}
