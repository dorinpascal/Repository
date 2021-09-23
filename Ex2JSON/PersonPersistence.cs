using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Ex2JSON
{
    public class PersonPersistence
    {
        public void StoreObjects(List<Person> persons)
        {
            //Styling the file
            /*string objAsJson = JsonSerializer.Serialize(persons,new JsonSerializerOptions
            {
                WriteIndented = true
            });*/
            
            
            //Simple file storage
           string objAsJson = JsonSerializer.Serialize(persons);
            
            
            string[] lines = objAsJson.Split();
            using StreamWriter sw = new StreamWriter("MyLines.txt");
            foreach (string line in lines)
            {
              sw.WriteLine(line);  
            }
        }


        public string ReadObjects()
        {
            StringBuilder sb = new StringBuilder();
            using StreamReader sr = new StreamReader("MyLines.txt");
            string line;
            while ((line=sr.ReadLine())!=null)
            {
                sb.AppendLine(line);
            }

            return sb.ToString();
        }
        
        
    }
}