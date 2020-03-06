using System;

namespace Classes
{
    public class Property
    {
        private double value;
        private double goodsValue;
        private bool hasAlarm;

        protected void setValue(double value)
        {
            if (value > 0.0)
            {
                this.value = value;
            }
        }

        public double getValue()
        {
            return this.value;
        }

        protected void setGoodsValue(double goodsValue)
        {
            if (goodsValue >= 0.0)
            {
                this.goodsValue = goodsValue;
            }
        }

        protected void setHasAlarme(bool hasAlarm)
        {
            this.hasAlarm = hasAlarm;
        }

        public bool getHasAlarme()
        {
            return hasAlarm;
        }

    }

}

