using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meowgic.Repositories.Models.Request.Question
{
    public class QuestionRequest
    {
        [Required]
        public required string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
