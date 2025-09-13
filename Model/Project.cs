using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Model
{
    public class Project : INotifyPropertyChanged
    {
        private string projectDescription;
        private string ownerName;
        private string projectMembers;
        private string risks;
        private string functionalRequirements;
        private string nonFunctionalRequirements;

        public string ProjectDescription
        {
            get
            {
                return projectDescription;
            }
            set
            {
                projectDescription = value;
                OnPropertyChanged("ProjectDescription");
            }
        }
        public string OwnerName
        {
            get
            {
                return ownerName;
            }
            set
            {
                ownerName = value;
                OnPropertyChanged("OwnerName");
            }
        }
        public string ProjectMembers
        {
            get
            {
                return projectMembers;
            }
            set
            {
                projectMembers = value;
                OnPropertyChanged("ProjectMembers");
            }
        }

        public string Risks
        {
            get
            {
                return risks;
            }
            set
            {
                risks = value;
                OnPropertyChanged("Risks");
            }
        }
        public string FunctionalRequirements
        {
            get
            {
                return functionalRequirements;
            }
            set
            {
                functionalRequirements = value;
                OnPropertyChanged("FunctionalRequirements");
            }
        }

        public string NonFunctionalRequirements
        {
            get
            {
                return nonFunctionalRequirements;
            }
            set
            {
                nonFunctionalRequirements = value;
                OnPropertyChanged("NonFunctionalRequirements");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
