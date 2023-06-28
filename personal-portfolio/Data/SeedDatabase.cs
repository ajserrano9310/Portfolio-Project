using Microsoft.EntityFrameworkCore;
using personal_portfolio.Data;
using personal_portfolio.Models;

namespace personal_portfolio.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectDbContext(
           serviceProvider.GetRequiredService<
               DbContextOptions<ProjectDbContext>>()))
            {
                if (context.Project.Any())
                {
                    return;
                }

                context.Project.AddRange
                (

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

                );

                context.SaveChanges();

            }
        }
    }
}
