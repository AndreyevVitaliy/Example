using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Example.Model
{
  public class ExampleModel : INotifyPropertyChanged
  {
    private XDocument _inputXML { get; set; }
    private XDocument _actionXML { get; set; }

    private XDocument _resultXML { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    public XDocument InputXML
    {
      get
      {
        return _inputXML;
      }
      set
      {
        if (value != _inputXML)
        {
          _inputXML = value;
          NotifyPropertyChanged();
        }
      }
    }

    public XDocument ResultXML
    {
      get
      {
        return _resultXML;
      }
      set
      {
        if (value != _resultXML)
        {
          _resultXML = value;
          NotifyPropertyChanged();
        }
      }
    }

    public XDocument ActionXML
    {
      get
      {
        return _actionXML;
      }
      set
      {
        if (value != _actionXML)
        {
          _actionXML = value;
          NotifyPropertyChanged();
        }
      }
    }



    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

  }


  public enum ActionType
  {
    Input = 1, Action = 2
  }


}
