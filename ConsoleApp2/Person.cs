// ConsoleApp2
// ConsoleApp2
// Person.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 3:18 22 11 2022

using System;
using Microsoft.SqlServer.Server;

namespace ConsoleApp2
{
    public class Person
    {
        public int Id { get; set; } = 0;

        public string FirstName { get; set; } = "Фамлия";
        public string LastName { get; set; } = "Имя";
        public string MiddleName { get; set; } = "Отчество";

        public string Initials => $"{LastName[0]}.{MiddleName[0]}."; // инициалы
        public string FIO => $"{FirstName} {Initials}"; // Фамилия с инициалами

        public DateTime BirthDate { get; set; } = DateTime.Now; // дата рождения
        public int BirthYear => BirthDate.Year;
        public int Age => (DateTime.Now.Year - BirthDate.Year); // возраст

        public override string ToString()
        {
            return $"Id: {Id}, " +
                   $"FirstName: {FirstName}, LastName: {LastName}, MiddleName: {MiddleName}, " +
                   $"FIO: {FIO}, " +
                   $"BirthDate: {BirthDate}, " +
                   $"BirthYear: {BirthYear}, " +
                   $"Age: {Age}";
        }
    }
}