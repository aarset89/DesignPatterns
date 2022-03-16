using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.CommandPattern
{
    public class SetContrastCommand: AbstractUndoableCommand
    {
        private float _prevContrast;
        private float _nextContrast;
        //private History _history;
        //private VideoEditor _videoEditor;

        public SetContrastCommand(VideoEditor videoEditor, History history, float nextContrast)
            :base(videoEditor,history)
        {
            //_videoEditor = videoEditor;
            //_history = history;
            _nextContrast = nextContrast;
        }

        //public void Execute()
        //{
        //    _prevContrast = _videoEditor.GetContrast();

        //    _videoEditor.SetContrast(_nextContrast);

        //    _history.Push(this);
        //}

        //public void Unexecute()
        //{
        //    _videoEditor.SetContrast(_prevContrast);
        //}

        protected override void DoExecute()
        {
            _prevContrast = _editor.GetContrast();

            _editor.SetContrast(_nextContrast);
        }

        protected override void DoUnexecute()
        {
            _editor.SetContrast(_prevContrast);
        }
    }
}
