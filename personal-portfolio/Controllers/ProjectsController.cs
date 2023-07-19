using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using personal_portfolio.Models;

namespace personal_portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ProjectDbContext _context;
        private readonly Project[] projects = new Project[]
        {
            new Project
                      {
                          Id = Guid.NewGuid(),
                          Title = "Draw!",
                          Description = "An app built to practice figure drawing. The application\r\n                      cycles through timed images. The main objective of the\r\n                      project was to build something that would help me with my\r\n                      own process of learning how to draw.",
                          ImageUrl = "./images/draw.png",
                          GitHubUrl = "https://github.com/ajserrano9310/FigureDrawingApp",
                          Technologies = "JavaScript,HTML,CSS,MongoDB"
                      },
                      new Project
                      {
                          Id = Guid.NewGuid(),
                          Title = "Personal Portfolio",
                          Description = "This personal project has been my most involved project,\r\n                      because it required a better undestanding of CSS, HTML and\r\n                      JavaScript. In addition, it was also very important to me\r\n                      to create an interesting design from scratch. Since most\r\n                      of the functionality is through CSS it required me to\r\n                      learn about animations and transitions. Another\r\n                      interesting part of the project was implementing an email\r\n                      service for contact with nodemailer.",
                          ImageUrl = "./images/portfolio.png",
                          GitHubUrl = "https://github.com/ajserrano9310/FigureDrawingApp",
                          Technologies = "JavaScript,HTML,CSS,C#,.NET Framework"
                      },

                      new Project
                      {
                          Id = Guid.NewGuid(),
                          Title = "LifeStyle Mobile App",
                          Description = "\r\nThe Mobile App Development course introduced me to one of the most interesting projects I've worked on. Unlike other courses, the main objective was to gain practical experience in building phone applications. One of the highlights was the opportunity to delve into building scalable software and learn new technologies like Android Studio. Additionally, we explored software design patterns such as the Factory and Singleton pattern in-depth.",
                          ImageUrl = "./images/life.png",
                          GitHubUrl = "https://github.com/ajserrano9310/FigureDrawingApp",
                          Technologies = "Android Studio,Java,SQLite,XML"
                      },
                      new Project
                      {
                          Id = Guid.NewGuid(),
                          Title = "TA Application",
                          Description = "This application provided my initial exposure to constructing modern web applications and understanding web software architecture as a whole. Additionally, I gained knowledge in connecting web applications with databases and exploring AWS concepts by deploying the web app in the cloud. ",
                          ImageUrl = "./images/webarchitecture.jpg",
                          GitHubUrl = "https://github.com/ajserrano9310/FigureDrawingApp",
                          Technologies = "CSHTML,JavaScript,SQL,CSS,C#,AWS,Visual Studio"
                      }

        };

        public ProjectsController(ProjectDbContext context)
        {
            _context = context;
        }



        // GET: Projects
        public async Task<IActionResult> Index()
        {
            return View(projects.ToArray());
            /*return _context.Project != null ?
                        View(await _context.Project.ToListAsync()) :
                        Problem("Entity set 'ProjectDbContext.Project'  is null.");*/
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Project == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,GitHubUrl,ImageUrl,Technologies")] Project project)
        {
            if (ModelState.IsValid)
            {
                project.Id = Guid.NewGuid();
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Project == null)
            {
                return NotFound();
            }

            var project = await _context.Project.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Description,GitHubUrl,ImageUrl,Technologies")] Project project)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.Id))
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
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Project == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Project == null)
            {
                return Problem("Entity set 'ProjectDbContext.Project'  is null.");
            }
            var project = await _context.Project.FindAsync(id);
            if (project != null)
            {
                _context.Project.Remove(project);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(Guid id)
        {
            return (_context.Project?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
