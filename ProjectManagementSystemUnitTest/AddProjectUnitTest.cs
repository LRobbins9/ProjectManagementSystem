using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManagementSystem.ViewModel;

namespace ProjectManagementSystemUnitTest
{
    [TestClass]
    public class AddProjectUnitTest
    {
        [TestMethod]
        public void Add_Fully_Populated_Fields_Project_Method()
        {
            //arrange
            ProjectViewModel pvm = new ProjectViewModel();

            pvm.ProjectDescriptionTextbox = "Description of Project";
            pvm.OwnerNameTextbox = "Bob Test";
            pvm.ProjectMembersTextbox = "Member 1, Member 2, Member 3";
            pvm.RisksTextbox = "Project Timeline: Low risk";
            pvm.FunctionalRequirementsTextbox = "This system must allow the user to enter in critical project information";
            pvm.NonFunctionalRequirementsTextbox = "The clear form button should take less than 2 seconds to clear the form.";

            //act
            pvm.addProject();

            //assert
            Assert.IsTrue(pvm.Projects.Count >= 1);
        }

        [TestMethod]
        public void Add_Missing_Fields_Project_Method()
        {
            //arrange
            ProjectViewModel pvm = new ProjectViewModel();

            pvm.ProjectDescriptionTextbox = "Description of Project";
            pvm.OwnerNameTextbox = "Bob Test";
            pvm.ProjectMembersTextbox = "Member 1, Member 2, Member 3";
            pvm.FunctionalRequirementsTextbox = "This system must allow the user to enter in critical project information";

            //act
            pvm.addProject();

            //assert
            Assert.IsTrue(pvm.Projects.Count == 0);
        }

        [TestMethod]
        public void Add_Missing_Fields_Then_Populate_Fields_Project_Method()
        {
            //arrange
            ProjectViewModel pvm = new ProjectViewModel();

            pvm.ProjectDescriptionTextbox = "Description of Project";
            pvm.OwnerNameTextbox = "Bob Test";
            pvm.ProjectMembersTextbox = "Member 1, Member 2, Member 3";
            pvm.FunctionalRequirementsTextbox = "This system must allow the user to enter in critical project information";

            //act
            pvm.addProject();

            //arrange
            pvm.ProjectDescriptionTextbox = "Description of Project";
            pvm.OwnerNameTextbox = "Bob Test";
            pvm.ProjectMembersTextbox = "Member 1, Member 2, Member 3";
            pvm.RisksTextbox = "Project Timeline: Low risk";
            pvm.FunctionalRequirementsTextbox = "This system must allow the user to enter in critical project information";
            pvm.NonFunctionalRequirementsTextbox = "The clear form button should take less than 2 seconds to clear the form.";

            //act
            pvm.addProject();

            //assert
            Assert.IsTrue(pvm.Projects.Count >= 1);
        }
    }
}
