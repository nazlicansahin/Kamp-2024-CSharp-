namespace CrudOperations
{
    public class Category : IEntity 
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}