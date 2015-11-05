using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    internal class ViewModel : INotifyPropertyChanged
    {

        private Model _newModel;
        private Model _selectedElementModel;

        private ObservableCollection<Model> _models;

        public ViewModel()
        {
            _models = new ObservableCollection<Model>();

            _models.Add(new Model() {Age = 24, ID = 124345, Name = "Casper"});
            _models.Add(new Model() {Age = 26, ID = 1545, Name = "Sven"});
            _models.Add(new Model() {Age = 28, ID = 123242, Name = "Bent"});
            
        }

        public ObservableCollection<Model> Models
        {
            get { return _models; }
            set
            {
                _models = value;
                RaisePropertyChanged("Models");
            }
        }

        public Model NewModel
        {
            get { return _newModel; }
            set
            {
                _newModel = value;
                RaisePropertyChanged("Model");
            }
        }

        public Model SelectedElementModel
        {
            get { return _selectedElementModel; }
            set
            {
                _selectedElementModel = value;
                RaisePropertyChanged("SelectedElementModel");
            }
        }

        public void AddModel()
        {
            
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
