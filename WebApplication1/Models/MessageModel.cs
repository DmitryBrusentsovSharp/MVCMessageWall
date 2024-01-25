using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace WebApplication1.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(10, MinimumLength = 8)]
        [DefaultValueAttribute("User")]
        public string Message { get; set; }

        public MessageModel() {
        }
    }
}
