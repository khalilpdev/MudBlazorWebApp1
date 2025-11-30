namespace MudBlazorWebApp1.Data;

public class User
{
    public int Id { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string LastMessage { get; set; } = string.Empty;
    public DateTime LastMessageDate { get; set; }

    public static List<User> GetFakeUsers(bool testScroolWithMoreData)
    {
        var Users = new List<User>();

        // Dados fake conforme o print
        Users.Add(new User
        {
            Id = 1,
            Phone = "Khalil Dev",
            LastMessage = "yy3-97f-d5p-Ca7",
            LastMessageDate = DateTime.Now.AddDays(-1)
        });

        Users.Add(new User
        {
            Id = 2,
            Phone = "Khalil PLO5",
            LastMessage = "Teoria 3 H + 2 L",
            LastMessageDate = new DateTime(2025, 11, 18)
        });

        Users.Add(new User
        {
            Id = 3,
            Phone = "Khalil IA's",
            LastMessage = "https://chat.whatsapp.com/GNQjOSxPsqn8...",
            LastMessageDate = new DateTime(2025, 11, 16)
        });

        Users.Add(new User
        {
            Id = 4,
            Phone = "Canal de cortes",
            LastMessage = "https://www.instagram.com/reeI/DMly-czxNUG/?igsh=NGVjZmR...",
            LastMessageDate = new DateTime(2025, 8, 5)
        });

        if (testScroolWithMoreData)
        {
            // Adicionar mais usuários para testar o scroll
            for (int i = 5; i <= 20; i++)
            {
                Users.Add(new User
                {
                    Id = i,
                    Phone = $"Contato {i}",
                    LastMessage = $"Mensagem de exemplo {i}",
                    LastMessageDate = DateTime.Now.AddDays(-i)
                });
            }
        }

        return Users;
    }
}