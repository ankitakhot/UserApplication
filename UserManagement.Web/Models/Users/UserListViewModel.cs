﻿using System.ComponentModel.DataAnnotations;

namespace UserManagement.Web.Models.Users;

public class UserListViewModel
{
    public List<UserListItemViewModel> Items { get; set; } = new();
}

public class LogsViewModel
{
    public List<Logs> Items { get; set; } = new();
}

public class UserDetailsLogViewModel{
    public UserListItemViewModel userItem { get; set; } = new();
    public LogsViewModel userLogs { get; set; } = new();
}

public class UserListItemViewModel
{
    public long Id { get; set; }
    public string? Forename { get; set; }
    public string? Surname { get; set; }
    [Required]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Date of birth is required")]
    [RegularExpression(@"^\d{2}-\d{2}-\d{4}$", ErrorMessage = "Invalid date format. Please use dd-MM-yyyy")]
    public string? DateOfBirth { get; set; }
    public bool IsActive { get; set; }
}

public class Logs
{
    public long UserId { get; set; }
    public string? Type { get; set; } 
    public string? ShowMessage { get; set; }
    public string? Details { get; set; }
}
