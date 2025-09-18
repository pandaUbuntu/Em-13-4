using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal static class MessageService
    {
        public static void ShowInfo(string message, string title = "Success")
        {
            ShowPopUp(message, title, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string message, string title = "Invalid Input")
        {
            ShowPopUp(message, title, MessageBoxIcon.Warning);
        }

        public static void ShowError(string message, string title = "Error")
        {
            ShowPopUp(message, title, MessageBoxIcon.Error);
        }

        public static void ShowErrorEx(Exception ex, string title = "Error")
        {
            ShowPopUp("An error occurred: " + ex.Message, title, MessageBoxIcon.Error);
        }

        private static void ShowPopUp(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}
