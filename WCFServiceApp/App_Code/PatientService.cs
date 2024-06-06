using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class PatientService : IPatientService
{
    public List<Patient> GetAllPatients()
    {
        try
        {
            using (var _contextDb = new DataEntities())
            {
                return _contextDb.Patients.ToList();
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
