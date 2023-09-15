using CommunityToolkit.Mvvm.ComponentModel;
using StudentProject.Models;
using System.Collections.Generic;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student student;

        [ObservableProperty]
        private List<string> _educationLevels = new EducationLevels().AllEducationLevels;

        [ObservableProperty]
        private string _selectedEducationLevel = string.Empty;

        [ObservableProperty]
        private List<Student> _students = new List<Student>();        

        public StudentViewModel()
        {
            student = new Student();
            _students.Add(new Student("Elek", "Teszt", System.DateTime.Now, 9, SchoolClassType.ClassA, ""));
        }
    }
}
