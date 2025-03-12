using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.Template_Pattern
{


    abstract class DataParser
    {
        public void Parse()
        {
            openFile();
            ParseData();
            closeFile();
        }
        protected virtual void openFile()
        {
            Console.WriteLine("Opening file");
        }

        protected virtual void closeFile()
        {
            Console.WriteLine("Closing file");
        }

        protected abstract void ParseData();
    }

    class CSVParser : DataParser
    {
        protected override void ParseData()
        {
            Console.WriteLine("CSV processing data");
        }
    }
    class JsonParser : DataParser
    {
        protected override void ParseData()
        {
            Console.WriteLine("Json processing data");
        }
    }

    public class TemplatePattern
    {
        public void MainMethod()
        {
            DataParser csvParser = new CSVParser();
            DataParser jsonParser = new JsonParser();

            csvParser.Parse();
            jsonParser.Parse();
        }
    }
}
