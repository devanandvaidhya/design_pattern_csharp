// See https://aka.ms/new-console-template for more information
using SystemDesignLLD.BehaviouralPatterns.Memento_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Momento_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Observer_Pattern;


//Memento pattern

//TextEditor editor = new TextEditor();
//Caretaker caretaker = new Caretaker();
//editor.write("A");
//caretaker.saveState(editor);

//editor.write("B");
//caretaker.saveState(editor);

//editor.write("C");
//caretaker.saveState(editor);

//caretaker.undo(editor);
////Console.WriteLine(editor.getContent());

//caretaker.undo(editor);
//Console.WriteLine(editor.getContent());

//-----------------End-------------------

//---Observer pattern-----------

WeatherStation weatherStation = new WeatherStation();
Mobile mobile = new Mobile("Samsung");
Tablet tablet = new Tablet("VIVO");

weatherStation.attach(tablet);
weatherStation.attach(mobile);

weatherStation.setTemperature(10);
weatherStation.setTemperature(20);

weatherStation.detach(tablet);
weatherStation.setTemperature(5);
