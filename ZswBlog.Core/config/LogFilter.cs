using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using ZswBlog.Common;
using ZswBlog.Common.Enums;
using ZswBlog.Entity;
using ZswBlog.IServices;

namespace ZswBlog.Core.config
{

    /// <summary>
    /// ��־��¼����
    /// </summary>
    public class LogFilter : ActionFilterAttribute
    {
        private static readonly ILogger Logger = LoggerFactory.Create(build =>
        {
            build.AddConsole(); // ���ڿ���̨��������
            build.AddDebug(); // ����VS���ԣ�������ڵ����
        }).CreateLogger("LogFilter");

        /// <summary>
        /// ��־��¼����
        /// </summary>
        private readonly IActionLogService _actionLogService;

        /// <summary>
        /// ��ʼ����־��¼���
        /// </summary>
        /// <param name="actionLogService"></param>
        public LogFilter(IActionLogService actionLogService)
        {
            _actionLogService = actionLogService;
        }

        /// <summary>
        /// ��־��¼
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var t = context.Controller.GetType();
            //��÷�����
            var actionName = context.RouteData.Values["action"]?.ToString();
            //�Ƿ��и�����
            var b = IsThatAttribute<FunctionDescriptionAttribute>(actionName, t);
            if (b.DescriptionValue.Equals(string.Empty)) return;
            var param = "";
            foreach (var (key, value) in context.ActionArguments)
            {
                param += "\n,\t\t��������:" + key + "=" + value;
            }

            if (context.HttpContext.Connection.RemoteIpAddress == null) return;
            var ip = context.HttpContext.Connection.RemoteIpAddress.MapToIPv4();
            //��־��¼
            Logger.LogInformation(
                $"������¼��{b.DescriptionValue}\n��\t���������({param})\n\t]\n�� \t����ʱ�䣺{DateTime.Now}\n, \tIP��ַ��{ip}");
            if (context.HttpContext.Request.Path.ToString().Contains("/api/action/admin")) return;
            var action = new ActionLogEntity()
            {
                actionDetail = b.DescriptionValue,
                ipAddress = ip.ToString(),
                moduleName = context.ActionDescriptor.DisplayName,
                actionUrl = context.HttpContext.Request.Path,
                createDate = DateTime.Now,
                operatorId = "admin",
                logType = (int)LogTypeEnum.INFO
            }; 
            _actionLogService.AddEntityAsync(action);
        }

        /// <summary>
        /// �ж��Ƿ���ӷ�������
        /// </summary>
        /// <param name="actionName">��������</param>
        /// <param name="t">��������</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static T IsThatAttribute<T>(string actionName, Type t) where T : new()
        {
            var attributes = t.GetMethod(actionName)?.GetCustomAttributes(typeof(T), true);
            if (attributes != null && attributes.Length > 0)
            {
                return (T) attributes.GetValue(0);
            }

            return new T();
        }
    }
}