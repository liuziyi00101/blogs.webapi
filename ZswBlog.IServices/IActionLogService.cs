using System.Threading.Tasks;
using ZswBlog.DTO;
using ZswBlog.Entity;

namespace ZswBlog.IServices
{
    /// <summary>
    /// ��־��¼����
    /// </summary>
    public interface IActionLogService: IBaseService<ActionLogEntity>
    {
        /// <summary>
        /// ��ȡ������־��¼
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="pageIndex"></param>
        /// <param name="logType"></param>
        /// <param name="dimTitle"></param>
        /// <returns></returns>
        Task<PageDTO<ActionLogEntity>> GetActionListByPage(int limit, int pageIndex, int logType, string dimTitle);

        /// <summary>
        /// ��ȡ��������
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ActionLogEntity> GetActionLogById(int id);
    }
}