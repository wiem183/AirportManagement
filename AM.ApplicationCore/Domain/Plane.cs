using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AM.ApplicationCore.Domain
{
    public enum PlanType { Boing, Airbus }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManifactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlanType PlaneType { get; set; }
        public ICollection<Flight> flights { get; set; }

        public override string? ToString()
        {
            return $"{base.ToString()}, Capacity : {Capacity},ManifactureDate: {ManifactureDate},PlaneId: {PlaneId}, PlaneType: {PlaneType}, ";

        }

        public Plane(int capacity, DateTime manifactureDate, int planeId, PlanType planeType, ICollection<Flight> flights)
        {
            Capacity = capacity;
            ManifactureDate = manifactureDate;
            PlaneId = planeId;
            PlaneType = planeType;
            this.flights = flights;
        }

        public Plane(PlanType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManifactureDate = date;
        }

        public Plane()
        {
        }


    }
    
}
  

