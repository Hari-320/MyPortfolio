// Animate skill bars on scroll into view
document.addEventListener("DOMContentLoaded", () => {
    const fills = document.querySelectorAll(".skill-fill");

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.style.width = entry.target.dataset.width || entry.target.style.width;
                observer.unobserve(entry.target);
            }
        });
    }, { threshold: 0.3 });

    fills.forEach(fill => {
        const target = fill.style.width;
        fill.style.width = "0%";
        fill.dataset.width = target;
        observer.observe(fill);
    });

    // Active nav link on scroll
    const sections = document.querySelectorAll("section[id]");
    const navLinks = document.querySelectorAll(".nav-links a");

    const sectionObserver = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                navLinks.forEach(link => {
                    link.style.color = "";
                    if (link.getAttribute("href") === "#" + entry.target.id) {
                        link.style.color = "var(--accent)";
                    }
                });
            }
        });
    }, { rootMargin: "-40% 0px -40% 0px" });

    sections.forEach(section => sectionObserver.observe(section));
});
