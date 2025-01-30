using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.Momento_Pattern
{
    public class TextEditor
    {
        private string content;

        public void write(string content)
        { 
            this.content = content; 
        }

        //save current state of editor
        public EditorMemento save()
        {
            return new EditorMemento(content);
        }
        //Restore 
        public void restore(EditorMemento memento)
        {
            content = memento.getContent();
        }
        public string getContent()
        {
            return content;
        }



    }
}
