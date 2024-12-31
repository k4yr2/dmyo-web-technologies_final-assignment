﻿function updateCards() {
    const containers = document.querySelectorAll('.book-container.line');

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

setInterval(() => {
    updateCards();
}, 0);

$(document).ready(function () {
    // Artı butonuna tıklama olayını dinliyoruz
    $('.book-card .cover .info .add').on('click', function () {
        var bookId = $(this).data('book-id'); 

        $.ajax({
            url: '/account/add-book',
            type: 'POST',
            data: { id: bookId }
        });
    });
});