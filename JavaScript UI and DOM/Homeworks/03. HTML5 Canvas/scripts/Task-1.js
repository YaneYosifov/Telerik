(function () {
    var ctx = document.getElementsByTagName('canvas')[0].getContext('2d');
    function drawOval(x, y, r, scaleX, scaleY, fillStyle, strokeStyle) {
        ctx.fillStyle = fillStyle;
        ctx.strokeStyle = strokeStyle;
        ctx.save();
        ctx.beginPath();
        ctx.scale(scaleX, scaleY);
        ctx.arc(x, y, r, 0, 2 * Math.PI);
        ctx.restore();
        ctx.lineWidth = 3.5;
        ctx.fill();
        ctx.stroke();
    }

    function drawEye(x, y) {
        drawOval(x, y, 17, 1, 0.6, '#90CAD7', '#376570');
        ctx.save();
        ctx.translate(x - 6, y - 146);
        drawOval(0, 0, 11, 0.3, 0.6, '#376570', '#376570');
        ctx.restore();
    }

    // head
    drawOval(130, 280, 100, 1, 0.9, '#90CAD7', '#376570');

    // mouth
    ctx.save();
    ctx.rotate(5 * Math.PI / 180);
    drawOval(140, 870, 37, 1, 0.33, '#90CAD7', '#376570');
    ctx.restore();

    // nose
    ctx.beginPath();
    ctx.moveTo(115, 215);
    ctx.lineTo(95, 260);
    ctx.lineTo(115, 260);
    ctx.stroke();

    // left eye
    drawEye(75, 365);

    // right eye
    drawEye(152, 365);

    // cap
    drawOval(125, 860, 110, 1, 0.2, '#396693', '#241F1A');
    drawOval(132, 375, 55, 1, 0.4, '#396693', '#241F1A');
    ctx.beginPath();
    ctx.lineWidth = 7;
    ctx.moveTo(79, 148);
    ctx.lineTo(79, 45);
    ctx.lineTo(185, 45);
    ctx.lineTo(185, 148);
    ctx.stroke();
    ctx.fill();
    drawOval(132, 110, 55, 1, 0.4, '#396693', '#241F1A');
}());