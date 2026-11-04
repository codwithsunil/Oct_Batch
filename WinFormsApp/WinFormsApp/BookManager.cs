using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    public static class BookManager
    {
        /// <summary>
        /// TODO -- add edit and delete 
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetAll(string search)
        {
            // this string is not empety 
            if (string.IsNullOrEmpty(search) == true)
            {
                return DataStoreManager.Books;
            }

            var lstBooks= DataStoreManager.Books.Where(x=>x.Name.Contains(search) || x.Tile.Contains(search)).ToList();

            return lstBooks;

        }

        /// <summary>
        /// what is the differnt between first and forst or defauls ?
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Book GetById(int id)
        {
            return DataStoreManager.Books.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
