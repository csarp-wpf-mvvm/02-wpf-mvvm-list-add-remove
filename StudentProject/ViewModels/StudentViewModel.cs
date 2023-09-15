using CommunityToolkit.Mvvm.ComponentModel;
using StudentProject.Models;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student student;

        public StudentViewModel()
        {
            student = new Student();
        }
    }
}
