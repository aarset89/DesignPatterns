using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class ArticlesDialogBox //: DialogBox
    {

        public class ArticleObserver : Observer
        {
            private ArticlesDialogBox _articlesDialogBox;

            public ArticleObserver(ArticlesDialogBox articlesDialogBox)
            {
                _articlesDialogBox = articlesDialogBox;
            }
            public void Update()
            {
                _articlesDialogBox.ArticleSelected();
            }
        }

        private class TitleObserver : Observer
        {
            private ArticlesDialogBox _articlesDialogBox;

            public TitleObserver(ArticlesDialogBox articlesDialogBox)
            {
                _articlesDialogBox = articlesDialogBox;
            }

            public void Update()
            {
                _articlesDialogBox.TitleChanged();
            }
        }



        private ListBox _articleListBox = new ListBox();
        private TextBox _titleTextBox = new TextBox();
        private Button _SaveButton = new Button();

        public ArticlesDialogBox()
        {
            //_articleListBox = new ListBox(this);
            //_titleTextBox = new TextBox(this);
            //_SaveButton = new Button(this);
            _articleListBox.AddObserver(new ArticleObserver(this));
            _titleTextBox.AddObserver(new TitleObserver(this));

        }

        public void Simulation()
        {
            _articleListBox.SetSelection("Article 1");
            Console.WriteLine("Textbox " + _titleTextBox.GetContent());
            Console.WriteLine("SaveButton " + _SaveButton.IsEnabled());
            _titleTextBox.SetContent("");
            Console.WriteLine("Textbox " + _titleTextBox.GetContent());
            Console.WriteLine("SaveButton " + _SaveButton.IsEnabled());
            _articleListBox.SetSelection("Article 2");
            Console.WriteLine("Textbox " + _titleTextBox.GetContent());
            Console.WriteLine("SaveButton " + _SaveButton.IsEnabled());
            //_titleTextBox.SetContent("");


        }

        //public override void Changed(UIControl uIControl)
        //{
        //    if (uIControl == _articleListBox)
        //    {
        //        TitleChanged();
        //    } else if (uIControl == _titleTextBox)
        //    {
        //        TitleBoxChanged();
        //    }
        //}

        private void ArticleSelected()
        {
            _titleTextBox.SetContent(_articleListBox.GetSelection());
            _SaveButton.SetEnabled(true);
        }

        private void TitleChanged()
        {
            var content = _titleTextBox.GetContent();
            var isEmpty = (string.IsNullOrWhiteSpace(content));
            _SaveButton.SetEnabled(!isEmpty);
        }
    }
}
