using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace EmployeeUI
{
    internal static class Program
    {
        public static IContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new XtraHome(Container.Resolve<IDepartmentService>(), Container.Resolve<IEmployeeService>(), Container.Resolve<IOffDayService>()));
        }
        static IContainer Configure()
        {
            var builder=new ContainerBuilder();
            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<OffDayManager>().As<IOffDayService>();
            builder.RegisterType<EfOffDayDal>().As<IOffDayDal>();

            builder.RegisterType<XtraHome>();
            return builder.Build();
        }
    }
}