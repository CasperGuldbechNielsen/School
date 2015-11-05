using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_5___AppBars.Common;
using Lab_5___AppBars.Model;
using Windows.UI.Popups;

namespace Lab_5___AppBars.ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private static StudentViewModel _studentViewModel;
        private ObservableCollection<Student> _students;
        private Student _selectedStudent;
        private Student _newStudent;
        private int _searchId;

        public RelayCommand AddCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public ObservableCollection<Student> Students
        {
            get { return this._students; }
            set
            {
                this._students = value;
                NotifyPropertyChanged("Students");
            }
        }

        public Student SelectedStudent
        {
            get { return this._selectedStudent; }
            set
            {
                this._selectedStudent = value;
                NotifyPropertyChanged("SelectedStudent");
            }
        }

        public Student NewStudent
        {
            get { return this._newStudent; }
            set
            {

                
                    this._newStudent = value;
                    NotifyPropertyChanged("NewStudent");
                
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public StudentViewModel()
        {
            this.Students = new ObservableCollection<Student>(Student.GetStudents());

            this.NewStudent = new Student();

            this.DeleteCommand = new RelayCommand(command =>
            {
                if (SelectedStudent != null)
                {
                    var foundStudent = Students.Where(x => x.Name == SelectedStudent.Name).FirstOrDefault();
                    Students.Remove(foundStudent);

                    var msgDialog = new MessageDialog("Selected student removed ");
                    msgDialog.ShowAsync();
                }
                else
                {
                    var msgDialog = new MessageDialog("No student selected");
                    msgDialog.ShowAsync();
                }
            });

            this.AddCommand = new RelayCommand(command =>
            {
                Students.Add(NewStudent);
                var msgDialog = new MessageDialog("New student has been created");
                msgDialog.ShowAsync();

                NewStudent = new Student();
            });

            this.SaveCommand = new RelayCommand(command =>
            {
                var msgDialog = new MessageDialog("Student info has now been saved");
                msgDialog.ShowAsync();
                SelectedStudent = null;
            });
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
