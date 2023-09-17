using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentProject.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Navigation;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        // https://egvijayanand.in/2022/04/22/mvvm-made-easy/

        [ObservableProperty]
        private Student _selectedStudent;

        [ObservableProperty]
        private ObservableCollection<string> _educationLevels = new ObservableCollection<string>(new EducationLevels().AllEducationLevels);

    
        private string _selectedEducationLevel = string.Empty;

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public StudentViewModel()
        {
            SelectedStudent = new Student();
            Students.Add(new Student("Elek", "Teszt", System.DateTime.Now, 9, SchoolClassType.ClassA, ""));
        }

        [RelayCommand]
        public void DoSave(Student newStudent)
        {
            Students.Add(newStudent);
            OnPropertyChanged(nameof(Students));
        }

        [RelayCommand]
        public void DoRemove(Student studentToDelete)
        {
            Students.Remove(studentToDelete);
            OnPropertyChanged(nameof(Students));            
        }

        [RelayCommand] void DoNewStudent()
        {
            SelectedStudent = new Student();
        }
    }
}
