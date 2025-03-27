using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Templates;

public class Course
{
    public static List<Course> GetData()
    {
        var list = new List<Course>();
        list.Add(new Course() { Name = "Generic", Image = "/Images/Generics.jpg", Teacher = "sajad baghrzadeh" });
        list.Add(new Course() { Name = "Interface", Image = "/Images/Interface.jpg", Teacher = "ALireza doostar" });
        list.Add(new Course() { Name = "Asp.net Core API", Image = "/Images/CSharp.jpg", Teacher = "hasan ozmafar" });
        list.Add(new Course() { Name = "WPF Profetional", Image = "/Images/WPF.jpg", Teacher = "sajad baghrzadeh" });
        return list;
    }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Teacher { get; set; }
}
