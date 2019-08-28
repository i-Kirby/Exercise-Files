using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.DTOs
{
    public class AuthorizeRequestDto
    {
        [Required]
        [MinLength(32), MaxLength(32)]
        public string AppToken { get; set; }

        [Required]
        [MinLength(32), MaxLength(32)]
        public string AppSecret { get; set; }

        //[Compare()] [CreditCard()] [Email()] [DataType()] [Range()] [RegularExpression()] [ValidationAttribute()]
       /* [AttributeUsage(AtributeTargets.Property | SttributyTargets.Field, AllowMultiple = false)]
        sealed public class CustomAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return true;
            }
        }*/
    }
}