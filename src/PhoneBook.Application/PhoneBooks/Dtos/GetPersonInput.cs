using System;
using Abp.Runtime.Validation;

namespace PhoneBook.PhoneBooks.Dtos
{
    public class GetPersonInput : PagedAndSortedDto, IShouldNormalize
    {
        public string FilterText { get; set; } 

        public void Normalize()
        { 
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id ";
            }
        }
    }
}