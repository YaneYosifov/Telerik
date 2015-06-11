function solve(params) {
    var s = +params[0], c1 = +params[1], c2 = +params[2], c3 = +params[3];
    var currMaxMoney = 0,
        finalMaxMoney = 0;

    for (var i = 0; i <= (s / c1) + 1; i++) {
        for (var j = 0; j <= (s / c2) + 1; j++) {
            for (var k = 0; k <= (s / c3) + 1; k++) {
                currMaxMoney = k * c3 + j * c2 + i * c1;
                if (currMaxMoney <= s) {
                    if (currMaxMoney > finalMaxMoney) {
                        finalMaxMoney = currMaxMoney;
                    }
                } else {
                    break;
                }
            }
        }
    }
    return finalMaxMoney;
}