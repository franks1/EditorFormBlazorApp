using System.ComponentModel.DataAnnotations;

namespace EditorFormBlazorApp.Data;
public class Person
{
    [Required]
    public string username { get; set; }
    [Required]
    public string address { get; set; }
}


