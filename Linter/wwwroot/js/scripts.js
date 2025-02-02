window.observeElement = (elementId) => {
    const element = document.getElementById(elementId);

    const observer = new IntersectionObserver((entries, observer) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add("fade-in");
                observer.unobserve(entry.target);
            }
        });
    }, { threshold: 0.5 });

    observer.observe(element);
};
