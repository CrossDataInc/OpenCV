import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.File;
import java.io.IOException;

/**
 * Manages reading and writing CVs in JSON format.
 *
 * <p>Example usage:</p>
 * <pre>
 * {@code
 * CVManager manager = new CVManager();
 * Object cv = manager.readCV("path/to/your/file.json");
 * manager.writeCV(cv, "path/to/new/file.json");
 * }
 * </pre>
 */
public class CVManager {

    /**
     * Reads a CV from a JSON file.
     *
     * @param filePath The path to the JSON file.
     * @return An Object representing the CV.
     * @throws IOException if an I/O error occurs.
     */
    public Object readCV(String filePath) throws IOException {
        ObjectMapper mapper = new ObjectMapper();
        return mapper.readValue(new File(filePath), Object.class);
    }

    /**
     * Writes a CV to a JSON file.
     *
     * @param cv The Object representing the CV.
     * @param filePath The path to the JSON file where the CV will be saved.
     * @throws IOException if an I/O error occurs.
     */
    public void writeCV(Object cv, String filePath) throws IOException {
        ObjectMapper mapper = new ObjectMapper();
        mapper.writerWithDefaultPrettyPrinter().writeValue(new File(filePath), cv);
    }
}
