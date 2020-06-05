using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData()
	{
		return "love";
	}

	public CompositeType GetDataUsingDataContract()
	{
        CompositeType ne = new CompositeType();
        ne.Id = 1;
        ne.Name = "There is no one.";
		return ne;
	}
}
