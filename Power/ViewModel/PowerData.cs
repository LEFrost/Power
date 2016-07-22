using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Power.Model
{
    public class PowerData : BaseClass
    {
        private int powerSpeed;
        private int powerTotal;
        private Color powerColor;
        private bool isCharging;
        private int powerNum;
        public int PowerSpeed
        {
            get
            {
                return powerSpeed;
            }

            set
            {
                powerSpeed = value;
                OnPropertyChanged(nameof(PowerSpeed));
            }
        }

        public int PowerTotal
        {
            get
            {
                return powerTotal;
            }

            set
            {
                powerTotal = value;
                OnPropertyChanged(nameof(PowerTotal));

            }
        }

        public Color PowerColor
        {
            get
            {
                return powerColor;
            }

            set
            {
                powerColor = value;
                OnPropertyChanged(nameof(PowerColor));

            }
        }

        public bool IsCharging
        {
            get
            {
                return isCharging;
            }

            set
            {
                isCharging = value;
                OnPropertyChanged(nameof(IsCharging));

            }
        }

        public int PowerNum
        {
            get
            {
                return powerNum;
            }

            set
            {
                powerNum = value;
                OnPropertyChanged(nameof(PowerNum));
            }
        }
    }
}
