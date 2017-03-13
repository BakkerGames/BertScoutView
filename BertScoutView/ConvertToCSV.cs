using Common.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertScoutView
{
    static class ConvertToCSV
    {
        static public void OutputCSV(string inPath, string outPath)
        {
            JSONObject inObj = JSONObject.FromString(File.ReadAllText(inPath));
            //Console.WriteLine(inArray.ToString());
            bool firstLine = true;
            bool addComma = false;
            JSONArray inArray;
            StringBuilder outData = new StringBuilder();
            if (inObj.ContainsKey("data"))
            {
                inArray = (JSONArray)inObj["data"];
            }
            else if (inObj.ContainsKey("stand_data"))
            {
                inArray = (JSONArray)inObj["stand_data"];
            }
            else if (inObj.ContainsKey("pit_data"))
            {
                inArray = (JSONArray)inObj["pit_data"];
            }
            else
            {
                return;
            }
            foreach (JSONObject js in inArray)
            {
                if (firstLine)
                {
                    firstLine = false;
                    addComma = false;
                    foreach (string key in js.Keys)
                    {
                        if (addComma)
                        {
                            outData.Append("\t");
                        }
                        else
                        {
                            addComma = true;
                        }
                        outData.Append(key);
                    }
                    outData.AppendLine();
                }
                addComma = false;
                foreach (object obj in js.Values)
                {
                    if (addComma)
                    {
                        outData.Append("\t");
                    }
                    else
                    {
                        addComma = true;
                    }
                    outData.Append(obj.ToString().Replace("\r", " ").Replace("\n", " ").Replace("\t", " "));
                }
                outData.AppendLine();
            }
            File.WriteAllText(outPath, outData.ToString());
        }
    }

}
