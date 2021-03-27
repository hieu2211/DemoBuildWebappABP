using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore.Web
{
    public class BookStoreWebAutoMapperProfile : Profile
    {
        public BookStoreWebAutoMapperProfile()
        {
            CreateMap<BookDto, CreateUpdateBookDto>();
            //add new mapping
            CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,
                CreateAuthorDto>();
        }
    }
}
