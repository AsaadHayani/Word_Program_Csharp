using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Program_Csharp
{
  public partial class frmword : Form
  {
    public frmword()
    {
      InitializeComponent();
    }

    private void frmword_Load(object sender, EventArgs e)
    {
      foreach (FontFamily font in FontFamily.Families)
      {
        cbxfont.Items.Add(font.Name);
      }
      cbxfont.SelectedItem = "Segoe UI";
    }

    private void setFont()
    {
      string strfont = "Segoe UI";
      if (cbxfont.SelectedIndex > -1) strfont = cbxfont.SelectedItem.ToString();

      FontStyle fstyle = FontStyle.Regular;
      if (cbxbold.Checked) fstyle = fstyle | FontStyle.Bold;
      if (cbxunderline.Checked) fstyle = fstyle | FontStyle.Underline;
      if (cbxitalic.Checked) fstyle = fstyle | FontStyle.Italic;

      Font myfont = new Font(strfont, (int)nudsize.Value, fstyle);
      text2.SelectionFont = myfont;
    }

    private void cbxfont_SelectedIndexChanged(object sender, EventArgs e)
    {
      setFont();
    }

    private void setColor(Color color)
    {
      if (rdutext.Checked) text2.SelectionColor = color;
      else text2.SelectionBackColor = color;
    }

    private void panel2_Click(object sender, EventArgs e)
    {
      setColor(((Panel)sender).BackColor);
    }

    private void btnmorecolor_Click(object sender, EventArgs e)
    {
      ColorDialog cdiag = new ColorDialog();
      if (cdiag.ShowDialog() == DialogResult.OK)
      {
        setColor(cdiag.Color);
      }
    }
  }
}
