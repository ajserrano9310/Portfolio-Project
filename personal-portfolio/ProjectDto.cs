using System.ComponentModel.DataAnnotations;

namespace personal_portfolio
{
    public record ProjectDto(Guid id, string Title, string ShortDescription, string GithubUrl, string ImageUrl, string[] Technologies);
    public record CreateProjectDto([Required] string Title, [Required] string ShortDescription, string GithubUrl, [Required] string ImageUrl, string[] Technologies);
    public record UpdateProjectDto([Required] string Title, [Required] string ShortDescription, string GithubUrl, [Required] string ImageUrl, string[] Technologies);

}
