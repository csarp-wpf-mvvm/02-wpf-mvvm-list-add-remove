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

        public StudentViewModel()
        {
            student = new Student();
        }
    }
}
