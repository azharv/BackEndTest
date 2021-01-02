using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndTest.models
{
    public class UserPostReportingService : IUserPostReporting
    {
        private readonly AppDBContext context;
        public UserPostReportingService(AppDBContext context)
        {
            this.context = context;
        }
        public List<UserPostReporting> GetUserPostReportingList()
        {
            try
            {
                var Reportings = context.UserPostReporting.FromSqlRaw(@" select tblPost.PostId PostId, PostDescription, CommentsDes, tblUser.UserFullName, format(CommentDateTime,'dd-MMM-yyyy') CommentDateTime , COUNT(tblLike.LikeId) LikeNo, COUNT(tbldisLike.DisLikeId) DisLikeNo from tblPost

                        left join tblComments on tblComments.PostId=tblPost.PostId
                        left join tblUser on tblUser.UId=tblComments.UserId
                        left join tblLike on tblComments.PostId=tblLike.PostId
                        left join tblDisLike on tblComments.PostId=tblDisLike.PostId
                        group by tblPost.PostId,PostDescription, CommentsDes, tblUser.UserFullName, CommentDateTime").ToList();

                return Reportings;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
