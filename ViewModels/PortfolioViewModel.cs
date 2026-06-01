using System.Collections.Generic;
using PortfolioWeb.Models.Domain;

namespace PortfolioWeb.ViewModels
{
    public class PortfolioViewModel
    {
        public IEnumerable<Skill> Skills { get; set; } = new List<Skill>();
        public IEnumerable<Project> Projects { get; set; } = new List<Project>();
        public IEnumerable<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
