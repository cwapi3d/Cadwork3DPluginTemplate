using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjectWizard
{
    public class WizardImplementation : IWizard
    {
        private WizardForm inputForm;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                inputForm = new WizardForm();
                inputForm.ShowDialog();

                var pluginAuthorName = WizardForm.pluginAuthorName;
                var pluginAuthorEmail = WizardForm.pluginAuthorEmail;
                var pluginCleanExit = WizardForm.pluginCleanExit;
                var cadworkExePath = WizardForm.cadworkExePath;
                var cadworkUserprofilPath = WizardForm.cadworkUserprofilPath;

                replacementsDictionary.Add("$cwtodaydate$", pluginAuthorName);
                replacementsDictionary.Add("$cwauthorname$", pluginAuthorName);
                replacementsDictionary.Add("$cwauthoremail$", pluginAuthorEmail);
                replacementsDictionary.Add("$cwplugincleanexit$", pluginCleanExit);
                replacementsDictionary.Add("$cwexepath$", cadworkExePath);
                replacementsDictionary.Add("$cwuserprofilepath$", cadworkUserprofilPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
