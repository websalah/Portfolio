using System.Collections.Generic;
using PortfolioWeb.Models.Domain;
using PortfolioWeb.ViewModels;

namespace PortfolioWeb.Services
{
    public interface IPortfolioService
    {
        PortfolioViewModel GetPortfolioData();
    }

    public class PortfolioService : IPortfolioService
    {
        public PortfolioViewModel GetPortfolioData()
        {
            return new PortfolioViewModel
            {
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Name = "HTML5",
                        Color = "#f15931",
                        WrapperClass = "html",
                        Description = "Proficient in writing semantic, accessible, and structured HTML to build the foundation of modern web applications.",
                        SvgIcon = "<svg fill=\"#f15931\" width=\"12vh\" height=\"100px\" viewBox=\"0 0 32 32\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" stroke=\"#f15931\"><path d=\"M11.677 13.196l-0.289-3.387 12.536 0.004 0.287-3.268-16.421-0.004 0.87 9.983h11.374l-0.406 4.27-3.627 1.002-3.683-1.009-0.234-2.63h-3.252l0.411 5.198 6.757 1.807 6.704-1.798 0.927-10.166h-11.954zM2.914 1.045h26.172l-2.38 26.874-10.734 3.037-10.673-3.038z\"></path></svg>"
                    },
                    new Skill
                    {
                        Name = "CSS3",
                        Color = "#007dc6",
                        WrapperClass = "css",
                        Description = "Experienced in modern CSS, Flexbox, Grid, and responsive design to create beautiful, cross-device user interfaces.",
                        SvgIcon = "<svg fill=\"#007dc6\" width=\"12vh\" height=\"100px\" viewBox=\"0 0 32 32\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" stroke=\"#007dc6\"><path d=\"M24.235 6.519l-16.47-0.004 0.266 3.277 12.653 0.002-0.319 3.394h-8.298l0.3 3.215h7.725l-0.457 4.403-3.636 1.005-3.694-1.012-0.235-2.637h-3.262l0.362 4.817 6.829 2.128 6.714-1.912 1.521-16.675zM2.879 1.004h26.242l-2.387 26.946-10.763 3.045-10.703-3.047z\"></path></svg>"
                    },
                    new Skill
                    {
                        Name = "C#",
                        Color = "#9b4993",
                        WrapperClass = "html",
                        Description = "Strong foundation in C# and object-oriented programming, utilizing SOLID principles for clean and maintainable backend logic.",
                        SvgIcon = "<svg fill=\"#9b4993\" width=\"12vh\" height=\"100px\" viewBox=\"0 0 24 24\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" stroke=\"#9b4993\"><path d=\"M19.789 12.75l-1.096 4.316h3.195l-.75 2.93h-3.195l-1.391 5.504h-3.193l1.385-5.504h-4.32l-1.391 5.504H5.84l1.385-5.504H4.031l.75-2.93h3.195l1.096-4.316H5.877l.75-2.93h3.195l1.391-5.504h3.193l-1.385 5.504h4.32l1.391-5.504h3.193l-1.385 5.504h3.195l-.75 2.93h-3.195zm-6.241 4.316l1.096-4.316h-4.32l-1.096 4.316h4.32z\"></path></svg>"
                    },
                    new Skill
                    {
                        Name = "ASP.NET Core",
                        Color = "#512bd4",
                        WrapperClass = "css",
                        Description = "Building robust, scalable REST APIs and MVC web applications using ASP.NET Core framework and Entity Framework.",
                        SvgIcon = "<svg fill=\"#512bd4\" width=\"12vh\" height=\"100px\" viewBox=\"0 0 24 24\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" stroke=\"#512bd4\"><path d=\"M12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm-1 17.93c-3.95-.49-7-3.85-7-7.93 0-.62.08-1.21.21-1.79L9 15v1c0 1.1.9 2 2 2v1.93zm6.9-2.54c-.26-.81-1-1.39-1.9-1.39h-1v-3c0-.55-.45-1-1-1H8v-2h2c.55 0 1-.45 1-1V7h2c1.1 0 2-.9 2-2v-.41c2.93 1.19 5 4.06 5 7.41 0 2.08-.8 3.97-2.1 5.39z\"></path></svg>"
                    },
                    new Skill
                    {
                        Name = "Python",
                        Color = "#ffde57",
                        WrapperClass = "html",
                        Description = "Experience in Python for data processing, scripting, and integrating advanced machine learning libraries into production.",
                        SvgIcon = "<svg fill=\"#ffde57\" width=\"12vh\" height=\"100px\" viewBox=\"0 0 24 24\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" stroke=\"#ffde57\"><path d=\"M14.2 2.3c-5.7 0-5.4 2.5-5.4 2.5l.1 2.6h5.5v.8H6.5s-4.3-.4-4.3 4.2 3.6 4.4 3.6 4.4h1.7v-2.1c0-2.4 2.3-2.5 2.3-2.5h5.4s2.4 0 2.4-2.3V4.7s.2-2.4-3.4-2.4zm-1.8 1.4c.5 0 .9.4.9.9s-.4.9-.9.9-.9-.4-.9-.9.4-.9.9-.9zm10.7 7.2s-2.1 0-2.1 2.3v5.1s0 2.4-2.4 2.4h-5.4s-2.3.1-2.3 2.5v2c0 2.4 4.3 2.4 4.3 2.4h2.9s5.4.3 5.4-4.2c0 0 0-2.8 0-2.8h-5.5v-.8h7.9s4.3.4 4.3-4.4c0-4.6-3.6-4.4-3.6-4.4h-3.5zm-4.7 6.4c.5 0 .9.4.9.9s-.4.9-.9.9-.9-.4-.9-.9.4-.9.9-.9z\"></path></svg>"
                    },
                    new Skill
                    {
                        Name = "AI / Machine Learning",
                        Color = "#ff4c4c",
                        WrapperClass = "css",
                        Description = "Integrating AI models and LLMs to solve complex problems and automation problems.",
                        SvgIcon = "<svg fill=\"#ff4c4c\" width=\"12vh\" height=\"100px\" viewBox=\"0 0 24 24\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" stroke=\"#ff4c4c\"><path d=\"M12 2a2 2 0 0 0-2 2c0 .74.4 1.39 1 1.73V7h-2v1.07A2.001 2.001 0 0 0 8 10a2 2 0 0 0 1 1.73V13H7v-1a2 2 0 1 0-2 0v1H3v2h2v1a2 2 0 1 0 2 0v-1h2v1.27a2.001 2.001 0 0 0 2 1.73 2 2 0 0 0 2-2c0-.74-.4-1.39-1-1.73V13h2v1a2 2 0 1 0 2 0v-1h2v-2h-2v-1h2a2 2 0 1 0-2 0v1h-2v-1.27a2.001 2.001 0 0 0-1-3.46V7h-2V5.73A2.001 2.001 0 0 0 12 2z\"></path></svg>"
                    }
                },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Resume Matcher",
                        Description = "A complete AI Resume Matcher that ranks candidates against job descriptions using local ONNX machine learning models and ASP.NET Core.",
                        TechStack = "C#, ASP.NET Core MVC, ONNX Runtime",
                        GithubLink = "https://github.com/websalah/ResumeMatcher"
                    },
                    new Project
                    {
                        Title = "AI-Based Short-Term Load Forecasting Using CNN-LSTM",
                        Description = " led a group of 3 students to create a deep learning model that predicts 7-days ahead electric load in Nineveh, Iraq as part of our B.Sc. graduation thesis. We used historical electrical load data of the Nineveh power grid and weather data from Open-meteo API to improve prediction accuracy. The project uses a combination of CNN and LSTM layers.",
                        TechStack = "Python, Neural Networks, Data Preprocessing, hyperparameter tuning",
                        GithubLink = "https://github.com/websalah/CNN_LSTM_MODEL"
                    },
                    new Project
                    {
                        Title = "Cards Maker",
                        Description = "a modern web application for creating and managing beautiful personal contact cards. It allows users to generate stylish digital cards with their personal information and export them as images for easy sharing.",
                        TechStack = "C#, ASP.NET Core MVC, Html, Css",
                        GithubLink = "https://github.com/websalah/CardsMaker"
                    },
                    new Project
                    {
                        Title = "Portfolio",
                        Description = "Migrated a static HTML/CSS web portfolio into a robust, dynamic ASP.NET Core MVC application with a clean architecture.",
                        TechStack = "ASP.NET Core, Razor, HTML5, CSS3",
                        GithubLink = "https://github.com/websalah/portfolio"
                    }
                },
                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        Role = "Nineveh Power grid intern",
                        Company = "Government",
                        Duration = "Jun 2025 - Aug 2025",
                        Description = "Worked on the Nineveh Power grid project, contributing to the development and maintenance of critical infrastructure systems."
                    },
                }
            };
        }
    }
}
