using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class NoteModel : INotifyPropertyChanged
    {

        private string _noteText;
        private string _subject;
        private DateTime _dateTime;

        public string NoteText
        {
            get { return _noteText; }
            set
            {
                _noteText = value;
                RaisePropertyChanged("NoteText");
            }
        }

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                RaisePropertyChanged("Subject");
            }
        }

        public DateTime Datetime { get; set; }

        public NoteModel(string subject, string noteText)
        {
            Subject = subject;
            NoteText = noteText;
            Datetime = DateTime.Now;
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
