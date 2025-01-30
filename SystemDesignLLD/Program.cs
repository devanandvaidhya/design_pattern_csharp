// See https://aka.ms/new-console-template for more information
using SystemDesignLLD.BehaviouralPatterns.Memento_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Momento_Pattern;


//Memento pattern

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

//-----------------End---------------------