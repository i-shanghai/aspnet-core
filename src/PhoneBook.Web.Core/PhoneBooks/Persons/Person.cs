using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace PhoneBook.PhoneBooks.Persons
{
    /// <summary>
    /// 人员信息
    /// </summary>
    public class Person:FullAuditedEntity<long>
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