namespace WcfServiceLibraryDemo
{
    using System;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    [ServiceContract]
    public interface IServiceDemo
    {
        [OperationContract]
        int GetCount(string firstString, string secondString);
    }
}
