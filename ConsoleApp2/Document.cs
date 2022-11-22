// ConsoleApp2
// ConsoleApp2
// Document.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 3:35 22 11 2022

using System;

namespace ConsoleApp2
{
    public class Document
    {
        public string Name { get; set; } = "Паспорт РФ";
        public string Description { get; set; } = "Паспорт гражданина Российской федерации";
        public string Series { get; set; } = "00-00";
        public string Code { get; set; } = "00-00-00";
        public DateTime Issue_Date { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"Name: {Name}, Series: {Series}, Code: {Code}, Issue_Date: {Issue_Date}";
        }
    }
}