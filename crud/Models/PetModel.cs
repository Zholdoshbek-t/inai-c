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
        public string Name {
            get => name; 
            set => name = value;
        }
        [DisplayName("Pet_type")]
        public string Type {
            get => type; 
            set => type = value;
        }
        [DisplayName("Pet_color")]
        public string Color {
            get => color; 
            set => color = value; 
        }
    }
}
