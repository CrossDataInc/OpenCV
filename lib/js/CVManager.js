const fs = require('fs');

/**
 * Reads a CV from a JSON file.
 * 
 * @param {string} filePath - The path to the JSON file.
 * @returns {Object} - An object representing the CV.
 * 
 * @example
 * const cv = readCV('path/to/your/file.json');
 */
function readCV(filePath) {
    const json = fs.readFileSync(filePath, 'utf8');
    return JSON.parse(json);
}

/**
 * Writes a CV to a JSON file.
 * 
 * @param {Object} cv - An object representing the CV.
 * @param {string} filePath - The path to the JSON file where the CV will be saved.
 * 
 * @example
 * writeCV(cv, 'path/to/new/file.json');
 */
function writeCV(cv, filePath) {
    const json = JSON.stringify(cv, null, 4);
    fs.writeFileSync(filePath, json, 'utf8');
}

/**
 * Example usage:
 * 
 * const cv = readCV('path/to/your/file.json');
 * writeCV(cv, 'path/to/new/file.json');
 */
