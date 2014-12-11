namespace WcfServiceDayOfWeek
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface IServiceDayOfWeek
    {
        [OperationContract]
        string GetDayOfWeek(DateTime date);
    }
}
