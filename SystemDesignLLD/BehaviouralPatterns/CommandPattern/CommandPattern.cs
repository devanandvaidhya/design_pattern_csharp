using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.CommandPattern
{
    public class CommandPattern
    {
    }

    public interface Command {
        void execute();
    }
    public class BoldCommand : Command
    {
        private TextEditors textEditor;
        public BoldCommand(TextEditors textEditor)
        {
            this.textEditor = textEditor;
        }
        public void execute()
        {
            textEditor.BoldText();
        }
    }

    public class ItalicCommand : Command
    {
        private TextEditors textEditor;
        public ItalicCommand(TextEditors textEditor)
        {
            this.textEditor = textEditor;
        }
        public void execute()
        {
            textEditor.ItalicText();
        }
    }


    public class TextEditors
    {

        public void BoldText()
        {
            Console.WriteLine("Text bold");
        }
        public void ItalicText()
        {
            Console.WriteLine("Text Italic");
        }
        public void ChangeTextColor()
        {
            Console.WriteLine("Changed Text color");
        }
    }

    public class Button {
        private Command command;

        public void setCommand( Command command)
        {
            this.command = command;
        }

        public void click() {
            this.command.execute();
        }


    }
}
