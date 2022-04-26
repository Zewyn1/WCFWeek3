using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDani
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        string GetDays(int day, int month, int year);
        [OperationContract]
        string GetNames(string fname, string lname, string bday);
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }
        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
