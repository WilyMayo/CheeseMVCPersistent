using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }
        public List<SelectListItem> Categories { get; set; }

        public AddCheeseViewModel(IEnumerable<CheeseCategory> categories)
        {
            CheeseTypes = new List<SelectListItem>(); 
            Categories = new List<SelectListItem>();

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Hard).ToString(),
                Text = CheeseType.Hard.ToString()
            });

            foreach (CheeseCategory category in categories)
            {
                CheeseTypes.Add(new SelectListItem
                {
                    Value = ((int)CheeseType.Soft).ToString(),
                    Text = CheeseType.Soft.ToString()
                });
                Categories.Add(new SelectListItem
                {
                    Value = item.ID.ToString(),
                    Text = item.Name
                });
                CheeseTypes.Add(new SelectListItem
                {
                    Value = ((int)CheeseType.Fake).ToString(),

                    Text = CheeseType.Fake.ToString()
                });


            }
        }
        }

    }
}