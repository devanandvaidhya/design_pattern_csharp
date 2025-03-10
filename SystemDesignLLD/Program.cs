﻿// See https://aka.ms/new-console-template for more information
using SystemDesignLLD.BehaviouralPatterns.CommandPattern;
using SystemDesignLLD.BehaviouralPatterns.Mediator_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Memento_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Momento_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Observer_Pattern;
using SystemDesignLLD.BehaviouralPatterns.State_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Strategy_Pattern;
using SystemDesignLLD.BehaviouralPatterns.Template_Pattern;
using SystemDesignLLD.Creational_Patterns.Abstract_Factory_Patterns;
using SystemDesignLLD.Creational_Patterns.Builder_Patterns;
using SystemDesignLLD.Creational_Patterns.Factory_Patterns;
using SystemDesignLLD.Creational_Patterns.Prototype_Patterns;
using SystemDesignLLD.Creational_Patterns.Singleton_Pattern;
using SystemDesignLLD.StructuralPatterns.Adapter_Patterns;
using SystemDesignLLD.StructuralPatterns.Composite_Patterns;
using SystemDesignLLD.StructuralPatterns.Decorator_Patterns;
using SystemDesignLLD.StructuralPatterns.Proxy_Patterns;


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

//-----------------End-----------------------------------------------------------------------------------------------------------

//---Observer pattern-----------

//WeatherStation weatherStation = new WeatherStation();
//Mobile mobile = new Mobile("Samsung");
//Tablet tablet = new Tablet("VIVO");

//weatherStation.attach(tablet);
//weatherStation.attach(mobile);

//weatherStation.setTemperature(10);
//weatherStation.setTemperature(20);

//weatherStation.detach(tablet);
//weatherStation.setTemperature(5);

//--------End---------------------------------------------------------------------------------------------------------------------------------

// ------------------Strategy Pattern--------------------------------

//// Single responsibility , open close imlementation
//PaymentService paymentService = new PaymentService();
////paymentService.setPayment(new CreditCard());
////paymentService.setPayment(new DebitCard());
////added new UPI payment method 

//paymentService.setPayment(new UPI());
//paymentService.payment();

//----------------------------------End----------------------------------------------------------------------------------------------------
//--------------------------Command Pattern--------------------------------------------

//TextEditors textEditors = new TextEditors();
//Button button = new Button();
//button.setCommand(new BoldCommand(textEditors));
//button.click();
//button.setCommand(new ItalicCommand(textEditors));
//button.click();
//---------------------------------END-----------------------------------------------------------

//Template Pattern

//DataParser csvParser = new CSVParser();
//DataParser jsonParser = new JsonParser();

//csvParser.Parse();
//jsonParser.Parse();

//------------------------------------END----------------------------------------------------------

// State Pattern

//TransportationService transportationService = new TransportationService(new Cycling());

//Console.WriteLine("ETA:" + transportationService.getETA());
//Console.WriteLine("Direction:" + transportationService.GetDirection());

//transportationService.setTransportationMode(new Car());

//Console.WriteLine("ETA:" + transportationService.getETA());
//Console.WriteLine("Direction:" + transportationService.GetDirection());
//------------------------------------------End--------------------------------------------------------------------

// Mediator Pattern 

//MediatorPattern mediatorPattern = new MediatorPattern();

//mediatorPattern.MainMethod();
// -----------------------------End------------------------------------------------------------------

// Singletone Pattern

//SignletonePattern signletonePattern = new SignletonePattern();

//signletonePattern.MainMethod();

//-------------------END----------------------------------
//Builder Pattern
//BuilderPattern builder = new BuilderPattern();
//builder.MainMethod();
//-------------------------------END----------------------------------------------------

// Factory Pattern
//FactoryPattern factory = new FactoryPattern();
//factory.MainMethod();
//-----------------------------END-------------------------------------------------------------
// Abstract factory pattern

//AbstractFactoryPattern abstractfactory = new AbstractFactoryPattern();
//abstractfactory.MainMethod();
//-----------------------END------------------------------------------------------
//Prototype pattern
//PrototypePattern prototypePattern = new PrototypePattern();
//prototypePattern.MainMethod();
//--------------End-------------------------------------------------------

//Adapter Pattern
//AdapterPattern adapterPattern = new AdapterPattern();
//adapterPattern.MainMethod();
//--------------------End------------------------------------
// Decorator Pattern
//DecoratorPattern decoratorPattern = new DecoratorPattern();
//decoratorPattern.MainMethod();
//-------------------------End-------------------------------------

// Proxy pattern
//ProxyPattern proxyPattern = new ProxyPattern();
//proxyPattern.MainMethod();
//----------------------End--------------------------------------------

//Composite pattern

CompositePattern compositePattern = new CompositePattern();
compositePattern.MainMethod();
