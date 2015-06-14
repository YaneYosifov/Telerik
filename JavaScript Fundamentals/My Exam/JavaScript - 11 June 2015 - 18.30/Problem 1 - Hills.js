function solve(params) {
    var s = params[0].split(' ').map(function (num) {
            return +num;
        }),
        currRocks = 1,
        maxRocks = 0;

    for (var i = 1; i < s.length - 1; i++)
        if (s[i] > s[i - 1] && s[i] > s[i + 1]) {
            maxRocks = Math.max(currRocks, maxRocks);
            currRocks = 1;
        } else {
            currRocks++;
        }
    return Math.max(currRocks, maxRocks);
}

var tests = [
    ['5 1 7 4 8'],
    ['5 1 7 6 3 6 4 2 3 8'],
    ['10 1 2 3 4 5 4 3 2 1 10']
];

tests.forEach(function (test) {
    console.log(solve(test));
});