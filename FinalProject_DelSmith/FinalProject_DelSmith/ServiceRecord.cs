using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DelSmith
{
    class ServiceRecord
    {
        private int serviceId;
        private String description;
        private int vehicleId;
        private DateTime serviceDate;
        private int serviceMiles;
        private DateTime nextServiceDate;
        private int nextServiceMiles;
        private String enteredBy;
        private String notes;

        public ServiceRecord(int serviceId, String description, int vehicleId, DateTime serviceDate, int serviceMiles,
            DateTime nextServiceDate, int nextServiceMiles, String enteredBy, String notes)
        {
            this.serviceId = serviceId;
            this.description = description;
            this.vehicleId = vehicleId;
            this.serviceDate = serviceDate;
            this.serviceMiles = serviceMiles;
            this.nextServiceDate = serviceDate;
            this.nextServiceMiles = nextServiceMiles;
            this.enteredBy = enteredBy;
            this.notes = notes;
        }

        public int ServiceID
        {
            get { return serviceId; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public int VehicleID
        {
            get { return vehicleId;}
            set { vehicleId = value; }
        }

        public DateTime ServiceDate
        {
            get { return serviceDate; }
            set { serviceDate = value; }
        }

        public int ServiceMiles
        {
            get { return ServiceMiles; }
            set { ServiceMiles = value; }
        }

        public DateTime NextServiceDate
        {
            get { return nextServiceDate; }
        }

        public String EnteredBy
        {
            get { return enteredBy; }
            set { enteredBy = value; }
        }

        public String Notes
        {
            get { return notes; }
            set { notes = value; }
        }

    }
}
