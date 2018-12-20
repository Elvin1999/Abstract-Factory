using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    interface IButton
    {
        string GetButtonDescription();
    }

    interface ITextBox
    {
        string GetTextBoxDescription();
    }

    class LinuxTextBox : ITextBox
    {
        public string GetTextBoxDescription()
        {
            return "Linux TextBox";
        }
    }
    class WindowsTextBox : ITextBox
    {
        public string GetTextBoxDescription()
        {
            return "Windows TextBox";
        }
    }
    class LinuxButton : IButton
    {
        public string GetButtonDescription()
        {
            return "Linux Button";
        }
    }
    class WindowsButton : IButton
    {
        public string GetButtonDescription()
        {
            return "Windows Button";
        }
    }
    interface IDialog
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
    class WindowsDialog : IDialog
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
    class LinuxDialog : IDialog
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ITextBox CreateTextBox()
        {
            return new LinuxTextBox();
        }
    }

    //Idialog,windowsDialog,linuxdialog
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
