function solve(args) {
    var matrixDirections = args.slice(1).map(function (line) {
        return line.split('');
    }),

        rowColBounds = args[0].split(' '),
        row = rowColBounds[0] - 1,
        col = rowColBounds[1] - 1,
        sum = 0,
        direction,
        counter = 0,
        matrixNumbers = [];

    for (var i = 0; i < rowColBounds[0]; i++) {
        matrixNumbers[i] = [];
        for (var j = 0; j <rowColBounds[1]; j++) {
            matrixNumbers[i][j] = Math.pow(2, i) - j;
        }
    }

    while (row >= 0 && col >= 0 && row < rowColBounds[0] && col < rowColBounds[1]) {
        sum += matrixNumbers[row][col];
        direction = matrixDirections[row][col];
        matrixDirections[row][col] = 'used';

        switch (direction) {
            case '1': row -= 2; col += 1; break;
            case '2': row -= 1; col += 2; break;
            case '3': row += 1; col += 2; break;
            case '4': row += 2; col += 1; break;
            case '5': row += 2; col -= 1; break;
            case '6': row += 1; col -= 2; break;
            case '7': row -= 1; col -= 2; break;
            case '8': row -= 2; col -= 1; break;
            case 'used': return 'Sadly the horse is doomed in ' + counter + ' jumps';
        }
        counter++;
    }

    return 'Go go Horsy! Collected ' + sum + ' weeds';
}