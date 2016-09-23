/// <summary>
/// 
/// </summary>
namespace DataGenerator
{
    using Project1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    public class TestClass
    {

        /// <summary>
        /// Parse json schema and writes into json data file
        /// </summary>
        public void ParseFile()
        {

            DirectoryInfo d = new DirectoryInfo(@"C:\Sneha\Selenium\DataGenerator\DataGenerator\bin\Debug\Schema");
            FileInfo[] Files = d.GetFiles("*.json");
            string str = "";
            foreach (FileInfo file in Files)
            {


                using (StreamReader r = new StreamReader("Schema\\" + file.Name))
                {
                    string json = r.ReadToEnd();
                    var temp = JsonConvert.DeserializeObject<dynamic>(json);
                    Dictionary<string, object> jsonData = new Dictionary<string, object>();

                    foreach (var property in temp.properties)
                    {
                        string name = property.name.ToString();
                        string datatype = property.datatype.ToString();
                        string isarray = property.isArray.ToString();
                        string customobject = property.CustomObject.ToString();

                        switch (datatype)
                        {
                            case "string":
                                jsonData.Add(name, Guid.NewGuid());
                                break;
                            case "int":
                                jsonData.Add(name, GenerateRandomNumber());
                                break;
                            default:
                                break;
                        }
                    }

                    string jsonFile = JsonConvert.SerializeObject(jsonData);

                    File.WriteAllText(file.Name, jsonFile);
                }
            }
        }

        /// <summary>
        /// Generate random non negative integer
        /// </summary>
        /// <returns>integer</returns>
        private static int GenerateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next();
        }
    }

   
}
