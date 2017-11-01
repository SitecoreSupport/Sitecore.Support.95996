using Sitecore.Diagnostics;
using Sitecore.Shell;
using System;

namespace Sitecore.Support.Shell.Applications.ContentManager.Dialogs.ResetFields
{
    public class ResetFieldsForm : Sitecore.Shell.Applications.ContentManager.Dialogs.ResetFields.ResetFieldsForm
    {
        protected override void OnLoad(EventArgs e)
        {
            Assert.ArgumentNotNull(e, "e");
            bool renderCollapsedSections = UserOptions.ContentEditor.RenderCollapsedSections;
            try
            {
                UserOptions.ContentEditor.RenderCollapsedSections = true;
                base.OnLoad(e);
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString(), this);
            }
            finally
            {
                UserOptions.ContentEditor.RenderCollapsedSections = renderCollapsedSections;
            }
        }
    }
}
