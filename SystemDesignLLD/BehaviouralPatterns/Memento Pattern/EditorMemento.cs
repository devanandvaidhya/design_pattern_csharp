using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.Momento_Pattern
{
    //Mementor Class: Stores the internal state of the TextEditor
    public class EditorMemento
    {
        private readonly string content;
        public EditorMemento(string content)
        {
            this.content = content;
        }

        public string getContent()
        {
            return content;
        }
    }
}
