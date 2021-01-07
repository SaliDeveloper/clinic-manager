using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject.Views
{
    class CustomTextBox : TextBox
    {
        private string _hintText = "";
        public Color TextColor { get; set; }
        public Color HintColor { get; set; } = Color.DarkGray;

        public string GetText() => ForeColor == HintColor ? "" : Text;

        public void SetText(string value)
        {
            ForeColor = TextColor;
            Text = value;
        }

        public string HintText
        {
            get => _hintText;
            set
            {
                _hintText = value;
                if (!string.IsNullOrEmpty(Text) || Focused) return;
                Text = _hintText;
                ForeColor = HintColor;
            }
        }


        public CustomTextBox()
        {
            // Add event handler for when the control gets focus
            GotFocus += (object sender, EventArgs e) =>
            {
                if (ForeColor == HintColor)
                    Text = string.Empty;
                ForeColor = TextColor;
            };
            // add event handling when focus is lost
            LostFocus += (object sender, EventArgs e) =>
            {
                if (string.IsNullOrEmpty(Text)/* ||Text==HintText */)
                {
                    ForeColor = HintColor;
                    Text = HintText;
                }
                else
                {
                    ForeColor = TextColor;
                }
            };
        }
    }
}
