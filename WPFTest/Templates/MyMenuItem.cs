using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Templates;

public class MyMenuItem
{
    public MyMenuItem(string item)
    {
        Item = item;
        Items = new ObservableCollection<MyMenuItem>();
    }
    public string Item { get; set; }
    public ObservableCollection<MyMenuItem> Items{ get; set; }

    public static ObservableCollection<MyMenuItem> DefaultMenu()
    {
        var list = new ObservableCollection<MyMenuItem>();
        var file = new MyMenuItem("File");
        file.Items.Add(new MyMenuItem("New"));
        file.Items.Add(new MyMenuItem("Save"));
        file.Items.Add(new MyMenuItem("Svae as.."));
        file.Items.Add(new MyMenuItem("Exit"));

        var edit = new MyMenuItem("Edit");
        edit.Items.Add(new MyMenuItem("Copy"));
        edit.Items.Add(new MyMenuItem("Cut"));
        edit.Items.Add(new MyMenuItem("Paste"));

        list.Add(file);
        list.Add(edit);

        return list;
    }
}
