using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace PhoneBook.PhoneBooks.Dtos
{
    /// <summary>
    /// Page List 基类，分页跳过的行数，最多显示行数，排序字段
    /// </summary>
    public class PagedAndSortedDto : IPagedAndSortedResultRequest
    {
        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }

        [Range(0,500)]
        public int MaxResultCount { get; set; }

        public string Sorting { get; set; }
    }
}