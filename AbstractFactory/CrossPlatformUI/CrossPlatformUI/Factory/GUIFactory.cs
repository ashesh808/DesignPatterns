using System;
using CrossPlatformUI.GUIComponents;

namespace CrossPlatformUI
{
	public interface GUIFactory
	{
		public Button createButton();
		public Checkbox createCheckbox();
	}
}

