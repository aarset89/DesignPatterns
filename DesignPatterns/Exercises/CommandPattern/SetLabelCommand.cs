using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.CommandPattern
{
    public class SetLabelCommand : AbstractUndoableCommand
    {
        private string _nextLabel;
        //private History _history;
        //private VideoEditor _videoEditor;

        public SetLabelCommand(VideoEditor videoEditor, History history, string nextLabel)
            :base(videoEditor,history)
        {
            _nextLabel = nextLabel;
        }
        //public void Execute()
        //{
        //    _videoEditor.SetText(_nextLabel);
        //    _history.Push(this);
        //}

        public void Unexecute()
        {
            _editor.RemoveText();
        }

        protected override void DoExecute()
        {
            _editor.SetText(_nextLabel);
        }

        protected override void DoUnexecute()
        {
            _editor.RemoveText();
        }
    }
}
