using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManagerBL
    {
       
        GenericRepositoryDAL<Category> repo = new GenericRepositoryDAL<Category>();

         public List<Category> GetListBL()
          {
            return repo.listDAL();
        
        
         }
        public void CategoryAddBL(Category p) 
        {
            if (p.CategoryName=="" || p.CategoryName.Length>3 || p.CategoryDescription==""|| p.CategoryName.Length<=50 )
            {
                //hata mesajı kullanıcaya

            }
            else
            {
                repo.Insert(p);

            }
           
       
        
        }


    }
}
