var canvas = document.getElementById('ball-field'),
    ctx = canvas.getContext('2d'),
    x = 350,
    y = 100,
    r = 20,
    positionX = 1,
    positionY = 1;

ctx.strokeStyle = "darkblue";
ctx.fillStyle = "darkgreen";
ctx.lineWidth = 2;

(function flyingBall() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    ctx.beginPath();
    ctx.arc(x, y, r, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();

    if (x + r >= canvas.width || x <= r) {
        positionX *= -1;
    }

    if (y + r >= canvas.height || y <= r) {
        positionY *= -1;
    }

    x += 6 * positionX;
    y += 6 * positionY;

    requestAnimationFrame(flyingBall);
}());