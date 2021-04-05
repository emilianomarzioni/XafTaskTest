using XafTasks.Module.BusinessObjects;
namespace XafTasks.Module.Controllers
{
    partial class TaskController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Print = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // Print
            // 
            this.Print.Caption = "Print";
            this.Print.ConfirmationMessage = null;
            this.Print.Id = "PrintAction";
            this.Print.TargetObjectsCriteria = "Not IsCurrentUserInRole(\'Default\')";
            this.Print.TargetObjectType = typeof(XafTasks.Module.BusinessObjects.Category);
            this.Print.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Print.ToolTip = null;
            this.Print.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Print.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Print_Execute);
            // 
            // TaskController
            // 
            this.Actions.Add(this.Print);

        }
        private DevExpress.ExpressApp.Actions.SimpleAction Print;

    }
}
