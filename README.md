# Harish Portfolio — ASP.NET Core

A personal portfolio website built with **ASP.NET Core MVC**, hosted on **Render.com**.

## Run Locally

```bash
dotnet run
```
Then open: https://localhost:5001

## Project Structure

```
HarishPortfolio/
├── Controllers/HomeController.cs   ← sends data to the view
├── Models/PortfolioData.cs         ← edit your info/projects here
├── Views/Home/Index.cshtml         ← the HTML page
├── wwwroot/css/site.css            ← all styling
├── wwwroot/js/site.js              ← scroll animations
├── wwwroot/images/                 ← drop your images here
├── Dockerfile                      ← for Render.com hosting
└── render.yaml                     ← Render config
```

## How to Personalise

1. **Your info** → edit `Models/PortfolioData.cs`
2. **Your photo** → put `profile.jpg` in `wwwroot/images/` and uncomment the `<img>` tag in `Index.cshtml`
3. **Project images** → put `bft.jpg`, `tvns.jpg`, `bis.jpg`, `polyx.jpg` in `wwwroot/images/`

## Deploy to Render.com (Free)

See full guide in the deployment instructions.
