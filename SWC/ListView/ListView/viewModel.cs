using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ListView
{
    class viewModel : INotifyPropertyChanged
    {

        private string note;

        public ObservableCollection<NoteModel> Notes { get; set; }

        public viewModel()
        {
            Notes = new ObservableCollection<NoteModel>();

            Notes.Add(new NoteModel("One"));
            Notes.Add(new NoteModel("Two"));
            Notes.Add(new NoteModel("Three"));
        }

        public void AddNotes(string input)
        {
            Notes.Add(new NoteModel(input));
            RaisePropertyChanged(input);
        }

        public void RemoveNote(int note)
        {
            Notes.RemoveAt(note);
        }

        public void RemoveAll()
        {
            Notes.Clear();
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
