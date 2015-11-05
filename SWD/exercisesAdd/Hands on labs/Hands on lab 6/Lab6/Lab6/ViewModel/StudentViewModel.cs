using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Web.Http;
using Lab6.Common;
using Lab6.Model;
using Windows.UI.Popups;
using Newtonsoft.Json.Linq;

namespace Lab6.ViewModel
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
            var client = new HttpClient();
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            var t = client.GetAsync(new Uri("http://peterlevinsky.azurewebsites.net/api/student")).AsTask();
            t.ContinueWith(r =>
            {
                try
                {
                    var result = r.Result;

                    List<Student> parsed = new List<Student>();
                    JArray a = JArray.Parse(r.Result.Content.ToString()); // nuget json

                    var q = a.Children<JObject>().Select(s => new Student()
                    {
                        Id = s.GetValue("Id").ToString(),
                        Name = s.GetValue("Name").ToString(),
                        Age = s.GetValue("Age").ToString()
                    });

                this.Students = new ObservableCollection<Student>(q);


                }
                catch (Exception e)
                {
                    
                }

            }, uiScheduler).ContinueWith(e =>
            {
                var ex = e.Exception;
            }, TaskContinuationOptions.OnlyOnFaulted);


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

            this.AddCommand = new RelayCommand(async command =>
            {
                Students.Add(NewStudent);
                var msgDialog = new MessageDialog("New student has been created");
                await msgDialog.ShowAsync();

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
