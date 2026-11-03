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
        public static List<Book> GetAll()
        {
            return DataStoreManager.Books;
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
