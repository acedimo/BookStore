﻿using BookStore.Data.Interfaces;
using BookStore.Models;
using BookStore.Services.Interfaces;
using System.Collections.Generic;

namespace BookStore.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _booksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public bool Create(Book book)
        {
            var dbBook = _booksRepository.GetByTitle(book.Title);

            if (dbBook == null)
            {
                _booksRepository.Create(book);
                return true;
            }

            return false;
        }

        public void Delete(int id)
        {
            var book = _booksRepository.GetById(id);

            if (book != null)
            {
                _booksRepository.Delete(book);
            }
        }

        public List<Book> GetAll()
        {
            return _booksRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return _booksRepository.GetById(id);
        }

        public void Update(Book book)
        {
            var dbBook = _booksRepository.GetById(book.Id);

            if (dbBook != null)
            {
                dbBook.Title = book.Title;
                dbBook.Author = book.Author;
                dbBook.Description = book.Description;
                dbBook.Genre = book.Genre;
                dbBook.Quantity = book.Quantity;
                dbBook.Price = book.Price;

                _booksRepository.Update(dbBook);
            }
        }
    }
}
