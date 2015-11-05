using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Model
{
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private string _age;
        private string _Id;


        public string Id
        {
            get { return this._Id; }
            set
            {
                this._Id = value;
                NotifyPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return this._name; }
            set
            {
                this._name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Age
        {
            get { return this._age; }
            set
            {
                this._age = value;
                NotifyPropertyChanged("Age");
            }
        }

        public static Student[] GetStudents()
        {
            return new[]
            {
                new Student {Age = "12", Name = "Bob B"},
                new Student {Age = "12", Name = "William K"},
                new Student {Age = "13", Name = "Alice S"},
                new Student {Age = "12", Name = "Martin M"},
                new Student {Age = "13", Name = "Alma R"},
                new Student {Age = "12", Name = "Robin H"},
                new Student {Age = "11", Name = "David B"},
                new Student {Age = "14", Name = "Jessy S"},
                new Student {Age = "11", Name = "Kevin M"}
            };
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
