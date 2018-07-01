using System.ComponentModel.DataAnnotations;

namespace PhoneBook.PhoneBooks.Dtos
{
    public class PersonEditDto
    {
        /// <summary>
        /// 姓名 
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱 
        /// </summary>
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(200)]
        public string Address { get; set; }
    }
}