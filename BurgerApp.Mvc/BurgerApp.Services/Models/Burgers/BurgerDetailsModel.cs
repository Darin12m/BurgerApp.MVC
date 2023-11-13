namespace BurgerApp.Services.Models.Burgers
{
    public class BurgerDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsVegan { get; set; }

        public bool HasFries { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
