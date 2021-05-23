using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ZswBlog.Core
{
    /// <summary>
    /// ��Ŀ������
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// ��������ڷ���
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {            
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// ���ó�ʼ��
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseUrls("http://*:8004");
                }).UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureLogging((hostingContext, logging) =>
                {
            logging.ClearProviders(); //ȥ��Ĭ����ӵ���־�ṩ����                                              
            logging.AddConsole();//��ӿ���̨���                    
            //logging.AddDebug();//��ӵ������
        });

    }
}
