using sample;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class viewModel : INotifyPropertyChanged
    {

        public ObservableCollection<NoteModel> Notes { get; set; }

        public viewModel()
        {
            Notes = new ObservableCollection<NoteModel>();

            Notes.Add(new NoteModel("Shopping", "Don't forget to buy milk"));
            Notes.Add(new NoteModel("Study", "notetext2"));
            Notes.Add(new NoteModel("Work", "notetext3"));
            Notes.Add(new NoteModel("Game", "notetext4"));
            Notes.Add(new NoteModel("Game123", "notetext45"));
            Notes.Add(new NoteModel("Game345", "notetext86"));

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}