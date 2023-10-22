using Example.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Example.Model;
using static System.Collections.Specialized.BitVector32;
using System.Reflection;

namespace Example.View

{
  public partial class Example : Form
  {
    private ExampleController _controller;
    

    public Example()
    {

      InitializeComponent();

      _controller = new ExampleController();

      btnAction.Click += BtnAction_Click;
      btnInput.Click += BtnInput_Click;
      btnResult.Click += BtnResult_Click;

      txtInput.ReadOnly = true;
      txtAction.ReadOnly = true;

      _controller.Model.PropertyChanged += Model_PropertyChanged;

    }

    private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      var model = (ExampleModel)sender;

      if (e.PropertyName == "InputXML")
        txtInput.Text = model.InputXML.ToString();

      if (e.PropertyName == "ActionXML")
        txtAction.Text = model.ActionXML.ToString();

      if (e.PropertyName == "ResultXML")
        txtResult.Text = model.ResultXML.ToString();

    }

    private void BtnResult_Click(object sender, EventArgs e)
    {
      _controller.GetResult();
      _controller.SaveFile();
    }

    private void BtnInput_Click(object sender, EventArgs e)
    {
      _controller.ReadSelectedFilePath(ActionType.Input);
    }

    private void BtnAction_Click(object sender, EventArgs e)
    {
      _controller.ReadSelectedFilePath(ActionType.Action);
    }




  }
}
