namespace SampleApplication.BusinessLayer.Dto;

public record PersonUpdateDto(
    int PersonId,
    string FirstName,
    string LastName);