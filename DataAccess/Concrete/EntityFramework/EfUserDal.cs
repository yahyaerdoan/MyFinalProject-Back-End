using Core.DataAcces.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {

                var result = from OperationClaim in context.OperationClaims
                             join UserOperationClaim in context.UserOperationClaims
                             on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                             where UserOperationClaim.UserId == user.UserId
                             select new OperationClaim 
                             { Id = OperationClaim.Id, Name = OperationClaim.Name };
                return result.ToList();

            }
        }
    }
}
