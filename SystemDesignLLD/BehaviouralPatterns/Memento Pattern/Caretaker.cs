using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDesignLLD.BehaviouralPatterns.Momento_Pattern;

namespace SystemDesignLLD.BehaviouralPatterns.Memento_Pattern
{
    //Caretaker Class: Manage mementos (snapshots of the TextEditor state)
    public class Caretaker
    {
        private readonly Stack<EditorMemento> history = new Stack<EditorMemento>();

        public void saveState(TextEditor editor)
        {
            history.Push(editor.save());
        }
        public void undo(TextEditor editor) {
            if (history !=null)
            {
                history.Pop();
                editor.restore(history.Peek());
            }
        }

    }
}
