using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{

    class NoteModel : INotifyPropertyChanged
    {

        private string _noteText;

        public NoteModel(string note)
        {
            NoteText = note;
        }

        public string NoteText
        {
            get { return _noteText; }
            set
            {
                _noteText = value;
                RaisePropertyChanged();
            }
        }

        public override string ToString()
        {
            return _noteText;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
