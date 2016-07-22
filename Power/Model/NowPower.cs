using Power.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Power.ViewModel;
using Windows.Devices.Power;
using System.Diagnostics;
using Windows.UI.Xaml.Media;

namespace Power.ViewModel
{
    public class NowPower
    {
        private PowerData nowPowerData;

        public PowerData NowPowerData
        {
            get
            {
                return nowPowerData;
            }

            set
            {
                nowPowerData = value;
            }
        }

        void getPower()
        {
            nowPowerData = new PowerData();
            nowPowerData = App.ViewModel;
           
            Battery myBattery = Battery.AggregateBattery;
            if (myBattery.GetReport().Status != Windows.System.Power.BatteryStatus.NotPresent)
            {
                NowPowerData.PowerTotal = myBattery.GetReport().DesignCapacityInMilliwattHours.Value;
                NowPowerData.PowerNum = myBattery.GetReport().RemainingCapacityInMilliwattHours.Value;
                
                if (myBattery.GetReport().Status == Windows.System.Power.BatteryStatus.Charging)
                {
                    NowPowerData.IsCharging = true;

                    NowPowerData.PowerSpeed = myBattery.GetReport().ChargeRateInMilliwatts.Value;
                }
                else if (myBattery.GetReport().Status == Windows.System.Power.BatteryStatus.Discharging)
                {
                    NowPowerData.IsCharging = false;
                }
                else if (myBattery.GetReport().Status == Windows.System.Power.BatteryStatus.Idle)
                {
                    Debug.Write("电池以充满");
                }
            }
        }
    }

}
