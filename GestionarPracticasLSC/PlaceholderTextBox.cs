using System;
using System.Drawing;
using System.Windows.Forms;

public class PlaceholderTextBox : TextBox
{
    private string placeholderText;
    public string PlaceholderText
    {
        get { return placeholderText; }
        set
        {
            placeholderText = value;
            this.SetPlaceholder();
        }
    }

    public PlaceholderTextBox()
    {
        this.GotFocus += RemovePlaceholder;
        this.LostFocus += SetPlaceholder;
    }

    private void RemovePlaceholder(object sender, EventArgs e)
    {
        if (this.Text == placeholderText)
        {
            this.Text = "";
            this.ForeColor = Color.Black;
        }
    }

    private void SetPlaceholder(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.Text))
        {
            this.Text = placeholderText;
            this.ForeColor = Color.Gray;
        }
    }

    private void SetPlaceholder()
    {
        if (string.IsNullOrEmpty(this.Text))
        {
            this.Text = placeholderText;
            this.ForeColor = Color.Gray;
        }
    }
}
