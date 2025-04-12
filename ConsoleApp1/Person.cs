using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleApp1;

internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> WatchCollection { get; set; }

    public Person ShallowClone()
    {
        return new Person()
        {
            Name = this.Name,
            Age = this.Age,
            WatchCollection = this.WatchCollection
        };
    }

    public Person DeepClone()
    {
        // Deep Clone
        Person person = new()
        {
            Age = this.Age,
            Name = this.Name,
            WatchCollection = new List<string>() // or just []
        };

        foreach (string watch in WatchCollection)
            person.WatchCollection.Add(new string(watch));

        return person;

        //return new Person()
        //{
        //    Name = this.Name,
        //    Age = this.Age,
        //    WatchCollection = this.WatchCollection.Select(w => new string(w)).ToList()
        //};
    }

    public Person JSON_DeepClone()
    {
        // Deep Clone for DTOs
        string json = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<Person>(json);
    }

    public override string ToString()
    {
        StringBuilder sb = new(1024);

        sb.Append($"{Name}{Environment.NewLine}{Age}");

        foreach (string watch in WatchCollection)
            sb.Append($"{Environment.NewLine}{watch}");

        return sb.ToString();

        //string s = $"{Name}{Environment.NewLine}{Age}";
        //foreach (string watch in WatchCollection)
        //    s += $"{Environment.NewLine}{watch}";
        //return s;
    }
}
