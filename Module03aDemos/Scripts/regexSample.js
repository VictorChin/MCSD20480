/// <reference path="jquery-1.7.1-intelli.js" />

function TestDemo(re, teststring) {
   $.ajax()
    var somethingElse;
    var another;
    // Test string for existence of regular expression.
    var found = re.test(teststring)
    somethingElse = "12345";
    another = window.somethingElse;
    // Format the output.
    var s = "";
    s += "'" + teststring + "'"

    if (found)
        s += " contains ";
    else
        s += " does not contain ";

    s += "'" + re.source + "'"
    var xyz;
    return (s);
}