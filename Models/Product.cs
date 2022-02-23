using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DeliveryApp.Models;
using DeliveryApp.Validations;


namespace DeliveryApp.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "The {0} field is necessary.")]
        [TypeAttribute]
        [Display(Name = "Kind of food.")]
        public string Type { get; set; } //is food, drink or dessert?

        [Required(ErrorMessage = "The {0} field is necessary.")]
        [StringLength(20)]
        [Display(Name = "Food name.")]
        public string FoodName { get; set; }















        [RegularExpression(@"^(((\d{1,3})(,\d{3})*)|(\d+))(.\d+)?$", ErrorMessage = "Invalid data.")]
        [Required(ErrorMessage = "The {0} field is necessary.")]
        [Display(Name = "Product value.")]
        public string Price { get; set; }

    
        

 










        [Required(ErrorMessage = "The {0} field is necessary.")]
        [Range(0, 999, ErrorMessage = "Maximum allowed: 999")]
        [Display(Name = "Quantity of products.")]
        [DefaultValue("0")]        
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The {0} field is necessary.")]        
        [StringLength(300)]
        [Display(Name = "Product description.")]
        public string Description { get; set; }
    }
}
