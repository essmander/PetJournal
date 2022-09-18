namespace GraphQL.Models;

public class OweerDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IEnumerable<PetDTO> PetsOwned { get; set; }
}