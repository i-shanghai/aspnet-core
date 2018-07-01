using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PhoneBook.PhoneBooks.Persons;

namespace PhoneBook.PhoneBooks.Dtos
{
    /// <summary>
    /// PersonList Auto Map From Person Object
    /// </summary>
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto:FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮箱 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }
}