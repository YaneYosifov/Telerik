function Solve(arr) {
    for (var index in arr) {
        arr[index] = +arr[index];
    }

    var best = 0, curr = 0;
    for (var i = 1; i < arr.length; i++) {
        curr = Math.max(0, curr + arr[i]);
        best = Math.max(curr, best);
    }

    if (best === 0) {
        return arr.sort()[0];
    }

    return best;
}