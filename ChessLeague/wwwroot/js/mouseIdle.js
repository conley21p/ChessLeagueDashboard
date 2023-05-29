let idleTimeout;

function handleMouseIdle() {
  // Hide buttons or perform any desired action
    console.log("hiding display");
  document.getElementById('buttons-menu').style.display = 'none';
}

function resetIdleTimeout() {
  clearTimeout(idleTimeout);
  idleTimeout = setTimeout(handleMouseIdle, 10000); // 30 seconds (30000 milliseconds)
  document.getElementById('buttons-menu').style.display = 'flex';
}

document.addEventListener('mousemove', resetIdleTimeout);
document.addEventListener('mousedown', resetIdleTimeout);
