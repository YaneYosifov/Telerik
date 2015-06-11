/*
 Problem 7. Parse URL
 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 */

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

function parseUrl(url) {
    var protocol = url.substring(0, url.indexOf('://')),
        server = url.substring(protocol.length + 3, url.indexOf('/', protocol.length + 3)),
        resource = url.substring(protocol.length + 3 + server.length);
    return {
        protocol: protocol,
        server: server,
        resource: resource
    };
}

console.log(parseUrl(url));