namespace HarishPortfolio.Models
{
    public class Project
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Tech { get; set; } = "";
        public string Image { get; set; } = "";
        public string Category { get; set; } = "";
    }

    public class Skill
    {
        public string Name { get; set; } = "";
        public int Level { get; set; } // 0–100
    }

    public class PortfolioData
    {
        public string Name { get; set; } = "HariBabu";
        public string Role { get; set; } = ".NET Developer";
        public string Tagline { get; set; } = "Building robust Windows & Web applications with clean, scalable code.";
        public string Email { get; set; } = "ragoluhari1999@email.com";
        public string GitHub { get; set; } = "https://github.com/Hari-320";
        public string LinkedIn { get; set; } = "https://linkedin.com/in/haribabu";
        public string Location { get; set; } = "India";
        public string About { get; set; } = "I'm a .NET Developer with strong experience in WinForms desktop applications, now expanding into modern ASP.NET Core web development. I enjoy building user-friendly, performant, and maintainable software solutions across domains including finance, surveillance, and industrial automation.";

        public List<Project> Projects { get; set; } = new()
        {
            new Project
            {
                Name = "BFT",
                Category = "Finance",
                Description = "A robust financial tracking and reporting system built with .NET WinForms. Handles bulk financial transactions, generates reports, and provides real-time data insights for business decision-making.",
                Tech = "C# · WinForms · SQL Server · Crystal Reports",
                Image = "/images/bft.jpg"
            },
            new Project
            {
                Name = "TVNS",
                Category = "Surveillance",
                Description = "A video and network surveillance management system. Enables monitoring, recording, and playback of camera feeds with alert management and user access control.",
                Tech = "C# · WinForms · DirectShow · SQL Server",
                Image = "/images/tvns.jpg"
            },
            new Project
            {
                Name = "BIS",
                Category = "Industrial",
                Description = "A business intelligence and industrial system designed to automate workflows, track production metrics, and generate compliance reports for manufacturing environments.",
                Tech = "C# · .NET · WinForms · SSRS · SQL Server",
                Image = "/images/bis.jpg"
            },
            new Project
            {
                Name = "PolyX Dual Camera",
                Category = "Imaging",
                Description = "An advanced dual-camera imaging application that synchronises two camera feeds for industrial inspection or scanning use cases. Supports live preview, snapshot capture, and image processing.",
                Tech = "C# · WinForms · DirectShow · OpenCV · USB SDK",
                Image = "/images/polyx.jpg"
            }
        };

        public List<Skill> Skills { get; set; } = new()
        {
            new Skill { Name = "C# / .NET", Level = 90 },
            new Skill { Name = "WinForms", Level = 88 },
            new Skill { Name = "SQL Server", Level = 82 },
            new Skill { Name = "ASP.NET Core", Level = 55 },
            new Skill { Name = "HTML / CSS", Level = 65 },
            new Skill { Name = "JavaScript", Level = 50 },
            new Skill { Name = "Git & GitHub", Level = 70 },
        };
    }
}
