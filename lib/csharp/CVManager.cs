using Newtonsoft.Json;
using System;
using System.IO;

/// <summary>
/// Manages reading and writing CVs in JSON format.
/// </summary>
/// <example>
/// This sample shows how to use the <see cref="CVManager"/> class.
/// <code>
/// CVManager manager = new CVManager();
/// dynamic cv = manager.ReadCV("path/to/your/file.json");
/// manager.WriteCV(cv, "path/to/new/file.json");
/// </code>
/// </example>
public class CVManager
{
    /// <summary>
    /// Reads a CV from a JSON file.
    /// </summary>
    /// <param name="filePath">The path to the JSON file.</param>
    /// <returns>A dynamic object representing the CV.</returns>
    public dynamic ReadCV(string filePath)
    {
        string json = File.ReadAllText(filePath);
        dynamic cv = JsonConvert.DeserializeObject(json);
        return cv;
    }

    /// <summary>
    /// Writes a CV to a JSON file.
    /// </summary>
    /// <param name="cv">The dynamic object representing the CV.</param>
    /// <param name="filePath">The path to the JSON file where the CV will be saved.</param>
    public void WriteCV(dynamic cv, string filePath)
    {
        string json = JsonConvert.SerializeObject(cv, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}

