using CrossPlatformUI.GUIComponents;
using CrossPlatformUI.GUIComponents.MacComponents;

namespace CrossPlatformUI
{
	public class MacFactory : GUIFactory
	{
		Button macButton;
		Checkbox macCheckbox;
		public MacFactory()
		{
			macButton = new MacButton();
            macCheckbox = new MacCheckbox();
		}

		public Button createButton()
		{
			return macButton;
		}

        public Checkbox createCheckbox()
        {
            return macCheckbox;
        }
    }
}

