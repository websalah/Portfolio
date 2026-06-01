namespace PortfolioWeb.Models.Domain
{
    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SvgIcon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string WrapperClass { get; set; } = string.Empty; // e.g. "html", "css" for specific styling
    }

    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TechStack { get; set; } = string.Empty;
        public string GithubLink { get; set; } = string.Empty;
    }

    public class Experience
    {
        public string Role { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
