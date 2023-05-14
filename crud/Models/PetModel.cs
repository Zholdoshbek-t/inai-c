using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace crud.Models
{
    public class PetModel
    {
        private int id;
        private string name;
        private string type;
        private string color;

        [DisplayName("Pet_id")]
        public int Id { 
            get => id; 
            set => id = value;
        }
        [DisplayName("Pet_name")]
        [Required(ErrorMessage = "Pet name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public string Name {
            get => name; 
            set => name = value;
        }

        [DisplayName("Pet_type")]
        [Required(ErrorMessage = "Pet type is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type must be between 3 and 50 characters")]
        public string Type {
            get => type; 
            set => type = value;
        }
        [DisplayName("Pet_color")]
        [Required(ErrorMessage = "Pet color is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet color must be between 3 and 50 characters")]
        public string Color {
            get => color; 
            set => color = value; 
        }
    }
}
