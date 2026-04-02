using System.ComponentModel.DataAnnotations;

namespace Models;

/// <summary>
/// Represents a customer in the system.
/// </summary>
public class Customer
{
    /// <summary>Unique identifier for the customer.</summary>
    public int Id { get; set; }

    /// <summary>Customer's first name.</summary>
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    /// <summary>Customer's last name.</summary>
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    /// <summary>Customer's email address. Must be unique across all customers.</summary>
    [Required]
    [MaxLength(255)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    /// <summary>Customer's phone number.</summary>
    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    /// <summary>Customer's date of birth.</summary>
    public DateTime? DateOfBirth { get; set; }

    /// <summary>Timestamp when the record was created.</summary>
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>Timestamp when the record was last updated.</summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>Whether the customer account is active.</summary>
    [Required]
    public bool IsActive { get; set; } = true;
}
