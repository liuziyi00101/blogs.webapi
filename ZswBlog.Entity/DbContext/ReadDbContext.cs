using Microsoft.EntityFrameworkCore;

namespace ZswBlog.Entity.DbContext
{
    /// <summary>
    /// 读取数据库
    /// </summary>
    public class ReadDbContext: ZswBlogDbContext
    { 
        /// <summary>
        /// 
        /// </summary>
        public ReadDbContext()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ReadDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
