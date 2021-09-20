# Palindrome Service

This is a CLI tool built using dotnet to check if an input can be arranged in such a way that it forms a palindrome.

The following assumptions were made:

- Whitespace should not be treated as a character, and so is removed from the input before testing
- Non-alphanumeric characters can form palindromes, and are not filtered out ie. `..,` is a valid input, and would be considered a palindrome

## Running

To run the tool enter the following in your CLI

``` BASH
dotnet build
dotnet run --project .\src\Palindrome\Palindrome.csproj
```

## Testing

To run the unit tests run the following

``` BASH
dotnet test 
```
