using System.ComponentModel.DataAnnotations;

namespace COOKING_RECIPE_PORTAL.Model
{
    public class NonVeg_Recipe
    {
        [Key]
        public int Recipe_Id { get; set; }
        public string Recipe_Name { get; set; }
        public int Recipe_Price { get; set; }
    }
}
