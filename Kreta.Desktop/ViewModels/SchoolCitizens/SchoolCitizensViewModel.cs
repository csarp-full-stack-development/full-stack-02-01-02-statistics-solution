﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private StudentViewModel _studentViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();
            _studentViewModel = new StudentViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel)
        {
            _studentViewModel = studentViewModel;

            _currentSchoolCitizensChildView= new StudentViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public async Task ShowStudentView()
        {
            await _studentViewModel.InitializeAsync();
            CurrentSchoolCitizensChildView = _studentViewModel;
        }
    }
}
