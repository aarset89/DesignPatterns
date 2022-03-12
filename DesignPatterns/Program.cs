using DesignPatterns.Exercises.IteratorPattern;
using DesignPatterns.Exercises.Memento;
using DesignPatterns.Exercises.StatePattern;
using DesignPatterns.Exercises.Strategy;
using DesignPatterns.Exercises.TemplateMethod;
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.MethodTemplate;
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

            #region MethodTemplate

            //var tm = new TransferMoney();

            //tm.Execute();

            var win = new Window();

            win.Close();

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
