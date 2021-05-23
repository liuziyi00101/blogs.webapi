using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZswBlog.Common;
using ZswBlog.DTO;
using ZswBlog.Entity;
using ZswBlog.IServices;

namespace ZswBlog.Core.Controllers
{
    /// <summary>
    /// ��־��¼
    /// </summary>
    public class ActionLogController: ControllerBase
    {
        private readonly IActionLogService _actionLogService;

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        /// <param name="actionLogService"></param>
        public ActionLogController(IActionLogService actionLogService)
        {
            _actionLogService = actionLogService;
        }

        /// <summary>
        /// ��ҳ��ȡ������־
        /// </summary>
        /// <param name="limit">ҳ��</param>
        /// <param name="pageIndex">ҳ��</param>
        /// <param name="logType">��־����</param>
        /// <param name="dimTitle">ģ������</param>
        /// <returns></returns>
        [Route("/api/action/admin/get/page")]
        [Authorize]
        [HttpGet]
        [FunctionDescription("��̨����-��ҳ��ȡ�����б�")]
        public async Task<ActionResult<PageDTO<ActionLogEntity>>> GetActionLogByPage(int limit, int pageIndex, int logType, string dimTitle)
        {
            var actionList = await _actionLogService.GetActionListByPage(limit, pageIndex, logType, dimTitle);
            return Ok(actionList);
        }

        /// <summary>
        /// ��ȡ������־����
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/action/admin/get/{id}")]
        [Authorize]
        [HttpGet]
        [FunctionDescription("��̨����-��ȡ������־����")]
        public async Task<ActionResult<ActionLogEntity>> GetActionDetails([FromRoute]int id)
        {
            var actionLog = await _actionLogService.GetActionLogById(id);
            return Ok(actionLog);
        }

    }
}