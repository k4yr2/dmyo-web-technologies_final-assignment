function updateCards() {
    const containers = document.querySelectorAll('.book-container');

    containers.forEach((container) => {
        const cards = container.children;
        const containerWidth = container.offsetWidth;

        const visibleCount = Math.floor(containerWidth / cards[0].offsetWidth);

        Array.from(cards).forEach((item, index) => {
            if (index < visibleCount) {
                item.style.display = 'flex';
            } else {
                item.style.display = 'none';
            }
        });
    });
}

window.addEventListener('resize', updateCards);
window.addEventListener('load', updateCards);