using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssembleProcess
{
    public class Repository
    {
        public int AddVehicleAssemble(VehicleAssembleModel vehicleAssemble)
        {
            int Result=0;
            try
            {
                if (vehicleAssemble != null)
                {
                   Form1.listOfVehicleAssembleModels.Add(vehicleAssemble);
                    Result = 1;
                }
            }
            catch (Exception ex)
            {
                Result = -1;
                Console.WriteLine(ex.ToString());
            }
            return Result;
        }

        public List<VehicleAssembleModel> GetVehicleAssembleData()
        {
            return Form1.listOfVehicleAssembleModels;
        }
    }
}
