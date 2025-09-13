using ProjectManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using ProjectManagementSystem.Utils;

namespace ProjectManagementSystem.ViewModel
{
    public class ProjectViewModel
    {
        private ObservableCollection<Project> projectList;
        public ProjectViewModel()
        {
            projectList = new ObservableCollection<Project>();
        }

        public ICommand AddProjectButtonCommand => new RelayCommand(action => addProject(), canExecute => true);

        public ObservableCollection<Project> Projects
        {
            get { return projectList; }
            set { projectList = value; }
        }


        private string projectDescriptionTextbox;
        public string ProjectDescriptionTextbox
        {
            get { return projectDescriptionTextbox; }
            set { projectDescriptionTextbox = value; }
        }

        private string ownerNameTextbox;
        public string OwnerNameTextbox
        {
            get { return ownerNameTextbox; }
            set { ownerNameTextbox = value; }
        }

        private string projectMembersTextbox;
        public string ProjectMembersTextbox
        {
            get { return projectMembersTextbox; }
            set { projectMembersTextbox = value; }
        }

        private string risksTextbox;
        public string RisksTextbox
        {
            get { return risksTextbox; }
            set { risksTextbox = value; }
        }

        private string functionalReqTextbox;
        public string FunctionalRequirementsTextbox
        {
            get { return functionalReqTextbox; }
            set { functionalReqTextbox = value; }
        }

        private string nonFunctionalReqTextbox;
        public string NonFunctionalRequirementsTextbox
        {
            get { return nonFunctionalReqTextbox; }
            set { nonFunctionalReqTextbox = value; }
        }

        public void addProject()
        {
            if (!checkMissingFields())
            {
                Project newProject = new Project()
                {
                    ProjectDescription = ProjectDescriptionTextbox,
                    OwnerName = OwnerNameTextbox,
                    ProjectMembers = ProjectMembersTextbox,
                    Risks = RisksTextbox,
                    FunctionalRequirements = FunctionalRequirementsTextbox,
                    NonFunctionalRequirements = NonFunctionalRequirementsTextbox,
                };

                projectList.Add(newProject);
            }
            else
            {
                MessageBoxResult missingFields = MessageBox.Show("There are missing fields, please populate all fields before adding a project!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool checkMissingFields()
        {
            if (ownerNameTextbox == null || projectDescriptionTextbox == null || projectMembersTextbox == null || risksTextbox == null
                || functionalReqTextbox == null || nonFunctionalReqTextbox == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
