using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ZswBlog.Common;
using ZswBlog.DTO;
using ZswBlog.Entity;
using ZswBlog.IRepository;
using ZswBlog.IServices;

namespace ZswBlog.Services
{
    /// <summary>
    /// ��־��¼
    /// </summary>
    public class ActionLogService : BaseService<ActionLogEntity, IActionLogRepository>, IActionLogService
    {
        public IActionLogRepository ActionLogRepository { get; set; }

        /// <summary>
        /// ��ҳ��ȡ������¼
        /// </summary>
        /// <param name="limit">ҳ��</param>
        /// <param name="pageIndex">ҳ��</param>
        /// <param name="logType"></param>
        /// <param name="dimTitle"></param>
        /// <returns></returns>
        public async Task<PageDTO<ActionLogEntity>> GetActionListByPage(int limit, int pageIndex, int logType, string dimTitle)
        {
            Expression<Func<ActionLogEntity, bool>> expression = t => true;
            if (logType != 0)
            {
                expression = expression.And(a => a.logType == logType);
            }
            if (!string.IsNullOrEmpty(dimTitle))
            {
                expression = expression.And(a => a.actionDetail.Contains(dimTitle));
            }
            var pageEntity = await ActionLogRepository.GetModelsByPageAsync(limit, pageIndex, false,
                a => a.createDate, expression);
            return new PageDTO<ActionLogEntity>(pageIndex, limit, pageEntity.count, pageEntity.data.ToList());
        }

        /// <summary>
        /// ��ȡ������־��¼
        /// </summary>
        /// <param name="id">����</param>
        /// <returns></returns>
        public async Task<ActionLogEntity> GetActionLogById(int id)
        {
            return await ActionLogRepository.GetSingleModelAsync(a => a.id == id);
        }
    }
}