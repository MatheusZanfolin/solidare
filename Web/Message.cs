using System.Web.UI;

namespace SolidareWeb
{
    public static class Message
    {
        public static void Show(Page page, string message)
        {
            ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('" + message + "')", true);
        }
    }
}