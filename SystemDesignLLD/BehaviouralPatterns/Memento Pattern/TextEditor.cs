using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDesignLLD.BehaviouralPatterns.Memento_Pattern;

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

    public class MementoPattern
    {
        public void MainMethod()
        {
            
            TextEditor editor = new TextEditor();
            Caretaker caretaker = new Caretaker();
            editor.write("A");
            caretaker.saveState(editor);

            editor.write("B");
            caretaker.saveState(editor);

            editor.write("C");
            caretaker.saveState(editor);

            caretaker.undo(editor);
            //Console.WriteLine(editor.getContent());

            caretaker.undo(editor);
            Console.WriteLine(editor.getContent());
        }
    }
}
