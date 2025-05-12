document.addEventListener('DOMContentLoaded', function() {
    // Toggle menu functionality
    const hamburger = document.querySelector('.hamburger-icon');
    const navMenu = document.querySelector('.nav-menu');
    
    hamburger.addEventListener('click', function() {
        navMenu.classList.toggle('visible');
        const isExpanded = hamburger.getAttribute('aria-expanded') === 'true';
        hamburger.setAttribute('aria-expanded', !isExpanded);
    });

    // Close menu when clicking outside
    document.addEventListener('click', function(event) {
        if (!event.target.closest('nav') && navMenu.classList.contains('visible')) {
            navMenu.classList.remove('visible');
            hamburger.setAttribute('aria-expanded', 'false');
        }
    });

    // Close menu when a link is clicked
    const navLinks = document.querySelectorAll('.nav-menu a');
    navLinks.forEach(link => {
        link.addEventListener('click', function() {
            navMenu.classList.remove('visible');
            hamburger.setAttribute('aria-expanded', 'false');
        });
    });
});