using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.Authors
{
    public class AuthorDto:EntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string ShortBio { get; set; }
    }
}
