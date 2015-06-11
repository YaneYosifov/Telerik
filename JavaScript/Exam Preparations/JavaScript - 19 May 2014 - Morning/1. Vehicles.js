function solve(params) {
    var s = +params[0];
    var count = 0;

    for (var i = 0; i <= s / 10; i += 1) {
        for (var j = 0; j <= s / 4; j += 1) {
            for (var k = 0; k <= s / 3; k += 1) {
                if (k * 3 + j * 4 + i * 10 === s) {
                    count += 1;
                }
            }
        }
    }
    return count;
}