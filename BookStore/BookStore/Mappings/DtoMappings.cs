using BookStore.DtoModels;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mappings
{
    public static class DtoMappings
    {
        public static BookDto ToDtoModel(this Book entity)
        {
            return new BookDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                Description = entity.Description,
                Genre = entity.Genre,
                Quantity = entity.Quantity,
                Price = entity.Price
            };
        }

        public static Book ToDomainModel(this BookDto entity)
        {
            return new Book
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                Description = entity.Description,
                Genre = entity.Genre,
                Quantity = entity.Quantity,
                Price = entity.Price
            };
        }
    }
}
