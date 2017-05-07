using Engine;
using System;
using System.Xml.Linq;

namespace Game
{
	public class EditRGBColorValueDialog : Dialog
	{
		private Action<int> m_handler;
		private SliderWidget m_RSlider;
		private SliderWidget m_GSlider;
		private SliderWidget m_BSlider;
		private ButtonWidget m_RplusButton;
		private ButtonWidget m_GplusButton;
		private ButtonWidget m_BplusButton;
		private ButtonWidget m_RminusButton;
		private ButtonWidget m_GminusButton;
		private ButtonWidget m_BminusButton;
		private LabelWidget m_colorLabel;
		private ButtonWidget m_okButton;
		private ButtonWidget m_cancelButton;
		private int m_color;
		public EditRGBColorValueDialog(int color, Action<int> handler)
		{
			XElement node = ContentManager.Get<XElement>("Dialogs/EditRGBColorValueDialog");
			base.DialogWidget = (ContainerWidget)WidgetsManager.LoadWidget(this, node, null);
			this.m_RSlider = base.DialogWidget.Children.Find<SliderWidget>("EditRGBColorValueDialog.RSlider", true);
			this.m_GSlider = base.DialogWidget.Children.Find<SliderWidget>("EditRGBColorValueDialog.GSlider", true);
			this.m_BSlider = base.DialogWidget.Children.Find<SliderWidget>("EditRGBColorValueDialog.BSlider", true);
			this.m_RplusButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.RPlusButton", true);
			this.m_RminusButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.RMinusButton", true);
			this.m_GplusButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.GPlusButton", true);
			this.m_GminusButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.GMinusButton", true);
			this.m_BplusButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.BPlusButton", true);
			this.m_BminusButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.BMinusButton", true);
			this.m_colorLabel = base.DialogWidget.Children.Find<LabelWidget>("EditRGBColorValueDialog.Label", true);
			this.m_okButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.OK", true);
			this.m_cancelButton = base.DialogWidget.Children.Find<ButtonWidget>("EditRGBColorValueDialog.Cancel", true);
			this.m_handler = handler;
			this.m_color = color;
			this.UpdateControls(color);
		}
		public override void Update()
		{
			int R = (int)this.m_RSlider.Value & 16711680,//255 << 16
				G = (int)this.m_GSlider.Value & 65280,//255 << 8
				B = (int)this.m_BSlider.Value & 255,
				max = 255;
			if (this.m_RSlider.IsSliding || this.m_GSlider.IsSliding || this.m_BSlider.IsSliding)
				this.m_color = R | G | B;
			if (this.m_RminusButton.IsClicked)
				R = MathUtils.Max(R - 1, 0);//(int)this.m_RSlider.MinValue
			if (this.m_RplusButton.IsClicked)
				R = MathUtils.Min(R + 1, max);//(int)this.m_RSlider.MaxValue
			if (this.m_GminusButton.IsClicked)
				G = MathUtils.Max(G - 1, 0);//(int)this.m_GSlider.MinValue
			if (this.m_GplusButton.IsClicked)
				G = MathUtils.Min(G + 1, max);//(int)this.m_GSlider.MaxValue
			if (this.m_BminusButton.IsClicked)
				B = MathUtils.Max(B - 1, 0);//(int)this.m_BSlider.MinValue
			if (this.m_BplusButton.IsClicked)
				B = MathUtils.Min(B + 1, max);//(int)this.m_BSlider.MaxValue
			if (this.m_okButton.IsClicked)
				this.Dismiss(new int?(this.m_color = R | G | B));
			if (InputManager.InputState.Back || InputManager.InputState.B || this.m_cancelButton.IsClicked)
				this.Dismiss(null);
			this.UpdateControls(this.m_color);
		}
		private void UpdateControls(int color)
		{
			//float R = this.m_RSlider.Value = (float)(color >> 16 & 255),
			//	  G = this.m_GSlider.Value = (float)(color >> 8 & 255),
			//	  B = this.m_BSlider.Value = (float)(color & 255);
			int R = color >> 16 & 255,
				G = color >> 8 & 255,
				B = color & 255,
				max = 255;
			this.m_RSlider.Value = R;
			this.m_GSlider.Value = G;
			this.m_BSlider.Value = B;
			this.m_RminusButton.IsEnabled = (R > 0);//this.m_RSlider.MinValue
			this.m_RplusButton.IsEnabled = (R < max);//this.m_RSlider.MaxValue
			this.m_GminusButton.IsEnabled = (G > 0);//this.m_GSlider.MinValue
			this.m_GplusButton.IsEnabled = (G < max);//this.m_GSlider.MaxValue
			this.m_BminusButton.IsEnabled = (B > 0);//this.m_BSlider.MinValue
			this.m_BplusButton.IsEnabled = (B < max);//this.m_BSlider.MaxValue
			this.m_colorLabel.Text = new TrueColorBlock1().GetDisplayName(null, this.m_color).Substring(16);
			this.m_colorLabel.Color = new Color((uint)TrueColorBlock.SetColor(this.m_color));
		}
		private void Dismiss(int? result)
		{
			DialogsManager.HideDialog(this);
			if (this.m_handler != null && result.HasValue)
				this.m_handler(result.Value);
		}
	}
}
