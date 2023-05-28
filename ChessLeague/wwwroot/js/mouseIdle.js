let idleTimeout;

function handleMouseIdle() {
  // Hide buttons or perform any desired action
    console.log("hiding display");
  // document.getElementById('buttons-menu').style.display = 'none';
}

function resetIdleTimeout() {
  clearTimeout(idleTimeout);
  idleTimeout = setTimeout(handleMouseIdle, 30000); // 30 seconds (30000 milliseconds)
}

document.addEventListener('mousemove', resetIdleTimeout);
document.addEventListener('mousedown', resetIdleTimeout);
