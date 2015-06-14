function solve(args) {
    var result,
        text = args[0],
        offset = +args[1],
        ALPHABET = 'abcdefghijklmnopqrstuvwxyz',
        CYPHERKEY = ALPHABET.slice(ALPHABET.length - offset) + ALPHABET.slice(0, ALPHABET.length - offset),
        count = 1,
        compressed = '',
        encrypted = '',
        sum = 0,
        product = 1,
        i;

    for (i = 0; i < text.length; i++) {
        if (text[i] === text[i + 1]) {
            count++;
        } else if (text[i] !== text[i + 1] && count > 2) {
            compressed += count + text[i];
            count = 1;
        } else if (text[i] !== text[i + 1] && count === 2) {
            compressed += text[i] + text[i];
            count = 1;
        } else {
            compressed += text[i];
        }
    }

    for (i = 0; i < compressed.length; i++) {
        if (isNaN(compressed[i])) {
            encrypted += compressed[i].charCodeAt(0) ^ CYPHERKEY[ALPHABET.indexOf(compressed[i])].charCodeAt(0);
        } else {
            encrypted += compressed[i];
        }
    }

    for (i = 0; i < encrypted.length; i++) {
        if (!(encrypted[i] % 2)) {
            sum += +encrypted[i];
        } else {
            product *= +encrypted[i];
        }

    }

    console.log(sum);
    console.log(product);
}