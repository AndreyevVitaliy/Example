using Example.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example.View
{

  public class ExampleController
  {
    public ExampleModel Model;

    public ExampleController()
    {
      Model = new ExampleModel();
    }

    public string getFilePath()
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
        openFileDialog.FilterIndex = 1;
        openFileDialog.Multiselect = false;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          string selectedFilePath = openFileDialog.FileName;
          return selectedFilePath;
        }
      }

      return null;
    }

    public void SaveFile()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
      saveFileDialog.FilterIndex = 1;


      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        string filePath = saveFileDialog.FileName;
        Model.ResultXML.Save(filePath);
      }


    }

    public void ReadSelectedFilePath(ActionType actionType)
    {
      var filePath = getFilePath();

      if (filePath == null)
        return;

      XDocument xmlDoc = XDocument.Load(filePath);

      switch (actionType)
      {
        case ActionType.Input:
          Model.InputXML = xmlDoc;
          break;
        case ActionType.Action:
          Model.ActionXML = xmlDoc;
          break;
      }

    }

    public void GetResult()
    {
      XDocument xmlInput = XDocument.Parse(Model.InputXML.ToString());
      XDocument xmlAction = XDocument.Parse(Model.ActionXML.ToString());

      var results = new XElement("results");
      var functions = new Dictionary<string, Func<IEnumerable<XElement>, double>>
    {
        { "sum", elements => elements.Sum(e => parseDouble(e.Value)) },
        { "max", elements => elements.Max(e => parseDouble(e.Value)) },
        { "min", elements => elements.Min(e => parseDouble(e.Value)) },
        { "average", elements => elements.Average(e => parseDouble(e.Value)) },
    };

      foreach (XElement action in xmlAction.Descendants("action"))
      {
        string actionName = action.Attribute("name").Value;
        string type = action.Attribute("type").Value;
        string function = action.Attribute("function").Value;
        string source = action.Attribute("source").Value;
        string filter = action.Attribute("filter").Value;

        var elements = xmlInput.Descendants("company")
            .Where(e => System.Text.RegularExpressions.Regex.IsMatch(e.Attribute("name").Value, filter));

        double resultValue = 0;

        if (type == "element" && functions.ContainsKey(function))
        {
          resultValue = functions[function](elements.Descendants(source));
        }
        else if (type == "attribute" && function == "sum")
        {
          resultValue = elements.Sum(e => parseDouble(e.Attribute(source).Value));
        }

        results.Add(new XElement("result", new XAttribute("name", actionName), resultValue.ToString("0.00", CultureInfo.InvariantCulture)));
      }

      Model.ResultXML = XDocument.Parse(results.ToString());

    }

    private double parseDouble(string value)
    {
      double result;
      if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
      {
        return result;
      }
      return 0.0;
    }

  }
}





