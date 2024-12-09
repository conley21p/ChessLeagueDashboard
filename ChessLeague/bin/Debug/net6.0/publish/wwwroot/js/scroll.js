window.addEventListener('mousemove', function() {
    clearTimeout(window.mouseIdleTimeout);
    window.mouseIdleTimeout = setTimeout(function() {
        window.dispatchEvent(new Event('mouseidle'));
    }, 30000);
});
