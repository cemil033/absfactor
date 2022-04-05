using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactor
{
    public interface Button
    {
        public void paint();
    }
    public class WinButton : Button
    {
        public void paint()
        {            
        }
    }
    public class MacButton : Button
    {
        public void paint()
        {
        }
    }
    public interface CheckBox
    {
        public void paint();
    }
    public class WinCheckBox : CheckBox
    {
        public void paint()
        {
            
        }
    }
    public class MacCheckBox : CheckBox
    {
        public void paint()
        {

        }
    }
    public interface GUIFactory
    {
        public Button createButton();
        public CheckBox createCheckBox();
    }
    public class WinFactory : GUIFactory
    {
        public Button createButton()
        {
            return new WinButton();
        }

        public CheckBox createCheckBox()
        {
            return new WinCheckBox();
        }
    }
    public class MacFactory : GUIFactory
    {
        public Button createButton()
        {
            return new MacButton();
        }

        public CheckBox createCheckBox()
        {
            return new MacCheckBox();
        }
    }
    public class Aplication
    {
        GUIFactory factory;
        Button button;
        public Aplication(GUIFactory factory)
        {
            this.factory = factory;
        }
        public void createUI()
        {
            this.button = factory.createButton();   
        }
        public void paint()
        {
            button.paint();
        }
    }
}
