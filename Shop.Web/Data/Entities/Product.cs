using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Web.Data.Entities
{
    public class Product : IEntity
    {


        public int Id { get; set; }


        [Required(ErrorMessage = "You must enter {0}")]
        public int ProductID { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "You must enter {0}")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Debe Ingresar el Precio")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


        [StringLength(30, ErrorMessage = "The Field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Display(Name = "Image")]

        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Availble?")]

        public bool IsAvailble { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Currency)]

        public decimal Stock { get; set; }

        public User User { get; set; }
    }
}
