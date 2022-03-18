﻿using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.CommandPattern;
using DesignPatterns.CommandPattern.Editor;
using DesignPatterns.CommandPattern.Fx;
using DesignPatterns.Exercises.ChainOfResposibility;
using DesignPatterns.Exercises.CommandPattern;
using DesignPatterns.Exercises.IteratorPattern;
using DesignPatterns.Exercises.Mediator;
using DesignPatterns.Exercises.Memento;
using DesignPatterns.Exercises.ObserverPattern;
using DesignPatterns.Exercises.StatePattern;
using DesignPatterns.Exercises.Strategy;
using DesignPatterns.Exercises.TemplateMethod;
using DesignPatterns.Iterator;
using DesignPatterns.Mediator;
using DesignPatterns.Memento;
using DesignPatterns.MethodTemplate;
using DesignPatterns.Observer;
using DesignPatterns.State;
using DesignPatterns.State.Abuse;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Chain of resposibility

            //var compressor = new Compressor(null);
            ////var logger = new Logger(compressor);
            //var enc = new Encryptor(compressor);
            //var auth = new Authenticator(enc);
            //var server = new WebServer(auth);
            //server.Handle(new HttpRequest { Username = "abc", Password = "123" });


            var excel = new ExcelFormat(null);
            var quick = new QuickBookFormat(excel);
            var Number = new NumbersFormat(quick);
            var dataReader = new DataReader(Number);

            dataReader.Handle(new File { FileName = "asdas.qwbe" });

            #endregion

            //For desktop and mobile applications
            #region MediatorPattern 

            ////var arti = new ArticlesDialogBox();
            ////arti.Simulation();

            //var arti = new SignUpWindow();
            //arti.SimulateBehavior();

            #endregion

            #region ObserverPattern

            #region General
            //var chart = new Chart();
            //var spreadSheet1 = new Spreadsheet();
            //var spreadSheet2 = new Spreadsheet();

            //var ds = new DataSource();

            //ds.AddObserver(chart);
            //ds.AddObserver(spreadSheet1);
            //ds.AddObserver(spreadSheet2);

            //ds.SetValue(2);
            #endregion

            #region pushStyle

            //var chart1 = new Observer.PushStyle.Chart();
            //var spreadSheet11 = new Observer.PushStyle.Spreadsheet();
            //var spreadSheet21 = new Observer.PushStyle.Spreadsheet();

            //var ds1 = new Observer.PushStyle.DataSource();

            //ds1.AddObserver(chart1);
            //ds1.AddObserver(spreadSheet11);
            //ds1.AddObserver(spreadSheet21);

            //ds1.SetValue(2);

            #endregion

            #region pullStyle
            //var ds2 = new Observer.PullStyle.DataSource();

            //var chart2 = new Observer.PullStyle.Chart(ds2);
            //var spreadSheet12 = new Observer.PullStyle.Spreadsheet(ds2);
            //var spreadSheet22 = new Observer.PullStyle.Spreadsheet(ds2);


            //ds2.AddObserver(chart2);
            //ds2.AddObserver(spreadSheet12);
            //ds2.AddObserver(spreadSheet22);

            //ds2.SetValue(2);

            #endregion

            #region ObserverExercise

            //var sb = new StatusBar();
            //var slv = new StockListView();

            //var s = new Stock("one",15f);
            //var s1 = new Stock("two",25f);
            //var s2 = new Stock("three",35f);

            //sb.AddStock(s);
            //sb.AddStock(s1);
            //sb.AddStock(s2);

            //slv.AddStock(s);
            //slv.AddStock(s1);
            //slv.AddStock(s2);

            //s.SetPrice(20f);
            //s1.SetPrice(10f);
            //s2.SetPrice(5f);

            #endregion
            #endregion

            #region CommandPattern

            //var service = new CustomerService();
            //var command = new AddCustomerCommand(service);
            //var button = new Button(command);

            //button.Click();

            #region CompositeCommands

            //var compo = new CompositeCommand();
            //compo.AddCommand(new ResizeCommand());
            //compo.AddCommand(new BackAndWhiteCommand());
            //compo.Execute();

            #endregion

            #region history

            //var history = new CommandPattern.Editor.History();
            //var document = new HtmlDocument();

            //document.SetContent("Hello");
            //Console.WriteLine(document.GetContent());

            //var boldCommand = new BoldCommand(document,history);
            //boldCommand.Execute();
            //Console.WriteLine(document.GetContent());

            ////boldCommand.Unexecute();
            ////Console.WriteLine(document.GetContent());

            //var undoCommand = new UndoCommand(history);
            //undoCommand.Execute();
            //Console.WriteLine(document.GetContent());


            #endregion

            #region exercise

            //var history = new Exercises.CommandPattern.History();
            //var videoEditor = new VideoEditor();

            //videoEditor.SetContrast(0.5f);
            //Console.WriteLine(videoEditor.ToString());

            //var contrastCommand = new SetContrastCommand(videoEditor, history, 1.4f);

            //contrastCommand.Execute();
            //Console.WriteLine(videoEditor.ToString());

            //contrastCommand.Unexecute();
            //Console.WriteLine(videoEditor.ToString());

            //var labelCommand = new SetLabelCommand(videoEditor, history, "new label");
            //labelCommand.Execute();
            //Console.WriteLine(videoEditor.ToString());

            //labelCommand.Unexecute();
            //Console.WriteLine(videoEditor.ToString());

            #endregion

            #endregion

            #region MethodTemplate

            //var tm = new TransferMoney();

            //tm.Execute();

            //var win = new Window();

            //win.Close();

            #endregion

            #region Strategy 
            ////var str = new ImageStorage(new JpegCompressor(), new BandWFilter());

            ////str.Store();

            //var enc = new ChatClient(new Sha256());
            //enc.send("This is a message");


            #endregion

            #region Iterator Pattern

            //var it = new BrowseHistory();
            //it.Push("a");
            //it.Push("b");
            //it.Push("c");
            //it.Push("d");

            //var iterator = it.CreateIterator();

            //while (iterator.HasNext())
            //{
            //    var url = iterator.Current();
            //    Console.WriteLine(url);
            //    iterator.Next();
            //}

            //var pc = new ProductCollection();

            //pc.Push(new Product(1,"one"));
            //pc.Push(new Product(2,"two"));
            //pc.Push(new Product(3,"three"));
            //pc.Push(new Product(4,"four"));

            //var it = pc.CreateIterator();

            //while (it.HasNext())
            //{
            //    var prod = it.Current();
            //    Console.WriteLine(prod.toString());
            //    it.Next();
            //}


            #endregion

            #region StatePatter

            //var canvas = new Canvas();
            //canvas.SetCurrentTool(new SelectionTool());
            //canvas.MouseDown();
            //canvas.MouseUp();

            //canvas.SetCurrentTool(new BrushTool());
            //canvas.MouseDown();
            //canvas.MouseUp();

            //var st = new StopWatch();
            //st.Click();
            //st.Click();
            //st.Click();

            //var ds = new DirectionService(new Walking());
            //ds.GetDirection();
            //ds.GetEta();

            //ds.setTravelMode(new Driving());
            //ds.GetDirection();
            //ds.GetEta();


            #endregion

            #region Memento
            //var ed = new Editor();
            //var hi = new History();
            //ed.SetContent("a");
            //hi.Push(ed.CreateState());
            //ed.SetContent("b");
            //hi.Push(ed.CreateState());
            //ed.SetContent("c");
            //ed.Restore(hi.Pop());
            //Console.WriteLine(ed.GetContent());

            //var ed = new Document();
            //var hi = new DocumentHistory();

            //ed.SetContent("a");
            //hi.Push(ed.CreateState());

            //ed.SetFontName("font1");
            //hi.Push(ed.CreateState());

            //ed.SetFontSize(1);

            //Console.WriteLine(ed.toString());

            //ed.Restore(hi.Pop());
            //Console.WriteLine(ed.toString());

            //ed.Restore(hi.Pop());
            //Console.WriteLine(ed.toString());
            #endregion

            Console.ReadLine();

        }
    }
}
