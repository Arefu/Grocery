namespace GroceryList.Types
{
    public class Shopping_List_Entry
    {
        public required string Name { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public int TotalItems { get; set; }
        public int Cost { get; set; }
    }
}
