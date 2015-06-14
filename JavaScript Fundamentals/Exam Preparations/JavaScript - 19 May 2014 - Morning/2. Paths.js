function solve(args) {
    var matrixDirections = args.slice(1).map(function (line) {
            return line.split(' ');
        }),

        col = 0,
        row = 0,
        direction,
        sum = 0,

        bounds = args[0].split(' '),
        matrixNumbers = [];

    for (var i = 0; i < bounds[0]; i++) {
        matrixNumbers[i] = [];
        for (var j = 0; j < bounds[1]; j++) {
            matrixNumbers[i][j] = Math.pow(2, i) + j;
        }
    }

    while (row >= 0 && row < bounds[0] && col >= 0 && col < bounds[1]) {
        sum += matrixNumbers[row][col];
        direction = matrixDirections[row][col];
        matrixDirections[row][col] = 'used';

        switch (direction) {
            case 'dr': row++; col++; break;
            case 'ur': row--; col++; break;
            case 'ul': row--; col--; break;
            case 'dl': row++; col--; break;
            case 'used': return 'failed at (' + row + ', ' + col + ')';
        }
    }
    return 'successed with ' + sum;
}