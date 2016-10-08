function TestDemo(re, teststring) {
    // Test string for existence of regular expression.
    var found = re.test(teststring)

    // Format the output.
    var s = "";
    s += "'" + teststring + "'"

    if (found)
        s += " contains ";
    else
        s += " does not contain ";

    s += "'" + re.source + "'"
    return (s);
}