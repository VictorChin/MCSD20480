self.onmessage = function (e) {
    var n = parseFloat(e.data.number);
    switch (e.data.task) {
        case "DOUBLE":
            setTimeout(self.postMessage, 4000, { result: n * 2 });
            break;
        case "SQUARE":
            self.postMessage({ result: n * n });
            break;
        case "CUBE":
            self.postMessage({ result: n * n * n });
            break;
        case "CLOSE":
            self.postMessage({ result: "I am closing. :-(" });
            self.close();
            break;
        case "ERROR":
            throw new Error("You asked me to throw an error!");
            break;
        default:
            self.postMessage({
                result:
                    "I only understand DOUBLE, SQUARE, CUBE, CLOSE, and ERROR."
            });
    }
}