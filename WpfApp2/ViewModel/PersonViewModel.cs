﻿using System;
using System.Collections.ObjectModel;
using WpfApp2.Model;
namespace WpfApp2.ViewModel
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> ListPerson { get; set; } =
        new ObservableCollection<Person>();
        public PersonViewModel()
        {
            this.ListPerson.Add(
            new Person
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Иван",
                LastName = "Иванов",
                Birthday = new DateTime(1980, 02, 28)
            });
            this.ListPerson.Add(
            new Person
            {
                Id = 2,
                RoleId = 2,
                FirstName = "Петр",
                LastName = "Петров",
                Birthday = new DateTime(1981, 03, 20)
        });
        this.ListPerson.Add(
        new Person
        {
            Id = 3,
            RoleId = 3,
            FirstName = "Виктор",
            LastName = "Борисенко",
            Birthday = new DateTime(1982, 04, 15)
        });
            this.ListPerson.Add(
            new Person
            {
                Id = 4,
                RoleId = 3,
                FirstName = "Сидор",
                LastName = "Сидоров",
                Birthday = new DateTime(1983, 05, 10)
            });
        }
    }
}
