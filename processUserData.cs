using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public object Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool Active { get; set; }
}

public class UserProcessor
{
    public List<User> ProcessUserData(List<Dictionary<string, object>> data)
    {
        var users = new List<User>();

        foreach (var item in data)
        {
            var user = new User();
            
            if (item.TryGetValue("id", out object idValue))
                user.Id = idValue;
            
            if (item.TryGetValue("name", out object nameValue))
                user.Name = nameValue?.ToString();
            
            if (item.TryGetValue("email", out object emailValue))
                user.Email = emailValue?.ToString();
            
            if (item.TryGetValue("status", out object statusValue))
                user.Active = statusValue?.ToString().Equals("active", StringComparison.OrdinalIgnoreCase) ?? false;
            
            users.Add(user);
        }

        Console.WriteLine($"Processed {users.Count} users");
        return users;
    }

    public bool SaveToDatabase(List<User> users)
    {
        // TODO: Implement database connection
        bool success = true;
        return success;
    }

    static void Main()
    {
        var processor = new UserProcessor();
        var data = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object>
            {
                { "id", 1 },
                { "name", "John" },
                { "email", "john@example.com" },
                { "status", "active" }
            },
            new Dictionary<string, object>
            {
                { "id", 2 },
                { "name", "Jane" },
                { "email", "jane@example.com" },
                { "status", "inactive" }
            }
        };

        var users = processor.ProcessUserData(data);
        var saved = processor.SaveToDatabase(users);
    }
}
