document.addEventListener("DOMContentLoaded", () => {

    // ── Hamburger menu toggle ──────────────
    const toggle = document.getElementById("nav-toggle");
    const navLinks = document.getElementById("nav-links");

    if (toggle && navLinks) {
        toggle.addEventListener("click", () => {
            navLinks.classList.toggle("open");
        });
        // Close menu when a link is clicked
        navLinks.querySelectorAll("a").forEach(link => {
            link.addEventListener("click", () => navLinks.classList.remove("open"));
        });
    }

    // ── Animate skill bars on scroll ──────
    const fills = document.querySelectorAll(".skill-fill");
    const skillObserver = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.style.width = entry.target.dataset.width;
                skillObserver.unobserve(entry.target);
            }
        });
    }, { threshold: 0.3 });

    fills.forEach(fill => {
        const target = fill.style.width;
        fill.style.width = "0%";
        fill.dataset.width = target;
        skillObserver.observe(fill);
    });

    // ── Active nav highlight on scroll ────
    const sections = document.querySelectorAll("section[id]");
    const links = document.querySelectorAll(".nav-links a");
    const sectionObserver = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                links.forEach(link => {
                    link.style.color = "";
                    if (link.getAttribute("href") === "#" + entry.target.id)
                        link.style.color = "var(--accent)";
                });
            }
        });
    }, { rootMargin: "-40% 0px -40% 0px" });

    sections.forEach(s => sectionObserver.observe(s));
});