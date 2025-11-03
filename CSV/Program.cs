class Program {
    public static void Main(string[] args) {
        Matrix matrix1 = new Matrix();
        matrix1.Manipulate();
        matrix1.SaveDataToFile();
    } 

}

class Matrix {
    double[][] data;

    private const string FILENAME = "saveFile.txt";

    public Matrix() {
        data = ReadSaveFile(FILENAME);
    }

    public Matrix(int sizeX, int sizeY) {
        data = new double[sizeX][];
        for (int x = 0; x < data.Length; x++) {
            data[x] = new double[sizeY];
        }

        SaveDataToFile();
    }

    public void Manipulate() {
        for (int i = 0; i < data.Length; i++) {
            for (int j = 0; j < data[i].Length; j++) {
                if (i == j) {
                    data[i][j] = 1;
                }
            }
        }
    }

    public void SaveDataToFile() {
        using (StreamWriter streamWriter = new StreamWriter(FILENAME)) {
            for (int x = 0; x < data.Length; x++) {
                for (int y = 0; y < data[x].Length; y++) {
                    string seperator = y != data[x].Length - 1 ? "," : "";
                    streamWriter.Write(data[x][y] + seperator);
                }
                if (x != data.Length - 1) {
                    streamWriter.WriteLine("");
                }
            }
        }
 
    }

    private double[][] ReadSaveFile(string fileName) {
        double[][] data = new double[10][];

        if (File.Exists(fileName)) {
            using (StreamReader streamReader = new StreamReader(fileName)) {

                string? line = "";
                int lineAmount = 0;
                do {
                    line = streamReader.ReadLine(); 
                    if (line == null) break;
                    string[] splited = line.Split(",");
                    
                    double[] lineValues = new double[splited.Length];
                    for (int i = 0; i < splited.Length; i++) {
                        if (double.TryParse(splited[i], out double value)) {
                            lineValues[i] = value;
                        }
                    }

                    data[lineAmount++] = lineValues;

                    Console.WriteLine("Line" + line);
                } while (line != null);
                
            
            }
           
        }

        return data;
    }
}