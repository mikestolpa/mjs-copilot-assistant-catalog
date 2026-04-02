# Customer

## Description
Represents a customer in the system.

## Properties

| Property       | Type     | Required | Description                          |
|----------------|----------|----------|--------------------------------------|
| Id             | int      | Yes      | Unique identifier for the customer   |
| FirstName      | string   | Yes      | Customer's first name                |
| LastName       | string   | Yes      | Customer's last name                 |
| Email          | string   | Yes      | Customer's email address             |
| PhoneNumber    | string   | No       | Customer's phone number              |
| DateOfBirth    | DateTime | No       | Customer's date of birth             |
| CreatedAt      | DateTime | Yes      | Timestamp when the record was created|
| UpdatedAt      | DateTime | No       | Timestamp when the record was last updated |
| IsActive       | bool     | Yes      | Whether the customer account is active |

## Notes
- `Email` must be unique across all customers
- `FirstName` and `LastName` have a max length of 100 characters
- `Email` has a max length of 255 characters
- `PhoneNumber` has a max length of 20 characters
