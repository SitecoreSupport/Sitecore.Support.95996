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
            base.OnLoad(e);
            if (!Context.ClientPage.IsEvent)
            {
                base.OK.ToolTip = Translate.Text("Reset the field values on this page.");
                Item itemFromQueryString = UIUtil.GetItemFromQueryString(Context.ContentDatabase);
                RenderEditor(itemFromQueryString, itemFromQueryString, this.Fields);
            }
        }
    }
}
