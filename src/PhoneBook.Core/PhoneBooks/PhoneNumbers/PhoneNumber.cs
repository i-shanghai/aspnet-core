using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using PhoneBook.PhoneBooks.Persons;

namespace PhoneBook.PhoneBooks.PhoneNumbers
{
   /// <summary>
   /// 电话号码
   /// </summary>
    public class PhoneNumber:Entity<long>, IHasCreationTime
    {
        [MaxLength(20)]
        public string Number { get; set; }

        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType PhoneType { get; set; } 

        public long PersonId { get; set; }

        public virtual Person  Person { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}