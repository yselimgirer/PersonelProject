using PersonelProject.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PersonelProject.DataAccessLayer
{
    public class PersonelDal : RepositoryBase<Personeller, ModelPersonelEntity>
    {
        public object GetPersonel(ModelPersonelEntity db, Expression<Func<Personeller, bool>> obj)
        {
            
            object model;
            if (obj == null)
            {
                model = db.Personellers.Join(db.Units, x => x.UnitID, x => x.UnitID, (p, b) => new
                {
                    p.PersonelD,
                    p.Name,
                    p.LastName,
                    p.Phone,
                    p.Date,
                    p.Address,
                    p.Email,
                    b.UnitID,
                    b.UnitName,
                    p.IsActive
                }).ToList();

            }
            else
            {
               
                    model = db.Personellers.Where(obj).Join(db.Units, x => x.UnitID, x => x.UnitID, (p, b) => new
                    {
                        p.PersonelD,
                        p.Name,
                        p.LastName,
                        p.Phone,
                        p.Date,
                        p.Address,
                        p.Email,
                        b.UnitID,
                        b.UnitName,
                        p.IsActive
                    }).ToList();
                

            }return model;  
            

        }

    }
}