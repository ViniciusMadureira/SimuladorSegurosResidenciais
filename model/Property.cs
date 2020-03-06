using System;

namespace Classes
{
    public class Property
    {
        private double value;
        private double goodsValue;
        private bool hasAlarm;
        public Property(double value, double goodsValue, bool hasAlarm)
        {
            setValue(value);
            setGoodsValue(goodsValue);
            setHasAlarme(hasAlarm);
        }
        private void setValue(double value)
        {
            if (value >= 0.0)
            {
                this.value = value;
            }
        }
        public double getValue()
        {
            return value;
        }
        private void setGoodsValue(double goodsValue)
        {
            if (goodsValue >= 0.0)
            {
                this.goodsValue = goodsValue;
            }
        }
        public double getGoodsValue()
        {
            return goodsValue;
        }
        private void setHasAlarme(bool hasAlarm)
        {
            this.hasAlarm = hasAlarm;
        }
        public bool getHasAlarme()
        {
            return hasAlarm;
        }
    }
}